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
    public partial class XOBOARD : UserControl
    {

        private bool nextTurn = true;
        private bool restartGame = false;

        private const string xPlayer = "X";
        private const string oPlayer = "O";


        public XOBOARD()
        {
            InitializeComponent();
            Board();



           


        }


        private void Board()
        {

            Panel[] panels = {panel1,panel2,panel3,panel4,panel5,panel6,panel7,panel8,panel9};

            foreach (Panel p in panels)
            {
                Label lb = new Label();
                lb.Text = "";
  

                p.Controls.Add(lb);
            }
        }



        private void panel2_Click(object sender, EventArgs e)
        {
            Panel panel = sender as Panel;

            if (nextTurn)
            {
                panel.Controls[0].Text = xPlayer;
                panel.Controls[0].AutoSize = false;
                panel.Controls[0].Size = new Size(80, 80);


                panel.Controls[0].Font = new Font("Arial", 50, FontStyle.Bold);
            }
            else
            {
                panel.Controls[0].Text = oPlayer;
                panel.Controls[0].AutoSize = false;
                panel.Controls[0].Size = new Size(80, 80);


                panel.Controls[0].Font = new Font("Arial", 50, FontStyle.Bold);
            }

            nextTurn = !nextTurn;
            panel.Enabled = false;

            if (CheckIfWin())
            {
                RestartGame(panel1,panel2,panel3,panel4,panel5,panel6,panel7,panel8,panel9);
            }
        }

        private bool CheckIfWin()
        {
            string[,] panels = new string[,]
            {
                { panel1.Controls[0].Text, panel2.Controls[0].Text, panel3.Controls[0].Text },
                { panel4.Controls[0].Text, panel5.Controls[0].Text, panel6.Controls[0].Text },
                { panel7.Controls[0].Text, panel8.Controls[0].Text, panel9.Controls[0].Text }
            };

            // Check rows and columns
            for (int i = 0; i < 3; i++)
            {
                if (panels[i, 0] == panels[i, 1] && panels[i, 1] == panels[i, 2] && !string.IsNullOrWhiteSpace(panels[i, 0]))
                {
                    MessageBox.Show($"{panels[i, 0]} wins");
                    restartGame = true;
                    return true;
                }

                if (panels[0, i] == panels[1, i] && panels[1, i] == panels[2, i] && !string.IsNullOrWhiteSpace(panels[0, i]))
                {
                    MessageBox.Show($"{panels[0, i]} wins");
                    restartGame = true;
                    return true;
                }
            }

            //  diagonals
            if (panels[0, 0] == panels[1, 1] && panels[1, 1] == panels[2, 2] && !string.IsNullOrWhiteSpace(panels[0, 0]))
            {
                MessageBox.Show($"{panels[0, 0]} wins");
                restartGame = true;
                return true;
            }

            if (panels[0, 2] == panels[1, 1] && panels[1, 1] == panels[2, 0] && !string.IsNullOrWhiteSpace(panels[0, 2]))
            {
                MessageBox.Show($"{panels[0, 2]} wins");
                restartGame = true;
                return true;
            }

            int tiecounter = 0;
            foreach(string input in panels)
            {

                if(input.Length==1) { tiecounter++; }; 


            }

            if (tiecounter == 9) { MessageBox.Show("its a tie"); restartGame = true; }
            return restartGame;
        }

        public void RestartGame(params Panel[]p)
        {
          if(restartGame)
            {


                  foreach(Panel p1 in p)
                {
                    p1.Enabled = true;


                    p1.Controls[0].Text = "";
                    p1.Controls[0].Size=new Size(1,1);

                }


                  restartGame = false;
              
            }


        }

        
    }
}





