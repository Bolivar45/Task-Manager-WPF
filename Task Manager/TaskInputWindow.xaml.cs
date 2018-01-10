using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Task_Manager.Models;

namespace Task_Manager
{
    /// <summary>
    /// Логика взаимодействия для ListInputWindow.xaml
    /// </summary>
    public partial class TaskInputWindow : Window
    {
        readonly IList<Person> persons;
        private string connectionString;
        public TaskInputWindow()
        {
            InitializeComponent();
            persons = new List<Person>();
            comboBoxPersonLoad();
            comboBoxStatusLoad();
        }
        private void comboBoxStatusLoad()
        {
            IList<string> statuses = new List<string> { "Не начата", "В процессе", "Завершена", "Отложена" };
            cboStatus.ItemsSource = statuses;

        }
        private void comboBoxPersonLoad()
        {
            connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string sql = "SELECT * FROM Persons ";
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(sql, connection);
                connection.Open();
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    Person p = new Person(dr);
                    persons.Add(p);
                }
                cboPersons.ItemsSource = persons;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void cmdAddTask_Click(object sender, RoutedEventArgs e)
        {
            string commandText = "INSERT INTO Tasks (Name, Task, StartDate, EndDate, Status, Person) VALUES (@Name, @Task, @StartDate, @EndDate, @Status, @Person);";
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(connectionString);
                SqlCommand insertCommand = new SqlCommand(commandText, connection);
                insertCommand.Parameters.AddWithValue("Name", txtboxTaskName.Text);
                insertCommand.Parameters.AddWithValue("Task", txtboxTaskTask.Text);
                insertCommand.Parameters.AddWithValue("StartDate", txtTaskStartDate.Text);
                insertCommand.Parameters.AddWithValue("EndDate", txtboxTaskEndDate.Text);
                insertCommand.Parameters.AddWithValue("Status", cboStatus.SelectedItem); 
                insertCommand.Parameters.AddWithValue("Person", ((Person)cboPersons.SelectedItem).PersonId);

                connection.Open();
                insertCommand.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Запись успешно добавлена!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection != null)
                    connection.Close();
                this.Close();
            }
        }


        private void cmdCancelAddTask_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
