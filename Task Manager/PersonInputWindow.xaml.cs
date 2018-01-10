using System;
using System.Collections.Generic;
using System.Configuration;
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
    /// Логика взаимодействия для PersonInputWindow.xaml
    /// </summary>
    public partial class PersonInputWindow : Window
    {
        private string connectionString;

        public PersonInputWindow()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }

        private void cmdAddPerson_Click(object sender, RoutedEventArgs e)
        {
            string commandText = "INSERT INTO Persons (FirstName, LastName, MiddleName) VALUES (@FirstName, @LastName, @MiddleName);";
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(connectionString);
                SqlCommand insertCommand = new SqlCommand(commandText, connection);
                insertCommand.Parameters.AddWithValue("FirstName", txtboxFirstName.Text);
                insertCommand.Parameters.AddWithValue("LastName", txtboxLastName.Text);
                insertCommand.Parameters.AddWithValue("MiddleName", txtboxMiddleName.Text);
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

        private void cmdCancelAddPerson_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
