namespace Sesion17G3.Formularios
{
    partial class ProductoFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductoFrm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbPrecio = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.gbRegistros = new System.Windows.Forms.GroupBox();
            this.DvgRegistros = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.gbRegistros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DvgRegistros)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbPrecio);
            this.groupBox1.Controls.Add(this.tbDescripcion);
            this.groupBox1.Controls.Add(this.tbNombre);
            this.groupBox1.Controls.Add(this.tbID);
            this.groupBox1.Controls.Add(this.lbPrecio);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(522, 280);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Generales";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripcion:";
            // 
            // lbPrecio
            // 
            this.lbPrecio.AutoSize = true;
            this.lbPrecio.Location = new System.Drawing.Point(30, 254);
            this.lbPrecio.Name = "lbPrecio";
            this.lbPrecio.Size = new System.Drawing.Size(40, 13);
            this.lbPrecio.TabIndex = 3;
            this.lbPrecio.Text = "Precio:";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(77, 37);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(100, 20);
            this.tbID.TabIndex = 4;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(77, 69);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(100, 20);
            this.tbNombre.TabIndex = 5;
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Location = new System.Drawing.Point(77, 114);
            this.tbDescripcion.Multiline = true;
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDescripcion.Size = new System.Drawing.Size(424, 105);
            this.tbDescripcion.TabIndex = 6;
            // 
            // tbPrecio
            // 
            this.tbPrecio.Location = new System.Drawing.Point(77, 246);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(100, 20);
            this.tbPrecio.TabIndex = 7;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGuardar,
            this.btnEditar,
            this.btnEliminar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(813, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnGuardar
            // 
            this.btnGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(23, 22);
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(23, 22);
            this.btnEditar.Text = "Editar";
            // 
            // btnEliminar
            // 
            this.btnEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(23, 22);
            this.btnEliminar.Text = "Eliminar";
            // 
            // gbRegistros
            // 
            this.gbRegistros.Controls.Add(this.DvgRegistros);
            this.gbRegistros.Location = new System.Drawing.Point(21, 366);
            this.gbRegistros.Name = "gbRegistros";
            this.gbRegistros.Size = new System.Drawing.Size(522, 243);
            this.gbRegistros.TabIndex = 2;
            this.gbRegistros.TabStop = false;
            this.gbRegistros.Text = "Registros Guardados";
            // 
            // DvgRegistros
            // 
            this.DvgRegistros.AllowUserToAddRows = false;
            this.DvgRegistros.AllowUserToDeleteRows = false;
            this.DvgRegistros.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Uighur", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.DvgRegistros.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DvgRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DvgRegistros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DvgRegistros.Location = new System.Drawing.Point(3, 16);
            this.DvgRegistros.Name = "DvgRegistros";
            this.DvgRegistros.ReadOnly = true;
            this.DvgRegistros.Size = new System.Drawing.Size(516, 224);
            this.DvgRegistros.TabIndex = 0;
            // 
            // ProductoFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 737);
            this.Controls.Add(this.gbRegistros);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Name = "ProductoFrm";
            this.Text = "ProductoFrm";
            this.Load += new System.EventHandler(this.ProductoFrm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.gbRegistros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DvgRegistros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label lbPrecio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.GroupBox gbRegistros;
        private System.Windows.Forms.DataGridView DvgRegistros;
    }
}