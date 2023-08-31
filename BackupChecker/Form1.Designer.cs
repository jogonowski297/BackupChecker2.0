namespace BackupChecker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Sidebar = new FlowLayoutPanel();
            panel1 = new Panel();
            menuButton = new PictureBox();
            panel6 = new Panel();
            button4 = new Button();
            panel4 = new Panel();
            button3 = new Button();
            panel3 = new Panel();
            button2 = new Button();
            panel2 = new Panel();
            button1 = new Button();
            SidebarTimer = new System.Windows.Forms.Timer(components);
            panel5 = new Panel();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            panel7 = new Panel();
            label1 = new Label();
            form_Paths1 = new Form_Paths();
            Sidebar.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menuButton).BeginInit();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // Sidebar
            // 
            Sidebar.BackColor = Color.SteelBlue;
            Sidebar.Controls.Add(panel1);
            Sidebar.Controls.Add(panel6);
            Sidebar.Controls.Add(panel4);
            Sidebar.Controls.Add(panel3);
            Sidebar.Controls.Add(panel2);
            Sidebar.Dock = DockStyle.Left;
            Sidebar.Location = new Point(0, 0);
            Sidebar.MaximumSize = new Size(199, 450);
            Sidebar.MinimumSize = new Size(73, 450);
            Sidebar.Name = "Sidebar";
            Sidebar.Size = new Size(199, 450);
            Sidebar.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(menuButton);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(197, 63);
            panel1.TabIndex = 0;
            // 
            // menuButton
            // 
            menuButton.Cursor = Cursors.Hand;
            menuButton.Image = Properties.Resources.heart;
            menuButton.Location = new Point(23, 18);
            menuButton.Name = "menuButton";
            menuButton.Size = new Size(28, 26);
            menuButton.SizeMode = PictureBoxSizeMode.StretchImage;
            menuButton.TabIndex = 0;
            menuButton.TabStop = false;
            menuButton.Click += menuButton_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(button4);
            panel6.Location = new Point(3, 72);
            panel6.Name = "panel6";
            panel6.Size = new Size(197, 52);
            panel6.TabIndex = 3;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Image = Properties.Resources.heart;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(14, 3);
            button4.Name = "button4";
            button4.Size = new Size(173, 41);
            button4.TabIndex = 1;
            button4.Text = "Windows backup";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(button3);
            panel4.Location = new Point(3, 130);
            panel4.Name = "panel4";
            panel4.Size = new Size(197, 52);
            panel4.TabIndex = 4;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Image = Properties.Resources.heart;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(14, 3);
            button3.Name = "button3";
            button3.Size = new Size(173, 41);
            button3.TabIndex = 1;
            button3.Text = "Home";
            button3.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(button2);
            panel3.Location = new Point(3, 188);
            panel3.Name = "panel3";
            panel3.Size = new Size(197, 52);
            panel3.TabIndex = 4;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Image = Properties.Resources.heart;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(14, 3);
            button2.Name = "button2";
            button2.Size = new Size(173, 41);
            button2.TabIndex = 1;
            button2.Text = "Home";
            button2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Location = new Point(3, 246);
            panel2.Name = "panel2";
            panel2.Size = new Size(197, 52);
            panel2.TabIndex = 4;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Image = Properties.Resources.heart;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(14, 3);
            button1.Name = "button1";
            button1.Size = new Size(173, 41);
            button1.TabIndex = 1;
            button1.Text = "Home";
            button1.UseVisualStyleBackColor = true;
            // 
            // SidebarTimer
            // 
            SidebarTimer.Tick += SidebarTimer_Tick;
            // 
            // panel5
            // 
            panel5.Controls.Add(button7);
            panel5.Controls.Add(button6);
            panel5.Controls.Add(button5);
            panel5.Controls.Add(panel7);
            panel5.Location = new Point(205, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(596, 47);
            panel5.TabIndex = 1;
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatAppearance.MouseOverBackColor = Color.Red;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Location = new Point(461, 0);
            button7.Name = "button7";
            button7.Size = new Size(44, 47);
            button7.TabIndex = 3;
            button7.Text = "minim";
            button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatAppearance.MouseOverBackColor = Color.Red;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Location = new Point(511, 0);
            button6.Name = "button6";
            button6.Size = new Size(44, 47);
            button6.TabIndex = 2;
            button6.Text = "full";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Right;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseOverBackColor = Color.Red;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(552, 0);
            button5.Name = "button5";
            button5.Size = new Size(44, 47);
            button5.TabIndex = 1;
            button5.Text = "close";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // panel7
            // 
            panel7.Controls.Add(label1);
            panel7.Location = new Point(163, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(273, 47);
            panel7.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 9);
            label1.Name = "label1";
            label1.Size = new Size(132, 15);
            label1.TabIndex = 0;
            label1.Text = "Student addmision font";
            // 
            // form_Paths1
            // 
            form_Paths1.Location = new Point(206, 53);
            form_Paths1.Margin = new Padding(3, 4, 3, 4);
            form_Paths1.Name = "form_Paths1";
            form_Paths1.Size = new Size(597, 397);
            form_Paths1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOliveGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(form_Paths1);
            Controls.Add(panel5);
            Controls.Add(Sidebar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Sidebar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)menuButton).EndInit();
            panel6.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel Sidebar;
        private Panel panel6;
        private Button button4;
        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private Panel panel4;
        private Button button3;
        private Panel panel3;
        private Button button2;
        private PictureBox menuButton;
        private System.Windows.Forms.Timer SidebarTimer;
        private Panel panel5;
        private Button button5;
        private Panel panel7;
        private Label label1;
        private Button button7;
        private Button button6;
        private Form_Paths form_Paths1;
    }
}