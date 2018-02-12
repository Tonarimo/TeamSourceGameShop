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

        }
    }
}
