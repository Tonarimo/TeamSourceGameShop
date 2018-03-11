using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamSourceGameShop
{
    public class Game
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
                _GameID = value;
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
                _GameName = value;
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
                _Price = value;
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
                _NumberOfCopies = value;
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
                _Availability = value;
            }
        }

        public override string ToString()
        {
            return String.Format("{0, -35} {1, -30} {2, -15} {3, 5}", _GameName,  $"{_Price:c}", _NumberOfCopies, _Availability);
        }
    }
}
