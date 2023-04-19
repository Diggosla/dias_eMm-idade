using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dias_eMm_idade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int anos, meses, dias, idadeEmDias;

            anos = int.Parse(txtano.Text);
            meses = int.Parse(txtmes.Text);
            dias = int.Parse(txtdia.Text);



            idadeEmDias = (anos * 365) + (meses * 30) + dias;



            txtresultado.Text = idadeEmDias.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
