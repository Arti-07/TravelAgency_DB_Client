using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TravelAgency
{
    public partial class User : Form
    {
        private NpgsqlConnection connToTravel = null;
        private Thread thread;
        private string selectedHotel;
        private string selectedCity;

        private int selectedTripID;
        public User()
        {
            connToTravel = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["TravelAgencyDB"].ConnectionString);
            connToTravel.Open();
            InitializeComponent();
        }

        private void backToMainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(OpenMainMenu);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void OpenMainMenu()
        {
            Application.Run(new MainForm());
        }

        private void User_Load(object sender, EventArgs e)
        {

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(
                "SELECT hotel_id AS Номер, hotel.name AS Название, stars AS Звезды, cities.name AS Город, type AS Тип, price_per_night AS Цена_за_ночь, available_rooms AS Свободные_Номера FROM hotel INNER JOIN cities USING(city_id)", connToTravel);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);

                dataGridViewHotels.DataSource = ds.Tables[0];
                dataGridViewHotels.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(
                "SELECT trip_id AS Номер, start_date AS Начало, end_date AS Конец, hotel.name AS Отель, trip.type AS Тип_путешествия, cities.name AS Город FROM trip INNER JOIN hotel USING(hotel_id) INNER JOIN cities USING(city_id)", connToTravel);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                dataGridViewTrip.DataSource = dataSet.Tables[0];
                dataGridViewTrip.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxStars_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                switch (comboBoxStars.SelectedIndex)
                {
                    case 0:
                        (dataGridViewHotels.DataSource as DataTable).DefaultView.RowFilter = $"Звезды = {comboBoxStars.SelectedItem}";
                        break;

                    case 1:
                        (dataGridViewHotels.DataSource as DataTable).DefaultView.RowFilter = $"Звезды = {comboBoxStars.SelectedItem}";
                        break;

                    case 2:
                        (dataGridViewHotels.DataSource as DataTable).DefaultView.RowFilter = $"Звезды = {comboBoxStars.SelectedItem}";
                        break;

                    case 3:
                        (dataGridViewHotels.DataSource as DataTable).DefaultView.RowFilter = $"Звезды = {comboBoxStars.SelectedItem}";
                        break;

                    case 4:
                        (dataGridViewHotels.DataSource as DataTable).DefaultView.RowFilter = $"Звезды = {comboBoxStars.SelectedItem}";
                        break;

                    case 5:
                        (dataGridViewHotels.DataSource as DataTable).DefaultView.RowFilter = $"";
                        break;
                }

            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewHotels_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int selRowNum = dataGridViewHotels.CurrentCell.RowIndex;
                var selectedId = dataGridViewHotels.Rows[selRowNum].Cells[0].Value.ToString();
                string name = dataGridViewHotels.Rows[selRowNum].Cells[1].Value.ToString();
                string city = dataGridViewHotels.Rows[selRowNum].Cells[3].Value.ToString();
                selectedHotel = name;
                selectedCity = city;
                textBoxSelectedHotel.Text = $"Selected Hotel:    {name}.";

                MessageBox.Show($"Отель {name} выбран успешно!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void radioButtonHotel_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                textBoxType.Text = String.Empty;
                (dataGridViewTrip.DataSource as DataTable).DefaultView.RowFilter = $"Отель LIKE '%{selectedHotel}%'";
            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void radioButtonClear_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(
                "SELECT trip_id AS Номер, start_date AS Начало, end_date AS Конец, hotel.name AS Отель, trip.type AS Тип_путешествия, cities.name AS Город FROM trip INNER JOIN hotel USING(hotel_id) INNER JOIN cities USING(city_id)", connToTravel);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                dataGridViewTrip.DataSource = dataSet.Tables[0];
                dataGridViewTrip.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                textBoxType.Text = String.Empty;
                dateTimePickerStart.Value = DateTime.Now;
                dateTimePickerEnd.Value = DateTime.Now;
            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxType_TextChanged(object sender, EventArgs e)
        {
            try
            {
                (dataGridViewTrip.DataSource as DataTable).DefaultView.RowFilter = $"Тип_путешествия LIKE '%{textBoxType.Text}%'";
            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(
                $"SELECT trip_id AS Номер, start_date AS Начало, end_date AS Конец, hotel.name AS Отель, trip.type AS Тип_путешествия, cities.name AS Город FROM trip INNER JOIN hotel USING(hotel_id) INNER JOIN cities USING(city_id) WHERE trip.start_date >= '{dateTimePickerStart.Value}' AND trip.end_date <= '{dateTimePickerEnd.Value}' ORDER BY trip_id ASC ", connToTravel);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                dataGridViewTrip.DataSource = dataSet.Tables[0];
                dataGridViewTrip.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                textBoxType.Text = String.Empty;
            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewTrip_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int selRowNum = dataGridViewTrip.CurrentCell.RowIndex;
                var tripId = dataGridViewTrip.Rows[selRowNum].Cells[0].Value.ToString();
                selectedTripID = int.Parse(tripId);
                MessageBox.Show($"Путевка {selectedTripID} выбрана успешно!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
