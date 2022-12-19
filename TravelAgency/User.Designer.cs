namespace TravelAgency
{
    partial class User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.backToMainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageAllHotels = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelHotels = new System.Windows.Forms.TableLayoutPanel();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelSelectYourHotel = new System.Windows.Forms.Label();
            this.dataGridViewHotels = new System.Windows.Forms.DataGridView();
            this.comboBoxStars = new System.Windows.Forms.ComboBox();
            this.labelSelectedHotel = new System.Windows.Forms.Label();
            this.textBoxSelectedHotel = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.tabPageAllTrips = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelTrip = new System.Windows.Forms.TableLayoutPanel();
            this.labelSelectYourTrip = new System.Windows.Forms.Label();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewTrip = new System.Windows.Forms.DataGridView();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.radioButtonHotel = new System.Windows.Forms.RadioButton();
            this.labelDates = new System.Windows.Forms.Label();
            this.radioButtonClear = new System.Windows.Forms.RadioButton();
            this.btnShow = new System.Windows.Forms.Button();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.labelType = new System.Windows.Forms.Label();
            this.tabPageBook = new System.Windows.Forms.TabPage();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnBookTrip = new System.Windows.Forms.Button();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxPatronymic = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelPatronymic = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.richTextBoxTripInfo = new System.Windows.Forms.RichTextBox();
            this.btnShowSelected = new System.Windows.Forms.Button();
            this.labelTrip = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageAllHotels.SuspendLayout();
            this.tableLayoutPanelHotels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHotels)).BeginInit();
            this.tabPageAllTrips.SuspendLayout();
            this.tableLayoutPanelTrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrip)).BeginInit();
            this.tabPageBook.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.LemonChiffon;
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToMainMenuToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1365, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // backToMainMenuToolStripMenuItem
            // 
            this.backToMainMenuToolStripMenuItem.Name = "backToMainMenuToolStripMenuItem";
            this.backToMainMenuToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.backToMainMenuToolStripMenuItem.Text = "Back to MainMenu";
            this.backToMainMenuToolStripMenuItem.Click += new System.EventHandler(this.backToMainMenuToolStripMenuItem_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageAllHotels);
            this.tabControl.Controls.Add(this.tabPageAllTrips);
            this.tabControl.Controls.Add(this.tabPageBook);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl.Location = new System.Drawing.Point(0, 28);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1365, 802);
            this.tabControl.TabIndex = 1;
            // 
            // tabPageAllHotels
            // 
            this.tabPageAllHotels.Controls.Add(this.tableLayoutPanelHotels);
            this.tabPageAllHotels.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPageAllHotels.Location = new System.Drawing.Point(4, 29);
            this.tabPageAllHotels.Name = "tabPageAllHotels";
            this.tabPageAllHotels.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAllHotels.Size = new System.Drawing.Size(1357, 769);
            this.tabPageAllHotels.TabIndex = 0;
            this.tabPageAllHotels.Text = "Hotels";
            this.tabPageAllHotels.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelHotels
            // 
            this.tableLayoutPanelHotels.BackColor = System.Drawing.Color.LightCyan;
            this.tableLayoutPanelHotels.ColumnCount = 1;
            this.tableLayoutPanelHotels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelHotels.Controls.Add(this.labelCity, 0, 5);
            this.tableLayoutPanelHotels.Controls.Add(this.labelSelectYourHotel, 0, 0);
            this.tableLayoutPanelHotels.Controls.Add(this.dataGridViewHotels, 0, 1);
            this.tableLayoutPanelHotels.Controls.Add(this.comboBoxStars, 0, 4);
            this.tableLayoutPanelHotels.Controls.Add(this.labelSelectedHotel, 0, 2);
            this.tableLayoutPanelHotels.Controls.Add(this.textBoxSelectedHotel, 0, 3);
            this.tableLayoutPanelHotels.Controls.Add(this.textBoxCity, 0, 6);
            this.tableLayoutPanelHotels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelHotels.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelHotels.Name = "tableLayoutPanelHotels";
            this.tableLayoutPanelHotels.RowCount = 7;
            this.tableLayoutPanelHotels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelHotels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanelHotels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelHotels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelHotels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelHotels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelHotels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelHotels.Size = new System.Drawing.Size(1351, 763);
            this.tableLayoutPanelHotels.TabIndex = 0;
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCity.Location = new System.Drawing.Point(3, 685);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(1345, 38);
            this.labelCity.TabIndex = 1;
            this.labelCity.Text = "Enter City :";
            this.labelCity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSelectYourHotel
            // 
            this.labelSelectYourHotel.AutoSize = true;
            this.labelSelectYourHotel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSelectYourHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSelectYourHotel.Location = new System.Drawing.Point(3, 0);
            this.labelSelectYourHotel.Name = "labelSelectYourHotel";
            this.labelSelectYourHotel.Size = new System.Drawing.Size(1345, 38);
            this.labelSelectYourHotel.TabIndex = 0;
            this.labelSelectYourHotel.Text = "Выберите нужный вам отель";
            this.labelSelectYourHotel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewHotels
            // 
            this.dataGridViewHotels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHotels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewHotels.Location = new System.Drawing.Point(3, 41);
            this.dataGridViewHotels.Name = "dataGridViewHotels";
            this.dataGridViewHotels.ReadOnly = true;
            this.dataGridViewHotels.RowHeadersWidth = 51;
            this.dataGridViewHotels.RowTemplate.Height = 24;
            this.dataGridViewHotels.Size = new System.Drawing.Size(1345, 489);
            this.dataGridViewHotels.TabIndex = 1;
            this.dataGridViewHotels.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHotels_CellContentDoubleClick);
            // 
            // comboBoxStars
            // 
            this.comboBoxStars.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.comboBoxStars.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxStars.FormattingEnabled = true;
            this.comboBoxStars.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "All"});
            this.comboBoxStars.Location = new System.Drawing.Point(3, 652);
            this.comboBoxStars.Name = "comboBoxStars";
            this.comboBoxStars.Size = new System.Drawing.Size(1345, 30);
            this.comboBoxStars.TabIndex = 8;
            this.comboBoxStars.Text = "Звезды";
            this.comboBoxStars.SelectedIndexChanged += new System.EventHandler(this.comboBoxStars_SelectedIndexChanged);
            // 
            // labelSelectedHotel
            // 
            this.labelSelectedHotel.AutoSize = true;
            this.labelSelectedHotel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSelectedHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSelectedHotel.Location = new System.Drawing.Point(3, 533);
            this.labelSelectedHotel.Name = "labelSelectedHotel";
            this.labelSelectedHotel.Size = new System.Drawing.Size(1345, 38);
            this.labelSelectedHotel.TabIndex = 9;
            this.labelSelectedHotel.Text = "Selected hotel  : ";
            this.labelSelectedHotel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxSelectedHotel
            // 
            this.textBoxSelectedHotel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSelectedHotel.Location = new System.Drawing.Point(3, 574);
            this.textBoxSelectedHotel.Name = "textBoxSelectedHotel";
            this.textBoxSelectedHotel.ReadOnly = true;
            this.textBoxSelectedHotel.Size = new System.Drawing.Size(1345, 27);
            this.textBoxSelectedHotel.TabIndex = 10;
            // 
            // textBoxCity
            // 
            this.textBoxCity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCity.Location = new System.Drawing.Point(3, 726);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(1345, 27);
            this.textBoxCity.TabIndex = 11;
            this.textBoxCity.TextChanged += new System.EventHandler(this.textBoxCity_TextChanged);
            // 
            // tabPageAllTrips
            // 
            this.tabPageAllTrips.Controls.Add(this.tableLayoutPanelTrip);
            this.tabPageAllTrips.Location = new System.Drawing.Point(4, 29);
            this.tabPageAllTrips.Name = "tabPageAllTrips";
            this.tabPageAllTrips.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAllTrips.Size = new System.Drawing.Size(1357, 769);
            this.tabPageAllTrips.TabIndex = 1;
            this.tabPageAllTrips.Text = "Trips";
            this.tabPageAllTrips.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelTrip
            // 
            this.tableLayoutPanelTrip.BackColor = System.Drawing.Color.LightCyan;
            this.tableLayoutPanelTrip.ColumnCount = 1;
            this.tableLayoutPanelTrip.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelTrip.Controls.Add(this.labelSelectYourTrip, 0, 0);
            this.tableLayoutPanelTrip.Controls.Add(this.dateTimePickerEnd, 0, 6);
            this.tableLayoutPanelTrip.Controls.Add(this.dataGridViewTrip, 0, 1);
            this.tableLayoutPanelTrip.Controls.Add(this.dateTimePickerStart, 0, 5);
            this.tableLayoutPanelTrip.Controls.Add(this.radioButtonHotel, 0, 2);
            this.tableLayoutPanelTrip.Controls.Add(this.labelDates, 0, 4);
            this.tableLayoutPanelTrip.Controls.Add(this.radioButtonClear, 0, 3);
            this.tableLayoutPanelTrip.Controls.Add(this.btnShow, 0, 7);
            this.tableLayoutPanelTrip.Controls.Add(this.textBoxType, 0, 9);
            this.tableLayoutPanelTrip.Controls.Add(this.labelType, 0, 8);
            this.tableLayoutPanelTrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelTrip.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelTrip.Name = "tableLayoutPanelTrip";
            this.tableLayoutPanelTrip.RowCount = 10;
            this.tableLayoutPanelTrip.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelTrip.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanelTrip.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelTrip.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelTrip.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelTrip.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelTrip.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelTrip.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelTrip.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelTrip.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelTrip.Size = new System.Drawing.Size(1351, 763);
            this.tableLayoutPanelTrip.TabIndex = 7;
            // 
            // labelSelectYourTrip
            // 
            this.labelSelectYourTrip.AutoSize = true;
            this.labelSelectYourTrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSelectYourTrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSelectYourTrip.Location = new System.Drawing.Point(3, 0);
            this.labelSelectYourTrip.Name = "labelSelectYourTrip";
            this.labelSelectYourTrip.Size = new System.Drawing.Size(1345, 38);
            this.labelSelectYourTrip.TabIndex = 0;
            this.labelSelectYourTrip.Text = "Выберите нужный вам тур";
            this.labelSelectYourTrip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePickerEnd.Location = new System.Drawing.Point(3, 612);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(1345, 27);
            this.dateTimePickerEnd.TabIndex = 6;
            // 
            // dataGridViewTrip
            // 
            this.dataGridViewTrip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTrip.Location = new System.Drawing.Point(3, 41);
            this.dataGridViewTrip.Name = "dataGridViewTrip";
            this.dataGridViewTrip.ReadOnly = true;
            this.dataGridViewTrip.RowHeadersWidth = 51;
            this.dataGridViewTrip.RowTemplate.Height = 24;
            this.dataGridViewTrip.Size = new System.Drawing.Size(1345, 413);
            this.dataGridViewTrip.TabIndex = 1;
            this.dataGridViewTrip.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTrip_CellContentDoubleClick);
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePickerStart.Location = new System.Drawing.Point(3, 574);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(1345, 27);
            this.dateTimePickerStart.TabIndex = 5;
            // 
            // radioButtonHotel
            // 
            this.radioButtonHotel.AutoSize = true;
            this.radioButtonHotel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonHotel.Location = new System.Drawing.Point(3, 460);
            this.radioButtonHotel.Name = "radioButtonHotel";
            this.radioButtonHotel.Size = new System.Drawing.Size(1345, 32);
            this.radioButtonHotel.TabIndex = 2;
            this.radioButtonHotel.TabStop = true;
            this.radioButtonHotel.Text = "Find with selected Hotel";
            this.radioButtonHotel.UseVisualStyleBackColor = true;
            this.radioButtonHotel.CheckedChanged += new System.EventHandler(this.radioButtonHotel_CheckedChanged);
            // 
            // labelDates
            // 
            this.labelDates.AutoSize = true;
            this.labelDates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDates.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDates.Location = new System.Drawing.Point(3, 533);
            this.labelDates.Name = "labelDates";
            this.labelDates.Size = new System.Drawing.Size(1345, 38);
            this.labelDates.TabIndex = 4;
            this.labelDates.Text = "Выберите временной интервал поиска тура :\r\n";
            this.labelDates.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioButtonClear
            // 
            this.radioButtonClear.AutoSize = true;
            this.radioButtonClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonClear.Location = new System.Drawing.Point(3, 498);
            this.radioButtonClear.Name = "radioButtonClear";
            this.radioButtonClear.Size = new System.Drawing.Size(1345, 32);
            this.radioButtonClear.TabIndex = 3;
            this.radioButtonClear.TabStop = true;
            this.radioButtonClear.Text = "Clear";
            this.radioButtonClear.UseVisualStyleBackColor = true;
            this.radioButtonClear.CheckedChanged += new System.EventHandler(this.radioButtonClear_CheckedChanged);
            // 
            // btnShow
            // 
            this.btnShow.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnShow.Location = new System.Drawing.Point(3, 650);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(304, 32);
            this.btnShow.TabIndex = 7;
            this.btnShow.Text = "Show with Dates";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // textBoxType
            // 
            this.textBoxType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxType.Location = new System.Drawing.Point(3, 726);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(1345, 28);
            this.textBoxType.TabIndex = 8;
            this.textBoxType.TextChanged += new System.EventHandler(this.textBoxType_TextChanged);
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelType.Location = new System.Drawing.Point(3, 685);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(1345, 38);
            this.labelType.TabIndex = 9;
            this.labelType.Text = "Enter type :";
            this.labelType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPageBook
            // 
            this.tabPageBook.Controls.Add(this.btnAddCustomer);
            this.tabPageBook.Controls.Add(this.btnBookTrip);
            this.tabPageBook.Controls.Add(this.lblCustomer);
            this.tabPageBook.Controls.Add(this.dateTimePicker);
            this.tabPageBook.Controls.Add(this.textBoxPhone);
            this.tabPageBook.Controls.Add(this.textBoxPatronymic);
            this.tabPageBook.Controls.Add(this.textBoxSurname);
            this.tabPageBook.Controls.Add(this.textBoxName);
            this.tabPageBook.Controls.Add(this.labelPhone);
            this.tabPageBook.Controls.Add(this.labelDate);
            this.tabPageBook.Controls.Add(this.labelPatronymic);
            this.tabPageBook.Controls.Add(this.labelSurname);
            this.tabPageBook.Controls.Add(this.labelName);
            this.tabPageBook.Controls.Add(this.richTextBoxTripInfo);
            this.tabPageBook.Controls.Add(this.btnShowSelected);
            this.tabPageBook.Controls.Add(this.labelTrip);
            this.tabPageBook.Location = new System.Drawing.Point(4, 29);
            this.tabPageBook.Name = "tabPageBook";
            this.tabPageBook.Size = new System.Drawing.Size(1357, 769);
            this.tabPageBook.TabIndex = 2;
            this.tabPageBook.Text = "Book trip";
            this.tabPageBook.UseVisualStyleBackColor = true;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(924, 277);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(318, 44);
            this.btnAddCustomer.TabIndex = 27;
            this.btnAddCustomer.Text = "Save my data";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnBookTrip
            // 
            this.btnBookTrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBookTrip.Location = new System.Drawing.Point(8, 673);
            this.btnBookTrip.Name = "btnBookTrip";
            this.btnBookTrip.Size = new System.Drawing.Size(1341, 88);
            this.btnBookTrip.TabIndex = 26;
            this.btnBookTrip.Text = "Book";
            this.btnBookTrip.UseVisualStyleBackColor = true;
            this.btnBookTrip.Click += new System.EventHandler(this.btnBookTrip_Click);
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCustomer.Location = new System.Drawing.Point(1034, 15);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(170, 25);
            this.lblCustomer.TabIndex = 25;
            this.lblCustomer.Text = "Input your details :";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker.Location = new System.Drawing.Point(1038, 172);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(204, 27);
            this.dateTimePicker.TabIndex = 24;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPhone.Location = new System.Drawing.Point(1038, 205);
            this.textBoxPhone.MaxLength = 10;
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(204, 27);
            this.textBoxPhone.TabIndex = 23;
            // 
            // textBoxPatronymic
            // 
            this.textBoxPatronymic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPatronymic.Location = new System.Drawing.Point(1038, 139);
            this.textBoxPatronymic.Name = "textBoxPatronymic";
            this.textBoxPatronymic.Size = new System.Drawing.Size(204, 27);
            this.textBoxPatronymic.TabIndex = 22;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSurname.Location = new System.Drawing.Point(1038, 107);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(204, 27);
            this.textBoxSurname.TabIndex = 21;
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.Location = new System.Drawing.Point(1038, 71);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(204, 27);
            this.textBoxName.TabIndex = 20;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPhone.Location = new System.Drawing.Point(920, 205);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(66, 20);
            this.labelPhone.TabIndex = 19;
            this.labelPhone.Text = "Phone :";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDate.Location = new System.Drawing.Point(920, 174);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(112, 20);
            this.labelDate.TabIndex = 18;
            this.labelDate.Text = "Date of birth :";
            // 
            // labelPatronymic
            // 
            this.labelPatronymic.AutoSize = true;
            this.labelPatronymic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPatronymic.Location = new System.Drawing.Point(920, 142);
            this.labelPatronymic.Name = "labelPatronymic";
            this.labelPatronymic.Size = new System.Drawing.Size(103, 20);
            this.labelPatronymic.TabIndex = 17;
            this.labelPatronymic.Text = "Patronymic :";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSurname.Location = new System.Drawing.Point(920, 107);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(86, 20);
            this.labelSurname.TabIndex = 16;
            this.labelSurname.Text = "Surname :";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(920, 73);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(63, 20);
            this.labelName.TabIndex = 15;
            this.labelName.Text = "Name :";
            // 
            // richTextBoxTripInfo
            // 
            this.richTextBoxTripInfo.Location = new System.Drawing.Point(8, 47);
            this.richTextBoxTripInfo.Name = "richTextBoxTripInfo";
            this.richTextBoxTripInfo.ReadOnly = true;
            this.richTextBoxTripInfo.Size = new System.Drawing.Size(497, 313);
            this.richTextBoxTripInfo.TabIndex = 3;
            this.richTextBoxTripInfo.Text = "";
            // 
            // btnShowSelected
            // 
            this.btnShowSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShowSelected.Location = new System.Drawing.Point(8, 366);
            this.btnShowSelected.Name = "btnShowSelected";
            this.btnShowSelected.Size = new System.Drawing.Size(497, 62);
            this.btnShowSelected.TabIndex = 2;
            this.btnShowSelected.Text = "Show selected Trip";
            this.btnShowSelected.UseVisualStyleBackColor = true;
            this.btnShowSelected.Click += new System.EventHandler(this.btnShowSelected_Click);
            // 
            // labelTrip
            // 
            this.labelTrip.AutoSize = true;
            this.labelTrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTrip.Location = new System.Drawing.Point(180, 15);
            this.labelTrip.Name = "labelTrip";
            this.labelTrip.Size = new System.Drawing.Size(131, 25);
            this.labelTrip.TabIndex = 0;
            this.labelTrip.Text = "Selected trip :";
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1365, 830);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User";
            this.Load += new System.EventHandler(this.User_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPageAllHotels.ResumeLayout(false);
            this.tableLayoutPanelHotels.ResumeLayout(false);
            this.tableLayoutPanelHotels.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHotels)).EndInit();
            this.tabPageAllTrips.ResumeLayout(false);
            this.tableLayoutPanelTrip.ResumeLayout(false);
            this.tableLayoutPanelTrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrip)).EndInit();
            this.tabPageBook.ResumeLayout(false);
            this.tabPageBook.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem backToMainMenuToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageAllHotels;
        private System.Windows.Forms.TabPage tabPageAllTrips;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelHotels;
        private System.Windows.Forms.Label labelSelectYourHotel;
        private System.Windows.Forms.DataGridView dataGridViewHotels;
        private System.Windows.Forms.ComboBox comboBoxStars;
        private System.Windows.Forms.Label labelSelectedHotel;
        private System.Windows.Forms.TextBox textBoxSelectedHotel;
        private System.Windows.Forms.Label labelSelectYourTrip;
        private System.Windows.Forms.DataGridView dataGridViewTrip;
        private System.Windows.Forms.RadioButton radioButtonHotel;
        private System.Windows.Forms.RadioButton radioButtonClear;
        private System.Windows.Forms.Label labelDates;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTrip;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.TabPage tabPageBook;
        private System.Windows.Forms.Label labelTrip;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.RichTextBox richTextBoxTripInfo;
        private System.Windows.Forms.Button btnShowSelected;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnBookTrip;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxPatronymic;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelPatronymic;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelName;
    }
}