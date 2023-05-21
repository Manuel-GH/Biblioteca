using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        int IdEscuela;
        string NombreEscuela;
        string DireccionEscuela;
        int TelefonoEscuela;
        string EmailEscuela;


        private void AsignarDatos()
        {
            IdEscuela = Int32.Parse(TxtBoxIdEscuela.Text);
            NombreEscuela = TxtBoxNombreEscuela.Text;
            DireccionEscuela = TxtBoxDireccionEscuela.Text;
            TelefonoEscuela = Int32.Parse(TxtBoxTelefonoEscuela.Text);
            EmailEscuela = TxtBoxEmailEscuela.Text;
        }



    }
}
