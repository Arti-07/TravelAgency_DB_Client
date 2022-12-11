using Npgsql;
using System;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace TravelAgency
{
    public partial class ViewData : Form
    {
        private NpgsqlConnection connection = null;
        private NpgsqlConnection connToTravel = null;
        private Thread thread;

        public ViewData()
        {
            InitializeComponent();
            //connection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString);
            //connection.Open();

            connToTravel = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["TravelAgencyDB"].ConnectionString);
            connToTravel.Open();
            /*
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM book";
            NpgsqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridViewInsert.DataSource = dt;
            }
            connection.Dispose();
            connection.Close();
            */
        }

        

        private void btnBackToMenu_Click(object sender, EventArgs e)
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(
                "SELECT cities.name AS Город, country.name AS Страна FROM cities INNER JOIN country USING(country_id)", connToTravel);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);

                dataGridViewCity.DataSource = ds.Tables[0];
                dataGridViewCity.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnRefreshCustomers_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(
                "SELECT customer_id AS \"Номер клиента\", name AS \"Имя\", surname AS \"Фамилия\", patronymic AS \"Отчество\", date_of_birth AS \"Дата рождения\", phone_number AS \"Телефон\" FROM customer", connToTravel);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);

                dataGridViewCustomers.DataSource = ds.Tables[0];
                dataGridViewCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnRefreshHotel_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(
                "SELECT hotel_id AS Номер, hotel.name AS Название, stars AS Звезды, cities.name AS Город, type AS Тип, price_per_night AS Цена_за_ночь, available_rooms AS Свободные_Номера FROM hotel INNER JOIN cities USING(city_id)", connToTravel);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);

                dataGridViewHotel.DataSource = ds.Tables[0];
                dataGridViewHotel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

        private void btnAddCity_Click(object sender, EventArgs e)
        {
            AddCity_Country addCity = new AddCity_Country();
            addCity.ShowDialog();

        }

        private void btnAddHotel_Click(object sender, EventArgs e)
        {
            AddHotel addHotel = new AddHotel();
            addHotel.ShowDialog();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer();
            addCustomer.ShowDialog();
        }

        private void btnAddTrip_Click(object sender, EventArgs e)
        {
            AddTrip addTrip = new AddTrip();
            addTrip.ShowDialog();
        }

        private void btnAddSales_Click(object sender, EventArgs e)
        {
            AddSales addSales = new AddSales();
            addSales.ShowDialog();
        }

        private void btnShowSales_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(
                "SELECT sales_id AS Номер, date AS Дата, price AS Цена, name AS Имя, surname AS Фамилия, type AS Тип_Путевки,\r\n(SELECT name FROM hotel WHERE hotel_id = trip.hotel_id) AS Отель FROM sales INNER JOIN customer USING(customer_id) INNER JOIN trip USING(trip_id)", connToTravel);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                dataGridViewSales.DataSource = dataSet.Tables[0];
                dataGridViewSales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void radioButtonCity_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxStars.Enabled = false;
            textBoxNameFilter.Enabled = false;
            textBoxCountryFilter.Enabled = true;
            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(
                "SELECT cities.name AS Город, country.name AS Страна FROM cities INNER JOIN country USING(country_id)", connToTravel);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);

                dataGridViewFilter.DataSource = ds.Tables[0];
                dataGridViewFilter.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void radioButtonCustomers_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxStars.Enabled = false;
            textBoxNameFilter.Enabled = true;
            textBoxCountryFilter.Enabled = false;
            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(
                "SELECT customer_id AS \"Номер клиента\", name AS \"Имя\", surname AS \"Фамилия\", patronymic AS \"Отчество\", date_of_birth AS \"Дата рождения\", phone_number AS \"Телефон\" FROM customer", connToTravel);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);

                dataGridViewFilter.DataSource = ds.Tables[0];
                dataGridViewFilter.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void radioButtonHotel_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxStars.Enabled = true;
            textBoxNameFilter.Enabled = false;
            textBoxCountryFilter.Enabled = false;
            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(
                "SELECT hotel_id AS Номер, hotel.name AS Название, stars AS Звезды, cities.name AS Город, type AS Тип, price_per_night AS Цена_за_ночь, available_rooms AS Свободные_Номера FROM hotel INNER JOIN cities USING(city_id)", connToTravel);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);

                dataGridViewFilter.DataSource = ds.Tables[0];
                dataGridViewFilter.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxNameFilter_TextChanged(object sender, EventArgs e)
        {
            try
            {
                (dataGridViewFilter.DataSource as DataTable).DefaultView.RowFilter = $"Имя LIKE '%{textBoxNameFilter.Text}%'";
            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxCountryFilter_TextChanged(object sender, EventArgs e)
        {
            try
            {
                (dataGridViewFilter.DataSource as DataTable).DefaultView.RowFilter = $"Страна LIKE '%{textBoxCountryFilter.Text}%'";
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
                        (dataGridViewFilter.DataSource as DataTable).DefaultView.RowFilter = $"Звезды = {comboBoxStars.SelectedItem}";
                        break;

                    case 1:
                        (dataGridViewFilter.DataSource as DataTable).DefaultView.RowFilter = $"Звезды = {comboBoxStars.SelectedItem}";
                        break;

                    case 2:
                        (dataGridViewFilter.DataSource as DataTable).DefaultView.RowFilter = $"Звезды = {comboBoxStars.SelectedItem}";
                        break;

                    case 3:
                        (dataGridViewFilter.DataSource as DataTable).DefaultView.RowFilter = $"Звезды = {comboBoxStars.SelectedItem}";
                        break;

                    case 4:
                        (dataGridViewFilter.DataSource as DataTable).DefaultView.RowFilter = $"Звезды = {comboBoxStars.SelectedItem}";
                        break;

                    case 5:
                        (dataGridViewFilter.DataSource as DataTable).DefaultView.RowFilter = $"";
                        break;
                }
            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
