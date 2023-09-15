namespace EmployeeManagement
{
    partial class UC_Employees
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges23 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges24 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges25 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges26 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges27 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges28 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges29 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges30 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges31 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges32 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            listBox1 = new ListBox();
            btn_EmployeeList = new Guna.UI2.WinForms.Guna2Button();
            btn_EditEmployee = new Guna.UI2.WinForms.Guna2Button();
            btn_GetInformationEmployeeById = new Guna.UI2.WinForms.Guna2Button();
            textbox_Id = new Guna.UI2.WinForms.Guna2TextBox();
            label1 = new Label();
            btn_DeleteEmployee = new Guna.UI2.WinForms.Guna2Button();
            btn_GetDepartList = new Guna.UI2.WinForms.Guna2Button();
            btn_GetEmployeesByLastName = new Guna.UI2.WinForms.Guna2Button();
            label_lastName = new Label();
            textbox_LastName = new Guna.UI2.WinForms.Guna2TextBox();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 23;
            listBox1.Location = new Point(94, 166);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(528, 257);
            listBox1.TabIndex = 0;
            // 
            // btn_EmployeeList
            // 
            btn_EmployeeList.BorderRadius = 30;
            btn_EmployeeList.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            btn_EmployeeList.BorderThickness = 1;
            btn_EmployeeList.CustomizableEdges = customizableEdges17;
            btn_EmployeeList.DisabledState.BorderColor = Color.DarkGray;
            btn_EmployeeList.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_EmployeeList.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_EmployeeList.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_EmployeeList.FillColor = Color.White;
            btn_EmployeeList.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_EmployeeList.ForeColor = Color.Black;
            btn_EmployeeList.Location = new Point(757, 29);
            btn_EmployeeList.Name = "btn_EmployeeList";
            btn_EmployeeList.ShadowDecoration.CustomizableEdges = customizableEdges18;
            btn_EmployeeList.Size = new Size(225, 99);
            btn_EmployeeList.TabIndex = 2;
            btn_EmployeeList.Text = "Список всех сотрудников";
            btn_EmployeeList.Click += btn_EmployeeList_Click;
            // 
            // btn_EditEmployee
            // 
            btn_EditEmployee.BorderRadius = 30;
            btn_EditEmployee.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            btn_EditEmployee.BorderThickness = 1;
            btn_EditEmployee.CustomizableEdges = customizableEdges19;
            btn_EditEmployee.DisabledState.BorderColor = Color.DarkGray;
            btn_EditEmployee.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_EditEmployee.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_EditEmployee.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_EditEmployee.FillColor = Color.White;
            btn_EditEmployee.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_EditEmployee.ForeColor = Color.Black;
            btn_EditEmployee.Location = new Point(757, 254);
            btn_EditEmployee.Name = "btn_EditEmployee";
            btn_EditEmployee.ShadowDecoration.CustomizableEdges = customizableEdges20;
            btn_EditEmployee.Size = new Size(225, 99);
            btn_EditEmployee.TabIndex = 3;
            btn_EditEmployee.Text = "Изменить сотрудника";
            btn_EditEmployee.Click += btn_EditEmployee_Click;
            // 
            // btn_GetInformationEmployeeById
            // 
            btn_GetInformationEmployeeById.BorderRadius = 30;
            btn_GetInformationEmployeeById.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            btn_GetInformationEmployeeById.BorderThickness = 1;
            btn_GetInformationEmployeeById.CustomizableEdges = customizableEdges21;
            btn_GetInformationEmployeeById.DisabledState.BorderColor = Color.DarkGray;
            btn_GetInformationEmployeeById.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_GetInformationEmployeeById.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_GetInformationEmployeeById.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_GetInformationEmployeeById.FillColor = Color.White;
            btn_GetInformationEmployeeById.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_GetInformationEmployeeById.ForeColor = Color.Black;
            btn_GetInformationEmployeeById.Location = new Point(757, 140);
            btn_GetInformationEmployeeById.Name = "btn_GetInformationEmployeeById";
            btn_GetInformationEmployeeById.ShadowDecoration.CustomizableEdges = customizableEdges22;
            btn_GetInformationEmployeeById.Size = new Size(225, 99);
            btn_GetInformationEmployeeById.TabIndex = 4;
            btn_GetInformationEmployeeById.Text = "Получить информацию о сотруднике по Id";
            btn_GetInformationEmployeeById.Click += btn_GetInformationEmployeeById_Click;
            // 
            // textbox_Id
            // 
            textbox_Id.BorderColor = Color.Black;
            textbox_Id.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            textbox_Id.CustomizableEdges = customizableEdges23;
            textbox_Id.DefaultText = "";
            textbox_Id.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            textbox_Id.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            textbox_Id.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            textbox_Id.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            textbox_Id.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            textbox_Id.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textbox_Id.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            textbox_Id.Location = new Point(1052, 166);
            textbox_Id.Name = "textbox_Id";
            textbox_Id.PasswordChar = '\0';
            textbox_Id.PlaceholderText = "";
            textbox_Id.SelectedText = "";
            textbox_Id.ShadowDecoration.CustomizableEdges = customizableEdges24;
            textbox_Id.Size = new Size(250, 45);
            textbox_Id.TabIndex = 5;
            textbox_Id.Enter += textbox_Id_Enter;
            textbox_Id.Leave += textbox_Id_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(1012, 175);
            label1.Name = "label1";
            label1.Size = new Size(35, 28);
            label1.TabIndex = 6;
            label1.Text = "Id:";
            // 
            // btn_DeleteEmployee
            // 
            btn_DeleteEmployee.BorderRadius = 30;
            btn_DeleteEmployee.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            btn_DeleteEmployee.BorderThickness = 1;
            btn_DeleteEmployee.CustomizableEdges = customizableEdges25;
            btn_DeleteEmployee.DisabledState.BorderColor = Color.DarkGray;
            btn_DeleteEmployee.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_DeleteEmployee.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_DeleteEmployee.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_DeleteEmployee.FillColor = Color.White;
            btn_DeleteEmployee.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_DeleteEmployee.ForeColor = Color.Black;
            btn_DeleteEmployee.Location = new Point(757, 378);
            btn_DeleteEmployee.Name = "btn_DeleteEmployee";
            btn_DeleteEmployee.ShadowDecoration.CustomizableEdges = customizableEdges26;
            btn_DeleteEmployee.Size = new Size(225, 99);
            btn_DeleteEmployee.TabIndex = 7;
            btn_DeleteEmployee.Text = "Удалить сотрудника";
            btn_DeleteEmployee.Click += btn_DeleteEmployee_Click;
            // 
            // btn_GetDepartList
            // 
            btn_GetDepartList.BorderRadius = 30;
            btn_GetDepartList.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            btn_GetDepartList.BorderThickness = 1;
            btn_GetDepartList.CustomizableEdges = customizableEdges27;
            btn_GetDepartList.DisabledState.BorderColor = Color.DarkGray;
            btn_GetDepartList.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_GetDepartList.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_GetDepartList.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_GetDepartList.FillColor = Color.White;
            btn_GetDepartList.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_GetDepartList.ForeColor = Color.Black;
            btn_GetDepartList.Location = new Point(757, 496);
            btn_GetDepartList.Name = "btn_GetDepartList";
            btn_GetDepartList.ShadowDecoration.CustomizableEdges = customizableEdges28;
            btn_GetDepartList.Size = new Size(225, 99);
            btn_GetDepartList.TabIndex = 8;
            btn_GetDepartList.Text = "Получить список всех должностей и департаментов";
            btn_GetDepartList.Click += btn_GetDepartList_Click;
            // 
            // btn_GetEmployeesByLastName
            // 
            btn_GetEmployeesByLastName.BorderRadius = 30;
            btn_GetEmployeesByLastName.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            btn_GetEmployeesByLastName.BorderThickness = 1;
            btn_GetEmployeesByLastName.CustomizableEdges = customizableEdges29;
            btn_GetEmployeesByLastName.DisabledState.BorderColor = Color.DarkGray;
            btn_GetEmployeesByLastName.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_GetEmployeesByLastName.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_GetEmployeesByLastName.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_GetEmployeesByLastName.FillColor = Color.White;
            btn_GetEmployeesByLastName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_GetEmployeesByLastName.ForeColor = Color.Black;
            btn_GetEmployeesByLastName.Location = new Point(757, 617);
            btn_GetEmployeesByLastName.Name = "btn_GetEmployeesByLastName";
            btn_GetEmployeesByLastName.ShadowDecoration.CustomizableEdges = customizableEdges30;
            btn_GetEmployeesByLastName.Size = new Size(225, 123);
            btn_GetEmployeesByLastName.TabIndex = 9;
            btn_GetEmployeesByLastName.Text = "Получить информацию о сотруднике по фамилии";
            btn_GetEmployeesByLastName.Click += btn_GetEmployeesByLastName_Click;
            // 
            // label_lastName
            // 
            label_lastName.AutoSize = true;
            label_lastName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_lastName.Location = new Point(1012, 635);
            label_lastName.Name = "label_lastName";
            label_lastName.Size = new Size(110, 28);
            label_lastName.TabIndex = 11;
            label_lastName.Text = "Фамилия:";
            // 
            // textbox_LastName
            // 
            textbox_LastName.BorderColor = Color.Black;
            textbox_LastName.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            textbox_LastName.CustomizableEdges = customizableEdges31;
            textbox_LastName.DefaultText = "";
            textbox_LastName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            textbox_LastName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            textbox_LastName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            textbox_LastName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            textbox_LastName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            textbox_LastName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textbox_LastName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            textbox_LastName.Location = new Point(1012, 666);
            textbox_LastName.Name = "textbox_LastName";
            textbox_LastName.PasswordChar = '\0';
            textbox_LastName.PlaceholderText = "";
            textbox_LastName.SelectedText = "";
            textbox_LastName.ShadowDecoration.CustomizableEdges = customizableEdges32;
            textbox_LastName.Size = new Size(250, 45);
            textbox_LastName.TabIndex = 10;
            // 
            // UC_Employees
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.Fixed3D;
            Controls.Add(label_lastName);
            Controls.Add(textbox_LastName);
            Controls.Add(btn_GetEmployeesByLastName);
            Controls.Add(btn_GetDepartList);
            Controls.Add(btn_DeleteEmployee);
            Controls.Add(label1);
            Controls.Add(textbox_Id);
            Controls.Add(btn_GetInformationEmployeeById);
            Controls.Add(btn_EditEmployee);
            Controls.Add(btn_EmployeeList);
            Controls.Add(listBox1);
            Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "UC_Employees";
            Size = new Size(2493, 1190);
            Load += UC_Employees_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Guna.UI2.WinForms.Guna2Button btn_EmployeeList;
        private Guna.UI2.WinForms.Guna2Button btn_EditEmployee;
        private Guna.UI2.WinForms.Guna2Button btn_GetInformationEmployeeById;
        private Guna.UI2.WinForms.Guna2TextBox textbox_Id;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button btn_DeleteEmployee;
        private Guna.UI2.WinForms.Guna2Button btn_GetDepartList;
        private Guna.UI2.WinForms.Guna2Button btn_GetEmployeesByLastName;
        private Label label_lastName;
        private Guna.UI2.WinForms.Guna2TextBox textbox_LastName;
    }
}
