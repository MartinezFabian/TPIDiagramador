
using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing;

namespace TPIDiagramador
{
    public class PanelPersonalizado : Panel
    {

        [DllImport("user32.dll")]
        static extern IntPtr GetWindowDC(IntPtr hWnd);
        [DllImport("User32.dll")]
        static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);

        //EventHandler delegado que ya existe en la Biblioteca de Clases Base
        public event EventHandler PanelPersonalizadoClick;
        public event EventHandler PanelPersonalizadoClickDerecho;
        public event EventHandler PanelPersonalizadoMovimiento;

        private void PanelPersonalizadoClickFuncion()
        {
            if (PanelPersonalizadoClick != null)
                PanelPersonalizadoClick(this, new EventArgs());
        }

        private void PanelPersonalizadoClickDerechoFuncion()
        {
            if (PanelPersonalizadoClickDerecho != null)
                PanelPersonalizadoClickDerecho(this, new EventArgs());
        }

        private void PanelPersonalizadoMovimientoFuncion()
        {
            if (PanelPersonalizadoMovimiento != null)
                PanelPersonalizadoMovimiento(this, new EventArgs());
        }

        public PanelPersonalizado()
        {
            if (this.Tag == null) this.Tag = string.Empty;

            bool arrastrando = false;
            bool arrastrado = false;
            Point arrastrarInicio = Point.Empty;

            bool Redimensionamiento = false;
            bool Redimensionado = false;
            bool mouseEnExtremoIzquierdo = false;
            bool mouseEnExtremoDerecho = false;
            bool mouseEnExtremoSuperior = false;
            bool mouseEnExtremoInferior = false;
            Point PuntoInicialCursor = new Point();
            Size tamDeInicio = new Size();

            this.VisibleChanged += delegate (object sender, EventArgs e)
            {
                PanelPersonalizadoMovimientoFuncion();
            };

            this.MouseDown += delegate (object sender, MouseEventArgs e)
            {
                mouseEnExtremoIzquierdo = Math.Abs(e.X) <= 5;
                mouseEnExtremoDerecho = Math.Abs(e.X - this.Width) <= 5;
                mouseEnExtremoSuperior = Math.Abs(e.Y) <= 5;
                mouseEnExtremoInferior = Math.Abs(e.Y - this.Height) <= 5;

                if (mouseEnExtremoIzquierdo || mouseEnExtremoDerecho || mouseEnExtremoSuperior || mouseEnExtremoInferior)
                {
                    Redimensionamiento = true;
                    Redimensionado = false;

                    PuntoInicialCursor = new Point(e.X, e.Y);
                    tamDeInicio = this.Size;

                    if (mouseEnExtremoIzquierdo)
                    {
                        if (mouseEnExtremoSuperior)
                        {
                            this.Cursor = Cursors.SizeNWSE;
                        }
                        else if (mouseEnExtremoInferior)
                        {
                            this.Cursor = Cursors.SizeNESW;
                        }
                        else
                        {
                            this.Cursor = Cursors.SizeWE;
                        }
                    }
                    else if (mouseEnExtremoDerecho)
                    {
                        if (mouseEnExtremoSuperior)
                        {
                            this.Cursor = Cursors.SizeNESW;
                        }
                        else if (mouseEnExtremoInferior)
                        {
                            this.Cursor = Cursors.SizeNWSE;
                        }
                        else
                        {
                            this.Cursor = Cursors.SizeWE;
                        }

                    }
                    else if (mouseEnExtremoSuperior || mouseEnExtremoInferior)
                    {
                        this.Cursor = Cursors.SizeNS;
                    }
                    else
                    {
                        this.Cursor = Cursors.Default;
                    }

                }
                else
                {
                    arrastrando = true;
                    arrastrado = false;
                    arrastrarInicio = new Point(e.X, e.Y);
                }
                this.Capture = true;
            };

            this.MouseUp += delegate (object sender, MouseEventArgs e)
            {
                arrastrando = false;
                Redimensionamiento = false;

                this.Capture = false;

                if (arrastrado || Redimensionado)
                {
                    PanelPersonalizadoMovimientoFuncion();
                }
                else
                {
                    if (e.Button == MouseButtons.Right)
                        PanelPersonalizadoClickDerechoFuncion();
                    else
                        PanelPersonalizadoClickFuncion();
                }
            };

            this.MouseMove += delegate (object sender, MouseEventArgs e)
            {
                if (Redimensionamiento)
                {
                    Redimensionado = false;

                    if (mouseEnExtremoIzquierdo)
                    {
                        if (mouseEnExtremoSuperior)
                        {
                            this.Width -= (e.X - PuntoInicialCursor.X);
                            this.Left += (e.X - PuntoInicialCursor.X);
                            this.Height -= (e.Y - PuntoInicialCursor.Y);
                            this.Top += (e.Y - PuntoInicialCursor.Y);
                        }
                        else if (mouseEnExtremoInferior)
                        {
                            this.Width -= (e.X - PuntoInicialCursor.X);
                            this.Left += (e.X - PuntoInicialCursor.X);
                            this.Height = (e.Y - PuntoInicialCursor.Y)
                                     + tamDeInicio.Height;
                        }
                        else
                        {
                            this.Width -= (e.X - PuntoInicialCursor.X);
                            this.Left += (e.X - PuntoInicialCursor.X);
                        }
                    }
                    else if (mouseEnExtremoDerecho)
                    {
                        if (mouseEnExtremoSuperior)
                        {
                            this.Width = (e.X - PuntoInicialCursor.X)
                                            + tamDeInicio.Width;
                            this.Height -= (e.Y - PuntoInicialCursor.Y);
                            this.Top += (e.Y - PuntoInicialCursor.Y);

                        }
                        else if (mouseEnExtremoInferior)
                        {
                            this.Width = (e.X - PuntoInicialCursor.X)
                                            + tamDeInicio.Width;
                            this.Height = (e.Y - PuntoInicialCursor.Y)
                                            + tamDeInicio.Height;
                        }
                        else
                        {
                            this.Width = (e.X - PuntoInicialCursor.X)
                                           + tamDeInicio.Width;
                        }
                    }
                    else if (mouseEnExtremoSuperior)
                    {
                        this.Height -= (e.Y - PuntoInicialCursor.Y);
                        this.Top += (e.Y - PuntoInicialCursor.Y);
                    }
                    else if (mouseEnExtremoInferior)
                    {
                        this.Height = (e.Y - PuntoInicialCursor.Y)
                                   + tamDeInicio.Height;
                    }
                    else
                    {
                        Redimensionamiento = false;
                    }
                }
                else if (arrastrando)
                {
                    arrastrado = true;
                    this.Left = Math.Max(0, e.X + this.Left - arrastrarInicio.X);
                    this.Top = Math.Max(0, e.Y + this.Top - arrastrarInicio.Y);
                }
            };

        }
    }
}
