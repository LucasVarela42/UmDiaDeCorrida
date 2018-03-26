using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UmDiaDeCorrida.Model
{
    public class Greyhound
    {
        public int StartingPosition;
        public int RacetrackLength;
        public PictureBox MyPictureBox = null;
        public int Location = 0;
        public Random MyRandom;

        public Greyhound(int startingPosition, int racetrackLength, PictureBox myPictureBox)
        {
            StartingPosition = startingPosition;
            RacetrackLength = racetrackLength;
            MyPictureBox = myPictureBox;
        }

        public bool Run()
        {
            MyRandom = new Random();
            int distance = MyRandom.Next(1, 4);
            MoveMyPictureBox(distance);
            Location += distance;
            if (Location >= (RacetrackLength - StartingPosition))  //Posição Final 
            {
                return true;
            }
            return false;
        }

        private void MoveMyPictureBox(int distance)
        {
            Point p = MyPictureBox.Location;
            p.X += distance;
            MyPictureBox.Location = p;
        }

        public void TakeStartingPosition()
        {
            MoveMyPictureBox(-Location);
            Location = 0;
        }
    }
}
