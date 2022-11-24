using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaAritmeticaSimples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            double nota1 = 0, nota2 = 0, nota3 = 0, media;
            nota1 = double.Parse(txtN1.Text);
            nota2 = double.Parse(txtN2.Text);
            nota3 = double.Parse(txtN3.Text);

            media = Math.Round((nota1 + nota2 + nota3) / 3,2);

            lblMedia.Text = txtNome.Text + " sua média é: " + media.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtN1.Clear();
            txtN2.Clear();
            txtN3.Clear();
            lblMedia.Text = "";
            txtNome.Focus();
        }
    }
}
