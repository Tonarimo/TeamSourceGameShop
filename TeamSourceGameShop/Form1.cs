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
            frmAddOrUpdateGames addGameForm = new frmAddOrUpdateGames();
            addGameForm.ShowDialog();
        }

        private void frmGameShop_Load(object sender, EventArgs e)
        {
            //PopulateGameList();
            // goes to catch on load, need to figure out why
        }

        private void PopulateGameList()
        {
            txtGamesList.Items.Clear();

            try
            {
                List<Game> games = GamesDB.getAllGamesByName();

                foreach (Game game in games)
                {
                    txtGamesList.Items.Add(game);
                }
            }
            catch
            {
                MessageBox.Show("Error, please try again later");
                Application.Exit();
            }
        }
    }
}
