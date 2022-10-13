using System.Windows;
using System.Diagnostics;
using Microsoft.Data.SqlClient;

namespace WpfResponsive;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private const string connectionString = "Data Source = LUNATPC\\MSSQLDEV;" +
                                            "Initial Catalog = Northwind;" +
                                            "Integrated Security = true;" +
                                            "MultipleActiveResultSets=true;" +
                                            "Encrypt=False";

    private const string sql = "WAITFOR DELAY '00:00:05';" +
                               "SELECT EmployeeId, FirstName, LastName" +
                               " FROM Employees";
    public MainWindow()
    {
        InitializeComponent();
    }

    private void GetEmployeesSyncButton_Click(object sender, RoutedEventArgs e)
    {
        Stopwatch sw = Stopwatch.StartNew();
        using (SqlConnection conn = new(connectionString))
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string employee = string.Format("{0}: {1} {2}",
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetString(2)
                );

                EmployeesListBox.Items.Add(employee);
            }
            reader.Close();
            conn.Close();
        }

        EmployeesListBox.Items.Add($"Sync: {sw.ElapsedMilliseconds:N0}ms");
    }

    private async void GetEmployeesAsyncButton_Click(object sender, RoutedEventArgs e)
    {
        Stopwatch sw = Stopwatch.StartNew();
        using (SqlConnection conn = new(connectionString))
        {
            await conn.OpenAsync();
            SqlCommand command = new(sql, conn);
            SqlDataReader reader = await command.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                string employee = string.Format("{0}: {1} {2}",
                    await reader.GetFieldValueAsync<int>(0),
                    await reader.GetFieldValueAsync<string>(1),
                    await reader.GetFieldValueAsync<string>(2)
                    );
                EmployeesListBox.Items.Add(employee);
            }

            await reader.CloseAsync();
            await conn.CloseAsync();
        }

        EmployeesListBox.Items.Add($"Async: {sw.ElapsedMilliseconds}ms");
    }
}
