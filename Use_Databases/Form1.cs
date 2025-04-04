namespace Use_Databases
{
    using Microsoft.Data.SqlClient;
    using System.Data; // Agrega esta línea para usar DataTable
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnOpenData_Click(object sender, EventArgs e)
        {
            string stringConnection = @"Server=LUX_ALAN\SQLEXPRESS;Database=ESCUELA;Trusted_Connection=True;TrustServerCertificate=true;";
            using (SqlConnection connection = new SqlConnection(stringConnection))
            {
                try
                {
                    connection.Open();
                    MessageBox.Show("Connection Opened");

                    // Mostrar los datos de la tabla de la base de datos en el DataGridView
                    SqlCommand command = new SqlCommand("SELECT * FROM CARRERA", connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable(); // Crea un DataTable para almacenar los datos
                    adapter.Fill(dataTable); // Llena el DataTable con los datos de la consulta

                    DataGridCarrera.DataSource = dataTable; // Asigna el DataTable como el DataSource del DataGridView

                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
                finally
                {
                    connection.Close();
                    MessageBox.Show("Connection Closed");
                }
            }
        }

        private void BtnSendData_Click(object sender, EventArgs e)
        {
            string stringConnection = @"Server=LUX_ALAN\SQLEXPRESS;Database=ESCUELA;Trusted_Connection=True;TrustServerCertificate=true;";

            using (SqlConnection connection = new SqlConnection(stringConnection))
            {
                try
                {
                    connection.Open();

                    foreach (DataGridViewRow row in DataGridCarrera.Rows)
                    {
                        if (!row.IsNewRow) // Evita procesar la última fila vacía
                        {
                            int id = Convert.ToInt32(row.Cells[0].Value);
                            string nombre = row.Cells[1].Value?.ToString() ?? "";

                            string query = "UPDATE CARRERA SET NOMBRE = @NOMBRE WHERE ID = @ID";
                            SqlCommand command = new SqlCommand(query, connection);
                            command.Parameters.AddWithValue("@ID", id);
                            command.Parameters.AddWithValue("@NOMBRE", nombre);

                            command.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Datos actualizados correctamente");

                    // Recargar el DataGridView para reflejar los cambios
                    SqlCommand selectCommand = new SqlCommand("SELECT * FROM CARRERA", connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(selectCommand);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    DataGridCarrera.DataSource = dataTable;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void BtnClose_Click_1(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close(); // Cierra el formulario activo
        }
    }
}
