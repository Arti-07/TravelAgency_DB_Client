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
    public partial class AddTrip : Form
    {
        private NpgsqlConnection connToTravel = null;

        public AddTrip()
        {
            InitializeComponent();
            connToTravel = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["TravelAgencyDB"].ConnectionString);
            connToTravel.Open();
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

        private void btnShowTrips_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(
                "SELECT trip_id AS Номер, start_date AS Начало, end_date AS Конец, hotel.name AS Отель, trip.type AS Тип_путешествия, cities.name AS Город FROM trip INNER JOIN hotel USING(hotel_id) INNER JOIN cities USING(city_id)", connToTravel);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                dataGridView.DataSource = dataSet.Tables[0];
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddTrip_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlCommand command = new NpgsqlCommand($"INSERT INTO trip (trip_id, start_date, end_date, hotel_id, type) VALUES (@trip_id, @start_date, @end_date, @hotel_id, @type)",
               connToTravel);
                command.Parameters.AddWithValue("trip_id", int.Parse(textBoxTripID.Text));
                command.Parameters.AddWithValue("start_date", dateTimePickerStart.Value);
                command.Parameters.AddWithValue("end_date", dateTimePickerEnd.Value);
                command.Parameters.AddWithValue("hotel_id", int.Parse(textBoxHotelID.Text));
                command.Parameters.AddWithValue("type", textBoxType.Text);
                MessageBox.Show(command.ExecuteNonQuery().ToString());
                textBoxTripID.Text = String.Empty;
                dateTimePickerStart.Value = DateTime.Now;
                dateTimePickerEnd.Value = DateTime.Now;
                textBoxHotelID.Text = String.Empty;
                textBoxType.Text = String.Empty;
            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
