namespace TravelAgency
{
    partial class ViewData
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewData));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.pageCity = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelCity = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewCity = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAddCity = new System.Windows.Forms.Button();
            this.pageCustomers = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelCustomer = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewCustomers = new System.Windows.Forms.DataGridView();
            this.btnRefreshCustomers = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.pageHotel = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelHotel = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewHotel = new System.Windows.Forms.DataGridView();
            this.btnRefreshHotel = new System.Windows.Forms.Button();
            this.btnAddHotel = new System.Windows.Forms.Button();
            this.pageTrip = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelTrip = new System.Windows.Forms.TableLayoutPanel();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnAddTrip = new System.Windows.Forms.Button();
            this.dataGridViewTrip = new System.Windows.Forms.DataGridView();
            this.tabPageSales = new System.Windows.Forms.TabPage();
            this.pageSelect = new System.Windows.Forms.TabPage();
            this.btnBackToMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.tabControl.SuspendLayout();
            this.pageCity.SuspendLayout();
            this.tableLayoutPanelCity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCity)).BeginInit();
            this.pageCustomers.SuspendLayout();
            this.tableLayoutPanelCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).BeginInit();
            this.pageHotel.SuspendLayout();
            this.tableLayoutPanelHotel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHotel)).BeginInit();
            this.pageTrip.SuspendLayout();
            this.tableLayoutPanelTrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrip)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.pageCity);
            this.tabControl.Controls.Add(this.pageCustomers);
            this.tabControl.Controls.Add(this.pageHotel);
            this.tabControl.Controls.Add(this.pageTrip);
            this.tabControl.Controls.Add(this.tabPageSales);
            this.tabControl.Controls.Add(this.pageSelect);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(0, 31);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1039, 475);
            this.tabControl.TabIndex = 0;
            // 
            // pageCity
            // 
            this.pageCity.Controls.Add(this.tableLayoutPanelCity);
            this.pageCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pageCity.Location = new System.Drawing.Point(4, 32);
            this.pageCity.Name = "pageCity";
            this.pageCity.Padding = new System.Windows.Forms.Padding(3);
            this.pageCity.Size = new System.Drawing.Size(1031, 439);
            this.pageCity.TabIndex = 0;
            this.pageCity.Text = "Города и страны";
            this.pageCity.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelCity
            // 
            this.tableLayoutPanelCity.ColumnCount = 1;
            this.tableLayoutPanelCity.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelCity.Controls.Add(this.dataGridViewCity, 0, 0);
            this.tableLayoutPanelCity.Controls.Add(this.btnRefresh, 0, 1);
            this.tableLayoutPanelCity.Controls.Add(this.btnAddCity, 0, 2);
            this.tableLayoutPanelCity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelCity.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelCity.Name = "tableLayoutPanelCity";
            this.tableLayoutPanelCity.RowCount = 3;
            this.tableLayoutPanelCity.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanelCity.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanelCity.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanelCity.Size = new System.Drawing.Size(1025, 433);
            this.tableLayoutPanelCity.TabIndex = 1;
            // 
            // dataGridViewCity
            // 
            this.dataGridViewCity.BackgroundColor = System.Drawing.Color.SlateGray;
            this.dataGridViewCity.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCity.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCity.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewCity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCity.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridViewCity.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewCity.Name = "dataGridViewCity";
            this.dataGridViewCity.ReadOnly = true;
            this.dataGridViewCity.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewCity.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewCity.RowTemplate.Height = 24;
            this.dataGridViewCity.Size = new System.Drawing.Size(1019, 297);
            this.dataGridViewCity.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRefresh.Location = new System.Drawing.Point(863, 306);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(159, 58);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Show Data";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAddCity
            // 
            this.btnAddCity.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAddCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btnAddCity.Location = new System.Drawing.Point(863, 370);
            this.btnAddCity.Name = "btnAddCity";
            this.btnAddCity.Size = new System.Drawing.Size(159, 60);
            this.btnAddCity.TabIndex = 2;
            this.btnAddCity.Text = "Add City";
            this.btnAddCity.UseVisualStyleBackColor = true;
            this.btnAddCity.Click += new System.EventHandler(this.btnAddCity_Click);
            // 
            // pageCustomers
            // 
            this.pageCustomers.Controls.Add(this.tableLayoutPanelCustomer);
            this.pageCustomers.Location = new System.Drawing.Point(4, 32);
            this.pageCustomers.Name = "pageCustomers";
            this.pageCustomers.Size = new System.Drawing.Size(1031, 439);
            this.pageCustomers.TabIndex = 2;
            this.pageCustomers.Text = "Покупатели";
            this.pageCustomers.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelCustomer
            // 
            this.tableLayoutPanelCustomer.ColumnCount = 1;
            this.tableLayoutPanelCustomer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelCustomer.Controls.Add(this.dataGridViewCustomers, 0, 0);
            this.tableLayoutPanelCustomer.Controls.Add(this.btnRefreshCustomers, 0, 1);
            this.tableLayoutPanelCustomer.Controls.Add(this.btnAddCustomer, 0, 2);
            this.tableLayoutPanelCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelCustomer.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelCustomer.Name = "tableLayoutPanelCustomer";
            this.tableLayoutPanelCustomer.RowCount = 3;
            this.tableLayoutPanelCustomer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanelCustomer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanelCustomer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanelCustomer.Size = new System.Drawing.Size(1031, 439);
            this.tableLayoutPanelCustomer.TabIndex = 2;
            // 
            // dataGridViewCustomers
            // 
            this.dataGridViewCustomers.BackgroundColor = System.Drawing.Color.SlateGray;
            this.dataGridViewCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCustomers.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCustomers.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewCustomers.Name = "dataGridViewCustomers";
            this.dataGridViewCustomers.ReadOnly = true;
            this.dataGridViewCustomers.RowHeadersWidth = 51;
            this.dataGridViewCustomers.RowTemplate.Height = 24;
            this.dataGridViewCustomers.Size = new System.Drawing.Size(1025, 301);
            this.dataGridViewCustomers.TabIndex = 1;
            // 
            // btnRefreshCustomers
            // 
            this.btnRefreshCustomers.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRefreshCustomers.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshCustomers.Location = new System.Drawing.Point(875, 310);
            this.btnRefreshCustomers.Name = "btnRefreshCustomers";
            this.btnRefreshCustomers.Size = new System.Drawing.Size(153, 59);
            this.btnRefreshCustomers.TabIndex = 0;
            this.btnRefreshCustomers.Text = "Show Data";
            this.btnRefreshCustomers.UseVisualStyleBackColor = true;
            this.btnRefreshCustomers.Click += new System.EventHandler(this.btnRefreshCustomers_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAddCustomer.Location = new System.Drawing.Point(875, 375);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(153, 61);
            this.btnAddCustomer.TabIndex = 2;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // pageHotel
            // 
            this.pageHotel.Controls.Add(this.tableLayoutPanelHotel);
            this.pageHotel.Location = new System.Drawing.Point(4, 32);
            this.pageHotel.Name = "pageHotel";
            this.pageHotel.Size = new System.Drawing.Size(1031, 439);
            this.pageHotel.TabIndex = 3;
            this.pageHotel.Text = "Отели";
            this.pageHotel.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelHotel
            // 
            this.tableLayoutPanelHotel.ColumnCount = 1;
            this.tableLayoutPanelHotel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelHotel.Controls.Add(this.dataGridViewHotel, 0, 0);
            this.tableLayoutPanelHotel.Controls.Add(this.btnRefreshHotel, 0, 1);
            this.tableLayoutPanelHotel.Controls.Add(this.btnAddHotel, 0, 2);
            this.tableLayoutPanelHotel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelHotel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelHotel.Name = "tableLayoutPanelHotel";
            this.tableLayoutPanelHotel.RowCount = 3;
            this.tableLayoutPanelHotel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanelHotel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanelHotel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanelHotel.Size = new System.Drawing.Size(1031, 439);
            this.tableLayoutPanelHotel.TabIndex = 2;
            // 
            // dataGridViewHotel
            // 
            this.dataGridViewHotel.BackgroundColor = System.Drawing.Color.SlateGray;
            this.dataGridViewHotel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewHotel.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewHotel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewHotel.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewHotel.Name = "dataGridViewHotel";
            this.dataGridViewHotel.ReadOnly = true;
            this.dataGridViewHotel.RowHeadersWidth = 51;
            this.dataGridViewHotel.RowTemplate.Height = 24;
            this.dataGridViewHotel.Size = new System.Drawing.Size(1025, 301);
            this.dataGridViewHotel.TabIndex = 0;
            // 
            // btnRefreshHotel
            // 
            this.btnRefreshHotel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRefreshHotel.Location = new System.Drawing.Point(887, 310);
            this.btnRefreshHotel.Name = "btnRefreshHotel";
            this.btnRefreshHotel.Size = new System.Drawing.Size(141, 59);
            this.btnRefreshHotel.TabIndex = 1;
            this.btnRefreshHotel.Text = "Show Data";
            this.btnRefreshHotel.UseVisualStyleBackColor = true;
            this.btnRefreshHotel.Click += new System.EventHandler(this.btnRefreshHotel_Click);
            // 
            // btnAddHotel
            // 
            this.btnAddHotel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAddHotel.Location = new System.Drawing.Point(887, 375);
            this.btnAddHotel.Name = "btnAddHotel";
            this.btnAddHotel.Size = new System.Drawing.Size(141, 61);
            this.btnAddHotel.TabIndex = 2;
            this.btnAddHotel.Text = "Add Hotel";
            this.btnAddHotel.UseVisualStyleBackColor = true;
            this.btnAddHotel.Click += new System.EventHandler(this.btnAddHotel_Click);
            // 
            // pageTrip
            // 
            this.pageTrip.Controls.Add(this.tableLayoutPanelTrip);
            this.pageTrip.Location = new System.Drawing.Point(4, 32);
            this.pageTrip.Name = "pageTrip";
            this.pageTrip.Size = new System.Drawing.Size(1031, 439);
            this.pageTrip.TabIndex = 6;
            this.pageTrip.Text = "Туры";
            this.pageTrip.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelTrip
            // 
            this.tableLayoutPanelTrip.ColumnCount = 1;
            this.tableLayoutPanelTrip.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelTrip.Controls.Add(this.btnShow, 0, 1);
            this.tableLayoutPanelTrip.Controls.Add(this.btnAddTrip, 0, 2);
            this.tableLayoutPanelTrip.Controls.Add(this.dataGridViewTrip, 0, 0);
            this.tableLayoutPanelTrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelTrip.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelTrip.Name = "tableLayoutPanelTrip";
            this.tableLayoutPanelTrip.RowCount = 3;
            this.tableLayoutPanelTrip.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanelTrip.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanelTrip.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanelTrip.Size = new System.Drawing.Size(1031, 439);
            this.tableLayoutPanelTrip.TabIndex = 0;
            // 
            // btnShow
            // 
            this.btnShow.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnShow.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(879, 310);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(149, 59);
            this.btnShow.TabIndex = 0;
            this.btnShow.Text = "Show Data";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnAddTrip
            // 
            this.btnAddTrip.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAddTrip.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTrip.Location = new System.Drawing.Point(879, 375);
            this.btnAddTrip.Name = "btnAddTrip";
            this.btnAddTrip.Size = new System.Drawing.Size(149, 61);
            this.btnAddTrip.TabIndex = 1;
            this.btnAddTrip.Text = "Add Trip";
            this.btnAddTrip.UseVisualStyleBackColor = true;
            this.btnAddTrip.Click += new System.EventHandler(this.btnAddTrip_Click);
            // 
            // dataGridViewTrip
            // 
            this.dataGridViewTrip.BackgroundColor = System.Drawing.Color.SlateGray;
            this.dataGridViewTrip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTrip.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewTrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTrip.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewTrip.Name = "dataGridViewTrip";
            this.dataGridViewTrip.ReadOnly = true;
            this.dataGridViewTrip.RowHeadersWidth = 51;
            this.dataGridViewTrip.RowTemplate.Height = 24;
            this.dataGridViewTrip.Size = new System.Drawing.Size(1025, 301);
            this.dataGridViewTrip.TabIndex = 2;
            // 
            // tabPageSales
            // 
            this.tabPageSales.Location = new System.Drawing.Point(4, 32);
            this.tabPageSales.Name = "tabPageSales";
            this.tabPageSales.Size = new System.Drawing.Size(1031, 439);
            this.tabPageSales.TabIndex = 7;
            this.tabPageSales.Text = "Продажи";
            this.tabPageSales.UseVisualStyleBackColor = true;
            // 
            // pageSelect
            // 
            this.pageSelect.Location = new System.Drawing.Point(4, 32);
            this.pageSelect.Name = "pageSelect";
            this.pageSelect.Size = new System.Drawing.Size(1031, 439);
            this.pageSelect.TabIndex = 5;
            this.pageSelect.Text = "SELECT";
            this.pageSelect.UseVisualStyleBackColor = true;
            // 
            // btnBackToMenu
            // 
            this.btnBackToMenu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBackToMenu.Name = "btnBackToMenu";
            this.btnBackToMenu.Size = new System.Drawing.Size(129, 27);
            this.btnBackToMenu.Text = "Back to menu";
            this.btnBackToMenu.Click += new System.EventHandler(this.btnBackToMenu_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.Wheat;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBackToMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1039, 31);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip";
            // 
            // ViewData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1039, 506);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "ViewData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewData";
            this.tabControl.ResumeLayout(false);
            this.pageCity.ResumeLayout(false);
            this.tableLayoutPanelCity.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCity)).EndInit();
            this.pageCustomers.ResumeLayout(false);
            this.tableLayoutPanelCustomer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).EndInit();
            this.pageHotel.ResumeLayout(false);
            this.tableLayoutPanelHotel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHotel)).EndInit();
            this.pageTrip.ResumeLayout(false);
            this.tableLayoutPanelTrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrip)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage pageCity;
        private System.Windows.Forms.TabPage pageCustomers;
        private System.Windows.Forms.TabPage pageHotel;
        private System.Windows.Forms.TabPage pageSelect;
        private System.Windows.Forms.ToolStripMenuItem btnBackToMenu;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnRefreshCustomers;
        private System.Windows.Forms.DataGridView dataGridViewCustomers;
        private System.Windows.Forms.DataGridView dataGridViewHotel;
        private System.Windows.Forms.Button btnRefreshHotel;
        private System.Windows.Forms.TabPage pageTrip;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCity;
        private System.Windows.Forms.DataGridView dataGridViewCity;
        private System.Windows.Forms.Button btnAddCity;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTrip;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnAddTrip;
        private System.Windows.Forms.DataGridView dataGridViewTrip;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelHotel;
        private System.Windows.Forms.Button btnAddHotel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCustomer;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.TabPage tabPageSales;
    }
}