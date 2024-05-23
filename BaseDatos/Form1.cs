using BaseDatos.Data.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseDatos
{
    public partial class Form1 : Form
    {
        private personajeDB personaje;
        private string[] razasDragonBall = {
    "Android",
    "Bio-Android",
    "Humana",
    "Humano",
    "Majin",
    "Namekuseijin",
    "Saiyajin",
    "Saiyajin/Humano",
    "Saiyajin/Saiyajin"
};
        public Form1()
        {
            InitializeComponent();
            personaje = new personajeDB();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (personaje.ProbarConexion())
            {
                MessageBox.Show("Simoncho");
            } else
            {
                MessageBox.Show("Nelson");
            }
        }

        private void buttonCargar_Click(object sender, EventArgs e)
        {
            DataTable dt = personaje.LeerPersonajes();
            dataGridViewPersonajes.DataSource = dt;
        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            string nombre = textBoxNombre.Text;
            string raza = comboBoxRaza.Text;
            int nivelPoder = (int)numericUpDownPower.Value;
            DateTime fecha_creacion = DateTime.Now;
            string historia= textBoxhistoria.Text;
            int respuesta = personaje.CrearPersonaje(nombre, raza, nivelPoder,fecha_creacion,historia);
            if (respuesta > 0)
            {
                MessageBox.Show("Si se pudo mi rey");
                dataGridViewPersonajes.DataSource = personaje.LeerPersonajes();
            }
            else
            {
                MessageBox.Show("Algo hiciste mal");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxRaza.Items.AddRange(razasDragonBall);
        }



        private void BuscarPorId()
        {
            int idPersonajeBuscar = int.Parse(textBoxid.Text);
            DataTable personajeEncontrado = personaje.BuscarPersonajePorId(idPersonajeBuscar);
            if (personajeEncontrado.Rows.Count > 0)
            {
                string nombre = personajeEncontrado.Rows[0]["nombre"].ToString();
                string raza = personajeEncontrado.Rows[0]["raza"].ToString();
                int nivelPoder = int.Parse(personajeEncontrado.Rows[0]["nivel_poder"].ToString());
                DateTime fecha_creacion = (DateTime)personajeEncontrado.Rows[0]["fecha_creacion"];
                string historia = personajeEncontrado.Rows[0]["historia"].ToString();
                textBoxNombre.Text = nombre;
                comboBoxRaza.Text = raza;
                numericUpDownPower.Value = nivelPoder;  
                dateTimePickerfecha.Value = fecha_creacion;
                textBoxhistoria.Text = historia;
            } else
            {
                MessageBox.Show("No se encontro codigo");
            }
        }
        private void buttonbuscar_Click(object sender, EventArgs e)
        {
            BuscarPorId();
        }

        private void textBoxid_Leave(object sender, EventArgs e)
        {
            BuscarPorId();
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxid.Text);
            string nombre = textBoxNombre.Text;
            string raza = comboBoxRaza.Text;
            int nivelPoder = (int)numericUpDownPower.Value;
            string historia = textBoxhistoria.Text;
            int respuesta = personaje.ActualizarPersonaje(id,nombre, raza, nivelPoder, historia);
            if (respuesta > 0)
            {
                MessageBox.Show("Si se pudo mi rey");
                dataGridViewPersonajes.DataSource = personaje.LeerPersonajes();
            }
            else
            {
                MessageBox.Show("Algo hiciste mal");
            }
        }

        private void buttoneliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxid.Text);
            int respuesta = personaje.BorrarPersonaje(id);
            if (respuesta > 0)
            {
                MessageBox.Show("Si se pudo mi rey");
                textBoxid.Clear();
                textBoxNombre.Clear();
                comboBoxRaza.SelectedIndex=-1;
                numericUpDownPower.Value=0;
                textBoxhistoria.Clear();
                dataGridViewPersonajes.DataSource = personaje.LeerPersonajes();
            }
            else
            {
                MessageBox.Show("Algo hiciste mal");
            }
        }
    }
}
