namespace BackpropagationAndPerceptron
{
    partial class Entrenamiento
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informaciónDelDesarrolladorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaTécnicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCargarDatos = new System.Windows.Forms.Button();
            this.BtnInicializarPU = new System.Windows.Forms.Button();
            this.BtnEntrenar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtNumeroIteraciones = new System.Windows.Forms.NumericUpDown();
            this.TxtErrorMaximoPermitido = new System.Windows.Forms.NumericUpDown();
            this.TxtRataAprendizaje = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnGuardarRed = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DtgCapas = new System.Windows.Forms.DataGridView();
            this.Capas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroNeuronas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FuncionActivacion = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.CbxFuncionActivacionCapaSalida = new System.Windows.Forms.ComboBox();
            this.TxtTipoRed = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DtgvDatos = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtNumeroCapas = new System.Windows.Forms.NumericUpDown();
            this.BtnConfigurar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lsterrores = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.GraficaComportamientoSalida = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.LabelEntradaSalidaPatrones = new System.Windows.Forms.Label();
            this.BtnSimular = new System.Windows.Forms.Button();
            this.LblResultados = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Menu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNumeroIteraciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtErrorMaximoPermitido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtRataAprendizaje)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgCapas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNumeroCapas)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GraficaComportamientoSalida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(1263, 24);
            this.Menu.TabIndex = 1;
            this.Menu.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
            this.inicioToolStripMenuItem.Click += new System.EventHandler(this.inicioToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informaciónDelDesarrolladorToolStripMenuItem,
            this.ayudaTécnicaToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            this.ayudaToolStripMenuItem.Click += new System.EventHandler(this.ayudaToolStripMenuItem_Click);
            // 
            // informaciónDelDesarrolladorToolStripMenuItem
            // 
            this.informaciónDelDesarrolladorToolStripMenuItem.Name = "informaciónDelDesarrolladorToolStripMenuItem";
            this.informaciónDelDesarrolladorToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.informaciónDelDesarrolladorToolStripMenuItem.Text = "Información del desarrollador";
            // 
            // ayudaTécnicaToolStripMenuItem
            // 
            this.ayudaTécnicaToolStripMenuItem.Name = "ayudaTécnicaToolStripMenuItem";
            this.ayudaTécnicaToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.ayudaTécnicaToolStripMenuItem.Text = "Ayuda técnica";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(495, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 55);
            this.label1.TabIndex = 2;
            this.label1.Text = "Entrenamiento";
            // 
            // BtnCargarDatos
            // 
            this.BtnCargarDatos.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCargarDatos.Location = new System.Drawing.Point(12, 89);
            this.BtnCargarDatos.Name = "BtnCargarDatos";
            this.BtnCargarDatos.Size = new System.Drawing.Size(128, 31);
            this.BtnCargarDatos.TabIndex = 5;
            this.BtnCargarDatos.Text = "Cargar datos";
            this.BtnCargarDatos.UseVisualStyleBackColor = true;
            this.BtnCargarDatos.Click += new System.EventHandler(this.BtnCargarDatos_Click);
            // 
            // BtnInicializarPU
            // 
            this.BtnInicializarPU.Enabled = false;
            this.BtnInicializarPU.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInicializarPU.Location = new System.Drawing.Point(505, 141);
            this.BtnInicializarPU.Name = "BtnInicializarPU";
            this.BtnInicializarPU.Size = new System.Drawing.Size(180, 24);
            this.BtnInicializarPU.TabIndex = 6;
            this.BtnInicializarPU.Text = "Inicializar pesos y umbrales";
            this.BtnInicializarPU.UseVisualStyleBackColor = true;
            this.BtnInicializarPU.Click += new System.EventHandler(this.BtnInicializarPU_Click);
            // 
            // BtnEntrenar
            // 
            this.BtnEntrenar.Enabled = false;
            this.BtnEntrenar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEntrenar.Location = new System.Drawing.Point(505, 227);
            this.BtnEntrenar.Name = "BtnEntrenar";
            this.BtnEntrenar.Size = new System.Drawing.Size(180, 23);
            this.BtnEntrenar.TabIndex = 7;
            this.BtnEntrenar.Text = "Entrenar";
            this.BtnEntrenar.UseVisualStyleBackColor = true;
            this.BtnEntrenar.Click += new System.EventHandler(this.BtnEntrenar_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.Location = new System.Drawing.Point(1046, 233);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(166, 24);
            this.BtnLimpiar.TabIndex = 8;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtNumeroIteraciones);
            this.groupBox1.Controls.Add(this.TxtErrorMaximoPermitido);
            this.groupBox1.Controls.Add(this.TxtRataAprendizaje);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(703, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 127);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parámetros de entrenamiento";
            // 
            // TxtNumeroIteraciones
            // 
            this.TxtNumeroIteraciones.Enabled = false;
            this.TxtNumeroIteraciones.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.TxtNumeroIteraciones.Location = new System.Drawing.Point(209, 21);
            this.TxtNumeroIteraciones.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.TxtNumeroIteraciones.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TxtNumeroIteraciones.Name = "TxtNumeroIteraciones";
            this.TxtNumeroIteraciones.Size = new System.Drawing.Size(98, 22);
            this.TxtNumeroIteraciones.TabIndex = 12;
            this.TxtNumeroIteraciones.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // TxtErrorMaximoPermitido
            // 
            this.TxtErrorMaximoPermitido.DecimalPlaces = 3;
            this.TxtErrorMaximoPermitido.Enabled = false;
            this.TxtErrorMaximoPermitido.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.TxtErrorMaximoPermitido.Location = new System.Drawing.Point(209, 90);
            this.TxtErrorMaximoPermitido.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            196608});
            this.TxtErrorMaximoPermitido.Name = "TxtErrorMaximoPermitido";
            this.TxtErrorMaximoPermitido.Size = new System.Drawing.Size(98, 22);
            this.TxtErrorMaximoPermitido.TabIndex = 11;
            // 
            // TxtRataAprendizaje
            // 
            this.TxtRataAprendizaje.DecimalPlaces = 1;
            this.TxtRataAprendizaje.Enabled = false;
            this.TxtRataAprendizaje.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.TxtRataAprendizaje.Location = new System.Drawing.Point(209, 57);
            this.TxtRataAprendizaje.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.TxtRataAprendizaje.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.TxtRataAprendizaje.Name = "TxtRataAprendizaje";
            this.TxtRataAprendizaje.Size = new System.Drawing.Size(98, 22);
            this.TxtRataAprendizaje.TabIndex = 13;
            this.TxtRataAprendizaje.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Error máximo permitido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Rata de aprendizaje: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Número de iteraciones: ";
            // 
            // BtnGuardarRed
            // 
            this.BtnGuardarRed.Enabled = false;
            this.BtnGuardarRed.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardarRed.Location = new System.Drawing.Point(1046, 141);
            this.BtnGuardarRed.Name = "BtnGuardarRed";
            this.BtnGuardarRed.Size = new System.Drawing.Size(166, 24);
            this.BtnGuardarRed.TabIndex = 10;
            this.BtnGuardarRed.Text = "Guardar red";
            this.BtnGuardarRed.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DtgCapas);
            this.groupBox2.Controls.Add(this.CbxFuncionActivacionCapaSalida);
            this.groupBox2.Controls.Add(this.TxtTipoRed);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.BtnAgregar);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.TxtNumeroCapas);
            this.groupBox2.Controls.Add(this.BtnConfigurar);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 261);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(454, 417);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Configuración de la red";
            // 
            // DtgCapas
            // 
            this.DtgCapas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgCapas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Capas,
            this.NumeroNeuronas,
            this.FuncionActivacion});
            this.DtgCapas.Location = new System.Drawing.Point(21, 123);
            this.DtgCapas.Name = "DtgCapas";
            this.DtgCapas.Size = new System.Drawing.Size(403, 220);
            this.DtgCapas.TabIndex = 34;
            this.DtgCapas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgCapas_CellContentClick);
            // 
            // Capas
            // 
            this.Capas.HeaderText = "Capas";
            this.Capas.Name = "Capas";
            this.Capas.ReadOnly = true;
            this.Capas.Width = 70;
            // 
            // NumeroNeuronas
            // 
            this.NumeroNeuronas.HeaderText = "# de Neuronas";
            this.NumeroNeuronas.Name = "NumeroNeuronas";
            this.NumeroNeuronas.Width = 140;
            // 
            // FuncionActivacion
            // 
            this.FuncionActivacion.HeaderText = "Funcion de activación";
            this.FuncionActivacion.Items.AddRange(new object[] {
            "Sigmoidal",
            "Gaussiana",
            "Sinusoidal"});
            this.FuncionActivacion.Name = "FuncionActivacion";
            this.FuncionActivacion.Width = 150;
            // 
            // CbxFuncionActivacionCapaSalida
            // 
            this.CbxFuncionActivacionCapaSalida.Enabled = false;
            this.CbxFuncionActivacionCapaSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxFuncionActivacionCapaSalida.FormattingEnabled = true;
            this.CbxFuncionActivacionCapaSalida.Items.AddRange(new object[] {
            "Sigmoidal",
            "Gaussiana",
            "Sinusoidal"});
            this.CbxFuncionActivacionCapaSalida.Location = new System.Drawing.Point(279, 352);
            this.CbxFuncionActivacionCapaSalida.Name = "CbxFuncionActivacionCapaSalida";
            this.CbxFuncionActivacionCapaSalida.Size = new System.Drawing.Size(145, 24);
            this.CbxFuncionActivacionCapaSalida.TabIndex = 20;
            this.CbxFuncionActivacionCapaSalida.Text = "Seleccionar";
            // 
            // TxtTipoRed
            // 
            this.TxtTipoRed.Enabled = false;
            this.TxtTipoRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTipoRed.FormattingEnabled = true;
            this.TxtTipoRed.Items.AddRange(new object[] {
            "Perceptrón Multicapa",
            "Backpropagation"});
            this.TxtTipoRed.Location = new System.Drawing.Point(200, 44);
            this.TxtTipoRed.Name = "TxtTipoRed";
            this.TxtTipoRed.Size = new System.Drawing.Size(224, 24);
            this.TxtTipoRed.TabIndex = 17;
            this.TxtTipoRed.Text = "Seleccionar";
            this.TxtTipoRed.SelectedIndexChanged += new System.EventHandler(this.TxtTipoRed_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 356);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "Función activación de la capa de salida";
            // 
            // DtgvDatos
            // 
            this.DtgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgvDatos.Enabled = false;
            this.DtgvDatos.Location = new System.Drawing.Point(12, 124);
            this.DtgvDatos.Name = "DtgvDatos";
            this.DtgvDatos.Size = new System.Drawing.Size(454, 133);
            this.DtgvDatos.TabIndex = 17;
            this.DtgvDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgvDatos_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Tipo de red";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Enabled = false;
            this.BtnAgregar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.Location = new System.Drawing.Point(231, 92);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(193, 25);
            this.BtnAgregar.TabIndex = 18;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Número de capas: ";
            // 
            // TxtNumeroCapas
            // 
            this.TxtNumeroCapas.Enabled = false;
            this.TxtNumeroCapas.Location = new System.Drawing.Point(163, 93);
            this.TxtNumeroCapas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TxtNumeroCapas.Name = "TxtNumeroCapas";
            this.TxtNumeroCapas.Size = new System.Drawing.Size(62, 22);
            this.TxtNumeroCapas.TabIndex = 14;
            this.TxtNumeroCapas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // BtnConfigurar
            // 
            this.BtnConfigurar.Enabled = false;
            this.BtnConfigurar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfigurar.Location = new System.Drawing.Point(21, 383);
            this.BtnConfigurar.Name = "BtnConfigurar";
            this.BtnConfigurar.Size = new System.Drawing.Size(403, 25);
            this.BtnConfigurar.TabIndex = 16;
            this.BtnConfigurar.Text = "Configurar";
            this.BtnConfigurar.UseVisualStyleBackColor = true;
            this.BtnConfigurar.Click += new System.EventHandler(this.BtnConfigurar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(109, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 26);
            this.label8.TabIndex = 37;
            this.label8.Text = "Comportamiento del Error \r\nrespecto a cada iteración";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(171, 334);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 15);
            this.label9.TabIndex = 35;
            this.label9.Text = "Error de iteraciones";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(419, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(186, 26);
            this.label10.TabIndex = 34;
            this.label10.Text = "Comportamiento de la salida obtenida \r\nrespecto a la deseada";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lsterrores
            // 
            this.lsterrores.Enabled = false;
            this.lsterrores.FormattingEnabled = true;
            this.lsterrores.Location = new System.Drawing.Point(343, 334);
            this.lsterrores.Name = "lsterrores";
            this.lsterrores.Size = new System.Drawing.Size(192, 30);
            this.lsterrores.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.GraficaComportamientoSalida);
            this.groupBox3.Controls.Add(this.chart1);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.lsterrores);
            this.groupBox3.Location = new System.Drawing.Point(505, 297);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(707, 381);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resultados del entrenamiento";
            // 
            // GraficaComportamientoSalida
            // 
            this.GraficaComportamientoSalida.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.GraficaComportamientoSalida.ChartAreas.Add(chartArea1);
            this.GraficaComportamientoSalida.Enabled = false;
            this.GraficaComportamientoSalida.Location = new System.Drawing.Point(375, 73);
            this.GraficaComportamientoSalida.Name = "GraficaComportamientoSalida";
            this.GraficaComportamientoSalida.Size = new System.Drawing.Size(309, 243);
            this.GraficaComportamientoSalida.TabIndex = 39;
            this.GraficaComportamientoSalida.Text = "GraficaComportamientoSalidas";
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Enabled = false;
            this.chart1.Location = new System.Drawing.Point(26, 73);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(328, 243);
            this.chart1.TabIndex = 38;
            this.chart1.Text = "GraficaComportamientoError";
            // 
            // LabelEntradaSalidaPatrones
            // 
            this.LabelEntradaSalidaPatrones.AutoSize = true;
            this.LabelEntradaSalidaPatrones.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEntradaSalidaPatrones.Location = new System.Drawing.Point(183, 97);
            this.LabelEntradaSalidaPatrones.Name = "LabelEntradaSalidaPatrones";
            this.LabelEntradaSalidaPatrones.Size = new System.Drawing.Size(0, 15);
            this.LabelEntradaSalidaPatrones.TabIndex = 18;
            // 
            // BtnSimular
            // 
            this.BtnSimular.Enabled = false;
            this.BtnSimular.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSimular.Location = new System.Drawing.Point(1046, 184);
            this.BtnSimular.Name = "BtnSimular";
            this.BtnSimular.Size = new System.Drawing.Size(166, 24);
            this.BtnSimular.TabIndex = 32;
            this.BtnSimular.Text = "Simular red";
            this.BtnSimular.UseVisualStyleBackColor = true;
            // 
            // LblResultados
            // 
            this.LblResultados.AutoSize = true;
            this.LblResultados.Location = new System.Drawing.Point(197, 91);
            this.LblResultados.Name = "LblResultados";
            this.LblResultados.Size = new System.Drawing.Size(0, 13);
            this.LblResultados.TabIndex = 33;
            // 
            // Entrenamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 728);
            this.Controls.Add(this.LblResultados);
            this.Controls.Add(this.BtnSimular);
            this.Controls.Add(this.LabelEntradaSalidaPatrones);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.DtgvDatos);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.BtnGuardarRed);
            this.Controls.Add(this.BtnInicializarPU);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnEntrenar);
            this.Controls.Add(this.BtnCargarDatos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Menu);
            this.Name = "Entrenamiento";
            this.Text = "Entrenamiento";
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNumeroIteraciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtErrorMaximoPermitido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtRataAprendizaje)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgCapas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNumeroCapas)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GraficaComportamientoSalida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informaciónDelDesarrolladorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaTécnicaToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCargarDatos;
        private System.Windows.Forms.Button BtnInicializarPU;
        private System.Windows.Forms.Button BtnEntrenar;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnGuardarRed;
        private System.Windows.Forms.NumericUpDown TxtNumeroIteraciones;
        private System.Windows.Forms.NumericUpDown TxtErrorMaximoPermitido;
        private System.Windows.Forms.NumericUpDown TxtRataAprendizaje;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown TxtNumeroCapas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnConfigurar;
        private System.Windows.Forms.DataGridView DtgvDatos;
        private System.Windows.Forms.ComboBox TxtTipoRed;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox lsterrores;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataVisualization.Charting.Chart GraficaComportamientoSalida;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label LabelEntradaSalidaPatrones;
        private System.Windows.Forms.Button BtnSimular;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Label LblResultados;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ComboBox CbxFuncionActivacionCapaSalida;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView DtgCapas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capas;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroNeuronas;
        private System.Windows.Forms.DataGridViewComboBoxColumn FuncionActivacion;
    }
}