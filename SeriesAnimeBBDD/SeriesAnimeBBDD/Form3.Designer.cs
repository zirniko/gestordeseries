namespace SeriesAnimeBBDD
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvGenero = new System.Windows.Forms.DataGridView();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.btnIngresarGenero = new System.Windows.Forms.Button();
            this.btnEliminarGenero = new System.Windows.Forms.Button();
            this.btnModificarGenero = new System.Windows.Forms.Button();
            this.btnRefrescar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenero)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Genero:";
            // 
            // dgvGenero
            // 
            this.dgvGenero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGenero.Location = new System.Drawing.Point(342, 12);
            this.dgvGenero.Name = "dgvGenero";
            this.dgvGenero.Size = new System.Drawing.Size(262, 351);
            this.dgvGenero.TabIndex = 1;
            // 
            // txtGenero
            // 
            this.txtGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGenero.Location = new System.Drawing.Point(93, 145);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(224, 27);
            this.txtGenero.TabIndex = 2;
            this.txtGenero.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnIngresarGenero
            // 
            this.btnIngresarGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarGenero.Location = new System.Drawing.Point(225, 178);
            this.btnIngresarGenero.Name = "btnIngresarGenero";
            this.btnIngresarGenero.Size = new System.Drawing.Size(92, 33);
            this.btnIngresarGenero.TabIndex = 3;
            this.btnIngresarGenero.Text = "Ingresar";
            this.btnIngresarGenero.UseVisualStyleBackColor = true;
            this.btnIngresarGenero.Click += new System.EventHandler(this.btnIngresarGenero_Click);
            // 
            // btnEliminarGenero
            // 
            this.btnEliminarGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarGenero.Location = new System.Drawing.Point(428, 369);
            this.btnEliminarGenero.Name = "btnEliminarGenero";
            this.btnEliminarGenero.Size = new System.Drawing.Size(92, 33);
            this.btnEliminarGenero.TabIndex = 4;
            this.btnEliminarGenero.Text = "Eliminar";
            this.btnEliminarGenero.UseVisualStyleBackColor = true;
            this.btnEliminarGenero.Click += new System.EventHandler(this.btnEliminarGenero_Click);
            // 
            // btnModificarGenero
            // 
            this.btnModificarGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarGenero.Location = new System.Drawing.Point(93, 282);
            this.btnModificarGenero.Name = "btnModificarGenero";
            this.btnModificarGenero.Size = new System.Drawing.Size(155, 32);
            this.btnModificarGenero.TabIndex = 5;
            this.btnModificarGenero.Text = "Modificar Genero";
            this.btnModificarGenero.UseVisualStyleBackColor = true;
            this.btnModificarGenero.Click += new System.EventHandler(this.btnModificarGenero_Click);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Location = new System.Drawing.Point(261, 12);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(75, 23);
            this.btnRefrescar.TabIndex = 6;
            this.btnRefrescar.Text = "refresh";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 414);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.btnModificarGenero);
            this.Controls.Add(this.btnEliminarGenero);
            this.Controls.Add(this.btnIngresarGenero);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.dgvGenero);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvGenero;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.Button btnIngresarGenero;
        private System.Windows.Forms.Button btnEliminarGenero;
        private System.Windows.Forms.Button btnModificarGenero;
        private System.Windows.Forms.Button btnRefrescar;
    }
}