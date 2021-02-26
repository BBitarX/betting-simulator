using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Threading;
using System.Runtime.InteropServices;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CustomizeDesign();
        }

        private void CustomizeDesign()
        {
            pnlBettingSubMenu.Visible = false;
            pnlSettingsSubMenu.Visible = false;

        }

        private void HideSubMenu()
        {
            if (pnlSettingsSubMenu.Visible == true)
            {
                pnlSettingsSubMenu.Visible = false;
            }
            if (pnlBettingSubMenu.Visible == true)
            {
                pnlBettingSubMenu.Visible = false;
            }

        }



        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


       /* bool mouseDown = false;
        private Point lastLocation;
        

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = this.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
                if (mouseDown)
                {
                    this.Location = new Point(
                        (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                
                    this.Update();
                }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        */

        // Above: Old code for the DragForm() Method

        public static int ghp { get; set; }
        [DllImport("shlwapi.dll")]
        public static extern int ColorHLSToRGB(int H, int L, int S);
        private void timer1_Tick(object sender, EventArgs e)
        {

            if (ghp == 240)
            {
                ghp = 0;
            }
            else
            {
                ghp++;


                lblTitle.ForeColor = ColorTranslator.FromWin32(ColorHLSToRGB(ghp, 100, 150));
                
            }



            lblTime.Text = System.DateTime.Now.ToString("hh:mm:ss");



        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            OpenChildForm(new Form2());
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            OpenChildForm(new Form3());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HideSubMenu();
           
        }

        private void btnBetting_Click(object sender, EventArgs e)
        {
            HideSubMenu(); 
            if (pnlBettingSubMenu.Visible == true)
            {
                HideSubMenu();
            }
            else
            {
                pnlBettingSubMenu.Visible = true;
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            if (pnlSettingsSubMenu.Visible)
            {
                HideSubMenu();
            }
            else
            {
                pnlSettingsSubMenu.Visible = true;
            }
        }

        private Form activeForm = null;
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlChildForm.Controls.Add(childForm);
            pnlChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_MouseDown_1(object sender, System.Windows.Forms.MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
               
        
        }
    
    
    
    
    
    }
}
