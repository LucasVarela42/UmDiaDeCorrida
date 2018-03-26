using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UmDiaDeCorrida.Model
{
    public class Guy
    {
        public string Name;
        public Bet MyBet;
        public int Cash;
        public RadioButton MyRadioButton;
        public Label MyLabel;

        public Guy(string name, Bet myBet, int cash, RadioButton myRadioButton, Label myLabel)
        {
            Name = name;
            MyBet = myBet;
            Cash = cash;
            MyRadioButton = myRadioButton;
            MyLabel = myLabel;
        }

        public void UpdateLabels()
        {
            if (MyBet == null)
            {
                MyLabel.Text = Name + " ainda não apostou";
            }
            else
            {
                MyLabel.Text = MyBet.GetDescription();
            }
            MyRadioButton.Text = Name + " tem " + Cash + " Reais";
        }
        public void ClearBet()
        {
            if(MyBet != null)
            {
                MyBet.Amount = 0;
            }
        }
        public bool PlaceBet(int Amount, int Dog)
        {
            if (Amount <= Cash)
            {
                MyBet = new Bet(Amount, Dog, this);
                return true;
            }
            return false;
        }
        public void Collect(int Winner)
        {
            Cash += MyBet.PayOut(Winner);
        }

    }
}
