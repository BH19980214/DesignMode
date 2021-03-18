using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01单例模式
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1 c1 = new Class1();
            textBox1.Text += c1.AddNumString() + "   ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Class2 c2 = new Class2();
            textBox1.Text += c2.AddNumString() + "   ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Class3 c3 = new Class3();
            textBox1.Text += c3.AddNumString() + "   ";
        }
    }
}
