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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Task_Manager
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class TaskListWindow : Window
    {
        string connectionString;
        SqlDataAdapter adapter;
        DataTable taskTable;

        public TaskListWindow()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }

        private void btnMenuTaskList_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnMenuPersonList_Click(object sender, RoutedEventArgs e)
        {
            PersonListWindow personListWindow = new PersonListWindow();
            personListWindow.Show();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string sql = "SELECT Name, Task, StartDate, EndDate, Status, Persons.FirstName FROM Tasks INNER JOIN Persons ON Tasks.Person=Persons.PersonId";
            taskTable = new DataTable();
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(sql, connection);
                adapter = new SqlDataAdapter(command);
                connection.Open();
                adapter.Fill(taskTable);
                tasksDataGrid.ItemsSource = taskTable.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }

        private void btnAddTask_Click(object sender, RoutedEventArgs e)
        {
            TaskInputWindow taskInputWindow = new TaskInputWindow();
            taskInputWindow.ShowDialog();
        }

        private void btnEditTask_Click(object sender, RoutedEventArgs e)
        {
            UpdateDB();
        }

        private void UpdateDB()
        {
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
            adapter.Update(taskTable);
        }

        private void btnDelTask_Click(object sender, RoutedEventArgs e)
        {

            if (tasksDataGrid.SelectedItems != null)
            {
                for (int i = 0; i < tasksDataGrid.SelectedItems.Count; i++)
                {
                    DataRowView datarowView = tasksDataGrid.SelectedItems[i] as DataRowView;
                    if (datarowView != null)
                    {
                        DataRow dataRow = (DataRow)datarowView.Row;
                        dataRow.Delete();
                    }
                }
            }
            UpdateDB();
        }
    }
}
