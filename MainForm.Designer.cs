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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btn_Exit = new Guna.UI2.WinForms.Guna2Button();
            uC_InfoAboutPackage1 = new EmployeeManagement.UC_InfoAboutPackage();
            SuspendLayout();
            // 
            // btn_Exit
            // 
            btn_Exit.CustomizableEdges = customizableEdges1;
            btn_Exit.DisabledState.BorderColor = Color.DarkGray;
            btn_Exit.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_Exit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_Exit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_Exit.FillColor = Color.Transparent;
            btn_Exit.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Exit.ForeColor = Color.Black;
            btn_Exit.Image = Properties.Resources.cancel;
            btn_Exit.ImageSize = new Size(30, 30);
            btn_Exit.Location = new Point(12, 27);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btn_Exit.Size = new Size(69, 45);
            btn_Exit.TabIndex = 0;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // uC_InfoAboutPackage1
            // 
            uC_InfoAboutPackage1.BackColor = Color.White;
            uC_InfoAboutPackage1.BorderStyle = BorderStyle.Fixed3D;
            uC_InfoAboutPackage1.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            uC_InfoAboutPackage1.Location = new Point(13, 79);
            uC_InfoAboutPackage1.Margin = new Padding(4);
            uC_InfoAboutPackage1.Name = "uC_InfoAboutPackage1";
            uC_InfoAboutPackage1.Size = new Size(2493, 1061);
            uC_InfoAboutPackage1.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(62, 120, 138);
            ClientSize = new Size(1924, 945);
            Controls.Add(uC_InfoAboutPackage1);
            Controls.Add(btn_Exit);
            Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            Text = "MainForm";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn_Exit;
        private EmployeeManagement.UC_InfoAboutPackage uC_InfoAboutPackage1;
    }
}