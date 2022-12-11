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
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(
                "SELECT cities.name AS Город, country.name AS Страна FROM cities INNER JOIN country USING(country_id)", connToTravel);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);

            dataGridViewCity.DataSource = ds.Tables[0];
            dataGridViewCity.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnRefreshCustomers_Click(object sender, EventArgs e)
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(
                "SELECT customer_id AS \"Номер клиента\", name AS \"Имя\", surname AS \"Фамилия\", patronymic AS \"Отчество\", date_of_birth AS \"Дата рождения\", phone_number AS \"Телефон\" FROM customer", connToTravel);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);

            dataGridViewCustomers.DataSource = ds.Tables[0];
            dataGridViewCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnRefreshHotel_Click(object sender, EventArgs e)
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(
                "SELECT hotel_id AS Номер, hotel.name AS Название, stars AS Звезды, cities.name AS Город, type AS Тип, price_per_night AS Цена_за_ночь, available_rooms AS Свободные_Номера FROM hotel INNER JOIN cities USING(city_id)", connToTravel);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);

            dataGridViewHotel.DataSource = ds.Tables[0];
            dataGridViewHotel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(
                "SELECT trip_id AS Номер, start_date AS Начало, end_date AS Конец, hotel.name AS Отель, trip.type AS Тип_путешествия, cities.name AS Город FROM trip INNER JOIN hotel USING(hotel_id) INNER JOIN cities USING(city_id)",connToTravel);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);

            dataGridViewTrip.DataSource = dataSet.Tables[0];
            dataGridViewTrip.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
    }
}
