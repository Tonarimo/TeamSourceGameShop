using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamSourceGameShop
{
    class Game
    {
        private int _GameID { get; set; }
        
        private string _GameName { get; set; }

        private double _Price { get; set; }

        private int _NumberOfCopies { get; set; }

        private string _Availability { get; set; }

        public Game()
        {

        }

        public Game(string gameName, double price, int numberOfCopies, string availability)
        {
            GameName = gameName;
            Price = price;
            NumberOfCopies = numberOfCopies;
            Availability = availability;
        }

        public int GameID
        {
            get
            {
                return _GameID;
            }
            set
            {
                GameID = value;
            }
        }

        public string GameName
        {
            get
            {
                return _GameName;
            }
            set
            {
                GameName = value;
            }
        }

        public double Price
        {
            get
            {
                return _Price;
            }
            set
            {
                Price = value;
            }
        }

        public int NumberOfCopies
        {
            get
            {
                return _NumberOfCopies;
            }
            set
            {
                NumberOfCopies = value;
            }
        }

        public string Availability
        {
            get
            {
                return _Availability;
            }
            set
            {
                Availability = value;
            }
        }

        public override string ToString()
        {
            return _GameName + "     " + _Price + "     " + _NumberOfCopies + "     " + _Availability;
        }
    }
}
