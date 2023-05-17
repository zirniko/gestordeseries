namespace SeriesAnimeBBDD
{
    partial class Form4
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
            this.btnModificarAdaptacion = new System.Windows.Forms.Button();
            this.btnEliminarAdaptacion = new System.Windows.Forms.Button();
            this.btnIngresarAdaptacion = new System.Windows.Forms.Button();
            this.txtAdaptacion = new System.Windows.Forms.TextBox();
            this.dgvAdaptacion = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdaptacion)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Location = new System.Drawing.Point(267, 26);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(75, 23);
            this.btnRefrescar.TabIndex = 13;
            this.btnRefrescar.Text = "refresh";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // btnModificarAdaptacion
            // 
            this.btnModificarAdaptacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarAdaptacion.Location = new System.Drawing.Point(88, 345);
            this.btnModificarAdaptacion.Name = "btnModificarAdaptacion";
            this.btnModificarAdaptacion.Size = new System.Drawing.Size(171, 32);
            this.btnModificarAdaptacion.TabIndex = 12;
            this.btnModificarAdaptacion.Text = "Modificar Adaptación";
            this.btnModificarAdaptacion.UseVisualStyleBackColor = true;
            this.btnModificarAdaptacion.Click += new System.EventHandler(this.btnModificarAdaptacion_Click);
            // 
            // btnEliminarAdaptacion
            // 
            this.btnEliminarAdaptacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarAdaptacion.Location = new System.Drawing.Point(434, 383);
            this.btnEliminarAdaptacion.Name = "btnEliminarAdaptacion";
            this.btnEliminarAdaptacion.Size = new System.Drawing.Size(92, 33);
            this.btnEliminarAdaptacion.TabIndex = 11;
            this.btnEliminarAdaptacion.Text = "Eliminar";
            this.btnEliminarAdaptacion.UseVisualStyleBackColor = true;
            this.btnEliminarAdaptacion.Click += new System.EventHandler(this.btnEliminarAdaptacion_Click);
            // 
            // btnIngresarAdaptacion
            // 
            this.btnIngresarAdaptacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarAdaptacion.Location = new System.Drawing.Point(231, 192);
            this.btnIngresarAdaptacion.Name = "btnIngresarAdaptacion";
            this.btnIngresarAdaptacion.Size = new System.Drawing.Size(92, 33);
            this.btnIngresarAdaptacion.TabIndex = 10;
            this.btnIngresarAdaptacion.Text = "Ingresar";
            this.btnIngresarAdaptacion.UseVisualStyleBackColor = true;
            this.btnIngresarAdaptacion.Click += new System.EventHandler(this.btnIngresarAdaptacion_Click);
            // 
            // txtAdaptacion
            // 
            this.txtAdaptacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdaptacion.Location = new System.Drawing.Point(114, 159);
            this.txtAdaptacion.Name = "txtAdaptacion";
            this.txtAdaptacion.Size = new System.Drawing.Size(224, 27);
            this.txtAdaptacion.TabIndex = 9;
            // 
            // dgvAdaptacion
            // 
            this.dgvAdaptacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdaptacion.Location = new System.Drawing.Point(348, 26);
            this.dgvAdaptacion.Name = "dgvAdaptacion";
            this.dgvAdaptacion.Size = new System.Drawing.Size(262, 351);
            this.dgvAdaptacion.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Adaptacion:";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 425);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.btnModificarAdaptacion);
            this.Controls.Add(this.btnEliminarAdaptacion);
            this.Controls.Add(this.btnIngresarAdaptacion);
            this.Controls.Add(this.txtAdaptacion);
            this.Controls.Add(this.dgvAdaptacion);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdaptacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Button btnModificarAdaptacion;
        private System.Windows.Forms.Button btnEliminarAdaptacion;
        private System.Windows.Forms.Button btnIngresarAdaptacion;
        private System.Windows.Forms.TextBox txtAdaptacion;
        private System.Windows.Forms.DataGridView dgvAdaptacion;
        private System.Windows.Forms.Label label1;
    }
}