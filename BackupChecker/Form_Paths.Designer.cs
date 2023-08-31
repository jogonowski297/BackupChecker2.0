namespace BackupChecker
{
    partial class Form_Paths
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
            folderBrowserDialog = new FolderBrowserDialog();
            panel2 = new Panel();
            label5 = new Label();
            listBox1 = new ListBox();
            label4 = new Label();
            btn_save = new Button();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            colorDialog1 = new ColorDialog();
            Load = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(Load);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(listBox1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(btn_save);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(846, 461);
            panel2.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(27, 198);
            label5.Name = "label5";
            label5.Size = new Size(144, 13);
            label5.TabIndex = 9;
            label5.Text = "Lista ścieżek do katalogów";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(27, 215);
            listBox1.Margin = new Padding(3, 2, 3, 2);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(504, 169);
            listBox1.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(27, 142);
            label4.Name = "label4";
            label4.Size = new Size(203, 13);
            label4.TabIndex = 7;
            label4.Text = "Nazwa wyświetlana w podsumowaniu";
            // 
            // btn_save
            // 
            btn_save.Location = new Point(448, 158);
            btn_save.Margin = new Padding(3, 2, 3, 2);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(82, 22);
            btn_save.TabIndex = 6;
            btn_save.Text = "Zapisz";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(27, 159);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(270, 23);
            textBox2.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(130, 78);
            label3.Name = "label3";
            label3.Size = new Size(110, 13);
            label3.TabIndex = 4;
            label3.Text = "Ścieżka do katalogu";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(130, 94);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(400, 23);
            textBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(27, 94);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Wybierz ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 43);
            label2.Name = "label2";
            label2.Size = new Size(243, 15);
            label2.TabIndex = 1;
            label2.Text = "Wybierz katalog który ma zostać sprawdzony";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(27, 13);
            label1.Name = "label1";
            label1.Size = new Size(176, 21);
            label1.TabIndex = 0;
            label1.Text = "Kopia Windows-Servers";
            // 
            // Load
            // 
            Load.Location = new Point(448, 185);
            Load.Name = "Load";
            Load.Size = new Size(75, 23);
            Load.TabIndex = 10;
            Load.Text = "Wczytaj";
            Load.UseVisualStyleBackColor = true;
            Load.Click += Load_Click;
            // 
            // Form_Paths
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Name = "Form_Paths";
            Size = new Size(859, 473);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private FolderBrowserDialog folderBrowserDialog;
        private Panel panel2;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label4;
        private Button btn_save;
        private TextBox textBox2;
        private Label label5;
        private ListBox listBox1;
        private ColorDialog colorDialog1;
        public Button button1;
        public TextBox textBox1;
        private Button Load;
    }
}
