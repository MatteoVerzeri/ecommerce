using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ecommerce
{
    public partial class Form1 : Form
    {
        private Carrello c;
        public Form1()
        {
            InitializeComponent();
            c = new Carrello("1");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Prodotto p = new Prodotto(textBox5.Text, textBox1.Text, textBox3.Text, textBox2.Text, textBox4.Text);
            c.aggiungiProdotto(p);
        }
    }
}
