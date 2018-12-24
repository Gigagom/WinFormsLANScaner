namespace WinFormsLANScaner
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.ownIPtextBox = new System.Windows.Forms.TextBox();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.LANMasktextBox = new System.Windows.Forms.TextBox();
            this.HostCounttextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PCNametextBox = new System.Windows.Forms.TextBox();
            this.LANhostslistView = new System.Windows.Forms.ListView();
            this.StartLANScanbutton = new System.Windows.Forms.Button();
            this.LANScanProgresstextBox = new System.Windows.Forms.TextBox();
            this.OpenPortslistView = new System.Windows.Forms.ListView();
            this.StartPortScanbutton = new System.Windows.Forms.Button();
            this.PortScanProgresstextBox = new System.Windows.Forms.TextBox();
            this.PortScanProgressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP-Адрес компьютера:";
            // 
            // ownIPtextBox
            // 
            this.ownIPtextBox.Location = new System.Drawing.Point(201, 6);
            this.ownIPtextBox.Name = "ownIPtextBox";
            this.ownIPtextBox.ReadOnly = true;
            this.ownIPtextBox.Size = new System.Drawing.Size(252, 22);
            this.ownIPtextBox.TabIndex = 1;
            this.ownIPtextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RefreshButton
            // 
            this.RefreshButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RefreshButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RefreshButton.Location = new System.Drawing.Point(790, 6);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(101, 60);
            this.RefreshButton.TabIndex = 2;
            this.RefreshButton.Text = "Обновить";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(460, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Маска подсети:";
            // 
            // LANMasktextBox
            // 
            this.LANMasktextBox.Location = new System.Drawing.Point(586, 6);
            this.LANMasktextBox.Name = "LANMasktextBox";
            this.LANMasktextBox.ReadOnly = true;
            this.LANMasktextBox.Size = new System.Drawing.Size(198, 22);
            this.LANMasktextBox.TabIndex = 4;
            this.LANMasktextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HostCounttextBox
            // 
            this.HostCounttextBox.Location = new System.Drawing.Point(294, 44);
            this.HostCounttextBox.Name = "HostCounttextBox";
            this.HostCounttextBox.ReadOnly = true;
            this.HostCounttextBox.Size = new System.Drawing.Size(159, 22);
            this.HostCounttextBox.TabIndex = 5;
            this.HostCounttextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(263, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Максимальное количество хостов:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(460, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Имя компьютера:";
            // 
            // PCNametextBox
            // 
            this.PCNametextBox.Location = new System.Drawing.Point(607, 44);
            this.PCNametextBox.Name = "PCNametextBox";
            this.PCNametextBox.ReadOnly = true;
            this.PCNametextBox.Size = new System.Drawing.Size(177, 22);
            this.PCNametextBox.TabIndex = 8;
            this.PCNametextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LANhostslistView
            // 
            this.LANhostslistView.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.LANhostslistView.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LANhostslistView.Location = new System.Drawing.Point(15, 170);
            this.LANhostslistView.MultiSelect = false;
            this.LANhostslistView.Name = "LANhostslistView";
            this.LANhostslistView.Size = new System.Drawing.Size(438, 347);
            this.LANhostslistView.TabIndex = 9;
            this.LANhostslistView.UseCompatibleStateImageBehavior = false;
            this.LANhostslistView.View = System.Windows.Forms.View.List;
            this.LANhostslistView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LANhostslistView_MouseClick);
            // 
            // StartLANScanbutton
            // 
            this.StartLANScanbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartLANScanbutton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartLANScanbutton.Location = new System.Drawing.Point(15, 72);
            this.StartLANScanbutton.Name = "StartLANScanbutton";
            this.StartLANScanbutton.Size = new System.Drawing.Size(438, 64);
            this.StartLANScanbutton.TabIndex = 10;
            this.StartLANScanbutton.Text = "Начать \r\nсканирование сети";
            this.StartLANScanbutton.UseVisualStyleBackColor = true;
            this.StartLANScanbutton.Click += new System.EventHandler(this.StartLANScanbutton_Click);
            // 
            // LANScanProgresstextBox
            // 
            this.LANScanProgresstextBox.Enabled = false;
            this.LANScanProgresstextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LANScanProgresstextBox.Location = new System.Drawing.Point(15, 142);
            this.LANScanProgresstextBox.Name = "LANScanProgresstextBox";
            this.LANScanProgresstextBox.Size = new System.Drawing.Size(438, 27);
            this.LANScanProgresstextBox.TabIndex = 11;
            this.LANScanProgresstextBox.Visible = false;
            // 
            // OpenPortslistView
            // 
            this.OpenPortslistView.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.OpenPortslistView.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenPortslistView.Location = new System.Drawing.Point(463, 170);
            this.OpenPortslistView.Name = "OpenPortslistView";
            this.OpenPortslistView.Size = new System.Drawing.Size(428, 347);
            this.OpenPortslistView.TabIndex = 12;
            this.OpenPortslistView.UseCompatibleStateImageBehavior = false;
            this.OpenPortslistView.View = System.Windows.Forms.View.List;
            // 
            // StartPortScanbutton
            // 
            this.StartPortScanbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartPortScanbutton.Enabled = false;
            this.StartPortScanbutton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartPortScanbutton.Location = new System.Drawing.Point(463, 72);
            this.StartPortScanbutton.Name = "StartPortScanbutton";
            this.StartPortScanbutton.Size = new System.Drawing.Size(428, 64);
            this.StartPortScanbutton.TabIndex = 13;
            this.StartPortScanbutton.Text = "Начать сканирование портов";
            this.StartPortScanbutton.UseVisualStyleBackColor = true;
            this.StartPortScanbutton.Click += new System.EventHandler(this.StartPortScanbutton_Click);
            // 
            // PortScanProgresstextBox
            // 
            this.PortScanProgresstextBox.Enabled = false;
            this.PortScanProgresstextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PortScanProgresstextBox.Location = new System.Drawing.Point(463, 142);
            this.PortScanProgresstextBox.Name = "PortScanProgresstextBox";
            this.PortScanProgresstextBox.Size = new System.Drawing.Size(428, 27);
            this.PortScanProgresstextBox.TabIndex = 14;
            this.PortScanProgresstextBox.Visible = false;
            // 
            // PortScanProgressBar
            // 
            this.PortScanProgressBar.Location = new System.Drawing.Point(463, 142);
            this.PortScanProgressBar.Maximum = 42;
            this.PortScanProgressBar.Name = "PortScanProgressBar";
            this.PortScanProgressBar.Size = new System.Drawing.Size(428, 27);
            this.PortScanProgressBar.Step = 1;
            this.PortScanProgressBar.TabIndex = 15;
            this.PortScanProgressBar.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 529);
            this.Controls.Add(this.PortScanProgressBar);
            this.Controls.Add(this.PortScanProgresstextBox);
            this.Controls.Add(this.StartPortScanbutton);
            this.Controls.Add(this.OpenPortslistView);
            this.Controls.Add(this.LANScanProgresstextBox);
            this.Controls.Add(this.StartLANScanbutton);
            this.Controls.Add(this.LANhostslistView);
            this.Controls.Add(this.PCNametextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.HostCounttextBox);
            this.Controls.Add(this.LANMasktextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.ownIPtextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LAN SCANER";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ownIPtextBox;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LANMasktextBox;
        private System.Windows.Forms.TextBox HostCounttextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PCNametextBox;
        private System.Windows.Forms.ListView LANhostslistView;
        private System.Windows.Forms.Button StartLANScanbutton;
        private System.Windows.Forms.TextBox LANScanProgresstextBox;
        private System.Windows.Forms.ListView OpenPortslistView;
        private System.Windows.Forms.Button StartPortScanbutton;
        private System.Windows.Forms.TextBox PortScanProgresstextBox;
        private System.Windows.Forms.ProgressBar PortScanProgressBar;
    }
}

