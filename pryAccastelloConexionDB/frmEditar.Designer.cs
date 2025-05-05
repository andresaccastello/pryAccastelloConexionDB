namespace pryAccastelloConexionDB
{
    partial class frmEditar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditar));
            this.grbID = new System.Windows.Forms.GroupBox();
            this.numBuscarId = new System.Windows.Forms.NumericUpDown();
            this.lblID = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgvGrilla = new System.Windows.Forms.DataGridView();
            this.grbCarga = new System.Windows.Forms.GroupBox();
            this.numPrecio = new System.Windows.Forms.NumericUpDown();
            this.btnDesacer = new System.Windows.Forms.Button();
            this.numStock = new System.Windows.Forms.NumericUpDown();
            this.btnModificar = new System.Windows.Forms.Button();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.grbID.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBuscarId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).BeginInit();
            this.grbCarga.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStock)).BeginInit();
            this.SuspendLayout();
            // 
            // grbID
            // 
            this.grbID.BackColor = System.Drawing.SystemColors.Window;
            this.grbID.Controls.Add(this.numBuscarId);
            this.grbID.Controls.Add(this.lblID);
            this.grbID.Controls.Add(this.btnSalir);
            this.grbID.Location = new System.Drawing.Point(463, 7);
            this.grbID.Name = "grbID";
            this.grbID.Size = new System.Drawing.Size(200, 64);
            this.grbID.TabIndex = 23;
            this.grbID.TabStop = false;
            this.grbID.Text = "Buscar Producto";
            // 
            // numBuscarId
            // 
            this.numBuscarId.Location = new System.Drawing.Point(41, 27);
            this.numBuscarId.Name = "numBuscarId";
            this.numBuscarId.Size = new System.Drawing.Size(100, 20);
            this.numBuscarId.TabIndex = 21;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(17, 29);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 19;
            this.lblID.Text = "ID";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(147, 13);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(47, 45);
            this.btnSalir.TabIndex = 17;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgvGrilla
            // 
            this.dgvGrilla.AllowDrop = true;
            this.dgvGrilla.AllowUserToAddRows = false;
            this.dgvGrilla.AllowUserToDeleteRows = false;
            this.dgvGrilla.AllowUserToResizeColumns = false;
            this.dgvGrilla.AllowUserToResizeRows = false;
            this.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrilla.Location = new System.Drawing.Point(255, 78);
            this.dgvGrilla.MultiSelect = false;
            this.dgvGrilla.Name = "dgvGrilla";
            this.dgvGrilla.ReadOnly = true;
            this.dgvGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGrilla.Size = new System.Drawing.Size(637, 330);
            this.dgvGrilla.TabIndex = 22;
            this.dgvGrilla.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrilla_CellClick);
            // 
            // grbCarga
            // 
            this.grbCarga.BackColor = System.Drawing.SystemColors.Window;
            this.grbCarga.Controls.Add(this.numPrecio);
            this.grbCarga.Controls.Add(this.btnDesacer);
            this.grbCarga.Controls.Add(this.numStock);
            this.grbCarga.Controls.Add(this.btnModificar);
            this.grbCarga.Controls.Add(this.cmbCategoria);
            this.grbCarga.Controls.Add(this.lblCategoria);
            this.grbCarga.Controls.Add(this.btnEliminar);
            this.grbCarga.Controls.Add(this.lblStock);
            this.grbCarga.Controls.Add(this.lblPrecio);
            this.grbCarga.Controls.Add(this.lblDescripcion);
            this.grbCarga.Controls.Add(this.lblNombre);
            this.grbCarga.Controls.Add(this.txtNombre);
            this.grbCarga.Controls.Add(this.txtDescripcion);
            this.grbCarga.Location = new System.Drawing.Point(12, 20);
            this.grbCarga.Name = "grbCarga";
            this.grbCarga.Size = new System.Drawing.Size(200, 388);
            this.grbCarga.TabIndex = 21;
            this.grbCarga.TabStop = false;
            this.grbCarga.Text = "Cargar Datos";
            // 
            // numPrecio
            // 
            this.numPrecio.Location = new System.Drawing.Point(61, 81);
            this.numPrecio.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.numPrecio.Name = "numPrecio";
            this.numPrecio.Size = new System.Drawing.Size(133, 20);
            this.numPrecio.TabIndex = 16;
            // 
            // btnDesacer
            // 
            this.btnDesacer.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnDesacer.Image = ((System.Drawing.Image)(resources.GetObject("btnDesacer.Image")));
            this.btnDesacer.Location = new System.Drawing.Point(61, 327);
            this.btnDesacer.Name = "btnDesacer";
            this.btnDesacer.Size = new System.Drawing.Size(46, 45);
            this.btnDesacer.TabIndex = 16;
            this.btnDesacer.UseVisualStyleBackColor = false;
            this.btnDesacer.Click += new System.EventHandler(this.btnDesacer_Click);
            // 
            // numStock
            // 
            this.numStock.Location = new System.Drawing.Point(61, 108);
            this.numStock.Name = "numStock";
            this.numStock.Size = new System.Drawing.Size(133, 20);
            this.numStock.TabIndex = 15;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.SandyBrown;
            this.btnModificar.Enabled = false;
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnModificar.Location = new System.Drawing.Point(26, 196);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(142, 42);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(61, 133);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(133, 21);
            this.cmbCategoria.TabIndex = 14;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(-3, 136);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 13;
            this.lblCategoria.Text = "Categoria";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnEliminar.Location = new System.Drawing.Point(26, 268);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(142, 42);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(-3, 110);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(35, 13);
            this.lblStock.TabIndex = 12;
            this.lblStock.Text = "Stock";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(-3, 84);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 11;
            this.lblPrecio.Text = "Precio";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(-3, 58);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 10;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(-3, 32);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 9;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(61, 29);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(133, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(61, 55);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(133, 20);
            this.txtDescripcion.TabIndex = 5;
            // 
            // frmEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 475);
            this.Controls.Add(this.grbID);
            this.Controls.Add(this.dgvGrilla);
            this.Controls.Add(this.grbCarga);
            this.Name = "frmEditar";
            this.Text = "frmEditar";
            this.Load += new System.EventHandler(this.frmEditar_Load);
            this.grbID.ResumeLayout(false);
            this.grbID.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBuscarId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).EndInit();
            this.grbCarga.ResumeLayout(false);
            this.grbCarga.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbID;
        private System.Windows.Forms.NumericUpDown numBuscarId;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvGrilla;
        private System.Windows.Forms.GroupBox grbCarga;
        private System.Windows.Forms.NumericUpDown numPrecio;
        private System.Windows.Forms.Button btnDesacer;
        private System.Windows.Forms.NumericUpDown numStock;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
    }
}