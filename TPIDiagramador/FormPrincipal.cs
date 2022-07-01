using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;
using System.Drawing.Drawing2D;

namespace TPIDiagramador
{
    public partial class FormPrincipal : Form
    {
        Bitmap bitmap;
        Graphics graphics;

        private List<Linea> lineas = new List<Linea>();
        public Point mouseDownLocacion;
        private bool mouseDown = false;
        private int inicioX;
        private int inicioY;
        private int finX;
        private int finY;
        private string seleccionUsuario;
        Point point1 = new Point();
        Point point2 = new Point();
        Point comienzoDownLocation = new Point();

        List<DatosFigura> datosPanel = new List<DatosFigura>();

        public FormPrincipal()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;

            // Bitmap es un objeto que se utiliza para trabajar con imágenes definidas mediante datos de píxeles.
            //Inicializa una nueva instancia de la clase Bitmap con el tamaño especificado.
            bitmap = new Bitmap(pic.Width, pic.Height);
            //La clase Graphics proporciona métodos para dibujar objetos
            //FromImage crea un nuevo Graphics con la imagen especificada
            graphics = Graphics.FromImage(bitmap);
            //Borra toda la superficie de dibujo y la rellena con el color de fondo especificado.
            graphics.Clear(Color.White);
            //establece la imagen que se muestra mediante el PictureBox.
            pic.Image = bitmap;
        }

        int contador = 0;
        private void button_rectangulo_Click(object sender, EventArgs e)
        {
            contador++;

            PanelPersonalizado rectangulo = new PanelPersonalizado();
            rectangulo.BackColor = Color.White;
            rectangulo.Name = "Rectangulo" + contador;
            rectangulo.Location = new Point(20, 150);
            rectangulo.Width = 200;
            rectangulo.Height = 100;
            rectangulo.BorderStyle = BorderStyle.FixedSingle;

            TextBox txt = new TextBox();

            txt.BackColor = Color.White;
            txt.Location = new Point(16, 36);
            txt.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold);
            txt.TextAlign = HorizontalAlignment.Center;
            txt.Name = "textBox1";
            txt.Size = new Size(166, 20);
            txt.TabIndex = 0;
            txt.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txt.BorderStyle = BorderStyle.None;

            //Dentro del panel rectangulo se agrega el control TextBox
            rectangulo.Controls.Add(txt);

            //Dentro del PictureBox se agrega el panel rectangulo
            pic.Controls.Add(rectangulo);
        }

        int contador2 = 0;

        private void circulo_Click(object sender, EventArgs e)
        {
            contador2++;
            PanelPersonalizado circulo = new PanelPersonalizado();

            circulo.BackColor = Color.White;
            circulo.BackgroundImage = Properties.Resources.CirculoSinFondo2;
            circulo.BackgroundImageLayout = ImageLayout.Stretch;
            circulo.Location = new Point(194, 102);
            circulo.Name = "circulo" + contador2;
            circulo.Size = new Size(227, 174);
            circulo.TabIndex = 1;

            TextBox txt = new TextBox();

            txt.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txt.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold);
            txt.Location = new Point(52, 71);
            txt.Name = "textBox";
            txt.Size = new Size(118, 26);
            txt.TabIndex = 0;
            txt.TextAlign = HorizontalAlignment.Center;
            txt.BorderStyle = BorderStyle.None;

            //Dentro del panel circulo se agrega el control TextBox
            circulo.Controls.Add(txt);

            //Dentro del PictureBox se agrega el panel circulo
            pic.Controls.Add(circulo);
        }

        private void linea_Click(object sender, EventArgs e)
        {
            seleccionUsuario = "Linea";
        }

        private void flecha_Click(object sender, EventArgs e)
        {
            seleccionUsuario = "Flecha";
        }

        private void flechadoble_Click(object sender, EventArgs e)
        {
            seleccionUsuario = "FlechaDoble";
        }

        //Se produce cuando el puntero del mouse se encuentra sobre el PictureBox
        //y se suelta un botón del mouse.
        private void pic_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;

            if (e.Button == MouseButtons.Left)
            {

                switch (seleccionUsuario)
                {
                    case "Linea":
                        {
                            Linea linea = new Linea();
                            linea.InicioX = inicioX;
                            linea.InicioY = inicioY;
                            linea.FinX = finX;
                            linea.FinY = finY;
                            linea.TipoDeLinea = "Linea";

                            lineas.Add(linea);

                            break;
                        }
                    case "Flecha":
                        {
                            Linea linea = new Linea();
                            linea.InicioX = inicioX;
                            linea.InicioY = inicioY;
                            linea.FinX = finX;
                            linea.FinY = finY;
                            linea.TipoDeLinea = "Flecha";

                            lineas.Add(linea);

                            break;
                        }
                    case "FlechaDoble":
                        {
                            Linea linea = new Linea();
                            linea.InicioX = inicioX;
                            linea.InicioY = inicioY;
                            linea.FinX = finX;
                            linea.FinY = finY;
                            linea.TipoDeLinea = "FlechaDoble";

                            lineas.Add(linea);

                            break;
                        }
                    case "MoverLinea":
                        {
                            int cont = lineas.Count - 1;

                            Linea linea = new Linea();
                            linea.InicioX = point1.X;
                            linea.InicioY = point1.Y;
                            linea.FinX = point2.X;
                            linea.FinY = point2.Y;

                            linea.TipoDeLinea = lineas[cont].TipoDeLinea;

                            lineas.Add(linea);

                            lineas.RemoveAt(cont);

                            seleccionUsuario = "";

                            break;
                        }
                }
                
                pic.Refresh();
            }
        }

        //El evento Paint se genera cuando se vuelve a dibujar el PictureBox
        private void pic_Paint(object sender, PaintEventArgs e)
        {
            int i, inicioX, inicioY, finX, finY;

            for (i = 0; i <= lineas.Count - 1; i++)
            {
                inicioX = lineas[i].InicioX;
                inicioY = lineas[i].InicioY;
                finX = lineas[i].FinX;            
                finY = lineas[i].FinY;

                e.Graphics.DrawLine(lineas[i].PenLinea(), inicioX, inicioY, finX, finY);
            }

            if (mouseDown == true)
            {
                switch (seleccionUsuario)
                {
                    case "Linea":
                        {
                            Pen pen = new Pen(Color.Black, 4);
                            e.Graphics.DrawLine(pen, this.inicioX, this.inicioY, this.finX, this.finY);
                            break;
                        }
                    case "Flecha":
                        {
                            Pen pen = new Pen(Color.Black, 4);
                            pen.EndCap = LineCap.ArrowAnchor;
                            pen.StartCap = LineCap.NoAnchor;
                            e.Graphics.DrawLine(pen, this.inicioX, this.inicioY, this.finX, this.finY);
                            break;
                        }
                    case "FlechaDoble":
                        {
                            Pen pen = new Pen(Color.Black, 4);
                            pen.EndCap = LineCap.ArrowAnchor;
                            pen.StartCap = LineCap.ArrowAnchor;
                            e.Graphics.DrawLine(pen, this.inicioX, this.inicioY, this.finX, this.finY);
                            break;
                        }
                    case "MoverLinea":
                        {
                            Pen pen = new Pen(Color.Black, 4);

                            if (seleccionUsuario == "Flecha")
                            {
                                pen.EndCap = LineCap.ArrowAnchor;
                                pen.StartCap = LineCap.NoAnchor;

                            }
                            else if (seleccionUsuario == "FlechaDoble")
                            {
                                pen.EndCap = LineCap.ArrowAnchor;
                                pen.StartCap = LineCap.ArrowAnchor;
                            }

                            e.Graphics.DrawLine(pen, point1.X, point1.Y, point2.X, point2.Y);
                            break;

                        }
                }
            }
        }

        //Se produce cuando el puntero del mouse se encuentra sobre el PictureBox
        //y se presiona un botón del mouse.
        private void pic_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;

            //MouseEventArgs (e) especifica las coordenadas del mouse

            inicioX = e.X;
            inicioY = e.Y;
            finX = e.X;
            finY = e.Y;
            comienzoDownLocation = e.Location;
        }

        //Se produce cuando el puntero del mouse se mueve sobre el PictureBox
        private void pic_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown == false) return;

            finX = e.X;
            finY = e.Y;

            switch (seleccionUsuario)
            {
                case "Linea":
                    {
                        break;
                    }
                case "Flecha":
                    {
                        break;
                    }
                case "FlechaDoble":
                    {
                        break;
                    }

                case "MoverLinea":
                    {
                        int i;
                        i = lineas.Count - 1;

                        if (i >= 0)
                        {
                            point1.X = e.X + lineas[i].InicioX - comienzoDownLocation.X;
                            point1.Y = e.Y + lineas[i].InicioY - comienzoDownLocation.Y;
                            point2.X = e.X + lineas[i].FinX - comienzoDownLocation.X;
                            point2.Y = e.Y + lineas[i].FinY - comienzoDownLocation.Y;
                        }
                        break;
                    }
            }

            pic.Refresh();
        }

        private void moverLineaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lineas.Count > 0)
            {
                seleccionUsuario = "MoverLinea";
            }       
        }

        private void eliminarLineaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int cont = lineas.Count - 1;

            try
            {              
                lineas.RemoveAt(cont);
                pic.Refresh();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("No hay lineas para eliminar");
            }

        }

        private void guardarComoJSONToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            datosPanel.Clear();

            var opciones = new JsonSerializerOptions { WriteIndented = true };

            string jsonString = JsonSerializer.Serialize(lineas, opciones);

            //WriteAllText crea un archivo nuevo, escribe el contenido en el archivo y, a continuación, lo cierra.
            //Si el archivo de destino ya existe, se sobrescribe.

            File.WriteAllText("Lineas.txt", jsonString);

            var listaControles = pic.Controls;

            foreach (PanelPersonalizado panelPersonalizado in listaControles)
            {
                DatosFigura datos = new DatosFigura();
                datos.RectanguloWidth = panelPersonalizado.Width;
                datos.RectanguloHeight = panelPersonalizado.Height;
                datos.RectanguloName = panelPersonalizado.Name;
                datos.RectanguloLocation = panelPersonalizado.Location;
                datos.FiguraSize = panelPersonalizado.Size;

                datos.TxtName = panelPersonalizado.Controls[0].Name;
                datos.TxtSize = panelPersonalizado.Controls[0].Size;
                datos.TxtLocation = panelPersonalizado.Controls[0].Location;
                datos.TxtTexto = panelPersonalizado.Controls[0].Text;

                if (panelPersonalizado.BackgroundImage != null)
                {
                    datos.EsCirculo = true;
                }

                datosPanel.Add(datos);
            }

            string jsonString2 = JsonSerializer.Serialize<List<DatosFigura>>(datosPanel);

            File.WriteAllText("Figuras.txt", jsonString2);

            MessageBox.Show("Proyecto guardado con exito");
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists("Lineas.txt") || File.Exists("Figuras.txt"))
            {
                lineas.Clear();
                pic.Controls.Clear();
                pic.Refresh();
            }
            else
            {
                MessageBox.Show("No guardo ningun proyecto.");
            }

            if (File.Exists("Lineas.txt"))
            {
                //Deserialización de Lineas
                string jsonString = File.ReadAllText("Lineas.txt");
                lineas = JsonSerializer.Deserialize<List<Linea>>(jsonString);
            }

            if(File.Exists("Figuras.txt"))
            {

                //Deserialización de Figuras
                string jsonString2 = File.ReadAllText("Figuras.txt");
                datosPanel = JsonSerializer.Deserialize<List<DatosFigura>>(jsonString2);

                int contador = 0;

                foreach (var datos in datosPanel)
                {
                    contador++;

                    PanelPersonalizado figura = new PanelPersonalizado();

                    figura.Name = "Rectangulo" + contador;
                    figura.BackColor = Color.White;
                    figura.Location = new Point(datos.RectanguloLocation.X, datos.RectanguloLocation.Y);
                    figura.Width = datos.RectanguloWidth;
                    figura.Height = datos.RectanguloHeight;
                    figura.BorderStyle = BorderStyle.FixedSingle;
                    figura.Size = datos.FiguraSize;

                    TextBox txt = new TextBox();

                    txt.BackColor = Color.White;
                    txt.Location = datos.TxtLocation;
                    txt.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold);
                    txt.TextAlign = HorizontalAlignment.Center;
                    txt.Name = datos.TxtName;
                    txt.Size = datos.TxtSize;
                    txt.TabIndex = 0;
                    txt.Anchor = AnchorStyles.Left | AnchorStyles.Right;
                    txt.BorderStyle = BorderStyle.None;
                    txt.Text = datos.TxtTexto;

                    if (datos.EsCirculo == true)
                    {
                        figura.BackgroundImage = Properties.Resources.CirculoSinFondo2;
                        figura.BackgroundImageLayout = ImageLayout.Stretch;
                        figura.BorderStyle = BorderStyle.None;
                    }

                    figura.Controls.Add(txt);

                    pic.Controls.Add(figura);
                }

                pic.Refresh();

                MessageBox.Show("Proyecto cargado con exito");
            }              

        }

        private void borrarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lineas.Clear();
            pic.Controls.Clear();
            pic.Refresh();
        }

        private Bitmap CapturarControl(PictureBox pic)
        {
            Size size = pic.Size;
            Bitmap imagen;

            using (Graphics graphics = CreateGraphics())
            {
                imagen = new Bitmap(size.Width, size.Height, graphics);
            }

            using (Graphics memoryGraphics = Graphics.FromImage(imagen))
            {
                Point picStart = new Point(155, 35);
                Point screenPoint = PointToScreen(picStart);
                memoryGraphics.CopyFromScreen(screenPoint.X, screenPoint.Y, 0, 0, size);
            }

            return imagen;
        }

        private void guardarComoJPGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Pregunta al usuario si desea seleccionar una ubicación para guardar un archivo.
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Image(*.jpg)|*.jpg|(*.*|*.*";

            using (Bitmap bitmap = CapturarControl(pic))
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    bitmap.Save(saveFileDialog.FileName, ImageFormat.Jpeg);
                    MessageBox.Show("Imagen guardada con exito.");
                }
            }
        }

        private void abrirAyudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAyuda formAyuda = new FormAyuda();

            if (formAyuda.ShowDialog() == DialogResult.OK)
            {
                
            }
        }
    }
}
