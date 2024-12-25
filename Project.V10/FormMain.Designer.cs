namespace Project.V10
{
    partial class FormMain
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
            panelLeft_AAR = new Panel();
            groupBoxRowsEdit_AAR = new GroupBox();
            checkBoxMarkRow_AAR = new CheckBox();
            buttonUnmarkDelete_AAR = new Button();
            buttonMarkDelete_AAR = new Button();
            buttonDeleteMarkedRow_AAR = new Button();
            buttonAddRow_AAR = new Button();
            groupBoxTable_AAR = new GroupBox();
            buttonOpenFile_AAR = new Button();
            buttonSaveFile_AAR = new Button();
            panelFill_AAR = new Panel();
            tabControlTable_AAR = new TabControl();
            tabPageReadOnly_AAR = new TabPage();
            dataGridViewReadOnly_AAR = new DataGridView();
            OrderID = new DataGridViewTextBoxColumn();
            UserID = new DataGridViewTextBoxColumn();
            Adress = new DataGridViewTextBoxColumn();
            OrderDate = new DataGridViewTextBoxColumn();
            OrderValue = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            ProductCount = new DataGridViewTextBoxColumn();
            ProductPrice = new DataGridViewTextBoxColumn();
            tabControlReadOnlySearch_AAR = new TabControl();
            tabPageReadOnlySearchOrderID_AAR = new TabPage();
            buttonReadOnlySearchOrderID_AAR = new Button();
            textBoxReadOnlySearchOrderID_AAR = new TextBox();
            tabPageReadOnlySearchUserID_AAR = new TabPage();
            buttonReadOnlySearchUserID_AAR = new Button();
            textBoxReadOnlySearchUserID_AAR = new TextBox();
            tabPageEdit_AAR = new TabPage();
            dataGridViewEdit_AAR = new DataGridView();
            OrderIDedit = new DataGridViewTextBoxColumn();
            UserIDedit = new DataGridViewTextBoxColumn();
            AdressEdit = new DataGridViewTextBoxColumn();
            OrderDateEdit = new DataGridViewTextBoxColumn();
            OrderValueEdit = new DataGridViewTextBoxColumn();
            ProductNameEdit = new DataGridViewTextBoxColumn();
            ProductCountEdit = new DataGridViewTextBoxColumn();
            ProductPriceEdit = new DataGridViewTextBoxColumn();
            tabControlEditSearch_AAR = new TabControl();
            tabPageEditSearchOrderID_AAR = new TabPage();
            buttonEditSearchOrderID_AAR = new Button();
            textBoxEditSearchOrderID_AAR = new TextBox();
            tabPageEditSearchUserID_AAR = new TabPage();
            buttonEditSearchUserID_AAR = new Button();
            textBoxEditSearchUserID_AAR = new TextBox();
            openFileDialogTask_AAR = new OpenFileDialog();
            toolTipTask_AAR = new ToolTip(components);
            saveFileDialogTask_AAR = new SaveFileDialog();
            menuStrip_AAR = new MenuStrip();
            statsToolStripMenuItem_AAR = new ToolStripMenuItem();
            filterToolStripMenuItem_AAR = new ToolStripMenuItem();
            DeletedRowsToolStripMenuItem_AAR = new ToolStripMenuItem();
            AddedRowsToolStripMenuItem_AAR = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            guideToolStripMenuItem_AAR = new ToolStripMenuItem();
            infoToolStripMenuItem_AAR = new ToolStripMenuItem();
            panelLeft_AAR.SuspendLayout();
            groupBoxRowsEdit_AAR.SuspendLayout();
            groupBoxTable_AAR.SuspendLayout();
            panelFill_AAR.SuspendLayout();
            tabControlTable_AAR.SuspendLayout();
            tabPageReadOnly_AAR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReadOnly_AAR).BeginInit();
            tabControlReadOnlySearch_AAR.SuspendLayout();
            tabPageReadOnlySearchOrderID_AAR.SuspendLayout();
            tabPageReadOnlySearchUserID_AAR.SuspendLayout();
            tabPageEdit_AAR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEdit_AAR).BeginInit();
            tabControlEditSearch_AAR.SuspendLayout();
            tabPageEditSearchOrderID_AAR.SuspendLayout();
            tabPageEditSearchUserID_AAR.SuspendLayout();
            menuStrip_AAR.SuspendLayout();
            SuspendLayout();
            // 
            // panelLeft_AAR
            // 
            panelLeft_AAR.Controls.Add(groupBoxRowsEdit_AAR);
            panelLeft_AAR.Controls.Add(groupBoxTable_AAR);
            panelLeft_AAR.Dock = DockStyle.Left;
            panelLeft_AAR.Location = new Point(0, 24);
            panelLeft_AAR.Margin = new Padding(3, 2, 3, 2);
            panelLeft_AAR.Name = "panelLeft_AAR";
            panelLeft_AAR.Size = new Size(156, 663);
            panelLeft_AAR.TabIndex = 0;
            // 
            // groupBoxRowsEdit_AAR
            // 
            groupBoxRowsEdit_AAR.Controls.Add(checkBoxMarkRow_AAR);
            groupBoxRowsEdit_AAR.Controls.Add(buttonUnmarkDelete_AAR);
            groupBoxRowsEdit_AAR.Controls.Add(buttonMarkDelete_AAR);
            groupBoxRowsEdit_AAR.Controls.Add(buttonDeleteMarkedRow_AAR);
            groupBoxRowsEdit_AAR.Controls.Add(buttonAddRow_AAR);
            groupBoxRowsEdit_AAR.Dock = DockStyle.Fill;
            groupBoxRowsEdit_AAR.Location = new Point(0, 103);
            groupBoxRowsEdit_AAR.Name = "groupBoxRowsEdit_AAR";
            groupBoxRowsEdit_AAR.Size = new Size(156, 560);
            groupBoxRowsEdit_AAR.TabIndex = 2;
            groupBoxRowsEdit_AAR.TabStop = false;
            groupBoxRowsEdit_AAR.Text = "Строки";
            // 
            // checkBoxMarkRow_AAR
            // 
            checkBoxMarkRow_AAR.AutoSize = true;
            checkBoxMarkRow_AAR.Enabled = false;
            checkBoxMarkRow_AAR.Location = new Point(19, 105);
            checkBoxMarkRow_AAR.Name = "checkBoxMarkRow_AAR";
            checkBoxMarkRow_AAR.Size = new Size(128, 19);
            checkBoxMarkRow_AAR.TabIndex = 4;
            checkBoxMarkRow_AAR.Text = "Выделение строки";
            checkBoxMarkRow_AAR.UseVisualStyleBackColor = true;
            checkBoxMarkRow_AAR.CheckedChanged += checkBoxMarkRow_AAR_Checked;
            // 
            // buttonUnmarkDelete_AAR
            // 
            buttonUnmarkDelete_AAR.Enabled = false;
            buttonUnmarkDelete_AAR.Image = Properties.Resources.flag_green;
            buttonUnmarkDelete_AAR.Location = new Point(19, 139);
            buttonUnmarkDelete_AAR.Name = "buttonUnmarkDelete_AAR";
            buttonUnmarkDelete_AAR.Size = new Size(51, 45);
            buttonUnmarkDelete_AAR.TabIndex = 3;
            toolTipTask_AAR.SetToolTip(buttonUnmarkDelete_AAR, "Снять пометку на удаление");
            buttonUnmarkDelete_AAR.UseVisualStyleBackColor = true;
            buttonUnmarkDelete_AAR.Click += buttonUnmarkDelete_AAR_Click;
            // 
            // buttonMarkDelete_AAR
            // 
            buttonMarkDelete_AAR.Enabled = false;
            buttonMarkDelete_AAR.Image = Properties.Resources.flag_red;
            buttonMarkDelete_AAR.Location = new Point(87, 139);
            buttonMarkDelete_AAR.Name = "buttonMarkDelete_AAR";
            buttonMarkDelete_AAR.Size = new Size(51, 45);
            buttonMarkDelete_AAR.TabIndex = 3;
            toolTipTask_AAR.SetToolTip(buttonMarkDelete_AAR, "Пометить строку на удаление");
            buttonMarkDelete_AAR.UseVisualStyleBackColor = true;
            buttonMarkDelete_AAR.Click += buttonMarkDelete_AAR_Click;
            // 
            // buttonDeleteMarkedRow_AAR
            // 
            buttonDeleteMarkedRow_AAR.Enabled = false;
            buttonDeleteMarkedRow_AAR.Image = Properties.Resources.cross;
            buttonDeleteMarkedRow_AAR.Location = new Point(89, 33);
            buttonDeleteMarkedRow_AAR.Name = "buttonDeleteMarkedRow_AAR";
            buttonDeleteMarkedRow_AAR.Size = new Size(49, 45);
            buttonDeleteMarkedRow_AAR.TabIndex = 2;
            toolTipTask_AAR.SetToolTip(buttonDeleteMarkedRow_AAR, "Удалить помеченные строки");
            buttonDeleteMarkedRow_AAR.UseVisualStyleBackColor = true;
            buttonDeleteMarkedRow_AAR.Click += buttonDeleteMarkedRow_AAR_Click;
            // 
            // buttonAddRow_AAR
            // 
            buttonAddRow_AAR.Enabled = false;
            buttonAddRow_AAR.Image = Properties.Resources.add;
            buttonAddRow_AAR.Location = new Point(19, 33);
            buttonAddRow_AAR.Name = "buttonAddRow_AAR";
            buttonAddRow_AAR.Size = new Size(49, 45);
            buttonAddRow_AAR.TabIndex = 0;
            toolTipTask_AAR.SetToolTip(buttonAddRow_AAR, "Добавить строку");
            buttonAddRow_AAR.UseVisualStyleBackColor = true;
            buttonAddRow_AAR.Click += buttonAdd_AAR_Click;
            // 
            // groupBoxTable_AAR
            // 
            groupBoxTable_AAR.Controls.Add(buttonOpenFile_AAR);
            groupBoxTable_AAR.Controls.Add(buttonSaveFile_AAR);
            groupBoxTable_AAR.Dock = DockStyle.Top;
            groupBoxTable_AAR.Location = new Point(0, 0);
            groupBoxTable_AAR.Name = "groupBoxTable_AAR";
            groupBoxTable_AAR.Size = new Size(156, 103);
            groupBoxTable_AAR.TabIndex = 1;
            groupBoxTable_AAR.TabStop = false;
            groupBoxTable_AAR.Text = "Таблица";
            // 
            // buttonOpenFile_AAR
            // 
            buttonOpenFile_AAR.Image = Properties.Resources.folder_go;
            buttonOpenFile_AAR.Location = new Point(19, 33);
            buttonOpenFile_AAR.Margin = new Padding(3, 2, 3, 2);
            buttonOpenFile_AAR.Name = "buttonOpenFile_AAR";
            buttonOpenFile_AAR.Size = new Size(55, 45);
            buttonOpenFile_AAR.TabIndex = 0;
            toolTipTask_AAR.SetToolTip(buttonOpenFile_AAR, "Открыть файл");
            buttonOpenFile_AAR.UseVisualStyleBackColor = true;
            buttonOpenFile_AAR.Click += buttonOpenFile_AAR_Click;
            // 
            // buttonSaveFile_AAR
            // 
            buttonSaveFile_AAR.Enabled = false;
            buttonSaveFile_AAR.Image = Properties.Resources.folder_database;
            buttonSaveFile_AAR.Location = new Point(87, 33);
            buttonSaveFile_AAR.Margin = new Padding(3, 2, 3, 2);
            buttonSaveFile_AAR.Name = "buttonSaveFile_AAR";
            buttonSaveFile_AAR.Size = new Size(55, 45);
            buttonSaveFile_AAR.TabIndex = 0;
            toolTipTask_AAR.SetToolTip(buttonSaveFile_AAR, "Сохранить файл");
            buttonSaveFile_AAR.UseVisualStyleBackColor = true;
            buttonSaveFile_AAR.Click += buttonSaveFile_AAR_Click;
            // 
            // panelFill_AAR
            // 
            panelFill_AAR.Controls.Add(tabControlTable_AAR);
            panelFill_AAR.Dock = DockStyle.Fill;
            panelFill_AAR.Location = new Point(156, 24);
            panelFill_AAR.Margin = new Padding(3, 2, 3, 2);
            panelFill_AAR.Name = "panelFill_AAR";
            panelFill_AAR.Size = new Size(989, 663);
            panelFill_AAR.TabIndex = 2;
            // 
            // tabControlTable_AAR
            // 
            tabControlTable_AAR.Controls.Add(tabPageReadOnly_AAR);
            tabControlTable_AAR.Controls.Add(tabPageEdit_AAR);
            tabControlTable_AAR.Dock = DockStyle.Fill;
            tabControlTable_AAR.Location = new Point(0, 0);
            tabControlTable_AAR.Name = "tabControlTable_AAR";
            tabControlTable_AAR.Padding = new Point(6, 15);
            tabControlTable_AAR.SelectedIndex = 0;
            tabControlTable_AAR.Size = new Size(989, 663);
            tabControlTable_AAR.TabIndex = 0;
            tabControlTable_AAR.SelectedIndexChanged += tabControlTable_AAR_SelectedIndexChanged;
            // 
            // tabPageReadOnly_AAR
            // 
            tabPageReadOnly_AAR.Controls.Add(dataGridViewReadOnly_AAR);
            tabPageReadOnly_AAR.Controls.Add(tabControlReadOnlySearch_AAR);
            tabPageReadOnly_AAR.Location = new Point(4, 48);
            tabPageReadOnly_AAR.Name = "tabPageReadOnly_AAR";
            tabPageReadOnly_AAR.Padding = new Padding(3);
            tabPageReadOnly_AAR.Size = new Size(981, 611);
            tabPageReadOnly_AAR.TabIndex = 0;
            tabPageReadOnly_AAR.Text = "Чтение";
            tabPageReadOnly_AAR.UseVisualStyleBackColor = true;
            // 
            // dataGridViewReadOnly_AAR
            // 
            dataGridViewReadOnly_AAR.AllowUserToAddRows = false;
            dataGridViewReadOnly_AAR.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReadOnly_AAR.Columns.AddRange(new DataGridViewColumn[] { OrderID, UserID, Adress, OrderDate, OrderValue, ProductName, ProductCount, ProductPrice });
            dataGridViewReadOnly_AAR.Dock = DockStyle.Fill;
            dataGridViewReadOnly_AAR.Location = new Point(3, 62);
            dataGridViewReadOnly_AAR.Margin = new Padding(3, 2, 3, 2);
            dataGridViewReadOnly_AAR.Name = "dataGridViewReadOnly_AAR";
            dataGridViewReadOnly_AAR.ReadOnly = true;
            dataGridViewReadOnly_AAR.RowHeadersVisible = false;
            dataGridViewReadOnly_AAR.RowHeadersWidth = 51;
            dataGridViewReadOnly_AAR.Size = new Size(975, 546);
            dataGridViewReadOnly_AAR.TabIndex = 0;
            // 
            // OrderID
            // 
            OrderID.HeaderText = "Номер заказа";
            OrderID.MinimumWidth = 6;
            OrderID.Name = "OrderID";
            OrderID.ReadOnly = true;
            // 
            // UserID
            // 
            UserID.HeaderText = "Номер счёта";
            UserID.MinimumWidth = 6;
            UserID.Name = "UserID";
            UserID.ReadOnly = true;
            // 
            // Adress
            // 
            Adress.HeaderText = "Адрес";
            Adress.Name = "Adress";
            Adress.ReadOnly = true;
            // 
            // OrderDate
            // 
            OrderDate.HeaderText = "Дата исполнения";
            OrderDate.MinimumWidth = 6;
            OrderDate.Name = "OrderDate";
            OrderDate.ReadOnly = true;
            OrderDate.Width = 125;
            // 
            // OrderValue
            // 
            OrderValue.HeaderText = "Стоимость заказа (руб.)";
            OrderValue.MinimumWidth = 6;
            OrderValue.Name = "OrderValue";
            OrderValue.ReadOnly = true;
            OrderValue.Width = 125;
            // 
            // ProductName
            // 
            ProductName.HeaderText = "Название товара";
            ProductName.MinimumWidth = 6;
            ProductName.Name = "ProductName";
            ProductName.ReadOnly = true;
            ProductName.Width = 125;
            // 
            // ProductCount
            // 
            ProductCount.HeaderText = "Количество (шт.)";
            ProductCount.MinimumWidth = 6;
            ProductCount.Name = "ProductCount";
            ProductCount.ReadOnly = true;
            ProductCount.Width = 125;
            // 
            // ProductPrice
            // 
            ProductPrice.HeaderText = "Стоимость товара (руб.)";
            ProductPrice.MinimumWidth = 6;
            ProductPrice.Name = "ProductPrice";
            ProductPrice.ReadOnly = true;
            ProductPrice.Width = 125;
            // 
            // tabControlReadOnlySearch_AAR
            // 
            tabControlReadOnlySearch_AAR.Controls.Add(tabPageReadOnlySearchOrderID_AAR);
            tabControlReadOnlySearch_AAR.Controls.Add(tabPageReadOnlySearchUserID_AAR);
            tabControlReadOnlySearch_AAR.Dock = DockStyle.Top;
            tabControlReadOnlySearch_AAR.Location = new Point(3, 3);
            tabControlReadOnlySearch_AAR.Name = "tabControlReadOnlySearch_AAR";
            tabControlReadOnlySearch_AAR.SelectedIndex = 0;
            tabControlReadOnlySearch_AAR.Size = new Size(975, 59);
            tabControlReadOnlySearch_AAR.TabIndex = 3;
            // 
            // tabPageReadOnlySearchOrderID_AAR
            // 
            tabPageReadOnlySearchOrderID_AAR.Controls.Add(buttonReadOnlySearchOrderID_AAR);
            tabPageReadOnlySearchOrderID_AAR.Controls.Add(textBoxReadOnlySearchOrderID_AAR);
            tabPageReadOnlySearchOrderID_AAR.Location = new Point(4, 24);
            tabPageReadOnlySearchOrderID_AAR.Name = "tabPageReadOnlySearchOrderID_AAR";
            tabPageReadOnlySearchOrderID_AAR.Padding = new Padding(3);
            tabPageReadOnlySearchOrderID_AAR.Size = new Size(967, 31);
            tabPageReadOnlySearchOrderID_AAR.TabIndex = 0;
            tabPageReadOnlySearchOrderID_AAR.Text = "По номеру заказа";
            tabPageReadOnlySearchOrderID_AAR.UseVisualStyleBackColor = true;
            // 
            // buttonReadOnlySearchOrderID_AAR
            // 
            buttonReadOnlySearchOrderID_AAR.BackgroundImage = Properties.Resources.zoom;
            buttonReadOnlySearchOrderID_AAR.BackgroundImageLayout = ImageLayout.Zoom;
            buttonReadOnlySearchOrderID_AAR.Dock = DockStyle.Left;
            buttonReadOnlySearchOrderID_AAR.Location = new Point(198, 3);
            buttonReadOnlySearchOrderID_AAR.Name = "buttonReadOnlySearchOrderID_AAR";
            buttonReadOnlySearchOrderID_AAR.Size = new Size(25, 25);
            buttonReadOnlySearchOrderID_AAR.TabIndex = 3;
            buttonReadOnlySearchOrderID_AAR.UseVisualStyleBackColor = true;
            buttonReadOnlySearchOrderID_AAR.Click += buttonReadOnlySearchOrderID_AAR_Click;
            // 
            // textBoxReadOnlySearchOrderID_AAR
            // 
            textBoxReadOnlySearchOrderID_AAR.Dock = DockStyle.Left;
            textBoxReadOnlySearchOrderID_AAR.Location = new Point(3, 3);
            textBoxReadOnlySearchOrderID_AAR.Name = "textBoxReadOnlySearchOrderID_AAR";
            textBoxReadOnlySearchOrderID_AAR.PlaceholderText = "Поиск...";
            textBoxReadOnlySearchOrderID_AAR.Size = new Size(195, 23);
            textBoxReadOnlySearchOrderID_AAR.TabIndex = 0;
            // 
            // tabPageReadOnlySearchUserID_AAR
            // 
            tabPageReadOnlySearchUserID_AAR.Controls.Add(buttonReadOnlySearchUserID_AAR);
            tabPageReadOnlySearchUserID_AAR.Controls.Add(textBoxReadOnlySearchUserID_AAR);
            tabPageReadOnlySearchUserID_AAR.Location = new Point(4, 24);
            tabPageReadOnlySearchUserID_AAR.Name = "tabPageReadOnlySearchUserID_AAR";
            tabPageReadOnlySearchUserID_AAR.Padding = new Padding(3);
            tabPageReadOnlySearchUserID_AAR.Size = new Size(967, 31);
            tabPageReadOnlySearchUserID_AAR.TabIndex = 1;
            tabPageReadOnlySearchUserID_AAR.Text = "По номеру счёта";
            tabPageReadOnlySearchUserID_AAR.UseVisualStyleBackColor = true;
            // 
            // buttonReadOnlySearchUserID_AAR
            // 
            buttonReadOnlySearchUserID_AAR.BackgroundImage = Properties.Resources.zoom;
            buttonReadOnlySearchUserID_AAR.BackgroundImageLayout = ImageLayout.Zoom;
            buttonReadOnlySearchUserID_AAR.Dock = DockStyle.Left;
            buttonReadOnlySearchUserID_AAR.Location = new Point(198, 3);
            buttonReadOnlySearchUserID_AAR.Name = "buttonReadOnlySearchUserID_AAR";
            buttonReadOnlySearchUserID_AAR.Size = new Size(25, 25);
            buttonReadOnlySearchUserID_AAR.TabIndex = 4;
            buttonReadOnlySearchUserID_AAR.UseVisualStyleBackColor = true;
            buttonReadOnlySearchUserID_AAR.Click += buttonReadOnlySearchUserID_AAR_Click;
            // 
            // textBoxReadOnlySearchUserID_AAR
            // 
            textBoxReadOnlySearchUserID_AAR.Dock = DockStyle.Left;
            textBoxReadOnlySearchUserID_AAR.Location = new Point(3, 3);
            textBoxReadOnlySearchUserID_AAR.Name = "textBoxReadOnlySearchUserID_AAR";
            textBoxReadOnlySearchUserID_AAR.PlaceholderText = "Поиск...";
            textBoxReadOnlySearchUserID_AAR.Size = new Size(195, 23);
            textBoxReadOnlySearchUserID_AAR.TabIndex = 1;
            // 
            // tabPageEdit_AAR
            // 
            tabPageEdit_AAR.Controls.Add(dataGridViewEdit_AAR);
            tabPageEdit_AAR.Controls.Add(tabControlEditSearch_AAR);
            tabPageEdit_AAR.Location = new Point(4, 48);
            tabPageEdit_AAR.Name = "tabPageEdit_AAR";
            tabPageEdit_AAR.Padding = new Padding(3);
            tabPageEdit_AAR.Size = new Size(981, 611);
            tabPageEdit_AAR.TabIndex = 1;
            tabPageEdit_AAR.Text = "Редактирование";
            tabPageEdit_AAR.UseVisualStyleBackColor = true;
            // 
            // dataGridViewEdit_AAR
            // 
            dataGridViewEdit_AAR.AllowUserToAddRows = false;
            dataGridViewEdit_AAR.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEdit_AAR.Columns.AddRange(new DataGridViewColumn[] { OrderIDedit, UserIDedit, AdressEdit, OrderDateEdit, OrderValueEdit, ProductNameEdit, ProductCountEdit, ProductPriceEdit });
            dataGridViewEdit_AAR.Dock = DockStyle.Fill;
            dataGridViewEdit_AAR.Location = new Point(3, 62);
            dataGridViewEdit_AAR.Margin = new Padding(3, 2, 3, 2);
            dataGridViewEdit_AAR.Name = "dataGridViewEdit_AAR";
            dataGridViewEdit_AAR.RowHeadersVisible = false;
            dataGridViewEdit_AAR.RowHeadersWidth = 51;
            dataGridViewEdit_AAR.Size = new Size(975, 546);
            dataGridViewEdit_AAR.TabIndex = 1;
            dataGridViewEdit_AAR.CellBeginEdit += dataGridViewEdit_AAR_CellBeginEdit;
            dataGridViewEdit_AAR.CellValidating += dataGridViewEdit_AAR_CellValidating;
            dataGridViewEdit_AAR.CellValueChanged += dataGridViewEdit_AAR_CellValueChanged;
            // 
            // OrderIDedit
            // 
            OrderIDedit.HeaderText = "Номер заказа";
            OrderIDedit.MinimumWidth = 6;
            OrderIDedit.Name = "OrderIDedit";
            // 
            // UserIDedit
            // 
            UserIDedit.HeaderText = "Номер счёта";
            UserIDedit.MinimumWidth = 6;
            UserIDedit.Name = "UserIDedit";
            // 
            // AdressEdit
            // 
            AdressEdit.HeaderText = "Адрес";
            AdressEdit.Name = "AdressEdit";
            // 
            // OrderDateEdit
            // 
            OrderDateEdit.HeaderText = "Дата исполнения";
            OrderDateEdit.MinimumWidth = 6;
            OrderDateEdit.Name = "OrderDateEdit";
            OrderDateEdit.Width = 125;
            // 
            // OrderValueEdit
            // 
            OrderValueEdit.HeaderText = "Стоимость заказа (руб.)";
            OrderValueEdit.MinimumWidth = 6;
            OrderValueEdit.Name = "OrderValueEdit";
            OrderValueEdit.Width = 125;
            // 
            // ProductNameEdit
            // 
            ProductNameEdit.HeaderText = "Название товара";
            ProductNameEdit.MinimumWidth = 6;
            ProductNameEdit.Name = "ProductNameEdit";
            ProductNameEdit.Width = 125;
            // 
            // ProductCountEdit
            // 
            ProductCountEdit.HeaderText = "Количество (шт.)";
            ProductCountEdit.MinimumWidth = 6;
            ProductCountEdit.Name = "ProductCountEdit";
            ProductCountEdit.Width = 125;
            // 
            // ProductPriceEdit
            // 
            ProductPriceEdit.HeaderText = "Стоимость товара (руб.)";
            ProductPriceEdit.MinimumWidth = 6;
            ProductPriceEdit.Name = "ProductPriceEdit";
            ProductPriceEdit.Width = 125;
            // 
            // tabControlEditSearch_AAR
            // 
            tabControlEditSearch_AAR.Controls.Add(tabPageEditSearchOrderID_AAR);
            tabControlEditSearch_AAR.Controls.Add(tabPageEditSearchUserID_AAR);
            tabControlEditSearch_AAR.Dock = DockStyle.Top;
            tabControlEditSearch_AAR.Location = new Point(3, 3);
            tabControlEditSearch_AAR.Name = "tabControlEditSearch_AAR";
            tabControlEditSearch_AAR.SelectedIndex = 0;
            tabControlEditSearch_AAR.Size = new Size(975, 59);
            tabControlEditSearch_AAR.TabIndex = 2;
            // 
            // tabPageEditSearchOrderID_AAR
            // 
            tabPageEditSearchOrderID_AAR.Controls.Add(buttonEditSearchOrderID_AAR);
            tabPageEditSearchOrderID_AAR.Controls.Add(textBoxEditSearchOrderID_AAR);
            tabPageEditSearchOrderID_AAR.Location = new Point(4, 24);
            tabPageEditSearchOrderID_AAR.Name = "tabPageEditSearchOrderID_AAR";
            tabPageEditSearchOrderID_AAR.Padding = new Padding(3);
            tabPageEditSearchOrderID_AAR.Size = new Size(967, 31);
            tabPageEditSearchOrderID_AAR.TabIndex = 0;
            tabPageEditSearchOrderID_AAR.Text = "По номеру заказа";
            tabPageEditSearchOrderID_AAR.UseVisualStyleBackColor = true;
            // 
            // buttonEditSearchOrderID_AAR
            // 
            buttonEditSearchOrderID_AAR.BackgroundImage = Properties.Resources.zoom;
            buttonEditSearchOrderID_AAR.BackgroundImageLayout = ImageLayout.Zoom;
            buttonEditSearchOrderID_AAR.Dock = DockStyle.Left;
            buttonEditSearchOrderID_AAR.Location = new Point(198, 3);
            buttonEditSearchOrderID_AAR.Name = "buttonEditSearchOrderID_AAR";
            buttonEditSearchOrderID_AAR.Size = new Size(25, 25);
            buttonEditSearchOrderID_AAR.TabIndex = 4;
            buttonEditSearchOrderID_AAR.UseVisualStyleBackColor = true;
            buttonEditSearchOrderID_AAR.Click += buttonEditSearchOrderID_AAR_Click;
            // 
            // textBoxEditSearchOrderID_AAR
            // 
            textBoxEditSearchOrderID_AAR.Dock = DockStyle.Left;
            textBoxEditSearchOrderID_AAR.Location = new Point(3, 3);
            textBoxEditSearchOrderID_AAR.Name = "textBoxEditSearchOrderID_AAR";
            textBoxEditSearchOrderID_AAR.PlaceholderText = "Поиск...";
            textBoxEditSearchOrderID_AAR.Size = new Size(195, 23);
            textBoxEditSearchOrderID_AAR.TabIndex = 1;
            // 
            // tabPageEditSearchUserID_AAR
            // 
            tabPageEditSearchUserID_AAR.Controls.Add(buttonEditSearchUserID_AAR);
            tabPageEditSearchUserID_AAR.Controls.Add(textBoxEditSearchUserID_AAR);
            tabPageEditSearchUserID_AAR.Location = new Point(4, 24);
            tabPageEditSearchUserID_AAR.Name = "tabPageEditSearchUserID_AAR";
            tabPageEditSearchUserID_AAR.Padding = new Padding(3);
            tabPageEditSearchUserID_AAR.Size = new Size(967, 31);
            tabPageEditSearchUserID_AAR.TabIndex = 1;
            tabPageEditSearchUserID_AAR.Text = "По номеру счёта";
            tabPageEditSearchUserID_AAR.UseVisualStyleBackColor = true;
            // 
            // buttonEditSearchUserID_AAR
            // 
            buttonEditSearchUserID_AAR.BackgroundImage = Properties.Resources.zoom;
            buttonEditSearchUserID_AAR.BackgroundImageLayout = ImageLayout.Zoom;
            buttonEditSearchUserID_AAR.Dock = DockStyle.Left;
            buttonEditSearchUserID_AAR.Location = new Point(198, 3);
            buttonEditSearchUserID_AAR.Name = "buttonEditSearchUserID_AAR";
            buttonEditSearchUserID_AAR.Size = new Size(25, 25);
            buttonEditSearchUserID_AAR.TabIndex = 4;
            buttonEditSearchUserID_AAR.UseVisualStyleBackColor = true;
            buttonEditSearchUserID_AAR.Click += buttonEditSearchUserID_AAR_Click;
            // 
            // textBoxEditSearchUserID_AAR
            // 
            textBoxEditSearchUserID_AAR.Dock = DockStyle.Left;
            textBoxEditSearchUserID_AAR.Location = new Point(3, 3);
            textBoxEditSearchUserID_AAR.Name = "textBoxEditSearchUserID_AAR";
            textBoxEditSearchUserID_AAR.PlaceholderText = "Поиск...";
            textBoxEditSearchUserID_AAR.Size = new Size(195, 23);
            textBoxEditSearchUserID_AAR.TabIndex = 1;
            // 
            // openFileDialogTask_AAR
            // 
            openFileDialogTask_AAR.FileName = "DataFile";
            // 
            // toolTipTask_AAR
            // 
            toolTipTask_AAR.ToolTipIcon = ToolTipIcon.Info;
            toolTipTask_AAR.ToolTipTitle = "Подсказка";
            // 
            // menuStrip_AAR
            // 
            menuStrip_AAR.Items.AddRange(new ToolStripItem[] { statsToolStripMenuItem_AAR, filterToolStripMenuItem_AAR, helpToolStripMenuItem });
            menuStrip_AAR.Location = new Point(0, 0);
            menuStrip_AAR.Name = "menuStrip_AAR";
            menuStrip_AAR.Size = new Size(1145, 24);
            menuStrip_AAR.TabIndex = 1;
            menuStrip_AAR.Text = "menuStrip1";
            // 
            // statsToolStripMenuItem_AAR
            // 
            statsToolStripMenuItem_AAR.Name = "statsToolStripMenuItem_AAR";
            statsToolStripMenuItem_AAR.Size = new Size(80, 20);
            statsToolStripMenuItem_AAR.Text = "Статистика";
            statsToolStripMenuItem_AAR.Click += statsToolStripMenuItem_AAR_Click;
            // 
            // filterToolStripMenuItem_AAR
            // 
            filterToolStripMenuItem_AAR.DropDownItems.AddRange(new ToolStripItem[] { DeletedRowsToolStripMenuItem_AAR, AddedRowsToolStripMenuItem_AAR });
            filterToolStripMenuItem_AAR.Enabled = false;
            filterToolStripMenuItem_AAR.Name = "filterToolStripMenuItem_AAR";
            filterToolStripMenuItem_AAR.Size = new Size(60, 20);
            filterToolStripMenuItem_AAR.Text = "Фильтр";
            // 
            // DeletedRowsToolStripMenuItem_AAR
            // 
            DeletedRowsToolStripMenuItem_AAR.Checked = true;
            DeletedRowsToolStripMenuItem_AAR.CheckOnClick = true;
            DeletedRowsToolStripMenuItem_AAR.CheckState = CheckState.Checked;
            DeletedRowsToolStripMenuItem_AAR.Name = "DeletedRowsToolStripMenuItem_AAR";
            DeletedRowsToolStripMenuItem_AAR.Size = new Size(191, 22);
            DeletedRowsToolStripMenuItem_AAR.Text = "Удаленные строки";
            DeletedRowsToolStripMenuItem_AAR.CheckedChanged += DeletedRowsToolStripMenuItem_AAR_CheckedChanged;
            // 
            // AddedRowsToolStripMenuItem_AAR
            // 
            AddedRowsToolStripMenuItem_AAR.Checked = true;
            AddedRowsToolStripMenuItem_AAR.CheckOnClick = true;
            AddedRowsToolStripMenuItem_AAR.CheckState = CheckState.Checked;
            AddedRowsToolStripMenuItem_AAR.Name = "AddedRowsToolStripMenuItem_AAR";
            AddedRowsToolStripMenuItem_AAR.Size = new Size(191, 22);
            AddedRowsToolStripMenuItem_AAR.Text = "Добавленные строки";
            AddedRowsToolStripMenuItem_AAR.CheckedChanged += AddedRowsToolStripMenuItem_AAR_CheckedChanged;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { guideToolStripMenuItem_AAR, infoToolStripMenuItem_AAR });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(68, 20);
            helpToolStripMenuItem.Text = "Помощь";
            // 
            // guideToolStripMenuItem_AAR
            // 
            guideToolStripMenuItem_AAR.Name = "guideToolStripMenuItem_AAR";
            guideToolStripMenuItem_AAR.Size = new Size(143, 22);
            guideToolStripMenuItem_AAR.Text = "Руководство";
            guideToolStripMenuItem_AAR.Click += guideToolStripMenuItem_AAR_Click;
            // 
            // infoToolStripMenuItem_AAR
            // 
            infoToolStripMenuItem_AAR.Name = "infoToolStripMenuItem_AAR";
            infoToolStripMenuItem_AAR.Size = new Size(143, 22);
            infoToolStripMenuItem_AAR.Text = "Справка";
            infoToolStripMenuItem_AAR.Click += infoToolStripMenuItem_AAR_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1145, 687);
            Controls.Add(panelFill_AAR);
            Controls.Add(panelLeft_AAR);
            Controls.Add(menuStrip_AAR);
            MainMenuStrip = menuStrip_AAR;
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(1161, 726);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Заказы";
            panelLeft_AAR.ResumeLayout(false);
            groupBoxRowsEdit_AAR.ResumeLayout(false);
            groupBoxRowsEdit_AAR.PerformLayout();
            groupBoxTable_AAR.ResumeLayout(false);
            panelFill_AAR.ResumeLayout(false);
            tabControlTable_AAR.ResumeLayout(false);
            tabPageReadOnly_AAR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewReadOnly_AAR).EndInit();
            tabControlReadOnlySearch_AAR.ResumeLayout(false);
            tabPageReadOnlySearchOrderID_AAR.ResumeLayout(false);
            tabPageReadOnlySearchOrderID_AAR.PerformLayout();
            tabPageReadOnlySearchUserID_AAR.ResumeLayout(false);
            tabPageReadOnlySearchUserID_AAR.PerformLayout();
            tabPageEdit_AAR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewEdit_AAR).EndInit();
            tabControlEditSearch_AAR.ResumeLayout(false);
            tabPageEditSearchOrderID_AAR.ResumeLayout(false);
            tabPageEditSearchOrderID_AAR.PerformLayout();
            tabPageEditSearchUserID_AAR.ResumeLayout(false);
            tabPageEditSearchUserID_AAR.PerformLayout();
            menuStrip_AAR.ResumeLayout(false);
            menuStrip_AAR.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelLeft_AAR;
        private Panel panelFill_AAR;
        private DataGridView dataGridViewReadOnly_AAR;
        private Button buttonOpenFile_AAR;
        private OpenFileDialog openFileDialogTask_AAR;
        private ToolTip toolTipTask_AAR;
        private SaveFileDialog saveFileDialogTask_AAR;
        private TabControl tabControlTable_AAR;
        private TabPage tabPageReadOnly_AAR;
        private TabPage tabPageEdit_AAR;
        private DataGridView dataGridViewEdit_AAR;
        private Button buttonSaveFile_AAR;
        private TabControl tabControlEditSearch_AAR;
        private TabPage tabPageEditSearchOrderID_AAR;
        private TabPage tabPageEditSearchUserID_AAR;
        private TabControl tabControlReadOnlySearch_AAR;
        private TabPage tabPageReadOnlySearchOrderID_AAR;
        private TabPage tabPageReadOnlySearchUserID_AAR;
        private TextBox textBoxReadOnlySearchOrderID_AAR;
        private Button buttonReadOnlySearchOrderID_AAR;
        private TextBox textBoxReadOnlySearchUserID_AAR;
        private TextBox textBoxEditSearchOrderID_AAR;
        private TextBox textBoxEditSearchUserID_AAR;
        private Button buttonReadOnlySearchUserID_AAR;
        private Button buttonEditSearchOrderID_AAR;
        private Button buttonEditSearchUserID_AAR;
        private MenuStrip menuStrip_AAR;
        private ToolStripMenuItem statsToolStripMenuItem_AAR;
        private ToolStripMenuItem filterToolStripMenuItem_AAR;
        private ToolStripMenuItem helpToolStripMenuItem;
        private GroupBox groupBoxRowsEdit_AAR;
        private GroupBox groupBoxTable_AAR;
        private Button buttonAddRow_AAR;
        private Button buttonDeleteMarkedRow_AAR;
        private Button buttonMarkDelete_AAR;
        private Button buttonUnmarkDelete_AAR;
        private ToolStripMenuItem DeletedRowsToolStripMenuItem_AAR;
        private ToolStripMenuItem AddedRowsToolStripMenuItem_AAR;
        private CheckBox checkBoxMarkRow_AAR;
        private ToolStripMenuItem guideToolStripMenuItem_AAR;
        private ToolStripMenuItem infoToolStripMenuItem_AAR;
        private DataGridViewTextBoxColumn OrderID;
        private DataGridViewTextBoxColumn UserID;
        private DataGridViewTextBoxColumn Adress;
        private DataGridViewTextBoxColumn OrderDate;
        private DataGridViewTextBoxColumn OrderValue;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn ProductCount;
        private DataGridViewTextBoxColumn ProductPrice;
        private DataGridViewTextBoxColumn OrderIDedit;
        private DataGridViewTextBoxColumn UserIDedit;
        private DataGridViewTextBoxColumn AdressEdit;
        private DataGridViewTextBoxColumn OrderDateEdit;
        private DataGridViewTextBoxColumn OrderValueEdit;
        private DataGridViewTextBoxColumn ProductNameEdit;
        private DataGridViewTextBoxColumn ProductCountEdit;
        private DataGridViewTextBoxColumn ProductPriceEdit;
    }
}
