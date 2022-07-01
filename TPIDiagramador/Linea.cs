using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPIDiagramador
{
    internal class Linea
    {
        private string tipoDeLinea;
        private int inicioX;
        private int inicioY;
        private int finX;
        private int finY;


        public int InicioX { get => inicioX; set => inicioX = value; }
        public int InicioY { get => inicioY; set => inicioY = value; }
        public int FinX { get => finX; set => finX = value; }
        public int FinY { get => finY; set => finY = value; }
        public string TipoDeLinea { get => tipoDeLinea; set => tipoDeLinea = value; }


        public Linea(int x1, int y1, int x2, int y2, string tipoDeLinea)
        {
            this.inicioX = x1;
            this.inicioY = y1;
            this.finX = x2;
            this.finY = y2;
            this.tipoDeLinea = tipoDeLinea;
        }

        public Linea()
        {
            inicioX = 0;
            inicioY = 0;
            finX = 0;
            finY = 0;
        }

        public Pen PenLinea()
        {
            Pen pen = new Pen(Color.Black, 6);

            if (tipoDeLinea == "Flecha")
            {
                pen.EndCap = LineCap.ArrowAnchor;
                pen.StartCap = LineCap.NoAnchor;
            }

            if (tipoDeLinea == "FlechaDoble")
            {
                pen.EndCap = LineCap.ArrowAnchor;
                pen.StartCap = LineCap.ArrowAnchor;
            }

            return pen;
        }
    }
}
