
namespace Facturacion
{
    partial class frm_participantes
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
            this.rbtn_nombre = new System.Windows.Forms.RadioButton();
            this.rbtn_apellido = new System.Windows.Forms.RadioButton();
            this.rbtn_direccion = new System.Windows.Forms.RadioButton();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgDatos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // rbtn_nombre
            // 
            this.rbtn_nombre.AutoSize = true;
            this.rbtn_nombre.Location = new System.Drawing.Point(28, 25);
            this.rbtn_nombre.Name = "rbtn_nombre";
            this.rbtn_nombre.Size = new System.Drawing.Size(81, 17);
            this.rbtn_nombre.TabIndex = 0;
            this.rbtn_nombre.TabStop = true;
            this.rbtn_nombre.Text = "Por Nombre";
            this.rbtn_nombre.UseVisualStyleBackColor = true;
            // 
            // rbtn_apellido
            // 
            this.rbtn_apellido.AutoSize = true;
            this.rbtn_apellido.Location = new System.Drawing.Point(119, 25);
            this.rbtn_apellido.Name = "rbtn_apellido";
            this.rbtn_apellido.Size = new System.Drawing.Size(81, 17);
            this.rbtn_apellido.TabIndex = 1;
            this.rbtn_apellido.TabStop = true;
            this.rbtn_apellido.Text = "Por Apellido";
            this.rbtn_apellido.UseVisualStyleBackColor = true;
            // 
            // rbtn_direccion
            // 
            this.rbtn_direccion.AutoSize = true;
            this.rbtn_direccion.Location = new System.Drawing.Point(210, 25);
            this.rbtn_direccion.Name = "rbtn_direccion";
            this.rbtn_direccion.Size = new System.Drawing.Size(89, 17);
            this.rbtn_direccion.TabIndex = 2;
            this.rbtn_direccion.TabStop = true;
            this.rbtn_direccion.Text = "Por Dirección";
            this.rbtn_direccion.UseVisualStyleBackColor = true;
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(394, 21);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(199, 20);
            this.txt_buscar.TabIndex = 3;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(599, 21);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 4;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(348, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Buscar";
            // 
            // dgDatos
            // 
            this.dgDatos.AllowUserToAddRows = false;
            this.dgDatos.AllowUserToDeleteRows = false;
            this.dgDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDatos.Location = new System.Drawing.Point(28, 60);
            this.dgDatos.Name = "dgDatos";
            this.dgDatos.ReadOnly = true;
            this.dgDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDatos.Size = new System.Drawing.Size(646, 306);
            this.dgDatos.TabIndex = 6;
            // 
            // frm_participantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 391);
            this.Controls.Add(this.dgDatos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.txt_buscar);
            this.Controls.Add(this.rbtn_direccion);
            this.Controls.Add(this.rbtn_apellido);
            this.Controls.Add(this.rbtn_nombre);
            this.Name = "frm_participantes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de participantes";
            this.Load += new System.EventHandler(this.frm_participantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtn_nombre;
        private System.Windows.Forms.RadioButton rbtn_apellido;
        private System.Windows.Forms.RadioButton rbtn_direccion;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgDatos;
    }
}