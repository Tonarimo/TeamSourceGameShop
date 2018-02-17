using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            game.GameName = txtNameOfGame.Text;
            game.NumberOfCopies = Convert.ToInt32(txtNumberOfCopies.Text);
            game.Price = Convert.ToDouble(txtPrice.Text);
            game.Availability = txtAvailability.Text;

            GamesDB.AddGame(game);

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
    }
}
