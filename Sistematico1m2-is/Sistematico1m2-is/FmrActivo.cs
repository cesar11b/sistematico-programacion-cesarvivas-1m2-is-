using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistematico1m2_is
{
    public partial class FmrActivo : Form
    {
        public FmrActivo()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CmbTipoActivoFijo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnNuevoProducto_Click(object sender, EventArgs e)
        {
            FmrCrearActivo cambio = new FmrCrearActivo();


            cambio.Show();




        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
