
namespace Facturacion
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.txt_producto = new System.Windows.Forms.TextBox();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.dgDatos = new System.Windows.Forms.DataGridView();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.c_codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(12, 37);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(100, 20);
            this.txt_codigo.TabIndex = 0;
            // 
            // txt_producto
            // 
            this.txt_producto.Location = new System.Drawing.Point(118, 37);
            this.txt_producto.Name = "txt_producto";
            this.txt_producto.Size = new System.Drawing.Size(375, 20);
            this.txt_producto.TabIndex = 1;
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(499, 37);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(100, 20);
            this.txt_cantidad.TabIndex = 2;
            // 
            // txt_precio
            // 
            this.txt_precio.Location = new System.Drawing.Point(605, 37);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(100, 20);
            this.txt_precio.TabIndex = 3;
            this.txt_precio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_precio_KeyDown);
           // this.txt_precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_precio_KeyPress);
            // 
            // dgDatos
            // 
            this.dgDatos.AllowUserToAddRows = false;
            this.dgDatos.AllowUserToDeleteRows = false;
            this.dgDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c_codigo,
            this.C_producto,
            this.c_precio,
            this.c_cantidad,
            this.c_valor});
            this.dgDatos.Location = new System.Drawing.Point(12, 64);
            this.dgDatos.Name = "dgDatos";
            this.dgDatos.ReadOnly = true;
            this.dgDatos.RowHeadersVisible = false;
            this.dgDatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDatos.Size = new System.Drawing.Size(693, 256);
            this.dgDatos.TabIndex = 4;
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(605, 326);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(100, 20);
            this.txt_total.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(507, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cantidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(612, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Precio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(568, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Total";
            // 
            // c_codigo
            // 
            this.c_codigo.FillWeight = 126.9035F;
            this.c_codigo.HeaderText = "Codigo";
            this.c_codigo.Name = "c_codigo";
            this.c_codigo.ReadOnly = true;
            // 
            // C_producto
            // 
            this.C_producto.FillWeight = 93.27412F;
            this.C_producto.HeaderText = "Producto";
            this.C_producto.Name = "C_producto";
            this.C_producto.ReadOnly = true;
            // 
            // c_precio
            // 
            this.c_precio.FillWeight = 93.27412F;
            this.c_precio.HeaderText = "Precio";
            this.c_precio.Name = "c_precio";
            this.c_precio.ReadOnly = true;
            // 
            // c_cantidad
            // 
            this.c_cantidad.FillWeight = 93.27412F;
            this.c_cantidad.HeaderText = "Cantidad";
            this.c_cantidad.Name = "c_cantidad";
            this.c_cantidad.ReadOnly = true;
            // 
            // c_valor
            // 
            this.c_valor.FillWeight = 93.27412F;
            this.c_valor.HeaderText = "Valor";
            this.c_valor.Name = "c_valor";
            this.c_valor.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 363);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.dgDatos);
            this.Controls.Add(this.txt_precio);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.txt_producto);
            this.Controls.Add(this.txt_codigo);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturación";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.TextBox txt_producto;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.DataGridView dgDatos;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_valor;
    }
}

