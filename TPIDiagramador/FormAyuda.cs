using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPIDiagramador
{
    public partial class FormAyuda : Form
    {
        public FormAyuda()
        {
            InitializeComponent();

            RellenarAyuda();
        }

        void RellenarAyuda()
        {
            txtTextoAyuda.Text = "Seleccione la figura que desea dibujar con un clic sobre la misma en el menú de la izquierda. En el caso del rectángulo o del círculo estas aparecen por sí solas en la zona de dibujo. En el caso de las líneas/flechas debe seleccionar la líneas/flechas con un clic y luego pulsar con el mouse donde desea que comience el dibujo de la línea/flecha y mantener pulsado el clic para dibujar la misma. En caso de querer mover la línea dibujada hacer clic derecho y seleccionar mover. En caso de querer eliminar la línea dibujada hacer clic derecho y seleccionar la opción eliminar. Para ingresar texto dentro de una figura hacer clic en el centro de la misma y escribir el texto. Las figuras (rectángulo/círculo) pueden redimensionarse.";
        }
    }
}
