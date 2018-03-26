using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UmDiaDeCorrida.Model;

namespace UmDiaDeCorrida
{
    public partial class FormSimulator : Form
    {
        Greyhound[] dogs = new Greyhound[4];
        Guy[] guys = new Guy[3];

        public FormSimulator()
        {
            InitializeComponent();
            InitializeRacetrack();
        }

        private void InitializeRacetrack()
        {
            labelMinimumBet.Text = "Aposta Minima: " + numericBetAmount.Minimum + " Reais";

            int startingPosition = pictureBoxDog1.Right - pictureBoxRacetrack.Left;
            int raceTrackLength = pictureBoxRacetrack.Size.Width;

            dogs[0] = new Greyhound(startingPosition, raceTrackLength, pictureBoxDog1);
            dogs[1] = new Greyhound(startingPosition, raceTrackLength, pictureBoxDog2);
            dogs[2] = new Greyhound(startingPosition, raceTrackLength, pictureBoxDog3);
            dogs[3] = new Greyhound(startingPosition, raceTrackLength, pictureBoxDog4);

            guys[0] = new Guy("João", null, 50, radioButtonJoão, labelJoaoBet);
            guys[1] = new Guy("Beto", null, 75, radioButtonBeto, labelBetoBet);
            guys[2] = new Guy("Alfredo", null, 45, radioButtonAlfredo, labelAlfredoBet);

            foreach (var guy in guys)
            {
                guy.UpdateLabels();
            }
        }

        private void radioButtonJoão_CheckedChanged(object sender, EventArgs e)
        {
            SetBettorNameTextLabel("João");
        }
        private void radioButtonBeto_CheckedChanged(object sender, EventArgs e)
        {
            SetBettorNameTextLabel("Beto");
        }
        private void radioButtonAlfredo_CheckedChanged(object sender, EventArgs e)
        {
            SetBettorNameTextLabel("Alfredo");
        }

        private void SetBettorNameTextLabel(string Name)
        {
            labelBettorName.Text = Name;
        }

        private void buttonBet_Click(object sender, EventArgs e)
        {
            int GuySelected = 0;

            if (radioButtonJoão.Checked)
                GuySelected = 0;

            if (radioButtonBeto.Checked)
                GuySelected = 1;

            if (radioButtonAlfredo.Checked)
                GuySelected = 2;

            guys[GuySelected].PlaceBet((int)numericBetAmount.Value, (int)numericDog.Value);
            guys[GuySelected].UpdateLabels();
        }

        private void buttonRace_Click(object sender, EventArgs e)
        {
            bool NoWinner = true;
            int winningDog;
            buttonRace.Enabled = false;

            while (NoWinner)
            {
                Application.DoEvents();
                for (int i = 0; i < dogs.Length; i++)
                {
                    if (dogs[i].Run())
                    {
                        winningDog = i + 1;
                        NoWinner = false;
                        MessageBox.Show("Temos um vencedor: cão número " + winningDog + "!");

                        foreach (Guy guy in guys)
                        {
                            if (guy.MyBet != null)
                            {
                                guy.Collect(winningDog);
                                guy.MyBet = null;
                                guy.UpdateLabels();
                            }
                        }

                        foreach (Greyhound dog in dogs)
                        {
                            dog.TakeStartingPosition();
                        }
                        break;
                    }
                }
            }

            buttonRace.Enabled = true;
        }
    }
}
