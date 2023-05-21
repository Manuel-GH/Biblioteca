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
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }
        
        
        int IdAlumno;
        string NombreAlumno;
        string ApellidoPaterno;
        string ApellidoMaterno;
        string ImagenPerfil;
        string Direccion;
        int Telefono;
        DateTime FechaIngreso;
        int IdEscuela;


        private void AsignarDatos()
        {
            IdAlumno = Int32.Parse(TxtBoxIdAlumno.Text);
            NombreAlumno = TxtBoxNombre.Text;
            ApellidoPaterno = TxtBoxAPaterno.Text;
            ApellidoMaterno = TxtBoxAMaterno.Text;
            ImagenPerfil = textBox1.Text;
            Direccion = TxtBoxDireccion.Text;
            Telefono = Int32.Parse(TxtBoxTelefono.Text);
            FechaIngreso = DateTime.Parse(TxtBoxFechaIngreso.Text);
            IdEscuela = Int32.Parse(TxtBoxIdEscuela.Text);


        }


        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog BuscarImagen = new OpenFileDialog(); BuscarImagen.Filter = "Archivos de Imagen|*.jpg";
            //Aquí incluiremos los filtros que queramos.
            BuscarImagen.FileName = "";
            BuscarImagen.Title = "Selecciona Tu Fotito de Perfil";
            BuscarImagen.InitialDirectory = "C:\\"; BuscarImagen.FileName = this.textBox1.Text;
            if (BuscarImagen.ShowDialog() == DialogResult.OK)
            {
                /// Si esto se cumple, capturamos la propiedad File Name y la guardamos en el control
                this.textBox1.Text = BuscarImagen.FileName; String Direccion = BuscarImagen.FileName; this.pictureBox1.ImageLocation = Direccion;
                //Pueden usar tambien esta forma para cargar la Imagen solo activenla y comenten la linea donde se cargaba anteriormente 
                //this.pictureBox1.ImageLocation = textBox1.Text;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
           

        }
    }
    
}
