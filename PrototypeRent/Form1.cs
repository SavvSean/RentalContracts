using PrototypeRent.UserControls;
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


namespace PrototypeRent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //for clicking

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);


        // For mouse dragging
        private void addUserControl(UserControl userControl) { 
            userControl.Dock = DockStyle.Fill;
            
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.MouseDown += new MouseEventHandler(panel1_MouseDown);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, (IntPtr)HTCAPTION, IntPtr.Zero);
            }
        }




        private void guna2Button1_Click(object sender, EventArgs e)
        {
            MenuPanel menuPanel = new MenuPanel();
            addUserControl(menuPanel);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            ViewPanel viewPanel = new ViewPanel();
            addUserControl(viewPanel);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            CreatePanel createPanel = new CreatePanel();
            addUserControl (createPanel);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            RenewPanel renewPanel = new RenewPanel();
            addUserControl(renewPanel);
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            TerminatePanel terminatePanel = new TerminatePanel();
            addUserControl(terminatePanel);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Chicken chicken = new Chicken();
            addUserControl(chicken);
        }

    }
}
