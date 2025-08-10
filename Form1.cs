using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace fileclinet
{
    public partial class Form1 : Form
    {
        public class pubilcinfo
        {
            public static string ip;
            public static string port;
            public static string filepage;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            startimg startimg= new startimg();
            startimg.ShowDialog();
            checkBox1.Checked = false;
            textBox3.Enabled = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pubilcinfo.port = textBox1.Text;
            pubilcinfo.ip = textBox2.Text;
            if (checkBox1.Checked == true)
            {
                pubilcinfo.filepage = textBox3.Text;
            }
            else
            {
                pubilcinfo.filepage = null;
            }
            broswer broswer = new broswer();
            broswer.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox3.Enabled = true;
            }
            else
            {
                textBox3.Enabled = false;
            }
        }
    }
}
