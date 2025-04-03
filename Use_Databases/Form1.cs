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
            string stringConnection = @"Server=ALAN_LUX_ASUS\SQLEXPRESS08;Database=ESCUELA;Trusted_Connection=True;TrustServerCertificate=true;";
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
        private void BtnInsertData_Click(object sender, EventArgs e)
        {
            string stringConnection = @"Server=ALAN_LUX_ASUS\SQLEXPRESS08;Database=ESCUELA;Trusted_Connection=True;TrustServerCertificate=true;";
            using (SqlConnection connection = new SqlConnection(stringConnection))
            {
                try
                {
                    connection.Open();
                    MessageBox.Show("Connection Opened");
                    // Insertar datos en la tabla de la base de datos
                    SqlCommand command = new SqlCommand("INSERT INTO CARRERA (ID_CARRERA, NOMBRE_CARRERA) VALUES (@ID_CARRERA, @NOMBRE_CARRERA)", connection);
                    command.Parameters.AddWithValue("@ID_CARRERA", 1);
                    command.Parameters.AddWithValue("@NOMBRE_CARRERA", "Ingeniería en Sistemas Computacionales");
                    command.ExecuteNonQuery();
                    MessageBox.Show("Data Inserted");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close(); // Cierra el formulario activo
        }
    }
}
