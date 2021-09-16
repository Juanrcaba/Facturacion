using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string codigo,producto;
        decimal valor = 0,total = 0, cantidad, precio; 


        private void txt_precio_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (txt_codigo.Text != string.Empty && txt_producto.Text != string.Empty && txt_cantidad.Text != string.Empty && txt_precio.Text != string.Empty)
                {
                    codigo = txt_codigo.Text;
                    producto = txt_producto.Text;
                    cantidad = Convert.ToDecimal(txt_cantidad.Text);
                    precio = Convert.ToDecimal(txt_precio.Text);
                    valor = cantidad * precio;

                    dgDatos.Rows.Add(codigo, producto, precio, cantidad, valor);

                    foreach(DataGridViewRow valor in dgDatos.Rows)
                    {
                        this.total += Convert.ToDecimal(valor.Cells["c_valor"].Value);
                    }
                    txt_total.Text = total.ToString();

                    limpiar(); //limpiar los controles
                }
                else
                    MessageBox.Show("Todos los datos deben ser ingresados.");

            }
        }

        

        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        void limpiar()
        {
            txt_codigo.Focus();
            txt_codigo.Clear();
            txt_producto.Clear();
            txt_cantidad.Clear();
            txt_precio.Clear();
            total = 0;
        }
    }
}
