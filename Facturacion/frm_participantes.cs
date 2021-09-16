using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Facturacion
{
    public partial class frm_participantes : Form
    {
        public frm_participantes()
        {
            InitializeComponent();
        }
        //conexion a la base de datos
        SqlConnection Cn = new SqlConnection("Data source = .; Initial Catalog= uapa; Integrated Security= true");

        private void frm_participantes_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string tipo_dato = "";
            if (rbtn_nombre.Checked)
                tipo_dato = "nombrepar";
            else if (rbtn_apellido.Checked)
                tipo_dato = "apellidopar";
            else if (rbtn_direccion.Checked)
                tipo_dato = "direccionpar";

            filtrar_datos(txt_buscar.Text,tipo_dato);
        }
        void CargarDatos()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("select * from participantes",Cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                dgDatos.DataSource = dt;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al solicitar datos a base de datos. "+ex.Message);
            }
        }

        void filtrar_datos(string dato, string tipo_dato)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand($"select * from participantes where "+tipo_dato+" like '"+dato+"%' ", Cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                dgDatos.DataSource = dt;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al solicitar datos a base de datos. " + ex.Message);
            }
        }
    }
}
