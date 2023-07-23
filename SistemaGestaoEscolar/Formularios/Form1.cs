using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CamadaEntidade;
using CamadaNegocio;

namespace Formularios
{
    public partial class Form1 : Form
    {
        ClasseNegocio clsUser = new ClasseNegocio();
        ClasseEntidade clsEnt = new ClasseEntidade();

        public static string usuario_nome;
        public static string id_tipo;
        public static string usuario_geral;
        public static string usuario_Codigo;

        FormularioPrincipal formPrinc = new FormularioPrincipal();

        public Form1()
        {
            InitializeComponent();
        }

        private void Limpar()
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
