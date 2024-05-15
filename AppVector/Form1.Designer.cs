namespace AppVector
{
    partial class Frmvectores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmvectores));
            this.lbvalor = new System.Windows.Forms.Label();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.btnadicionar = new System.Windows.Forms.Button();
            this.lbresultado = new System.Windows.Forms.Label();
            this.btnmostrar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.basicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invertirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avanzadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cantidaddeParesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenarMenorAmayorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarElementoPosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invertirVectorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contarNCapicuaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contarNPrimosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbvalor
            // 
            this.lbvalor.AutoSize = true;
            this.lbvalor.Location = new System.Drawing.Point(78, 63);
            this.lbvalor.Name = "lbvalor";
            this.lbvalor.Size = new System.Drawing.Size(31, 13);
            this.lbvalor.TabIndex = 0;
            this.lbvalor.Text = "Valor";
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(139, 56);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(100, 20);
            this.txtvalor.TabIndex = 1;
            // 
            // btnadicionar
            // 
            this.btnadicionar.Image = ((System.Drawing.Image)(resources.GetObject("btnadicionar.Image")));
            this.btnadicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnadicionar.Location = new System.Drawing.Point(262, 45);
            this.btnadicionar.Name = "btnadicionar";
            this.btnadicionar.Size = new System.Drawing.Size(111, 48);
            this.btnadicionar.TabIndex = 2;
            this.btnadicionar.Text = "Adicionar";
            this.btnadicionar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnadicionar.UseVisualStyleBackColor = true;
            this.btnadicionar.Click += new System.EventHandler(this.btnadicionar_Click);
            // 
            // lbresultado
            // 
            this.lbresultado.AutoSize = true;
            this.lbresultado.Location = new System.Drawing.Point(73, 107);
            this.lbresultado.Name = "lbresultado";
            this.lbresultado.Size = new System.Drawing.Size(55, 13);
            this.lbresultado.TabIndex = 3;
            this.lbresultado.Text = "Resultado";
            // 
            // btnmostrar
            // 
            this.btnmostrar.Location = new System.Drawing.Point(76, 133);
            this.btnmostrar.Name = "btnmostrar";
            this.btnmostrar.Size = new System.Drawing.Size(75, 23);
            this.btnmostrar.TabIndex = 4;
            this.btnmostrar.Text = "Mostrar";
            this.btnmostrar.UseVisualStyleBackColor = true;
            this.btnmostrar.Click += new System.EventHandler(this.btnmostrar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.basicaToolStripMenuItem,
            this.invertirToolStripMenuItem,
            this.avanzadoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(737, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // basicaToolStripMenuItem
            // 
            this.basicaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarToolStripMenuItem,
            this.mostrarToolStripMenuItem});
            this.basicaToolStripMenuItem.Name = "basicaToolStripMenuItem";
            this.basicaToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.basicaToolStripMenuItem.Text = "Basica";
            // 
            // adicionarToolStripMenuItem
            // 
            this.adicionarToolStripMenuItem.Name = "adicionarToolStripMenuItem";
            this.adicionarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.adicionarToolStripMenuItem.Text = "Adicionar";
            this.adicionarToolStripMenuItem.Click += new System.EventHandler(this.adicionarToolStripMenuItem_Click);
            // 
            // mostrarToolStripMenuItem
            // 
            this.mostrarToolStripMenuItem.Name = "mostrarToolStripMenuItem";
            this.mostrarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.mostrarToolStripMenuItem.Text = "Mostrar";
            this.mostrarToolStripMenuItem.Click += new System.EventHandler(this.mostrarToolStripMenuItem_Click);
            // 
            // invertirToolStripMenuItem
            // 
            this.invertirToolStripMenuItem.Name = "invertirToolStripMenuItem";
            this.invertirToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.invertirToolStripMenuItem.Text = "invertir";
            this.invertirToolStripMenuItem.Click += new System.EventHandler(this.invertirToolStripMenuItem_Click);
            // 
            // avanzadoToolStripMenuItem
            // 
            this.avanzadoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cantidaddeParesToolStripMenuItem,
            this.ordenarMenorAmayorToolStripMenuItem,
            this.eliminarElementoPosToolStripMenuItem,
            this.invertirVectorToolStripMenuItem,
            this.contarNCapicuaToolStripMenuItem,
            this.contarNPrimosToolStripMenuItem});
            this.avanzadoToolStripMenuItem.Name = "avanzadoToolStripMenuItem";
            this.avanzadoToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.avanzadoToolStripMenuItem.Text = "Avanzado";
            // 
            // cantidaddeParesToolStripMenuItem
            // 
            this.cantidaddeParesToolStripMenuItem.Name = "cantidaddeParesToolStripMenuItem";
            this.cantidaddeParesToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.cantidaddeParesToolStripMenuItem.Text = "CantidaddePares";
            this.cantidaddeParesToolStripMenuItem.Click += new System.EventHandler(this.cantidaddeParesToolStripMenuItem_Click);
            // 
            // ordenarMenorAmayorToolStripMenuItem
            // 
            this.ordenarMenorAmayorToolStripMenuItem.Name = "ordenarMenorAmayorToolStripMenuItem";
            this.ordenarMenorAmayorToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.ordenarMenorAmayorToolStripMenuItem.Text = "OrdenarMenorAmayor";
            this.ordenarMenorAmayorToolStripMenuItem.Click += new System.EventHandler(this.ordenarMenorAmayorToolStripMenuItem_Click);
            // 
            // eliminarElementoPosToolStripMenuItem
            // 
            this.eliminarElementoPosToolStripMenuItem.Name = "eliminarElementoPosToolStripMenuItem";
            this.eliminarElementoPosToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.eliminarElementoPosToolStripMenuItem.Text = "Eliminar Elemento Pos";
            this.eliminarElementoPosToolStripMenuItem.Click += new System.EventHandler(this.eliminarElementoPosToolStripMenuItem_Click);
            // 
            // invertirVectorToolStripMenuItem
            // 
            this.invertirVectorToolStripMenuItem.Name = "invertirVectorToolStripMenuItem";
            this.invertirVectorToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.invertirVectorToolStripMenuItem.Text = "Invertir Vector";
            this.invertirVectorToolStripMenuItem.Click += new System.EventHandler(this.invertirVectorToolStripMenuItem_Click);
            // 
            // contarNCapicuaToolStripMenuItem
            // 
            this.contarNCapicuaToolStripMenuItem.Name = "contarNCapicuaToolStripMenuItem";
            this.contarNCapicuaToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.contarNCapicuaToolStripMenuItem.Text = "Contar N. Capicua";
            this.contarNCapicuaToolStripMenuItem.Click += new System.EventHandler(this.contarNCapicuaToolStripMenuItem_Click);
            // 
            // contarNPrimosToolStripMenuItem
            // 
            this.contarNPrimosToolStripMenuItem.Name = "contarNPrimosToolStripMenuItem";
            this.contarNPrimosToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.contarNPrimosToolStripMenuItem.Text = "Contar N. Primos";
            this.contarNPrimosToolStripMenuItem.Click += new System.EventHandler(this.contarNPrimosToolStripMenuItem_Click);
            // 
            // Frmvectores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(737, 349);
            this.Controls.Add(this.btnmostrar);
            this.Controls.Add(this.lbresultado);
            this.Controls.Add(this.btnadicionar);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.lbvalor);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frmvectores";
            this.Text = "Vectores";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbvalor;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.Button btnadicionar;
        private System.Windows.Forms.Label lbresultado;
        private System.Windows.Forms.Button btnmostrar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem basicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invertirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avanzadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cantidaddeParesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenarMenorAmayorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarElementoPosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invertirVectorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contarNCapicuaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contarNPrimosToolStripMenuItem;
    }
}

