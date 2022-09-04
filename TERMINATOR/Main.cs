using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Net;

namespace TERMINATOR
{
    
    public partial class Main : Form
    {
        string nsudo = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\TERMINATORBYAWIRE9966\nsudo.exe";
        string exefile;
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(!File.Exists(nsudo))
            {
                WebClient client = new WebClient();
                client.DownloadFile(new Uri("http://awiresoftware.xyz/nsudo/ns.exe"), nsudo);
            }
        }

       

        private void button2_Click(object sender, EventArgs e)
        { 
            if(checkBox1.Checked)
            {
                Process.Start(nsudo, "-U:T -ShowWindowMode:Hide taskkill /f  /pid " + richTextBox1.Text);
            }
            else
            {
                Process.Start(nsudo, "-U:T -ShowWindowMode:Hide taskkill /f /IM " + richTextBox1.Text );
            }
            
            
        }
    }
}
