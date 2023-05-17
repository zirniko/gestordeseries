namespace SeriesAnimeBBDD
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.btnIngresarAnime = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.dgvAnime = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbAdaptacion = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbClasificacion = new System.Windows.Forms.ComboBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nudEpisodios = new System.Windows.Forms.NumericUpDown();
            this.btnEliminarAnime = new System.Windows.Forms.Button();
            this.panelM = new System.Windows.Forms.Panel();
            this.lblID = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.nudEPISODIOSM = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFECHAM = new System.Windows.Forms.TextBox();
            this.cmbCLASIFICACIONM = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbGENEROM = new System.Windows.Forms.ComboBox();
            this.txtNOMBREM = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbADAPTACIONM = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.cbFiltro = new System.Windows.Forms.CheckBox();
            this.cmbG = new System.Windows.Forms.ComboBox();
            this.cmbA = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.panelFiltro = new System.Windows.Forms.Panel();
            this.pictureG = new System.Windows.Forms.PictureBox();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.cmbC = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.pictureA = new System.Windows.Forms.PictureBox();
            this.pictureC = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEpisodios)).BeginInit();
            this.panelM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEPISODIOSM)).BeginInit();
            this.panelFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureC)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Location = new System.Drawing.Point(829, 373);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(75, 23);
            this.btnRefrescar.TabIndex = 27;
            this.btnRefrescar.Text = "Reset";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // btnIngresarAnime
            // 
            this.btnIngresarAnime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarAnime.Location = new System.Drawing.Point(12, 50);
            this.btnIngresarAnime.Name = "btnIngresarAnime";
            this.btnIngresarAnime.Size = new System.Drawing.Size(76, 23);
            this.btnIngresarAnime.TabIndex = 24;
            this.btnIngresarAnime.Text = "Ingresar";
            this.btnIngresarAnime.UseVisualStyleBackColor = true;
            this.btnIngresarAnime.Click += new System.EventHandler(this.btnIngresarAnime_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(12, 23);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(130, 21);
            this.txtNombre.TabIndex = 23;
            // 
            // dgvAnime
            // 
            this.dgvAnime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnime.Location = new System.Drawing.Point(160, 67);
            this.dgvAnime.Name = "dgvAnime";
            this.dgvAnime.Size = new System.Drawing.Size(744, 300);
            this.dgvAnime.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(470, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 29;
            this.label2.Text = "Genero:";
            // 
            // cmbGenero
            // 
            this.cmbGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Location = new System.Drawing.Point(473, 23);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(112, 23);
            this.cmbGenero.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(614, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 31;
            this.label3.Text = "Adaptación:";
            // 
            // cmbAdaptacion
            // 
            this.cmbAdaptacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAdaptacion.FormattingEnabled = true;
            this.cmbAdaptacion.Location = new System.Drawing.Point(617, 23);
            this.cmbAdaptacion.Name = "cmbAdaptacion";
            this.cmbAdaptacion.Size = new System.Drawing.Size(112, 23);
            this.cmbAdaptacion.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(755, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 15);
            this.label4.TabIndex = 33;
            this.label4.Text = "Clasificación:";
            // 
            // cmbClasificacion
            // 
            this.cmbClasificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClasificacion.FormattingEnabled = true;
            this.cmbClasificacion.Location = new System.Drawing.Point(758, 23);
            this.cmbClasificacion.Name = "cmbClasificacion";
            this.cmbClasificacion.Size = new System.Drawing.Size(112, 23);
            this.cmbClasificacion.TabIndex = 32;
            // 
            // txtFecha
            // 
            this.txtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Location = new System.Drawing.Point(159, 23);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(130, 21);
            this.txtFecha.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(156, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 15);
            this.label5.TabIndex = 34;
            this.label5.Text = "Fecha emisión:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(311, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 15);
            this.label6.TabIndex = 36;
            this.label6.Text = "Episodios:";
            // 
            // nudEpisodios
            // 
            this.nudEpisodios.Location = new System.Drawing.Point(314, 24);
            this.nudEpisodios.Name = "nudEpisodios";
            this.nudEpisodios.Size = new System.Drawing.Size(120, 20);
            this.nudEpisodios.TabIndex = 37;
            // 
            // btnEliminarAnime
            // 
            this.btnEliminarAnime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarAnime.Location = new System.Drawing.Point(829, 402);
            this.btnEliminarAnime.Name = "btnEliminarAnime";
            this.btnEliminarAnime.Size = new System.Drawing.Size(71, 23);
            this.btnEliminarAnime.TabIndex = 38;
            this.btnEliminarAnime.Text = "Eliminar";
            this.btnEliminarAnime.UseVisualStyleBackColor = true;
            this.btnEliminarAnime.Click += new System.EventHandler(this.btnEliminarAnime_Click);
            // 
            // panelM
            // 
            this.panelM.Controls.Add(this.lblID);
            this.panelM.Controls.Add(this.label7);
            this.panelM.Controls.Add(this.btnActualizar);
            this.panelM.Controls.Add(this.nudEPISODIOSM);
            this.panelM.Controls.Add(this.label8);
            this.panelM.Controls.Add(this.label11);
            this.panelM.Controls.Add(this.label9);
            this.panelM.Controls.Add(this.txtFECHAM);
            this.panelM.Controls.Add(this.cmbCLASIFICACIONM);
            this.panelM.Controls.Add(this.label12);
            this.panelM.Controls.Add(this.cmbGENEROM);
            this.panelM.Controls.Add(this.txtNOMBREM);
            this.panelM.Controls.Add(this.label10);
            this.panelM.Controls.Add(this.label13);
            this.panelM.Controls.Add(this.cmbADAPTACIONM);
            this.panelM.Location = new System.Drawing.Point(160, 373);
            this.panelM.Name = "panelM";
            this.panelM.Size = new System.Drawing.Size(602, 94);
            this.panelM.TabIndex = 41;
            this.panelM.Visible = false;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(58, 21);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 13);
            this.lblID.TabIndex = 49;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "ID:";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(465, 55);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 43;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // nudEPISODIOSM
            // 
            this.nudEPISODIOSM.Location = new System.Drawing.Point(463, 22);
            this.nudEPISODIOSM.Name = "nudEPISODIOSM";
            this.nudEPISODIOSM.Size = new System.Drawing.Size(120, 20);
            this.nudEPISODIOSM.TabIndex = 47;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(313, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 15);
            this.label8.TabIndex = 47;
            this.label8.Text = "Clasificación:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(460, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 15);
            this.label11.TabIndex = 46;
            this.label11.Text = "Episodios:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(172, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 15);
            this.label9.TabIndex = 45;
            this.label9.Text = "Adaptación:";
            // 
            // txtFECHAM
            // 
            this.txtFECHAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFECHAM.Location = new System.Drawing.Point(308, 21);
            this.txtFECHAM.Name = "txtFECHAM";
            this.txtFECHAM.Size = new System.Drawing.Size(130, 21);
            this.txtFECHAM.TabIndex = 45;
            // 
            // cmbCLASIFICACIONM
            // 
            this.cmbCLASIFICACIONM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCLASIFICACIONM.FormattingEnabled = true;
            this.cmbCLASIFICACIONM.Location = new System.Drawing.Point(316, 65);
            this.cmbCLASIFICACIONM.Name = "cmbCLASIFICACIONM";
            this.cmbCLASIFICACIONM.Size = new System.Drawing.Size(112, 23);
            this.cmbCLASIFICACIONM.TabIndex = 46;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(305, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 15);
            this.label12.TabIndex = 44;
            this.label12.Text = "Fecha emisión:";
            // 
            // cmbGENEROM
            // 
            this.cmbGENEROM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGENEROM.FormattingEnabled = true;
            this.cmbGENEROM.Location = new System.Drawing.Point(31, 65);
            this.cmbGENEROM.Name = "cmbGENEROM";
            this.cmbGENEROM.Size = new System.Drawing.Size(112, 23);
            this.cmbGENEROM.TabIndex = 42;
            // 
            // txtNOMBREM
            // 
            this.txtNOMBREM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNOMBREM.Location = new System.Drawing.Point(161, 21);
            this.txtNOMBREM.Name = "txtNOMBREM";
            this.txtNOMBREM.Size = new System.Drawing.Size(130, 21);
            this.txtNOMBREM.TabIndex = 43;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(28, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 15);
            this.label10.TabIndex = 43;
            this.label10.Text = "Genero:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(159, 3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 15);
            this.label13.TabIndex = 42;
            this.label13.Text = "Nombre:";
            // 
            // cmbADAPTACIONM
            // 
            this.cmbADAPTACIONM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbADAPTACIONM.FormattingEnabled = true;
            this.cmbADAPTACIONM.Location = new System.Drawing.Point(175, 65);
            this.cmbADAPTACIONM.Name = "cmbADAPTACIONM";
            this.cmbADAPTACIONM.Size = new System.Drawing.Size(112, 23);
            this.cmbADAPTACIONM.TabIndex = 44;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(24, 396);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(87, 34);
            this.btnBuscar.TabIndex = 42;
            this.btnBuscar.Text = "Buscar para Modificar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(21, 98);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 13);
            this.label14.TabIndex = 43;
            this.label14.Text = "Filtro:";
            // 
            // cbFiltro
            // 
            this.cbFiltro.AutoSize = true;
            this.cbFiltro.Location = new System.Drawing.Point(69, 98);
            this.cbFiltro.Name = "cbFiltro";
            this.cbFiltro.Size = new System.Drawing.Size(15, 14);
            this.cbFiltro.TabIndex = 44;
            this.cbFiltro.UseVisualStyleBackColor = true;
            this.cbFiltro.CheckedChanged += new System.EventHandler(this.cbFiltro_CheckedChanged);
            // 
            // cmbG
            // 
            this.cmbG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbG.FormattingEnabled = true;
            this.cmbG.Location = new System.Drawing.Point(6, 38);
            this.cmbG.Name = "cmbG";
            this.cmbG.Size = new System.Drawing.Size(112, 23);
            this.cmbG.TabIndex = 46;
            // 
            // cmbA
            // 
            this.cmbA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbA.FormattingEnabled = true;
            this.cmbA.Location = new System.Drawing.Point(6, 92);
            this.cmbA.Name = "cmbA";
            this.cmbA.Size = new System.Drawing.Size(112, 23);
            this.cmbA.TabIndex = 46;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(3, 74);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 15);
            this.label16.TabIndex = 47;
            this.label16.Text = "Adaptación:";
            // 
            // panelFiltro
            // 
            this.panelFiltro.Controls.Add(this.pictureC);
            this.panelFiltro.Controls.Add(this.pictureA);
            this.panelFiltro.Controls.Add(this.pictureG);
            this.panelFiltro.Controls.Add(this.btnFiltro);
            this.panelFiltro.Controls.Add(this.label17);
            this.panelFiltro.Controls.Add(this.cmbC);
            this.panelFiltro.Controls.Add(this.label16);
            this.panelFiltro.Controls.Add(this.cmbA);
            this.panelFiltro.Controls.Add(this.label15);
            this.panelFiltro.Controls.Add(this.cmbG);
            this.panelFiltro.Location = new System.Drawing.Point(5, 118);
            this.panelFiltro.Name = "panelFiltro";
            this.panelFiltro.Size = new System.Drawing.Size(149, 261);
            this.panelFiltro.TabIndex = 45;
            this.panelFiltro.Visible = false;
            // 
            // pictureG
            // 
            this.pictureG.Image = ((System.Drawing.Image)(resources.GetObject("pictureG.Image")));
            this.pictureG.Location = new System.Drawing.Point(121, 38);
            this.pictureG.Name = "pictureG";
            this.pictureG.Size = new System.Drawing.Size(25, 23);
            this.pictureG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureG.TabIndex = 49;
            this.pictureG.TabStop = false;
            this.pictureG.Click += new System.EventHandler(this.pictureG_Click);
            // 
            // btnFiltro
            // 
            this.btnFiltro.Location = new System.Drawing.Point(31, 189);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(75, 23);
            this.btnFiltro.TabIndex = 48;
            this.btnFiltro.Text = "Filtrar";
            this.btnFiltro.UseVisualStyleBackColor = true;
            this.btnFiltro.Click += new System.EventHandler(this.button1_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(4, 132);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(79, 15);
            this.label17.TabIndex = 47;
            this.label17.Text = "Clasificación:";
            // 
            // cmbC
            // 
            this.cmbC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbC.FormattingEnabled = true;
            this.cmbC.Location = new System.Drawing.Point(7, 150);
            this.cmbC.Name = "cmbC";
            this.cmbC.Size = new System.Drawing.Size(112, 23);
            this.cmbC.TabIndex = 46;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(5, 20);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 15);
            this.label15.TabIndex = 47;
            this.label15.Text = "Genero:";
            // 
            // pictureA
            // 
            this.pictureA.Image = ((System.Drawing.Image)(resources.GetObject("pictureA.Image")));
            this.pictureA.Location = new System.Drawing.Point(121, 92);
            this.pictureA.Name = "pictureA";
            this.pictureA.Size = new System.Drawing.Size(25, 23);
            this.pictureA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureA.TabIndex = 50;
            this.pictureA.TabStop = false;
            this.pictureA.Click += new System.EventHandler(this.pictureA_Click);
            // 
            // pictureC
            // 
            this.pictureC.Image = ((System.Drawing.Image)(resources.GetObject("pictureC.Image")));
            this.pictureC.Location = new System.Drawing.Point(121, 150);
            this.pictureC.Name = "pictureC";
            this.pictureC.Size = new System.Drawing.Size(25, 23);
            this.pictureC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureC.TabIndex = 51;
            this.pictureC.TabStop = false;
            this.pictureC.Click += new System.EventHandler(this.pictureC_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 476);
            this.Controls.Add(this.panelFiltro);
            this.Controls.Add(this.cbFiltro);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.panelM);
            this.Controls.Add(this.btnEliminarAnime);
            this.Controls.Add(this.nudEpisodios);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbClasificacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbAdaptacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbGenero);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.btnIngresarAnime);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.dgvAnime);
            this.Controls.Add(this.label1);
            this.Name = "Form6";
            this.Text = "Form6";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEpisodios)).EndInit();
            this.panelM.ResumeLayout(false);
            this.panelM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEPISODIOSM)).EndInit();
            this.panelFiltro.ResumeLayout(false);
            this.panelFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Button btnIngresarAnime;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DataGridView dgvAnime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbAdaptacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbClasificacion;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudEpisodios;
        private System.Windows.Forms.Button btnEliminarAnime;
        private System.Windows.Forms.Panel panelM;
        private System.Windows.Forms.NumericUpDown nudEPISODIOSM;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtFECHAM;
        private System.Windows.Forms.ComboBox cmbCLASIFICACIONM;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbGENEROM;
        private System.Windows.Forms.TextBox txtNOMBREM;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbADAPTACIONM;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox cbFiltro;
        private System.Windows.Forms.ComboBox cmbG;
        private System.Windows.Forms.ComboBox cmbA;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panelFiltro;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cmbC;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnFiltro;
        private System.Windows.Forms.PictureBox pictureG;
        private System.Windows.Forms.PictureBox pictureC;
        private System.Windows.Forms.PictureBox pictureA;
    }
}