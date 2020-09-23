using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace media
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double n1, n2, n3, media;
            n1 = Convert.ToDouble(txtnota1.Text);
            n2 = Convert.ToDouble(txtnota2.Text);
            n3 = Convert.ToDouble(txtnota3.Text);
            media = (n1 + n2 + n3) / 3;
            txtmedia.Text = media.ToString();

            if (media < 5) MessageBox.Show("Aluno foi reprovado!!");
            else if (media >= 7) MessageBox.Show("Aluno foi Aprovado");
            else MessageBox.Show("Aluno em Recuperação");
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtnota1.Text = "";
            txtnota2.Text = "";
            txtnota3.Text = "";
            txtmedia.Text = "";
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
