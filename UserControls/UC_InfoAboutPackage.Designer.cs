﻿namespace EmployeeManagement
{
    partial class UC_InfoAboutPackage
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DGV_PartiesForTheDay = new Guna.UI2.WinForms.Guna2DataGridView();
            kommis_num = new DataGridViewTextBoxColumn();
            Select = new DataGridViewCheckBoxColumn();
            DTP_DateStartSearchPart = new DateTimePicker();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            DTP_DateEndSearchPart = new DateTimePicker();
            UC_infoPackage = new Guna.UI2.WinForms.Guna2Elipse(components);
            DGV_tbPartNumber = new Guna.UI2.WinForms.Guna2DataGridView();
            PosInOrder = new DataGridViewTextBoxColumn();
            OrderNum = new DataGridViewTextBoxColumn();
            Item = new DataGridViewTextBoxColumn();
            Part = new DataGridViewTextBoxColumn();
            DGV_DetailsItem = new Guna.UI2.WinForms.Guna2DataGridView();
            btn_SearchPart = new Guna.UI2.WinForms.Guna2Button();
            btn_showSelectPart = new Guna.UI2.WinForms.Guna2Button();
            checkbox_selectAllParts = new Guna.UI2.WinForms.Guna2CheckBox();
            BarCode = new DataGridViewTextBoxColumn();
            Pyramida = new DataGridViewTextBoxColumn();
            TimeScan = new DataGridViewTextBoxColumn();
            Commentary = new DataGridViewTextBoxColumn();
            RescanPyramida = new DataGridViewTextBoxColumn();
            TimeRescan = new DataGridViewTextBoxColumn();
            IsBryansk = new DataGridViewTextBoxColumn();
            Formula = new DataGridViewTextBoxColumn();
            ItemSize = new DataGridViewTextBoxColumn();
            partItem = new DataGridViewTextBoxColumn();
            orderItem = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)DGV_PartiesForTheDay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGV_tbPartNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGV_DetailsItem).BeginInit();
            SuspendLayout();
            // 
            // DGV_PartiesForTheDay
            // 
            DGV_PartiesForTheDay.AllowUserToAddRows = false;
            DGV_PartiesForTheDay.AllowUserToDeleteRows = false;
            DGV_PartiesForTheDay.AllowUserToResizeColumns = false;
            DGV_PartiesForTheDay.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            DGV_PartiesForTheDay.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DGV_PartiesForTheDay.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DGV_PartiesForTheDay.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DGV_PartiesForTheDay.ColumnHeadersHeight = 30;
            DGV_PartiesForTheDay.Columns.AddRange(new DataGridViewColumn[] { kommis_num, Select });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DGV_PartiesForTheDay.DefaultCellStyle = dataGridViewCellStyle3;
            DGV_PartiesForTheDay.GridColor = Color.FromArgb(231, 229, 255);
            DGV_PartiesForTheDay.Location = new Point(216, 17);
            DGV_PartiesForTheDay.Name = "DGV_PartiesForTheDay";
            DGV_PartiesForTheDay.RowHeadersVisible = false;
            DGV_PartiesForTheDay.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            DGV_PartiesForTheDay.RowTemplate.Height = 25;
            DGV_PartiesForTheDay.Size = new Size(107, 898);
            DGV_PartiesForTheDay.TabIndex = 10;
            DGV_PartiesForTheDay.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            DGV_PartiesForTheDay.ThemeStyle.AlternatingRowsStyle.Font = null;
            DGV_PartiesForTheDay.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            DGV_PartiesForTheDay.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            DGV_PartiesForTheDay.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            DGV_PartiesForTheDay.ThemeStyle.BackColor = Color.White;
            DGV_PartiesForTheDay.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            DGV_PartiesForTheDay.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            DGV_PartiesForTheDay.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            DGV_PartiesForTheDay.ThemeStyle.HeaderStyle.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            DGV_PartiesForTheDay.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            DGV_PartiesForTheDay.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DGV_PartiesForTheDay.ThemeStyle.HeaderStyle.Height = 30;
            DGV_PartiesForTheDay.ThemeStyle.ReadOnly = false;
            DGV_PartiesForTheDay.ThemeStyle.RowsStyle.BackColor = Color.White;
            DGV_PartiesForTheDay.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DGV_PartiesForTheDay.ThemeStyle.RowsStyle.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            DGV_PartiesForTheDay.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            DGV_PartiesForTheDay.ThemeStyle.RowsStyle.Height = 25;
            DGV_PartiesForTheDay.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            DGV_PartiesForTheDay.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            DGV_PartiesForTheDay.SelectionChanged += DGV_PartiesForTheDay_SelectionChanged;
            // 
            // kommis_num
            // 
            kommis_num.HeaderText = "Партия";
            kommis_num.Name = "kommis_num";
            // 
            // Select
            // 
            Select.FalseValue = "0";
            Select.HeaderText = "X";
            Select.Name = "Select";
            Select.Resizable = DataGridViewTriState.True;
            Select.SortMode = DataGridViewColumnSortMode.Automatic;
            Select.TrueValue = "1";
            // 
            // DTP_DateStartSearchPart
            // 
            DTP_DateStartSearchPart.Location = new Point(44, 17);
            DTP_DateStartSearchPart.Name = "DTP_DateStartSearchPart";
            DTP_DateStartSearchPart.Size = new Size(169, 19);
            DTP_DateStartSearchPart.TabIndex = 11;
            DTP_DateStartSearchPart.Value = new DateTime(2023, 10, 27, 0, 1, 0, 0);
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Microsoft Sans Serif", 12.8F, FontStyle.Regular, GraphicsUnit.Point);
            guna2HtmlLabel1.Location = new Point(18, 17);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(20, 22);
            guna2HtmlLabel1.TabIndex = 12;
            guna2HtmlLabel1.Text = "C:";
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Microsoft Sans Serif", 12.8F, FontStyle.Regular, GraphicsUnit.Point);
            guna2HtmlLabel2.Location = new Point(12, 47);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(31, 22);
            guna2HtmlLabel2.TabIndex = 14;
            guna2HtmlLabel2.Text = "По:";
            // 
            // DTP_DateEndSearchPart
            // 
            DTP_DateEndSearchPart.Location = new Point(44, 51);
            DTP_DateEndSearchPart.Name = "DTP_DateEndSearchPart";
            DTP_DateEndSearchPart.Size = new Size(169, 19);
            DTP_DateEndSearchPart.TabIndex = 13;
            DTP_DateEndSearchPart.Value = new DateTime(2023, 10, 27, 23, 59, 0, 0);
            // 
            // UC_infoPackage
            // 
            UC_infoPackage.BorderRadius = 30;
            UC_infoPackage.TargetControl = this;
            // 
            // DGV_tbPartNumber
            // 
            DGV_tbPartNumber.AllowUserToAddRows = false;
            DGV_tbPartNumber.AllowUserToDeleteRows = false;
            DGV_tbPartNumber.AllowUserToResizeColumns = false;
            DGV_tbPartNumber.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = Color.White;
            DGV_tbPartNumber.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            DGV_tbPartNumber.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            DGV_tbPartNumber.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            DGV_tbPartNumber.ColumnHeadersHeight = 30;
            DGV_tbPartNumber.Columns.AddRange(new DataGridViewColumn[] { PosInOrder, OrderNum, Item, Part });
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.White;
            dataGridViewCellStyle9.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle9.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            DGV_tbPartNumber.DefaultCellStyle = dataGridViewCellStyle9;
            DGV_tbPartNumber.GridColor = Color.FromArgb(231, 229, 255);
            DGV_tbPartNumber.Location = new Point(322, 17);
            DGV_tbPartNumber.Name = "DGV_tbPartNumber";
            DGV_tbPartNumber.ReadOnly = true;
            DGV_tbPartNumber.RowHeadersVisible = false;
            DGV_tbPartNumber.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            DGV_tbPartNumber.RowTemplate.Height = 25;
            DGV_tbPartNumber.Size = new Size(337, 898);
            DGV_tbPartNumber.TabIndex = 15;
            DGV_tbPartNumber.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            DGV_tbPartNumber.ThemeStyle.AlternatingRowsStyle.Font = null;
            DGV_tbPartNumber.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            DGV_tbPartNumber.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            DGV_tbPartNumber.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            DGV_tbPartNumber.ThemeStyle.BackColor = Color.White;
            DGV_tbPartNumber.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            DGV_tbPartNumber.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            DGV_tbPartNumber.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            DGV_tbPartNumber.ThemeStyle.HeaderStyle.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            DGV_tbPartNumber.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            DGV_tbPartNumber.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DGV_tbPartNumber.ThemeStyle.HeaderStyle.Height = 30;
            DGV_tbPartNumber.ThemeStyle.ReadOnly = true;
            DGV_tbPartNumber.ThemeStyle.RowsStyle.BackColor = Color.White;
            DGV_tbPartNumber.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DGV_tbPartNumber.ThemeStyle.RowsStyle.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            DGV_tbPartNumber.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            DGV_tbPartNumber.ThemeStyle.RowsStyle.Height = 25;
            DGV_tbPartNumber.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            DGV_tbPartNumber.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            DGV_tbPartNumber.SelectionChanged += DGV_tbPartNumber_SelectionChanged;
            // 
            // PosInOrder
            // 
            PosInOrder.HeaderText = "Позиция в заказе";
            PosInOrder.Name = "PosInOrder";
            PosInOrder.ReadOnly = true;
            // 
            // OrderNum
            // 
            OrderNum.HeaderText = "Номер заказа";
            OrderNum.Name = "OrderNum";
            OrderNum.ReadOnly = true;
            // 
            // Item
            // 
            Item.HeaderText = "Изделий";
            Item.Name = "Item";
            Item.ReadOnly = true;
            // 
            // Part
            // 
            Part.HeaderText = "Партия";
            Part.Name = "Part";
            Part.ReadOnly = true;
            // 
            // DGV_DetailsItem
            // 
            DGV_DetailsItem.AllowUserToAddRows = false;
            DGV_DetailsItem.AllowUserToDeleteRows = false;
            DGV_DetailsItem.AllowUserToResizeColumns = false;
            DGV_DetailsItem.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = Color.White;
            DGV_DetailsItem.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            DGV_DetailsItem.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            DGV_DetailsItem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            DGV_DetailsItem.ColumnHeadersHeight = 30;
            DGV_DetailsItem.Columns.AddRange(new DataGridViewColumn[] { BarCode, Pyramida, TimeScan, Commentary, RescanPyramida, TimeRescan, IsBryansk, Formula, ItemSize, partItem, orderItem });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            DGV_DetailsItem.DefaultCellStyle = dataGridViewCellStyle6;
            DGV_DetailsItem.GridColor = Color.FromArgb(231, 229, 255);
            DGV_DetailsItem.Location = new Point(665, 17);
            DGV_DetailsItem.Name = "DGV_DetailsItem";
            DGV_DetailsItem.ReadOnly = true;
            DGV_DetailsItem.RowHeadersVisible = false;
            DGV_DetailsItem.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            DGV_DetailsItem.RowTemplate.Height = 25;
            DGV_DetailsItem.Size = new Size(1166, 898);
            DGV_DetailsItem.TabIndex = 18;
            DGV_DetailsItem.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            DGV_DetailsItem.ThemeStyle.AlternatingRowsStyle.Font = null;
            DGV_DetailsItem.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            DGV_DetailsItem.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            DGV_DetailsItem.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            DGV_DetailsItem.ThemeStyle.BackColor = Color.White;
            DGV_DetailsItem.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            DGV_DetailsItem.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            DGV_DetailsItem.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            DGV_DetailsItem.ThemeStyle.HeaderStyle.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            DGV_DetailsItem.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            DGV_DetailsItem.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DGV_DetailsItem.ThemeStyle.HeaderStyle.Height = 30;
            DGV_DetailsItem.ThemeStyle.ReadOnly = true;
            DGV_DetailsItem.ThemeStyle.RowsStyle.BackColor = Color.White;
            DGV_DetailsItem.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DGV_DetailsItem.ThemeStyle.RowsStyle.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            DGV_DetailsItem.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            DGV_DetailsItem.ThemeStyle.RowsStyle.Height = 25;
            DGV_DetailsItem.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            DGV_DetailsItem.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // btn_SearchPart
            // 
            btn_SearchPart.BorderRadius = 23;
            btn_SearchPart.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            btn_SearchPart.BorderThickness = 1;
            btn_SearchPart.CustomizableEdges = customizableEdges3;
            btn_SearchPart.DisabledState.BorderColor = Color.DarkGray;
            btn_SearchPart.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_SearchPart.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_SearchPart.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_SearchPart.FillColor = Color.White;
            btn_SearchPart.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_SearchPart.ForeColor = Color.Black;
            btn_SearchPart.Location = new Point(18, 87);
            btn_SearchPart.Name = "btn_SearchPart";
            btn_SearchPart.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btn_SearchPart.Size = new Size(180, 45);
            btn_SearchPart.TabIndex = 19;
            btn_SearchPart.Text = "Поиск";
            btn_SearchPart.Click += btn_SearchPart_Click_1;
            // 
            // btn_showSelectPart
            // 
            btn_showSelectPart.BorderRadius = 23;
            btn_showSelectPart.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            btn_showSelectPart.BorderThickness = 1;
            btn_showSelectPart.CustomizableEdges = customizableEdges1;
            btn_showSelectPart.DisabledState.BorderColor = Color.DarkGray;
            btn_showSelectPart.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_showSelectPart.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_showSelectPart.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_showSelectPart.FillColor = Color.White;
            btn_showSelectPart.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_showSelectPart.ForeColor = Color.Black;
            btn_showSelectPart.Location = new Point(18, 156);
            btn_showSelectPart.Name = "btn_showSelectPart";
            btn_showSelectPart.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btn_showSelectPart.Size = new Size(180, 68);
            btn_showSelectPart.TabIndex = 20;
            btn_showSelectPart.Text = "Отобразить выбранные партии";
            btn_showSelectPart.Click += btn_showSelectPart_Click;
            // 
            // checkbox_selectAllParts
            // 
            checkbox_selectAllParts.AutoSize = true;
            checkbox_selectAllParts.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            checkbox_selectAllParts.CheckedState.BorderRadius = 0;
            checkbox_selectAllParts.CheckedState.BorderThickness = 0;
            checkbox_selectAllParts.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            checkbox_selectAllParts.Font = new Font("Microsoft Sans Serif", 12.8F, FontStyle.Regular, GraphicsUnit.Point);
            checkbox_selectAllParts.Location = new Point(12, 240);
            checkbox_selectAllParts.Name = "checkbox_selectAllParts";
            checkbox_selectAllParts.Size = new Size(198, 26);
            checkbox_selectAllParts.TabIndex = 22;
            checkbox_selectAllParts.Text = "Выбрать все партии";
            checkbox_selectAllParts.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            checkbox_selectAllParts.UncheckedState.BorderRadius = 0;
            checkbox_selectAllParts.UncheckedState.BorderThickness = 0;
            checkbox_selectAllParts.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            checkbox_selectAllParts.CheckedChanged += checkbox_selectAllParts_CheckedChanged;
            // 
            // BarCode
            // 
            BarCode.HeaderText = "Штрихкод";
            BarCode.Name = "BarCode";
            BarCode.ReadOnly = true;
            // 
            // Pyramida
            // 
            Pyramida.HeaderText = "Пирамида";
            Pyramida.Name = "Pyramida";
            Pyramida.ReadOnly = true;
            // 
            // TimeScan
            // 
            TimeScan.HeaderText = "Время сканирования";
            TimeScan.Name = "TimeScan";
            TimeScan.ReadOnly = true;
            // 
            // Commentary
            // 
            Commentary.HeaderText = "Комментарий";
            Commentary.Name = "Commentary";
            Commentary.ReadOnly = true;
            // 
            // RescanPyramida
            // 
            RescanPyramida.HeaderText = "Пересканированная пирамида";
            RescanPyramida.Name = "RescanPyramida";
            RescanPyramida.ReadOnly = true;
            // 
            // TimeRescan
            // 
            TimeRescan.HeaderText = "Время пересканирования";
            TimeRescan.Name = "TimeRescan";
            TimeRescan.ReadOnly = true;
            // 
            // IsBryansk
            // 
            IsBryansk.HeaderText = "Это Брянск?";
            IsBryansk.Name = "IsBryansk";
            IsBryansk.ReadOnly = true;
            // 
            // Formula
            // 
            Formula.HeaderText = "Формула";
            Formula.Name = "Formula";
            Formula.ReadOnly = true;
            // 
            // ItemSize
            // 
            ItemSize.HeaderText = "Размер";
            ItemSize.Name = "ItemSize";
            ItemSize.ReadOnly = true;
            // 
            // partItem
            // 
            partItem.HeaderText = "Партия";
            partItem.Name = "partItem";
            partItem.ReadOnly = true;
            // 
            // orderItem
            // 
            orderItem.HeaderText = "Заказ";
            orderItem.Name = "orderItem";
            orderItem.ReadOnly = true;
            // 
            // UC_InfoAboutPackage
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.Fixed3D;
            Controls.Add(checkbox_selectAllParts);
            Controls.Add(btn_showSelectPart);
            Controls.Add(btn_SearchPart);
            Controls.Add(DGV_DetailsItem);
            Controls.Add(DGV_tbPartNumber);
            Controls.Add(guna2HtmlLabel2);
            Controls.Add(DTP_DateEndSearchPart);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(DTP_DateStartSearchPart);
            Controls.Add(DGV_PartiesForTheDay);
            Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "UC_InfoAboutPackage";
            Size = new Size(2493, 1190);
            Load += UC_Employees_Load;
            ((System.ComponentModel.ISupportInitialize)DGV_PartiesForTheDay).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGV_tbPartNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGV_DetailsItem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Guna.UI2.WinForms.Guna2DataGridView DGV_PartiesForTheDay;
        private DateTimePicker DTP_DateStartSearchPart;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private DateTimePicker DTP_DateEndSearchPart;
        public Guna.UI2.WinForms.Guna2Elipse UC_infoPackage;
        private Guna.UI2.WinForms.Guna2DataGridView DGV_tbPartNumber;
        private Guna.UI2.WinForms.Guna2DataGridView DGV_DetailsItem;
        private Guna.UI2.WinForms.Guna2Button btn_SearchPart;
        private DataGridViewTextBoxColumn kommis_num;
        private DataGridViewCheckBoxColumn Select;
        private Guna.UI2.WinForms.Guna2Button btn_showSelectPart;
        private Guna.UI2.WinForms.Guna2CheckBox checkbox_selectAllParts;
        private DataGridViewTextBoxColumn PosInOrder;
        private DataGridViewTextBoxColumn OrderNum;
        private DataGridViewTextBoxColumn Item;
        private DataGridViewTextBoxColumn Part;
        private DataGridViewTextBoxColumn BarCode;
        private DataGridViewTextBoxColumn Pyramida;
        private DataGridViewTextBoxColumn TimeScan;
        private DataGridViewTextBoxColumn Commentary;
        private DataGridViewTextBoxColumn RescanPyramida;
        private DataGridViewTextBoxColumn TimeRescan;
        private DataGridViewTextBoxColumn IsBryansk;
        private DataGridViewTextBoxColumn Formula;
        private DataGridViewTextBoxColumn ItemSize;
        private DataGridViewTextBoxColumn partItem;
        private DataGridViewTextBoxColumn orderItem;
    }
}
