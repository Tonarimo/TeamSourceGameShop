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
            // goes to catch on load, need to figure out why
        }

        private void PopulateGameList()
        {
            lstGamesList.Items.Clear();

            try
            {
                List<Game> games = GamesDB.getAllGames();

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
            // this does not properly work yet, it just adds another game
            // will be working on this later
            Game game = (Game)lstGamesList.SelectedItem;
            var updateGameForm = new frmAddOrUpdateGames(game);
            updateGameForm.ShowDialog();
            PopulateGameList();
        }
    }
}
