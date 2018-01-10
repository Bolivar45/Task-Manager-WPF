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

namespace Task_Manager
{
    /// <summary>
    /// Логика взаимодействия для PersonListWindow.xaml
    /// </summary>
    public partial class PersonListWindow : Window
    {
        string connectionString;
        SqlDataAdapter adapter;
        DataTable personsTable;

        public PersonListWindow()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }

        private void btnMenuTaskList_Click(object sender, RoutedEventArgs e)
        {
            TaskListWindow taskListWindow = new TaskListWindow();
            taskListWindow.Show();
        }

        private void btnMenuPersonList_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnPersonAdd_Click(object sender, RoutedEventArgs e)
        {
            PersonInputWindow personInputWindow = new PersonInputWindow();
            personInputWindow.ShowDialog();
        }

        private void btnPersonCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnPersonEdit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string sql = "SELECT FirstName, LastName, MiddleName FROM Persons ";
            personsTable = new DataTable();
            SqlConnection connection= null;
            try
            {
                connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(sql, connection);
                adapter = new SqlDataAdapter(command);
                connection.Open();
                adapter.Fill(personsTable);
                PersonsDataGrid.ItemsSource = personsTable.DefaultView;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }


        }
    }
}
