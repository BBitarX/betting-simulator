using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            
            
        }

        private void lnklblGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/BBitarX");
        }


        public static int ghp2 { get; set; }
        [DllImport("shlwapi.dll")]
        public static extern int ColorHLSToRGB(int H, int L, int S);
        private void timer1_Tick(object sender, EventArgs e)
        {



            if (ghp2 == 240)
            {
                ghp2 = 0;
            }
            else
            {
                ghp2++;


                lblCreds.ForeColor = ColorTranslator.FromWin32(ColorHLSToRGB(ghp2, 100, 150));
                lblCreds.ForeColor = ColorTranslator.FromWin32(ColorHLSToRGB(ghp2, 100, 150));


            }

        }
    }
}
