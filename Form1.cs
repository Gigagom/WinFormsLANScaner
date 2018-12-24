using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;
using System.Threading;
using System.Diagnostics;

namespace WinFormsLANScaner
{
    public partial class Form1 : Form
    {
        int[] ports_array = new int[] { 20, 21, 22, 23, 25, 42, 43, 53, 67, 69, 80, 110, 115, 123, 137, 138, 139, 143,
                                            161, 179, 443, 445, 514, 515, 993, 995, 1080, 1194, 1433, 1702, 1723, 3128, 3268,
                                            3306, 3389, 5432, 5060, 5900, 5938, 8080, 10000, 20000 };
        string OWN_IP;
        string LAN_mask;
        int hosts_count;
        delegate void string_progress(string str);
        delegate void bool_progress(bool b);
        delegate void progress_bar();
        public static string getPcIp()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return null;
        }
        public static string getLANMask(string ownIP)
        {
            NetworkInterface[] Interfaces = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface Interface in Interfaces)
            {
                if (Interface.NetworkInterfaceType == NetworkInterfaceType.Loopback) continue;
                UnicastIPAddressInformationCollection UnicastIPInfoCol = Interface.GetIPProperties().UnicastAddresses;
                foreach (UnicastIPAddressInformation UnicatIPInfo in UnicastIPInfoCol)
                {
                    if (UnicatIPInfo.Address.ToString() == ownIP)
                        return UnicatIPInfo.IPv4Mask.ToString();
                }
            }
            return null;
        }
        public static int CountOfHosts(string ownIP)
        {
            int Count = 0;
            string ones = "";
            char[] oktet1 = new char[8] { '0', '0', '0', '0', '0', '0', '0', '0' };
            char[] oktet2 = new char[8] { '0', '0', '0', '0', '0', '0', '0', '0' };
            char[] oktet3 = new char[8] { '0', '0', '0', '0', '0', '0', '0', '0' };
            char[] oktet4 = new char[8] { '0', '0', '0', '0', '0', '0', '0', '0' };
            string mask = getLANMask(ownIP);
            Console.WriteLine(mask);
            string[] maskOktets = mask.Split('.');
            int startOktet = 4;
            foreach (string oktet in maskOktets.Reverse())
            {
                bool[] oktet_in_binary = GetBinaryRepresentation(255 - Convert.ToInt32(oktet));
                int num = 7;
                foreach (bool i in oktet_in_binary.Reverse())
                {
                    if (i)
                        switch (startOktet)
                        {
                            case 4:
                                oktet4[num] = '1';
                                break;
                            case 3:
                                oktet3[num] = '1';
                                break;
                            case 2:
                                oktet2[num] = '1';
                                break;
                            case 1:
                                oktet1[num] = '1';
                                break;
                        }
                    num--;
                }
                startOktet--;
            }

            foreach (char i in oktet4.Reverse())
            {
                if (i == '1')
                    ones = '1' + ones;
                else
                    ones = '0' + ones;
            }

            foreach (char i in oktet3.Reverse())
            {
                if (i == '1')
                    ones = '1' + ones;
                else
                    ones = '0' + ones;
            }

            foreach (char i in oktet2.Reverse())
            {
                if (i == '1')
                    ones = '1' + ones;
                else
                    ones = '0' + ones;
            }

            foreach (char i in oktet1.Reverse())
            {
                if (i == '1')
                    ones = '1' + ones;
                else
                    ones = '0' + ones;
            }
            string countInBinary = ones.Substring(ones.IndexOf('1'));
            Console.WriteLine(countInBinary);
            Console.WriteLine(Convert.ToInt32(countInBinary, 2) - 1);
            Count = Convert.ToInt32(countInBinary, 2) - 1;
            return Count;
        }
        private static bool[] GetBinaryRepresentation(int i)
        {
            List<bool> result = new List<bool>();
            while (i > 0)
            {
                int m = i % 2;
                i = i / 2;
                result.Add(m == 1);
            }
            result.Reverse();
            return result.ToArray();
        }
        public static string getNameByIP(string Ip)
        {
            try
            {
                string name = Dns.GetHostEntry(Ip).HostName.ToString();
                return name;
            }
            catch (SocketException ex)
            {
                return "Имя не задано!";
            }
        }
        public void Lan_scan()
        {
            string[] okt = OWN_IP.Split('.');
            string status = "Выберите необходимый хост.";
            LANScanProgresstextBox.Invoke(new string_progress((s) => LANScanProgresstextBox.Text = s), status);
            string ipBase = okt[0] + "." + okt[1] + "." + okt[2] + ".";
            for (int i = 1; i <= hosts_count; i++)
            {
                string ip = ipBase + i.ToString();
                Ping p = new Ping();
                p.PingCompleted += new PingCompletedEventHandler(Ping_Completed);
                p.SendAsync(ip, 100, ip);
            }
            MessageBox.Show("Процесс сканирования сети завершен!");
        }
        public void Ping_Completed(object sender, PingCompletedEventArgs e)
        {
            string ip = (string)e.UserState;
            if (e.Reply != null && e.Reply.Status == IPStatus.Success)
            {
                ListViewItem item = new ListViewItem(ip);
                LANhostslistView.Invoke(new MethodInvoker(delegate () 
                {
                    LANhostslistView.Items.Add(item);
                }));
            }
        }
        public Form1()
        {
            InitializeComponent();
            ownIPtextBox.Text = OWN_IP = getPcIp();
            LANMasktextBox.Text = LAN_mask = getLANMask(OWN_IP);
            hosts_count = CountOfHosts(OWN_IP);
            HostCounttextBox.Text = hosts_count.ToString();
            PCNametextBox.Text = getNameByIP(OWN_IP);
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            ownIPtextBox.Text = OWN_IP = getPcIp();
            LANMasktextBox.Text = LAN_mask = getLANMask(OWN_IP);
            hosts_count = CountOfHosts(OWN_IP);
            HostCounttextBox.Text = hosts_count.ToString();
            PCNametextBox.Text = getNameByIP(OWN_IP);
        }

        private void StartLANScanbutton_Click(object sender, EventArgs e)
        {
            LANhostslistView.Clear();
            LANScanProgresstextBox.Visible = true;
            Thread LAN_Scanning_thread = new Thread(new ThreadStart(Lan_scan));
            LAN_Scanning_thread.IsBackground = true;
            LAN_Scanning_thread.Start();
        }

        private void LANhostslistView_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                StartPortScanbutton.Enabled = true;
                StartPortScanbutton.Text = "Начать сканирование портов";
                StartPortScanbutton.Text = StartPortScanbutton.Text + " (" + LANhostslistView.SelectedItems[0].Text + ")";
            }
            catch(Exception)
            {
                MessageBox.Show("Выберите хост!");
            }
        }

        private void StartPortScanbutton_Click(object sender, EventArgs e)
        {
            OpenPortslistView.Clear();
            string ip = LANhostslistView.SelectedItems[0].Text;
            PortScanProgresstextBox.Text = "Сканирование портов ("+ip+"). Подождите!";
            PortScanProgresstextBox.Visible = false;
            PortScanProgressBar.Visible = true;
            ParameterizedThreadStart port_delegate = new ParameterizedThreadStart(AllPortsByIP);
            Thread port_Scanning_thread = new Thread(port_delegate);
            port_Scanning_thread.IsBackground = true;
            port_Scanning_thread.Start(ip);
            StartPortScanbutton.Text = "Начать сканирование портов";
            StartPortScanbutton.Enabled = false;
        }

        public static bool ScanPort(string ip, int port)
        {
            using (TcpClient tcpClient = new TcpClient())
            {
                try
                {
                    tcpClient.Connect(ip, port);
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
                finally
                {
                    tcpClient.Close();
                }
            }
        }

        public void AllPortsByIP(object ip)
        {
            try
            {
                foreach (int p in ports_array)
                {
                    if (ScanPort(ip.ToString(), p))
                    {
                        ListViewItem item = new ListViewItem("Порт " + p.ToString() + "  -  Открыт!");
                        OpenPortslistView.Invoke(new MethodInvoker(delegate ()
                        {
                            OpenPortslistView.Items.Add(item);
                        }));
                    }
                    PortScanProgressBar.Invoke(new progress_bar(delegate() { PortScanProgressBar.PerformStep(); }));
                    
                }
            }
            finally
            {
                if (OpenPortslistView.Items.Count == 0)
                {
                    ListViewItem item = new ListViewItem("Открытые порты отсутствуют!");
                    OpenPortslistView.Invoke(new MethodInvoker(delegate ()
                    {
                        OpenPortslistView.Items.Add(item);
                    }));
                }
                bool F = false;
                bool T = true;
                PortScanProgressBar.Invoke(new bool_progress((f) => PortScanProgressBar.Visible = f), F);
                PortScanProgressBar.Invoke(new MethodInvoker(delegate () { PortScanProgressBar.Value = 0; }));
                string S = "Список открытых портов("+ ip.ToString() + ").";
                PortScanProgresstextBox.Invoke(new string_progress((s) => PortScanProgresstextBox.Text = s), S);
                MessageBox.Show("Процесс сканирования портов завершен!");
                PortScanProgresstextBox.Invoke(new bool_progress((t) => PortScanProgresstextBox.Visible = t), T);
            }
        }
    }
}
