using Npgsql;
using System;
using System.Configuration;
using System.Data;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace TravelAgency
{
    public partial class User : Form
    {
        private NpgsqlConnection connToTravel = null;
        private Thread thread;
        private string selectedHotel;

        /* tripInfo */
        private int selectedTripID;
        private DateTime startDate;
        private DateTime endDate;
        private string hotel;
        private string type;
        private string city;
        private decimal price;

        /* book trip */
        private decimal salePrice;
        private int customerID;
        bool isBook = false;
        
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
                "SELECT trip_id AS Номер, start_date AS Начало, end_date AS Конец,hotel.name AS Отель, trip.type AS Тип_путешествия, cities.name AS Город, hotel.price_per_night AS Цена_за_ночь FROM trip INNER JOIN hotel USING(hotel_id) INNER JOIN cities USING(city_id)", connToTravel);
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
                selectedHotel = name;
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
                startDate = (DateTime)dataGridViewTrip.Rows[selRowNum].Cells[1].Value;
                endDate = (DateTime)dataGridViewTrip.Rows[selRowNum].Cells[2].Value;
                hotel = dataGridViewTrip.Rows[selRowNum].Cells[3].Value.ToString();
                city = dataGridViewTrip.Rows[selRowNum].Cells[5].Value.ToString();
                type = dataGridViewTrip.Rows[selRowNum].Cells[4].Value.ToString();
                price = decimal.Parse(dataGridViewTrip.Rows[selRowNum].Cells[6].Value.ToString());
                MessageBox.Show($"Путевка {selectedTripID} выбрана успешно!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxCity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                (dataGridViewHotels.DataSource as DataTable).DefaultView.RowFilter = $"Город LIKE '%{textBoxCity.Text}%'";
            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnShowSelected_Click(object sender, EventArgs e)
        {
            salePrice = (endDate.Subtract(startDate).Days) * price;
            string message =
                $"Номер вашего путешествия : {selectedTripID} \n\n" +
                $"Дата начала путешествия : {startDate.Date} \n\n" +
                $"Дата окончания путешествия : {endDate.Date} \n\n" +
                $"Всего дней : {endDate.Subtract(startDate).Days}\n\n" +
                $"Отель : {hotel} \n\n" +
                $"Город : {city} \n\n" +
                $"Тип путевки : {type} \n\n" +
                $"Общая цена за тур составит : {salePrice} rub.";
            richTextBoxTripInfo.Text = message;
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxName.Text))
            {
                MessageBox.Show("Поле имя не может быть пустым!");
            }
            else if (String.IsNullOrEmpty(textBoxSurname.Text))
            {
                MessageBox.Show("Поле фамилия не может быть пустым!");
            }
            else if (String.IsNullOrEmpty(textBoxPatronymic.Text))
            {
                MessageBox.Show("Поле отчество не может быть пустым!");
            }
            else if (String.IsNullOrEmpty(textBoxPhone.Text))
            {
                MessageBox.Show("Поле телефон не может быть пустым!");
            }
            else
            {
                try
                {
                    NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(
                    "SELECT * FROM public.customer ORDER BY customer_id ASC ", connToTravel);
                    DataSet ds = new DataSet();
                    dataAdapter.Fill(ds);

                    int lastId = ds.Tables[0].Rows.Count;
                    customerID = lastId + 1;

                    NpgsqlCommand command = new NpgsqlCommand($"INSERT INTO customer(customer_id,name,surname,patronymic,date_of_birth,phone_number) VALUES (@customer_id,@name,@surname,@patronymic,@date_of_birth,@phone_number)",
                                   connToTravel);
                    command.Parameters.AddWithValue("customer_id", customerID);
                    command.Parameters.AddWithValue("name", textBoxName.Text);
                    command.Parameters.AddWithValue("surname", textBoxSurname.Text);
                    command.Parameters.AddWithValue("patronymic", textBoxPatronymic.Text);
                    command.Parameters.AddWithValue("date_of_birth", dateTimePicker.Value);
                    command.Parameters.AddWithValue("phone_number", textBoxPhone.Text);
                    MessageBox.Show(command.ExecuteNonQuery().ToString());
                    textBoxName.Text = String.Empty;
                    textBoxSurname.Text = String.Empty;
                    textBoxPatronymic.Text = String.Empty;
                    textBoxPhone.Text = String.Empty;
                    dateTimePicker.Value = DateTime.Now;
                    isBook = true;
                    MessageBox.Show("Успешное сохранение данных!");
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void btnBookTrip_Click(object sender, EventArgs e)
        {
            if (isBook)
            {
                try
                {
                    NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(
                        "SELECT * FROM public.sales\r\nORDER BY sales_id ASC ", connToTravel);
                    DataSet ds = new DataSet();
                    dataAdapter.Fill(ds);

                    int saleLastId = ds.Tables[0].Rows.Count;
                    int saleID = saleLastId + 1;



                    
                    NpgsqlCommand command = new NpgsqlCommand($"INSERT INTO sales (sales_id, date, price, customer_id, trip_id) VALUES (@sales_id, @date, @price, @customer_id, @trip_id)",
                   connToTravel);
                    command.Parameters.AddWithValue("sales_id", saleID);
                    command.Parameters.AddWithValue("date", DateTime.Now);
                    command.Parameters.AddWithValue("price", salePrice);
                    command.Parameters.AddWithValue("customer_id", customerID);
                    command.Parameters.AddWithValue("trip_id", selectedTripID);
                    MessageBox.Show(command.ExecuteNonQuery().ToString());


                    NpgsqlCommand commandUpdate = new NpgsqlCommand($"UPDATE hotel SET available_rooms = available_rooms - 1 WHERE name = '{hotel}'",
               connToTravel);
                    MessageBox.Show(commandUpdate.ExecuteNonQuery().ToString());

                    MessageBox.Show("Благодарим Вас за бронирование путевки!\n В ближайшее время с вами свяжется наш сотрудник.");
                    textBoxName.Text = String.Empty;
                    textBoxSurname.Text = String.Empty;
                    textBoxPatronymic.Text = String.Empty;
                    textBoxPhone.Text = String.Empty;
                    dateTimePicker.Value = DateTime.Now;
                    isBook = false;
                }
                catch (Exception exeption)
                {
                    MessageBox.Show(exeption.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Необходимо сохранить свои данные!");
            }
            
        }
    }
}
