using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using capaDatos;
using capaLogica;
using Entidades;
namespace capaPresentacion
{
    public partial class Form1 : Form
    {

        private CL_Vehiculo datosVehiculo = new CL_Vehiculo();
        public Form1()
        {
            InitializeComponent();
            ConfigurarDataGridView(dataGridView1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataTable dtVehiculos = datosVehiculo.ObtenerFuncionarios();
            dataGridView1.DataSource = dtVehiculos;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                VehiculosGS vehiculos = new VehiculosGS
            {
                Matricula = textBox1.Text,
                Marca = textBox2.Text,
                Modelo = textBox3.Text,
                Anio = int.Parse(textBox4.Text),
                Cod_serv = int.Parse(textBox5.Text)

            };
            datosVehiculo.AgregarVehiculo(vehiculos);
            DataTable dtVehiculos = datosVehiculo.ObtenerFuncionarios();
            dataGridView1.DataSource = dtVehiculos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public static void ConfigurarDataGridView(DataGridView dataGridView)
        {
            // Establecer el DataGridView como de solo lectura
            dataGridView.ReadOnly = true;

            // Seleccionar la fila completa al hacer clic en cualquier celda
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Deshabilitar la edición
            dataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;

            // Deshabilitar la posibilidad de que el usuario agregue o elimine filas
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;

            // Deshabilitar la opción de reordenar columnas arrastrando
            dataGridView.AllowUserToOrderColumns = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);
                datosVehiculo.EliminarVehiculos(id);
                DataTable dtVehiculos = datosVehiculo.ObtenerFuncionarios();
                dataGridView1.DataSource = dtVehiculos;
            }
            else
                MessageBox.Show("Por favor, selecciona un vehiculo para eliminar.");
        }

        private void button3_Click(object sender, EventArgs e)
        {


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaSeleccionada = dataGridView1.SelectedRows[0]; // Obtén la primera fila seleccionada
            int id = Convert.ToInt32(filaSeleccionada.Cells["id"].Value);
            string matricula = Convert.ToString(filaSeleccionada.Cells["matricula"].Value);
            string marca = Convert.ToString(filaSeleccionada.Cells["marca"].Value);
            string modelo = Convert.ToString(filaSeleccionada.Cells["modelo"].Value);
            int anio = Convert.ToInt32(filaSeleccionada.Cells["anio"].Value);
            int cod_Serv = Convert.ToInt32(filaSeleccionada.Cells["cod_Serv"].Value);

            textBox6.Text = Convert.ToString(id);
            textBox1.Text = matricula;
            textBox2.Text = marca;
            textBox3.Text = modelo;
            textBox4.Text = Convert.ToString(anio);
            textBox5.Text = Convert.ToString(cod_Serv);    

        }
    }
}