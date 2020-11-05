namespace BackpropagationAndPerceptron
{
    partial class Simulacion
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
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informaciónDelDesarrolladorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaTécnicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.BtnCargarUmbrales = new System.Windows.Forms.Button();
            this.BtnCargarPesos = new System.Windows.Forms.Button();
            this.BtnSimular = new System.Windows.Forms.Button();
            this.Menu.SuspendLayout();
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
            this.Menu.Size = new System.Drawing.Size(899, 24);
            this.Menu.TabIndex = 0;
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
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(336, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "Simulación";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(273, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo de red a simular";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Perceptrón Multicapa",
            "Backpropagation"});
            this.comboBox1.Location = new System.Drawing.Point(466, 106);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(158, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // BtnCargarUmbrales
            // 
            this.BtnCargarUmbrales.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCargarUmbrales.Location = new System.Drawing.Point(43, 192);
            this.BtnCargarUmbrales.Name = "BtnCargarUmbrales";
            this.BtnCargarUmbrales.Size = new System.Drawing.Size(137, 35);
            this.BtnCargarUmbrales.TabIndex = 4;
            this.BtnCargarUmbrales.Text = "Cargar Umbrales";
            this.BtnCargarUmbrales.UseVisualStyleBackColor = true;
            // 
            // BtnCargarPesos
            // 
            this.BtnCargarPesos.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCargarPesos.Location = new System.Drawing.Point(43, 233);
            this.BtnCargarPesos.Name = "BtnCargarPesos";
            this.BtnCargarPesos.Size = new System.Drawing.Size(137, 35);
            this.BtnCargarPesos.TabIndex = 5;
            this.BtnCargarPesos.Text = "Cargar Pesos";
            this.BtnCargarPesos.UseVisualStyleBackColor = true;
            // 
            // BtnSimular
            // 
            this.BtnSimular.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSimular.Location = new System.Drawing.Point(43, 274);
            this.BtnSimular.Name = "BtnSimular";
            this.BtnSimular.Size = new System.Drawing.Size(137, 35);
            this.BtnSimular.TabIndex = 6;
            this.BtnSimular.Text = "Simular";
            this.BtnSimular.UseVisualStyleBackColor = true;
            // 
            // Simulacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 450);
            this.Controls.Add(this.BtnSimular);
            this.Controls.Add(this.BtnCargarPesos);
            this.Controls.Add(this.BtnCargarUmbrales);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Menu);
            this.MainMenuStrip = this.Menu;
            this.Name = "Simulacion";
            this.Text = "Simulacion";
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button BtnCargarUmbrales;
        private System.Windows.Forms.Button BtnCargarPesos;
        private System.Windows.Forms.Button BtnSimular;
    }
}