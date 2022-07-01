using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPIDiagramador
{
     //Se arma una clase que permite guardar los valores de las
    //propiedades de los paneles creados en tiempo de ejecucion

    class DatosFigura
    {
        //Panel Rectangulo
        string figuraName;
        Point figuraLocation;
        int figuraWidth;
        int figuraHeight;
        bool esCirculo;
        Size figuraSize;

        //TextBoxt
        Point txtLocation;
        string txtName;
        Size txtSize;
        string txtTexto;

        public DatosFigura()
        { 
            this.EsCirculo = false;
        }

        public string RectanguloName { get => figuraName; set => figuraName = value; }
        public Point RectanguloLocation { get => figuraLocation; set => figuraLocation = value; }
        public int RectanguloWidth { get => figuraWidth; set => figuraWidth = value; }
        public int RectanguloHeight { get => figuraHeight; set => figuraHeight = value; }
        public Point TxtLocation { get => txtLocation; set => txtLocation = value; }
        public string TxtName { get => txtName; set => txtName = value; }
        public Size TxtSize { get => txtSize; set => txtSize = value; }
        public bool EsCirculo { get => esCirculo; set => esCirculo = value; }
        public Size FiguraSize { get => figuraSize; set => figuraSize = value; }
        public string TxtTexto { get => txtTexto; set => txtTexto = value; }
    }
}
