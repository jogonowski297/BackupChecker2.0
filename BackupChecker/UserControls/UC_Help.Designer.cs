namespace BackupChecker.UserControls
{
    partial class UC_Help
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
            check = new Button();
            versionConst = new Label();
            version = new Label();
            SuspendLayout();
            // 
            // check
            // 
            check.Location = new Point(232, 196);
            check.Name = "check";
            check.Size = new Size(75, 23);
            check.TabIndex = 0;
            check.Text = "Check";
            check.UseVisualStyleBackColor = true;
            // 
            // versionConst
            // 
            versionConst.AutoSize = true;
            versionConst.Location = new Point(171, 122);
            versionConst.Name = "versionConst";
            versionConst.Size = new Size(48, 15);
            versionConst.TabIndex = 1;
            versionConst.Text = "Version:";
            // 
            // version
            // 
            version.AutoSize = true;
            version.Location = new Point(251, 122);
            version.Name = "version";
            version.Size = new Size(0, 15);
            version.TabIndex = 2;
            // 
            // UC_Help
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(version);
            Controls.Add(versionConst);
            Controls.Add(check);
            Name = "UC_Help";
            Size = new Size(557, 425);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button check;
        private Label versionConst;
        private Label version;
    }
}
