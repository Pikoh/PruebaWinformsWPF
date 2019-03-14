using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaWinformsWPF
{
    public partial class Form1 : Form
    {
        List<System.Windows.Window> ventantas = new List<System.Windows.Window>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Window4 w = new Window4();
            ventantas.Add(w);
            w.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ventantas.First().Close();
        }
    }
}
