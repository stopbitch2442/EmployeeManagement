namespace WindowAnalystARM
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            uC_InfoAboutPackage1 = new EmployeeManagement.UC_InfoAboutPackage();
            SuspendLayout();
            // 
            // uC_InfoAboutPackage1
            // 
            uC_InfoAboutPackage1.BackColor = Color.White;
            uC_InfoAboutPackage1.BorderStyle = BorderStyle.Fixed3D;
            uC_InfoAboutPackage1.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            uC_InfoAboutPackage1.Location = new Point(24, 27);
            uC_InfoAboutPackage1.Margin = new Padding(4);
            uC_InfoAboutPackage1.Name = "uC_InfoAboutPackage1";
            uC_InfoAboutPackage1.Size = new Size(2482, 1113);
            uC_InfoAboutPackage1.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(62, 120, 138);
            ClientSize = new Size(1920, 945);
            Controls.Add(uC_InfoAboutPackage1);
            Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "MainForm";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
        }

        #endregion
        private EmployeeManagement.UC_InfoAboutPackage uC_InfoAboutPackage1;
    }
}