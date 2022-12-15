using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelAgency
{
    public partial class UpdateHotel : Form
    {
        private int hotelID;
        private NpgsqlConnection connToTravel = null;

        public UpdateHotel(int id)
        {
            hotelID = id;
            connToTravel = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["TravelAgencyDB"].ConnectionString);
            connToTravel.Open();
            InitializeComponent();
        }

        private void UpdateHotel_Load(object sender, EventArgs e)
        {
            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(
                $"SELECT hotel_id, name, stars, city_id, type, price_per_night, available_rooms FROM hotel WHERE hotel.hotel_id = {hotelID}", connToTravel);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                textBoxHotelID.Text = ds.Tables[0].Rows[0]["hotel_id"].ToString();
                textBoxName.Text = ds.Tables[0].Rows[0]["name"].ToString();
                textBoxStars.Text = ds.Tables[0].Rows[0]["stars"].ToString();
                textBoxCityID.Text = ds.Tables[0].Rows[0]["city_id"].ToString();
                textBoxType.Text = ds.Tables[0].Rows[0]["type"].ToString();
                textBoxPrice.Text = ds.Tables[0].Rows[0]["price_per_night"].ToString();
                textBoxRooms.Text = ds.Tables[0].Rows[0]["available_rooms"].ToString();
            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlCommand command = new NpgsqlCommand($"UPDATE hotel SET name = '{textBoxName.Text}', stars = {int.Parse(textBoxStars.Text)}, city_id = {int.Parse(textBoxCityID.Text)}, type = '{textBoxType.Text}', price_per_night = {decimal.Parse(textBoxPrice.Text)}, available_rooms = {int.Parse(textBoxRooms.Text)} WHERE hotel.hotel_id = {hotelID}",
               connToTravel);
                MessageBox.Show(command.ExecuteNonQuery().ToString());
            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
