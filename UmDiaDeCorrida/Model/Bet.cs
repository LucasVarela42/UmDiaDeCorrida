using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmDiaDeCorrida.Model
{
    public class Bet
    {
        public int Amount;
        public int Dog;
        public Guy Bettor;

        public Bet(int amount, int dog, Guy bettor)
        {
            Amount = amount;
            Dog = dog;
            Bettor = bettor;
        }

        public string GetDescription()
        {
            if(Amount > 0)
            {
                return Bettor.Name + " apostou " + Amount + " no cão " + Dog;
            }
            return Bettor.Name + " não apostou";
        }
        public int PayOut(int Winner)
        {
            if(Dog == Winner)
            {
                return Amount*2;
            }
            return -Amount;
        }
    }
}
