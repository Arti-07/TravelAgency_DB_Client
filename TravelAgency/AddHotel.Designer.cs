namespace TravelAgency
{
    partial class AddHotel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddHotel));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.labelHotelAdd = new System.Windows.Forms.Label();
            this.lblHotelID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblStars = new System.Windows.Forms.Label();
            this.lblCity_id = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.labelAvaliable = new System.Windows.Forms.Label();
            this.textBoxHotelID = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxStars = new System.Windows.Forms.TextBox();
            this.textBoxCityID = new System.Windows.Forms.TextBox();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxRooms = new System.Windows.Forms.TextBox();
            this.btnShowCity = new System.Windows.Forms.Button();
            this.btnShowHotels = new System.Windows.Forms.Button();
            this.btnAddHotel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(355, 9);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(1085, 395);
            this.dataGridView.TabIndex = 0;
            // 
            // labelHotelAdd
            // 
            this.labelHotelAdd.AutoSize = true;
            this.labelHotelAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHotelAdd.Location = new System.Drawing.Point(94, 9);
            this.labelHotelAdd.Name = "labelHotelAdd";
            this.labelHotelAdd.Size = new System.Drawing.Size(119, 29);
            this.labelHotelAdd.TabIndex = 7;
            this.labelHotelAdd.Text = "Add Hotel";
            // 
            // lblHotelID
            // 
            this.lblHotelID.AutoSize = true;
            this.lblHotelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHotelID.Location = new System.Drawing.Point(12, 86);
            this.lblHotelID.Name = "lblHotelID";
            this.lblHotelID.Size = new System.Drawing.Size(81, 20);
            this.lblHotelID.TabIndex = 8;
            this.lblHotelID.Text = "Hotel_id :";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.Location = new System.Drawing.Point(12, 127);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(63, 20);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "Name :";
            // 
            // lblStars
            // 
            this.lblStars.AutoSize = true;
            this.lblStars.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStars.Location = new System.Drawing.Point(12, 168);
            this.lblStars.Name = "lblStars";
            this.lblStars.Size = new System.Drawing.Size(59, 20);
            this.lblStars.TabIndex = 10;
            this.lblStars.Text = "Stars :";
            // 
            // lblCity_id
            // 
            this.lblCity_id.AutoSize = true;
            this.lblCity_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCity_id.Location = new System.Drawing.Point(12, 206);
            this.lblCity_id.Name = "lblCity_id";
            this.lblCity_id.Size = new System.Drawing.Size(70, 20);
            this.lblCity_id.TabIndex = 11;
            this.lblCity_id.Text = "City_id :";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblType.Location = new System.Drawing.Point(12, 248);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(55, 20);
            this.lblType.TabIndex = 12;
            this.lblType.Text = "Type :";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPrice.Location = new System.Drawing.Point(3, 286);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(128, 20);
            this.lblPrice.TabIndex = 13;
            this.lblPrice.Text = "Price per night :";
            // 
            // labelAvaliable
            // 
            this.labelAvaliable.AutoSize = true;
            this.labelAvaliable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAvaliable.Location = new System.Drawing.Point(2, 319);
            this.labelAvaliable.Name = "labelAvaliable";
            this.labelAvaliable.Size = new System.Drawing.Size(138, 20);
            this.labelAvaliable.TabIndex = 14;
            this.labelAvaliable.Text = " Available rooms:";
            // 
            // textBoxHotelID
            // 
            this.textBoxHotelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxHotelID.Location = new System.Drawing.Point(137, 83);
            this.textBoxHotelID.Name = "textBoxHotelID";
            this.textBoxHotelID.Size = new System.Drawing.Size(200, 27);
            this.textBoxHotelID.TabIndex = 15;
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.Location = new System.Drawing.Point(137, 124);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(200, 27);
            this.textBoxName.TabIndex = 16;
            // 
            // textBoxStars
            // 
            this.textBoxStars.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxStars.Location = new System.Drawing.Point(137, 165);
            this.textBoxStars.Name = "textBoxStars";
            this.textBoxStars.Size = new System.Drawing.Size(200, 27);
            this.textBoxStars.TabIndex = 17;
            // 
            // textBoxCityID
            // 
            this.textBoxCityID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCityID.Location = new System.Drawing.Point(137, 203);
            this.textBoxCityID.Name = "textBoxCityID";
            this.textBoxCityID.Size = new System.Drawing.Size(200, 27);
            this.textBoxCityID.TabIndex = 18;
            // 
            // textBoxType
            // 
            this.textBoxType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxType.Location = new System.Drawing.Point(137, 245);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(200, 27);
            this.textBoxType.TabIndex = 19;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPrice.Location = new System.Drawing.Point(137, 283);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(200, 27);
            this.textBoxPrice.TabIndex = 20;
            // 
            // textBoxRooms
            // 
            this.textBoxRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRooms.Location = new System.Drawing.Point(137, 316);
            this.textBoxRooms.Name = "textBoxRooms";
            this.textBoxRooms.Size = new System.Drawing.Size(200, 27);
            this.textBoxRooms.TabIndex = 21;
            // 
            // btnShowCity
            // 
            this.btnShowCity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShowCity.Location = new System.Drawing.Point(355, 410);
            this.btnShowCity.Name = "btnShowCity";
            this.btnShowCity.Size = new System.Drawing.Size(151, 64);
            this.btnShowCity.TabIndex = 22;
            this.btnShowCity.Text = "Show Cities";
            this.btnShowCity.UseVisualStyleBackColor = true;
            this.btnShowCity.Click += new System.EventHandler(this.btnShowCity_Click);
            // 
            // btnShowHotels
            // 
            this.btnShowHotels.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnShowHotels.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowHotels.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShowHotels.Location = new System.Drawing.Point(1289, 410);
            this.btnShowHotels.Name = "btnShowHotels";
            this.btnShowHotels.Size = new System.Drawing.Size(151, 64);
            this.btnShowHotels.TabIndex = 23;
            this.btnShowHotels.Text = "Show Hotels";
            this.btnShowHotels.UseVisualStyleBackColor = false;
            this.btnShowHotels.Click += new System.EventHandler(this.btnShowHotels_Click);
            // 
            // btnAddHotel
            // 
            this.btnAddHotel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddHotel.Location = new System.Drawing.Point(16, 410);
            this.btnAddHotel.Name = "btnAddHotel";
            this.btnAddHotel.Size = new System.Drawing.Size(272, 59);
            this.btnAddHotel.TabIndex = 24;
            this.btnAddHotel.Text = "Add Hotel to DB";
            this.btnAddHotel.UseVisualStyleBackColor = true;
            this.btnAddHotel.Click += new System.EventHandler(this.btnAddHotel_Click);
            // 
            // AddHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(1452, 486);
            this.Controls.Add(this.btnAddHotel);
            this.Controls.Add(this.btnShowHotels);
            this.Controls.Add(this.btnShowCity);
            this.Controls.Add(this.textBoxRooms);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxType);
            this.Controls.Add(this.textBoxCityID);
            this.Controls.Add(this.textBoxStars);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxHotelID);
            this.Controls.Add(this.labelAvaliable);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblCity_id);
            this.Controls.Add(this.lblStars);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblHotelID);
            this.Controls.Add(this.labelHotelAdd);
            this.Controls.Add(this.dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddHotel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddHotel";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label labelHotelAdd;
        private System.Windows.Forms.Label lblHotelID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblStars;
        private System.Windows.Forms.Label lblCity_id;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label labelAvaliable;
        private System.Windows.Forms.TextBox textBoxHotelID;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxStars;
        private System.Windows.Forms.TextBox textBoxCityID;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxRooms;
        private System.Windows.Forms.Button btnShowCity;
        private System.Windows.Forms.Button btnShowHotels;
        private System.Windows.Forms.Button btnAddHotel;
    }
}