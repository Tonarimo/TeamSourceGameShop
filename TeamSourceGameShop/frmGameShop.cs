﻿using System;
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

        private void txtSearchGames_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchGames.Text.Length > 0)
            {
                lstGamesList.Items.Clear();
                string search = txtSearchGames.Text;

                List<Game> games = GamesDB.getAllGames();

                List<Game> matches = new List<Game>();

                matches = games.Where(g => g.GameName.Contains(search)).ToList();

                foreach (var match in matches)
                {
                    lstGamesList.Items.Add(match);
                }

                string search2 = txtSearchGames.Text;


                List<Game> gamesByPrice = GamesDB.getAllGamesByPrice();

                List<Game> match2 = new List<Game>();

                match2 = gamesByPrice.Where(g => g.Price.ToString().StartsWith(search)).ToList();

                foreach (var match in match2)
                {
                    lstGamesList.Items.Add(match);
                }
            }
            else
            {
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
