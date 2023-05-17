namespace SeriesAnimeBBDD
{
    partial class Form2
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
            this.btnGenero = new System.Windows.Forms.Button();
            this.btnClasificacion = new System.Windows.Forms.Button();
            this.btnAdaptacion = new System.Windows.Forms.Button();
            this.btnAnime = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGenero
            // 
            this.btnGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenero.Location = new System.Drawing.Point(48, 47);
            this.btnGenero.Name = "btnGenero";
            this.btnGenero.Size = new System.Drawing.Size(95, 28);
            this.btnGenero.TabIndex = 0;
            this.btnGenero.Text = "Genero";
            this.btnGenero.UseVisualStyleBackColor = true;
            this.btnGenero.Click += new System.EventHandler(this.btnGenero_Click);
            // 
            // btnClasificacion
            // 
            this.btnClasificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClasificacion.Location = new System.Drawing.Point(361, 47);
            this.btnClasificacion.Name = "btnClasificacion";
            this.btnClasificacion.Size = new System.Drawing.Size(102, 28);
            this.btnClasificacion.TabIndex = 1;
            this.btnClasificacion.Text = "Clasificación";
            this.btnClasificacion.UseVisualStyleBackColor = true;
            this.btnClasificacion.Click += new System.EventHandler(this.btnClasificacion_Click);
            // 
            // btnAdaptacion
            // 
            this.btnAdaptacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdaptacion.Location = new System.Drawing.Point(206, 47);
            this.btnAdaptacion.Name = "btnAdaptacion";
            this.btnAdaptacion.Size = new System.Drawing.Size(95, 28);
            this.btnAdaptacion.TabIndex = 2;
            this.btnAdaptacion.Text = "Adaptación";
            this.btnAdaptacion.UseVisualStyleBackColor = true;
            this.btnAdaptacion.Click += new System.EventHandler(this.btnAdaptacion_Click);
            // 
            // btnAnime
            // 
            this.btnAnime.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnime.Location = new System.Drawing.Point(146, 126);
            this.btnAnime.Name = "btnAnime";
            this.btnAnime.Size = new System.Drawing.Size(219, 48);
            this.btnAnime.TabIndex = 3;
            this.btnAnime.Text = "Anime";
            this.btnAnime.UseVisualStyleBackColor = true;
            this.btnAnime.Click += new System.EventHandler(this.btnAnime_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 224);
            this.Controls.Add(this.btnAnime);
            this.Controls.Add(this.btnAdaptacion);
            this.Controls.Add(this.btnClasificacion);
            this.Controls.Add(this.btnGenero);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenero;
        private System.Windows.Forms.Button btnClasificacion;
        private System.Windows.Forms.Button btnAdaptacion;
        private System.Windows.Forms.Button btnAnime;
    }
}