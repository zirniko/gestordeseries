namespace SeriesAnimeBBDD
{
    partial class Form5
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
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.btnModificarClasificacion = new System.Windows.Forms.Button();
            this.btnEliminarClasificacion = new System.Windows.Forms.Button();
            this.btnIngresarClasificacion = new System.Windows.Forms.Button();
            this.txtClasificacion = new System.Windows.Forms.TextBox();
            this.dgvClasificacion = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasificacion)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Location = new System.Drawing.Point(270, 17);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(75, 23);
            this.btnRefrescar.TabIndex = 20;
            this.btnRefrescar.Text = "refresh";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // btnModificarClasificacion
            // 
            this.btnModificarClasificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarClasificacion.Location = new System.Drawing.Point(91, 336);
            this.btnModificarClasificacion.Name = "btnModificarClasificacion";
            this.btnModificarClasificacion.Size = new System.Drawing.Size(181, 32);
            this.btnModificarClasificacion.TabIndex = 19;
            this.btnModificarClasificacion.Text = "Modificar Clasificación";
            this.btnModificarClasificacion.UseVisualStyleBackColor = true;
            this.btnModificarClasificacion.Click += new System.EventHandler(this.btnModificarClasificacion_Click);
            // 
            // btnEliminarClasificacion
            // 
            this.btnEliminarClasificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarClasificacion.Location = new System.Drawing.Point(437, 374);
            this.btnEliminarClasificacion.Name = "btnEliminarClasificacion";
            this.btnEliminarClasificacion.Size = new System.Drawing.Size(92, 33);
            this.btnEliminarClasificacion.TabIndex = 18;
            this.btnEliminarClasificacion.Text = "Eliminar";
            this.btnEliminarClasificacion.UseVisualStyleBackColor = true;
            this.btnEliminarClasificacion.Click += new System.EventHandler(this.btnEliminarClasificacion_Click);
            // 
            // btnIngresarClasificacion
            // 
            this.btnIngresarClasificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarClasificacion.Location = new System.Drawing.Point(234, 183);
            this.btnIngresarClasificacion.Name = "btnIngresarClasificacion";
            this.btnIngresarClasificacion.Size = new System.Drawing.Size(92, 33);
            this.btnIngresarClasificacion.TabIndex = 17;
            this.btnIngresarClasificacion.Text = "Ingresar";
            this.btnIngresarClasificacion.UseVisualStyleBackColor = true;
            this.btnIngresarClasificacion.Click += new System.EventHandler(this.btnIngresarClasificacion_Click);
            // 
            // txtClasificacion
            // 
            this.txtClasificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClasificacion.Location = new System.Drawing.Point(117, 150);
            this.txtClasificacion.Name = "txtClasificacion";
            this.txtClasificacion.Size = new System.Drawing.Size(224, 27);
            this.txtClasificacion.TabIndex = 16;
            // 
            // dgvClasificacion
            // 
            this.dgvClasificacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClasificacion.Location = new System.Drawing.Point(351, 17);
            this.dgvClasificacion.Name = "dgvClasificacion";
            this.dgvClasificacion.Size = new System.Drawing.Size(262, 351);
            this.dgvClasificacion.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 22);
            this.label1.TabIndex = 14;
            this.label1.Text = "Clasificación:";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 414);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.btnModificarClasificacion);
            this.Controls.Add(this.btnEliminarClasificacion);
            this.Controls.Add(this.btnIngresarClasificacion);
            this.Controls.Add(this.txtClasificacion);
            this.Controls.Add(this.dgvClasificacion);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasificacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Button btnModificarClasificacion;
        private System.Windows.Forms.Button btnEliminarClasificacion;
        private System.Windows.Forms.Button btnIngresarClasificacion;
        private System.Windows.Forms.TextBox txtClasificacion;
        private System.Windows.Forms.DataGridView dgvClasificacion;
        private System.Windows.Forms.Label label1;
    }
}