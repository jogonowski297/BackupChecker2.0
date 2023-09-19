namespace BackupChecker
{
    partial class UC_WinSrv
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
            difference = new TextBox();
            label6 = new Label();
            ChBSu = new CheckBox();
            ChBSa = new CheckBox();
            ChBFr = new CheckBox();
            ChBTh = new CheckBox();
            ChBWe = new CheckBox();
            ChBTu = new CheckBox();
            ChBMo = new CheckBox();
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
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(difference);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(ChBSu);
            panel2.Controls.Add(ChBSa);
            panel2.Controls.Add(ChBFr);
            panel2.Controls.Add(ChBTh);
            panel2.Controls.Add(ChBWe);
            panel2.Controls.Add(ChBTu);
            panel2.Controls.Add(ChBMo);
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
            panel2.Size = new Size(859, 473);
            panel2.TabIndex = 1;
            // 
            // difference
            // 
            difference.Location = new Point(27, 195);
            difference.Name = "difference";
            difference.Size = new Size(75, 23);
            difference.TabIndex = 18;
            difference.KeyPress += difference_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 177);
            label6.Name = "label6";
            label6.Size = new Size(173, 15);
            label6.TabIndex = 17;
            label6.Text = "Różnica rozmiaru katalogu (GB)";
            // 
            // ChBSu
            // 
            ChBSu.AutoSize = true;
            ChBSu.Location = new Point(473, 145);
            ChBSu.Name = "ChBSu";
            ChBSu.Size = new Size(74, 19);
            ChBSu.TabIndex = 16;
            ChBSu.Text = "Niedziela";
            ChBSu.UseVisualStyleBackColor = true;
            // 
            // ChBSa
            // 
            ChBSa.AutoSize = true;
            ChBSa.Location = new Point(404, 145);
            ChBSa.Name = "ChBSa";
            ChBSa.Size = new Size(63, 19);
            ChBSa.TabIndex = 15;
            ChBSa.Text = "Sobota";
            ChBSa.UseVisualStyleBackColor = true;
            // 
            // ChBFr
            // 
            ChBFr.AutoSize = true;
            ChBFr.Location = new Point(340, 145);
            ChBFr.Name = "ChBFr";
            ChBFr.Size = new Size(58, 19);
            ChBFr.TabIndex = 14;
            ChBFr.Text = "Piątek";
            ChBFr.UseVisualStyleBackColor = true;
            // 
            // ChBTh
            // 
            ChBTh.AutoSize = true;
            ChBTh.Location = new Point(260, 145);
            ChBTh.Name = "ChBTh";
            ChBTh.Size = new Size(74, 19);
            ChBTh.TabIndex = 13;
            ChBTh.Text = "Czwartek";
            ChBTh.UseVisualStyleBackColor = true;
            // 
            // ChBWe
            // 
            ChBWe.AutoSize = true;
            ChBWe.Location = new Point(198, 145);
            ChBWe.Name = "ChBWe";
            ChBWe.Size = new Size(56, 19);
            ChBWe.TabIndex = 12;
            ChBWe.Text = "Środa";
            ChBWe.UseVisualStyleBackColor = true;
            // 
            // ChBTu
            // 
            ChBTu.AutoSize = true;
            ChBTu.Location = new Point(128, 145);
            ChBTu.Name = "ChBTu";
            ChBTu.Size = new Size(64, 19);
            ChBTu.TabIndex = 11;
            ChBTu.Text = "Wtorek";
            ChBTu.UseVisualStyleBackColor = true;
            // 
            // ChBMo
            // 
            ChBMo.AutoSize = true;
            ChBMo.Location = new Point(30, 145);
            ChBMo.Name = "ChBMo";
            ChBMo.Size = new Size(92, 19);
            ChBMo.TabIndex = 10;
            ChBMo.Text = "Poniedziałek";
            ChBMo.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(27, 295);
            label5.Name = "label5";
            label5.Size = new Size(144, 13);
            label5.TabIndex = 9;
            label5.Text = "Lista ścieżek do katalogów";
            // 
            // listBox1
            // 
            listBox1.BackColor = SystemColors.InactiveCaption;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(27, 312);
            listBox1.Margin = new Padding(3, 2, 3, 2);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(520, 154);
            listBox1.TabIndex = 8;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(27, 239);
            label4.Name = "label4";
            label4.Size = new Size(203, 13);
            label4.TabIndex = 7;
            label4.Text = "Nazwa wyświetlana w podsumowaniu";
            // 
            // btn_save
            // 
            btn_save.Location = new Point(448, 255);
            btn_save.Margin = new Padding(3, 2, 3, 2);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(99, 22);
            btn_save.TabIndex = 6;
            btn_save.Text = "Zapisz";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(27, 256);
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
            textBox1.Size = new Size(417, 23);
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
            // UC_WinSrv
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Name = "UC_WinSrv";
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
        private CheckBox ChBMo;
        private TextBox difference;
        private Label label6;
        private CheckBox ChBSu;
        private CheckBox ChBSa;
        private CheckBox ChBFr;
        private CheckBox ChBTh;
        private CheckBox ChBWe;
        private CheckBox ChBTu;
    }
}
