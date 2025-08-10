using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Windows.Forms;
using static fileclinet.Form1;

namespace fileclinet
{
    
    public partial class broswer : Form
    {
        private string realip = null;
        private string realport = null;
        private bool check_ip = false;
        private bool check_port = false;
        public void url(string ip=null, string port = null, string filepage = null)
        {
            if(pubilcinfo.ip == null||pubilcinfo.ip=="")
            {
                realip = "http://localhost:";
                check_ip = false;
            }
            else
            {
                realip = "http://" + ip + ":";
                check_ip = true;
            }
            if (pubilcinfo.port == null||pubilcinfo.port=="") 
            {
                realport = "8000";
                check_port = false;
            }
            else
            {
                realport = port;
                check_port = true;
            }

        }
        
        public broswer()
        {
            InitializeComponent();
        }

        private void broswer_Load(object sender, EventArgs e)
        {
            url(pubilcinfo.ip, pubilcinfo.port, pubilcinfo.filepage);
            webBrowser1.Navigate(realip+realport);
            
        }
    }
}
