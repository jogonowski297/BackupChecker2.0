using System.Windows.Forms;

namespace BackupChecker
{
    partial class UC_Settings
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            Save = new Button();
            password = new TextBox();
            username = new TextBox();
            port = new TextBox();
            smtpClient = new TextBox();
            ssl = new CheckBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            time = new DateTimePicker();
            emailAddress = new TextBox();
            companyName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(557, 59);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(3, 32);
            label2.Name = "label2";
            label2.Size = new Size(237, 21);
            label2.TabIndex = 1;
            label2.Text = "Wprowadz potrzebne ustaweinia";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(128, 32);
            label1.TabIndex = 0;
            label1.Text = "Ustawienia";
            // 
            // panel2
            // 
            panel2.Controls.Add(Save);
            panel2.Controls.Add(password);
            panel2.Controls.Add(username);
            panel2.Controls.Add(port);
            panel2.Controls.Add(smtpClient);
            panel2.Controls.Add(ssl);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(time);
            panel2.Controls.Add(emailAddress);
            panel2.Controls.Add(companyName);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 59);
            panel2.Name = "panel2";
            panel2.Size = new Size(557, 363);
            panel2.TabIndex = 1;
            // 
            // Save
            // 
            Save.Location = new Point(216, 277);
            Save.Name = "Save";
            Save.Size = new Size(102, 34);
            Save.TabIndex = 16;
            Save.Text = "Zapisz";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // password
            // 
            password.Location = new Point(352, 203);
            password.Name = "password";
            password.Size = new Size(120, 23);
            password.TabIndex = 15;
            // 
            // username
            // 
            username.Location = new Point(352, 149);
            username.Name = "username";
            username.Size = new Size(120, 23);
            username.TabIndex = 14;
            // 
            // port
            // 
            port.Location = new Point(352, 92);
            port.Name = "port";
            port.Size = new Size(120, 23);
            port.TabIndex = 13;
            // 
            // smtpClient
            // 
            smtpClient.Location = new Point(352, 39);
            smtpClient.Name = "smtpClient";
            smtpClient.Size = new Size(120, 23);
            smtpClient.TabIndex = 12;
            // 
            // ssl
            // 
            ssl.AutoSize = true;
            ssl.Location = new Point(421, 245);
            ssl.Name = "ssl";
            ssl.Size = new Size(15, 14);
            ssl.TabIndex = 11;
            ssl.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(352, 244);
            label10.Name = "label10";
            label10.Size = new Size(63, 15);
            label10.TabIndex = 10;
            label10.Text = "Enable SSL";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(352, 185);
            label9.Name = "label9";
            label9.Size = new Size(57, 15);
            label9.TabIndex = 9;
            label9.Text = "Password";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(352, 127);
            label8.Name = "label8";
            label8.Size = new Size(60, 15);
            label8.TabIndex = 8;
            label8.Text = "Username";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(352, 74);
            label7.Name = "label7";
            label7.Size = new Size(29, 15);
            label7.TabIndex = 7;
            label7.Text = "port";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(352, 21);
            label6.Name = "label6";
            label6.Size = new Size(68, 15);
            label6.TabIndex = 6;
            label6.Text = "smtp Client";
            // 
            // time
            // 
            time.CustomFormat = "HH:mm";
            time.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            time.Format = DateTimePickerFormat.Custom;
            time.Location = new Point(71, 145);
            time.Name = "time";
            time.ShowUpDown = true;
            time.Size = new Size(117, 27);
            time.TabIndex = 5;
            time.Value = new DateTime(2023, 9, 5, 21, 37, 0, 0);
            // 
            // emailAddress
            // 
            emailAddress.Location = new Point(71, 92);
            emailAddress.Name = "emailAddress";
            emailAddress.Size = new Size(117, 23);
            emailAddress.TabIndex = 4;
            // 
            // companyName
            // 
            companyName.Location = new Point(71, 39);
            companyName.Name = "companyName";
            companyName.Size = new Size(117, 23);
            companyName.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(71, 127);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 2;
            label5.Text = "Godzina";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(71, 74);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 1;
            label4.Text = "E-mail";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(71, 21);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 0;
            label3.Text = "Firma";
            // 
            // UC_Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UC_Settings";
            Size = new Size(557, 425);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Label label4;
        private Label label3;
        private Label label5;
        private DateTimePicker time;
        private TextBox emailAddress;
        private TextBox companyName;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Button Save;
        private TextBox password;
        private TextBox username;
        private TextBox port;
        private TextBox smtpClient;
        private CheckBox ssl;
    }
}
