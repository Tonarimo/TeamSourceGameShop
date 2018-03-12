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
    public partial class frmGameShop : Form
    {
        public frmGameShop()
        {
            InitializeComponent();
        }

        private void btnAddGame_Click(object sender, EventArgs e)
        {
            frmAddOrUpdateGames addGameForm = new frmAddOrUpdateGames(null);
            addGameForm.ShowDialog();
            PopulateGameList();
        }

        private void frmGameShop_Load(object sender, EventArgs e)
        {
            PopulateGameList();
        }

        /// <summary>
        /// Populates the gamesListBox with all the 
        /// games that have been added into the database.
        /// </summary>
        private void PopulateGameList()
        {
            lstGamesList.Items.Clear();

            try
            {
                List<Game> games = GamesDB.getAllGamesByName();

                foreach (Game game in games)
                {
                    lstGamesList.Items.Add(game);
                }
            }
            catch
            {
                MessageBox.Show("Error, please try again later");
                Application.Exit();
            }
        }

        private void btnUpdateGame_Click(object sender, EventArgs e)
        {
            Game game = (Game)lstGamesList.SelectedItem;
            var updateGameForm = new frmAddOrUpdateGames(game);
            updateGameForm.ShowDialog();
            PopulateGameList();
        }

        private void txtSearchGames_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchGames.Text.Length > 0)
            {
                /**************START GET GAME BY NAME************/
                // clear the list
                lstGamesList.Items.Clear();

                // get the text from the search box
                string search = txtSearchGames.Text;

                // get a list of all games by name
                List<Game> games = GamesDB.getAllGamesByName();

                // get a second list of games to compare to
                List<Game> matches = new List<Game>();

                // get all games by name that contain the search name
                matches = games.Where(g => g.GameName.Contains(search)).ToList();

                // add them to the listbox when you find a game name that 
                // contains the search word
                foreach (var match in matches)
                {
                    lstGamesList.Items.Add(match);
                }
                /***************END GET GAME BY NAME*************/
                
                /**************START GET GAME BY PRICE***********/
                // get the text from the search box
                string search2 = txtSearchGames.Text;

                // get a list of all games by price
                List<Game> gamesByPrice = GamesDB.getAllGamesByPrice();

                // get a second list to compare to
                List<Game> match2 = new List<Game>();

                // get all games whose price starts with the price in the text box
                match2 = gamesByPrice.Where(g => g.Price.ToString().StartsWith(search)).ToList();

                // display all games whose price matches what is typed in the 
                // search box
                foreach (var i in match2)
                {
                    lstGamesList.Items.Add(match2);
                }
                /***************END GET GAME BY PRICE*************/
            }
            else
            {
                // populate the list with all the games
                PopulateGameList();
            }
        }

        private void btnDeleteGame_Click(object sender, EventArgs e)
        {
            Game games = (Game)lstGamesList.SelectedItem;
            GamesDB.deleteGame(games);
            PopulateGameList();
        }
    }
}
