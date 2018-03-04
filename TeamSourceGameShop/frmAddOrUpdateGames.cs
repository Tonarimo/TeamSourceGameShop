using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamSourceGameShop
{
    public partial class frmAddOrUpdateGames : Form
    {
        private Game gameToBeUpdated;
        public frmAddOrUpdateGames(Game game)
        {
            gameToBeUpdated = game;
            InitializeComponent();
        }

        private void btnAddOrUpdateGame_Click(object sender, EventArgs e)
        {
            Game game;
            if(gameToBeUpdated == null)
            {
                game = new Game();
            }
            else
            {
                game = gameToBeUpdated;
            }
            if (!string.IsNullOrWhiteSpace(txtNameOfGame.Text)
                && !string.IsNullOrWhiteSpace(txtNumberOfCopies.Text)
                && !string.IsNullOrWhiteSpace(txtPrice.Text)
                && IsAnInt(txtNumberOfCopies.Text) == true
                && IsADecimal(txtPrice.Text) == true
                && !string.IsNullOrWhiteSpace(txtAvailability.Text))
            {
                game.GameName = txtNameOfGame.Text;
                game.NumberOfCopies = Convert.ToInt32(txtNumberOfCopies.Text);
                game.Price = Convert.ToDouble(txtPrice.Text);
                game.Availability = txtAvailability.Text;

                GamesDB.AddOrUpdateGame(game);
            }
            else
            {
                MessageBox.Show("You must enter something in all four fields.");
            }
        }

        private bool IsAnInt(string data)
        {
            int value;
            bool result = int.TryParse(data, out value);
            if(result == false)
            {
                MessageBox.Show("Number of Copies must be an integer.");
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool IsADecimal(string data)
        {
            decimal value;
            bool result = decimal.TryParse(data, out value);
            if (result == false)
            {
                MessageBox.Show("Price must be a decimal.");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void frmAddOrUpdateGames_Load(object sender, EventArgs e)
        {
            if (gameToBeUpdated != null) // add a new game
            {
                LoadUpdateGameData();
                btnAddOrUpdateGame.Text = "Update Game";
            }
            else
            {
                btnAddOrUpdateGame.Text = "Add Game";
            }
        }

        private void LoadUpdateGameData()
        {
            txtNameOfGame.Text = gameToBeUpdated.GameName;
            txtNumberOfCopies.Text = gameToBeUpdated.NumberOfCopies.ToString();
            txtPrice.Text = gameToBeUpdated.Price.ToString();
            txtAvailability.Text = gameToBeUpdated.Availability.ToString();
        }

        private void txtPrice_Leave(object sender, EventArgs e)
        {
            double amount = 0.00d;
            if (Double.TryParse(txtPrice.Text, out amount))
            {
                txtPrice.Text = amount.ToString("0.00");
            }
        }
    }
}
