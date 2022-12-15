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
            this.labelSelectYourHotel = new System.Windows.Forms.Label();
            this.dataGridViewHotels = new System.Windows.Forms.DataGridView();
            this.comboBoxStars = new System.Windows.Forms.ComboBox();
            this.labelSelectedHotel = new System.Windows.Forms.Label();
            this.textBoxSelectedHotel = new System.Windows.Forms.TextBox();
            this.tabPageAllTrips = new System.Windows.Forms.TabPage();
            this.labelSelectYourTrip = new System.Windows.Forms.Label();
            this.dataGridViewTrip = new System.Windows.Forms.DataGridView();
            this.radioButtonHotel = new System.Windows.Forms.RadioButton();
            this.radioButtonClear = new System.Windows.Forms.RadioButton();
            this.labelDates = new System.Windows.Forms.Label();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanelTrip = new System.Windows.Forms.TableLayoutPanel();
            this.btnShow = new System.Windows.Forms.Button();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.menuStrip.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageAllHotels.SuspendLayout();
            this.tableLayoutPanelHotels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHotels)).BeginInit();
            this.tabPageAllTrips.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrip)).BeginInit();
            this.tableLayoutPanelTrip.SuspendLayout();
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
            this.menuStrip.Size = new System.Drawing.Size(1365, 30);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // backToMainMenuToolStripMenuItem
            // 
            this.backToMainMenuToolStripMenuItem.Name = "backToMainMenuToolStripMenuItem";
            this.backToMainMenuToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.backToMainMenuToolStripMenuItem.Text = "Back to MainMenu";
            this.backToMainMenuToolStripMenuItem.Click += new System.EventHandler(this.backToMainMenuToolStripMenuItem_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageAllHotels);
            this.tabControl.Controls.Add(this.tabPageAllTrips);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl.Location = new System.Drawing.Point(0, 30);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1365, 800);
            this.tabControl.TabIndex = 1;
            // 
            // tabPageAllHotels
            // 
            this.tabPageAllHotels.Controls.Add(this.tableLayoutPanelHotels);
            this.tabPageAllHotels.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPageAllHotels.Location = new System.Drawing.Point(4, 29);
            this.tabPageAllHotels.Name = "tabPageAllHotels";
            this.tabPageAllHotels.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAllHotels.Size = new System.Drawing.Size(1357, 767);
            this.tabPageAllHotels.TabIndex = 0;
            this.tabPageAllHotels.Text = "Hotels";
            this.tabPageAllHotels.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelHotels
            // 
            this.tableLayoutPanelHotels.BackColor = System.Drawing.Color.LightCyan;
            this.tableLayoutPanelHotels.ColumnCount = 1;
            this.tableLayoutPanelHotels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelHotels.Controls.Add(this.labelSelectYourHotel, 0, 0);
            this.tableLayoutPanelHotels.Controls.Add(this.dataGridViewHotels, 0, 1);
            this.tableLayoutPanelHotels.Controls.Add(this.comboBoxStars, 0, 4);
            this.tableLayoutPanelHotels.Controls.Add(this.labelSelectedHotel, 0, 2);
            this.tableLayoutPanelHotels.Controls.Add(this.textBoxSelectedHotel, 0, 3);
            this.tableLayoutPanelHotels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelHotels.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelHotels.Name = "tableLayoutPanelHotels";
            this.tableLayoutPanelHotels.RowCount = 5;
            this.tableLayoutPanelHotels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelHotels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanelHotels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelHotels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelHotels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelHotels.Size = new System.Drawing.Size(1351, 761);
            this.tableLayoutPanelHotels.TabIndex = 0;
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
            this.dataGridViewHotels.Size = new System.Drawing.Size(1345, 564);
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
            this.comboBoxStars.Location = new System.Drawing.Point(3, 728);
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
            this.labelSelectedHotel.Location = new System.Drawing.Point(3, 608);
            this.labelSelectedHotel.Name = "labelSelectedHotel";
            this.labelSelectedHotel.Size = new System.Drawing.Size(1345, 38);
            this.labelSelectedHotel.TabIndex = 9;
            this.labelSelectedHotel.Text = "Selected hotel  : ";
            this.labelSelectedHotel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxSelectedHotel
            // 
            this.textBoxSelectedHotel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSelectedHotel.Location = new System.Drawing.Point(3, 649);
            this.textBoxSelectedHotel.Name = "textBoxSelectedHotel";
            this.textBoxSelectedHotel.Size = new System.Drawing.Size(1345, 27);
            this.textBoxSelectedHotel.TabIndex = 10;
            // 
            // tabPageAllTrips
            // 
            this.tabPageAllTrips.Controls.Add(this.tableLayoutPanelTrip);
            this.tabPageAllTrips.Location = new System.Drawing.Point(4, 29);
            this.tabPageAllTrips.Name = "tabPageAllTrips";
            this.tabPageAllTrips.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAllTrips.Size = new System.Drawing.Size(1357, 767);
            this.tabPageAllTrips.TabIndex = 1;
            this.tabPageAllTrips.Text = "Trips";
            this.tabPageAllTrips.UseVisualStyleBackColor = true;
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
            // dataGridViewTrip
            // 
            this.dataGridViewTrip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTrip.Location = new System.Drawing.Point(3, 41);
            this.dataGridViewTrip.Name = "dataGridViewTrip";
            this.dataGridViewTrip.ReadOnly = true;
            this.dataGridViewTrip.RowHeadersWidth = 51;
            this.dataGridViewTrip.RowTemplate.Height = 24;
            this.dataGridViewTrip.Size = new System.Drawing.Size(1345, 450);
            this.dataGridViewTrip.TabIndex = 1;
            this.dataGridViewTrip.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTrip_CellContentDoubleClick);
            // 
            // radioButtonHotel
            // 
            this.radioButtonHotel.AutoSize = true;
            this.radioButtonHotel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonHotel.Location = new System.Drawing.Point(3, 497);
            this.radioButtonHotel.Name = "radioButtonHotel";
            this.radioButtonHotel.Size = new System.Drawing.Size(1345, 32);
            this.radioButtonHotel.TabIndex = 2;
            this.radioButtonHotel.TabStop = true;
            this.radioButtonHotel.Text = "Find with selected Hotel";
            this.radioButtonHotel.UseVisualStyleBackColor = true;
            this.radioButtonHotel.CheckedChanged += new System.EventHandler(this.radioButtonHotel_CheckedChanged);
            // 
            // radioButtonClear
            // 
            this.radioButtonClear.AutoSize = true;
            this.radioButtonClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonClear.Location = new System.Drawing.Point(3, 535);
            this.radioButtonClear.Name = "radioButtonClear";
            this.radioButtonClear.Size = new System.Drawing.Size(1345, 32);
            this.radioButtonClear.TabIndex = 3;
            this.radioButtonClear.TabStop = true;
            this.radioButtonClear.Text = "Clear";
            this.radioButtonClear.UseVisualStyleBackColor = true;
            this.radioButtonClear.CheckedChanged += new System.EventHandler(this.radioButtonClear_CheckedChanged);
            // 
            // labelDates
            // 
            this.labelDates.AutoSize = true;
            this.labelDates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDates.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDates.Location = new System.Drawing.Point(3, 570);
            this.labelDates.Name = "labelDates";
            this.labelDates.Size = new System.Drawing.Size(1345, 38);
            this.labelDates.TabIndex = 4;
            this.labelDates.Text = "Выберите временной интервал поиска тура :\r\n";
            this.labelDates.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePickerStart.Location = new System.Drawing.Point(3, 611);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(1345, 27);
            this.dateTimePickerStart.TabIndex = 5;
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePickerEnd.Location = new System.Drawing.Point(3, 649);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(1345, 27);
            this.dateTimePickerEnd.TabIndex = 6;
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
            this.tableLayoutPanelTrip.Controls.Add(this.textBoxType, 0, 8);
            this.tableLayoutPanelTrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelTrip.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelTrip.Name = "tableLayoutPanelTrip";
            this.tableLayoutPanelTrip.RowCount = 9;
            this.tableLayoutPanelTrip.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelTrip.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanelTrip.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelTrip.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelTrip.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelTrip.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelTrip.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelTrip.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelTrip.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelTrip.Size = new System.Drawing.Size(1351, 761);
            this.tableLayoutPanelTrip.TabIndex = 7;
            // 
            // btnShow
            // 
            this.btnShow.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnShow.Location = new System.Drawing.Point(3, 687);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(304, 32);
            this.btnShow.TabIndex = 7;
            this.btnShow.Text = "Show with Dates";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // textBoxType
            // 
            this.textBoxType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxType.Location = new System.Drawing.Point(3, 725);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(1345, 28);
            this.textBoxType.TabIndex = 8;
            this.textBoxType.Text = "Type filter";
            this.textBoxType.TextChanged += new System.EventHandler(this.textBoxType_TextChanged);
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1365, 830);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrip)).EndInit();
            this.tableLayoutPanelTrip.ResumeLayout(false);
            this.tableLayoutPanelTrip.PerformLayout();
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
    }
}