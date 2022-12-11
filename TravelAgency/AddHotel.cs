using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelAgency
{
    public partial class AddHotel : Form
    {
        private NpgsqlConnection connToTravel = null;

        public AddHotel()
        {
            InitializeComponent();
            connToTravel = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["TravelAgencyDB"].ConnectionString);
            connToTravel.Open();
        }

        private void btnShowCity_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(
               "SELECT city_id AS Id, cities.name AS Город, country.name AS Страна FROM cities INNER JOIN country USING(country_id) ORDER BY city_id ASC ", connToTravel);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);

                dataGridView.DataSource = ds.Tables[0];
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnShowHotels_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(
               "SELECT hotel_id AS Номер, hotel.name AS Название, stars AS Звезды, cities.name AS Город, type AS Тип, price_per_night AS Цена_за_ночь, available_rooms AS Свободные_Номера FROM hotel INNER JOIN cities USING(city_id)", connToTravel);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);

                dataGridView.DataSource = ds.Tables[0];
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddHotel_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlCommand command = new NpgsqlCommand($"INSERT INTO hotel (hotel_id, name, stars, city_id, type, price_per_night, available_rooms) VALUES (@hotel_id, @name, @stars, @city_id, @type, @price_per_night, @available_rooms)",
               connToTravel);
                command.Parameters.AddWithValue("hotel_id", int.Parse(textBoxHotelID.Text));
                command.Parameters.AddWithValue("name", textBoxName.Text);
                command.Parameters.AddWithValue("stars", int.Parse(textBoxStars.Text));
                command.Parameters.AddWithValue("city_id", int.Parse(textBoxCityID.Text));
                command.Parameters.AddWithValue("type", textBoxType.Text);
                command.Parameters.AddWithValue("price_per_night", decimal.Parse(textBoxPrice.Text));
                command.Parameters.AddWithValue("available_rooms", int.Parse(textBoxRooms.Text));
                MessageBox.Show(command.ExecuteNonQuery().ToString());
                textBoxHotelID.Text = String.Empty;
                textBoxName.Text = String.Empty;
                textBoxStars.Text = String.Empty;
                textBoxCityID.Text = String.Empty;
                textBoxType.Text = String.Empty;
                textBoxPrice.Text = String.Empty;
                textBoxRooms.Text = String.Empty;
            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
