using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tic_tac_tow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        
            panel1.BorderStyle = BorderStyle.None;

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

            XOBOARD xOBOARD = new XOBOARD();

            xOBOARD.RestartGame();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            xoboard1.Visible = false;
        }

        private void materialButtonstart_Click(object sender, EventArgs e)
        {

            hidestartingelements(panel1);
            xoboard1.Visible = true;

        }

        public void hidestartingelements(Panel panel)
        {


            foreach (Control control in panel.Controls)
            {

                control.Visible = false;    

            }

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
