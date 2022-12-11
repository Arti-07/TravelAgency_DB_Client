namespace TravelAgency
{
    partial class AddTrip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTrip));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.labelTripAdd = new System.Windows.Forms.Label();
            this.textBoxTripID = new System.Windows.Forms.TextBox();
            this.lblTripID = new System.Windows.Forms.Label();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.textBoxHotelID = new System.Windows.Forms.TextBox();
            this.lblHotelID = new System.Windows.Forms.Label();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.btnAddTrip = new System.Windows.Forms.Button();
            this.btnShowTrips = new System.Windows.Forms.Button();
            this.btnShowHotels = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(437, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(974, 385);
            this.dataGridView.TabIndex = 0;
            // 
            // labelTripAdd
            // 
            this.labelTripAdd.AutoSize = true;
            this.labelTripAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTripAdd.Location = new System.Drawing.Point(139, 12);
            this.labelTripAdd.Name = "labelTripAdd";
            this.labelTripAdd.Size = new System.Drawing.Size(106, 29);
            this.labelTripAdd.TabIndex = 8;
            this.labelTripAdd.Text = "Add Trip";
            // 
            // textBoxTripID
            // 
            this.textBoxTripID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTripID.Location = new System.Drawing.Point(144, 82);
            this.textBoxTripID.Name = "textBoxTripID";
            this.textBoxTripID.Size = new System.Drawing.Size(200, 27);
            this.textBoxTripID.TabIndex = 17;
            // 
            // lblTripID
            // 
            this.lblTripID.AutoSize = true;
            this.lblTripID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTripID.Location = new System.Drawing.Point(19, 85);
            this.lblTripID.Name = "lblTripID";
            this.lblTripID.Size = new System.Drawing.Size(70, 20);
            this.lblTripID.TabIndex = 16;
            this.lblTripID.Text = "Trip_id :";
            // 
            // labelStartDate
            // 
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStartDate.Location = new System.Drawing.Point(19, 123);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(96, 20);
            this.labelStartDate.TabIndex = 18;
            this.labelStartDate.Text = "Start Date :";
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEndDate.Location = new System.Drawing.Point(19, 159);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(89, 20);
            this.labelEndDate.TabIndex = 19;
            this.labelEndDate.Text = "End Date :";
            // 
            // textBoxHotelID
            // 
            this.textBoxHotelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxHotelID.Location = new System.Drawing.Point(144, 187);
            this.textBoxHotelID.Name = "textBoxHotelID";
            this.textBoxHotelID.Size = new System.Drawing.Size(200, 27);
            this.textBoxHotelID.TabIndex = 21;
            // 
            // lblHotelID
            // 
            this.lblHotelID.AutoSize = true;
            this.lblHotelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHotelID.Location = new System.Drawing.Point(19, 194);
            this.lblHotelID.Name = "lblHotelID";
            this.lblHotelID.Size = new System.Drawing.Size(81, 20);
            this.lblHotelID.TabIndex = 20;
            this.lblHotelID.Text = "Hotel_id :";
            // 
            // textBoxType
            // 
            this.textBoxType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxType.Location = new System.Drawing.Point(144, 227);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(200, 27);
            this.textBoxType.TabIndex = 23;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblType.Location = new System.Drawing.Point(19, 230);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(55, 20);
            this.lblType.TabIndex = 22;
            this.lblType.Text = "Type :";
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerStart.Location = new System.Drawing.Point(144, 118);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(200, 27);
            this.dateTimePickerStart.TabIndex = 24;
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerEnd.Location = new System.Drawing.Point(144, 154);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(200, 27);
            this.dateTimePickerEnd.TabIndex = 25;
            // 
            // btnAddTrip
            // 
            this.btnAddTrip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddTrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddTrip.Location = new System.Drawing.Point(23, 288);
            this.btnAddTrip.Name = "btnAddTrip";
            this.btnAddTrip.Size = new System.Drawing.Size(321, 59);
            this.btnAddTrip.TabIndex = 26;
            this.btnAddTrip.Text = "Add Trip to DB";
            this.btnAddTrip.UseVisualStyleBackColor = true;
            this.btnAddTrip.Click += new System.EventHandler(this.btnAddTrip_Click);
            // 
            // btnShowTrips
            // 
            this.btnShowTrips.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnShowTrips.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowTrips.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShowTrips.Location = new System.Drawing.Point(1258, 403);
            this.btnShowTrips.Name = "btnShowTrips";
            this.btnShowTrips.Size = new System.Drawing.Size(153, 66);
            this.btnShowTrips.TabIndex = 27;
            this.btnShowTrips.Text = "Show Trips";
            this.btnShowTrips.UseVisualStyleBackColor = false;
            this.btnShowTrips.Click += new System.EventHandler(this.btnShowTrips_Click);
            // 
            // btnShowHotels
            // 
            this.btnShowHotels.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowHotels.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShowHotels.Location = new System.Drawing.Point(437, 403);
            this.btnShowHotels.Name = "btnShowHotels";
            this.btnShowHotels.Size = new System.Drawing.Size(153, 66);
            this.btnShowHotels.TabIndex = 28;
            this.btnShowHotels.Text = "Show Hotels";
            this.btnShowHotels.UseVisualStyleBackColor = true;
            this.btnShowHotels.Click += new System.EventHandler(this.btnShowHotels_Click);
            // 
            // AddTrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(1423, 481);
            this.Controls.Add(this.btnShowHotels);
            this.Controls.Add(this.btnShowTrips);
            this.Controls.Add(this.btnAddTrip);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.dateTimePickerStart);
            this.Controls.Add(this.textBoxType);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.textBoxHotelID);
            this.Controls.Add(this.lblHotelID);
            this.Controls.Add(this.labelEndDate);
            this.Controls.Add(this.labelStartDate);
            this.Controls.Add(this.textBoxTripID);
            this.Controls.Add(this.lblTripID);
            this.Controls.Add(this.labelTripAdd);
            this.Controls.Add(this.dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddTrip";
            this.Text = "AddTrip";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label labelTripAdd;
        private System.Windows.Forms.TextBox textBoxTripID;
        private System.Windows.Forms.Label lblTripID;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.TextBox textBoxHotelID;
        private System.Windows.Forms.Label lblHotelID;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.Button btnAddTrip;
        private System.Windows.Forms.Button btnShowTrips;
        private System.Windows.Forms.Button btnShowHotels;
    }
}