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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TravelAgency
{
    public partial class AddSales : Form
    {
        private NpgsqlConnection connToTravel = null;

        public AddSales()
        {
            InitializeComponent();
            connToTravel = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["TravelAgencyDB"].ConnectionString);
            connToTravel.Open();
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

        private void btnShowCustomers_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = connToTravel;
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT customer_id AS Номер, name AS Имя, surname AS Фамилия, patronymic AS Отчество, date_of_birth AS Дата_рождения, phone_number AS Телефон FROM customer ORDER BY customer_id ASC ";
                NpgsqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dataGridView.DataSource = dt;
                    dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnShowSales_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(
                "SELECT sales_id AS Номер, date AS Дата, price AS Цена, name AS Имя, surname AS Фамилия, type AS Тип_Путевки,\r\n(SELECT name FROM hotel WHERE hotel_id = trip.hotel_id) AS Отель FROM sales INNER JOIN customer USING(customer_id) INNER JOIN trip USING(trip_id)", connToTravel);
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

        private void btnAddSale_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlCommand command = new NpgsqlCommand($"INSERT INTO sales (sales_id, date, price, customer_id, trip_id) VALUES (@sales_id, @date, @price, @customer_id, @trip_id)",
               connToTravel);
                command.Parameters.AddWithValue("sales_id", int.Parse(textBoxSalesID.Text));
                command.Parameters.AddWithValue("date", dateTimePicker.Value);
                command.Parameters.AddWithValue("price", decimal.Parse(textBoxPrice.Text));
                command.Parameters.AddWithValue("customer_id", int.Parse(textBoxCustomerID.Text));
                command.Parameters.AddWithValue("trip_id", int.Parse(textBoxTripID.Text));
                MessageBox.Show(command.ExecuteNonQuery().ToString());
                textBoxSalesID.Text = String.Empty;
                dateTimePicker.Value = DateTime.Now;
                textBoxPrice.Text = String.Empty;
                textBoxCustomerID.Text = String.Empty;
                textBoxTripID.Text = String.Empty;
            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
