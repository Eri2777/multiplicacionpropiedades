using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace multipli_propiedades
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Objeto
            clmulti pMultip = new clmulti();
            pMultip.Nume1 = int.Parse(textbox1.Text);
            pMultip.Nume2 = int.Parse(textbox2.Text);
            textBox3.Text = pMultip.multip().ToString();
        }
    }
}
