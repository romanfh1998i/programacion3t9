using System.Data.SqlClient;
using System.Data;
using System.Data.Entity;

namespace Tarea9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            double Precio;                
            string NombreProducto=txtProducto.Text;

            string PrecioProducto=nudPrecioProducto.Text.ToString();
            Precio=double.Parse(PrecioProducto);
            string cadenaconexion = "Server = MSI; Database = EjemploTrigger; integrated security = true";
            using (SqlConnection conexion = new SqlConnection(cadenaconexion))
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexion;
                comando.CommandText = "INSERT INTO productos(nombre,precio) VALUES(@nombre,@precio)";
                comando.Parameters.AddWithValue("@precio", Precio);
                comando.Parameters.AddWithValue("@nombre", NombreProducto);
                comando.ExecuteNonQuery();
            }
                
                MessageBox.Show("El producto se  registado correctamente");
            
           
        }

        private void nudPrecioProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void nudPrecioProducto_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void nudPrecioProducto_Enter(object sender, EventArgs e)
        {

        }
    }
}