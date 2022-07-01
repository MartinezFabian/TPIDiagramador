namespace TPIDiagramador
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarComoJSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarComoJPGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarTodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirAyudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flechadoble = new System.Windows.Forms.Button();
            this.flecha = new System.Windows.Forms.Button();
            this.linea = new System.Windows.Forms.Button();
            this.circulo = new System.Windows.Forms.Button();
            this.boton_rectangulo = new System.Windows.Forms.Button();
            this.panel_diagrama = new System.Windows.Forms.Panel();
            this.pic = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.moverLineaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarLineaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.menu.SuspendLayout();
            this.panel_diagrama.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1008, 31);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.guardarComoJSONToolStripMenuItem,
            this.guardarComoJPGToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(79, 27);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(223, 28);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // guardarComoJSONToolStripMenuItem
            // 
            this.guardarComoJSONToolStripMenuItem.Name = "guardarComoJSONToolStripMenuItem";
            this.guardarComoJSONToolStripMenuItem.Size = new System.Drawing.Size(223, 28);
            this.guardarComoJSONToolStripMenuItem.Text = "Guardar Proyecto";
            this.guardarComoJSONToolStripMenuItem.Click += new System.EventHandler(this.guardarComoJSONToolStripMenuItem_Click);
            // 
            // guardarComoJPGToolStripMenuItem
            // 
            this.guardarComoJPGToolStripMenuItem.Name = "guardarComoJPGToolStripMenuItem";
            this.guardarComoJPGToolStripMenuItem.Size = new System.Drawing.Size(223, 28);
            this.guardarComoJPGToolStripMenuItem.Text = "Guardar como JPG";
            this.guardarComoJPGToolStripMenuItem.Click += new System.EventHandler(this.guardarComoJPGToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.borrarTodoToolStripMenuItem});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(66, 27);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // borrarTodoToolStripMenuItem
            // 
            this.borrarTodoToolStripMenuItem.Name = "borrarTodoToolStripMenuItem";
            this.borrarTodoToolStripMenuItem.Size = new System.Drawing.Size(180, 28);
            this.borrarTodoToolStripMenuItem.Text = "Borrar todo";
            this.borrarTodoToolStripMenuItem.Click += new System.EventHandler(this.borrarTodoToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirAyudaToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(70, 27);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // abrirAyudaToolStripMenuItem
            // 
            this.abrirAyudaToolStripMenuItem.Name = "abrirAyudaToolStripMenuItem";
            this.abrirAyudaToolStripMenuItem.Size = new System.Drawing.Size(180, 28);
            this.abrirAyudaToolStripMenuItem.Text = "Abrir Ayuda";
            this.abrirAyudaToolStripMenuItem.Click += new System.EventHandler(this.abrirAyudaToolStripMenuItem_Click);
            // 
            // flechadoble
            // 
            this.flechadoble.BackColor = System.Drawing.Color.White;
            this.flechadoble.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flechadoble.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flechadoble.Image = global::TPIDiagramador.Properties.Resources.flechadoble;
            this.flechadoble.Location = new System.Drawing.Point(3, 551);
            this.flechadoble.Name = "flechadoble";
            this.flechadoble.Size = new System.Drawing.Size(139, 135);
            this.flechadoble.TabIndex = 6;
            this.flechadoble.UseVisualStyleBackColor = false;
            this.flechadoble.Click += new System.EventHandler(this.flechadoble_Click);
            // 
            // flecha
            // 
            this.flecha.BackColor = System.Drawing.Color.White;
            this.flecha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flecha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flecha.Image = global::TPIDiagramador.Properties.Resources.flecha;
            this.flecha.Location = new System.Drawing.Point(3, 414);
            this.flecha.Name = "flecha";
            this.flecha.Size = new System.Drawing.Size(139, 131);
            this.flecha.TabIndex = 5;
            this.flecha.UseVisualStyleBackColor = false;
            this.flecha.Click += new System.EventHandler(this.flecha_Click);
            // 
            // linea
            // 
            this.linea.BackColor = System.Drawing.Color.White;
            this.linea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linea.Image = global::TPIDiagramador.Properties.Resources.linea;
            this.linea.Location = new System.Drawing.Point(3, 277);
            this.linea.Name = "linea";
            this.linea.Size = new System.Drawing.Size(139, 131);
            this.linea.TabIndex = 4;
            this.linea.UseVisualStyleBackColor = false;
            this.linea.Click += new System.EventHandler(this.linea_Click);
            // 
            // circulo
            // 
            this.circulo.BackColor = System.Drawing.Color.White;
            this.circulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.circulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.circulo.Image = global::TPIDiagramador.Properties.Resources.circulo;
            this.circulo.Location = new System.Drawing.Point(3, 140);
            this.circulo.Name = "circulo";
            this.circulo.Size = new System.Drawing.Size(139, 131);
            this.circulo.TabIndex = 3;
            this.circulo.UseVisualStyleBackColor = false;
            this.circulo.Click += new System.EventHandler(this.circulo_Click);
            // 
            // boton_rectangulo
            // 
            this.boton_rectangulo.BackColor = System.Drawing.Color.White;
            this.boton_rectangulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boton_rectangulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boton_rectangulo.Image = global::TPIDiagramador.Properties.Resources.rectangulo;
            this.boton_rectangulo.Location = new System.Drawing.Point(3, 3);
            this.boton_rectangulo.Name = "boton_rectangulo";
            this.boton_rectangulo.Size = new System.Drawing.Size(139, 131);
            this.boton_rectangulo.TabIndex = 2;
            this.boton_rectangulo.UseVisualStyleBackColor = false;
            this.boton_rectangulo.Click += new System.EventHandler(this.button_rectangulo_Click);
            // 
            // panel_diagrama
            // 
            this.panel_diagrama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_diagrama.Controls.Add(this.pic);
            this.panel_diagrama.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_diagrama.Location = new System.Drawing.Point(154, 3);
            this.panel_diagrama.Name = "panel_diagrama";
            this.panel_diagrama.Size = new System.Drawing.Size(851, 689);
            this.panel_diagrama.TabIndex = 0;
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.Color.White;
            this.pic.ContextMenuStrip = this.contextMenuStrip1;
            this.pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic.Location = new System.Drawing.Point(0, 0);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(849, 687);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic.TabIndex = 0;
            this.pic.TabStop = false;
            this.pic.Paint += new System.Windows.Forms.PaintEventHandler(this.pic_Paint);
            this.pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_MouseDown);
            this.pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_MouseMove);
            this.pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_MouseUp);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moverLineaToolStripMenuItem,
            this.eliminarLineaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(187, 60);
            // 
            // moverLineaToolStripMenuItem
            // 
            this.moverLineaToolStripMenuItem.Name = "moverLineaToolStripMenuItem";
            this.moverLineaToolStripMenuItem.Size = new System.Drawing.Size(186, 28);
            this.moverLineaToolStripMenuItem.Text = "Mover Linea";
            this.moverLineaToolStripMenuItem.Click += new System.EventHandler(this.moverLineaToolStripMenuItem_Click);
            // 
            // eliminarLineaToolStripMenuItem
            // 
            this.eliminarLineaToolStripMenuItem.Name = "eliminarLineaToolStripMenuItem";
            this.eliminarLineaToolStripMenuItem.Size = new System.Drawing.Size(186, 28);
            this.eliminarLineaToolStripMenuItem.Text = "Eliminar Linea";
            this.eliminarLineaToolStripMenuItem.Click += new System.EventHandler(this.eliminarLineaToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.Controls.Add(this.panel_diagrama, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 31);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1008, 695);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.flechadoble, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.boton_rectangulo, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.flecha, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.circulo, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.linea, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(145, 689);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1008, 726);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menu;
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diagramador.NET";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.panel_diagrama.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarComoJPGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarComoJSONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.Panel panel_diagrama;
        private System.Windows.Forms.Button flechadoble;
        private System.Windows.Forms.Button flecha;
        private System.Windows.Forms.Button linea;
        private System.Windows.Forms.Button circulo;
        private System.Windows.Forms.Button boton_rectangulo;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.ToolStripMenuItem borrarTodoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem moverLineaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarLineaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirAyudaToolStripMenuItem;
    }
}

