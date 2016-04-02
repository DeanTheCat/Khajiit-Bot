using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL_KhajiitBot;
using BLL_KhajiitBot;

namespace Khajiit_Bot
{
    public partial class KhajiitBot : Form
    {
        public static int tournament = 0;
        public static int tournamentLoaded = 0;

        public KhajiitBot()
        {
            InitializeComponent();
        }

        private void addDuelerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void createTournamentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateTournament frm = new CreateTournament();
            frm.Show();
        }

        private void loadTournamentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadTournament frm = new LoadTournament();
            frm.Show();
        }

        private void registerDuelersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(tournamentLoaded == 1)
            {
                RegisterDueler frm = new RegisterDueler();
                frm.Show();
            }else
            {
                LoadTournament frm = new LoadTournament();
                frm.Show();
            }
        }

        private void pairingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tournamentLoaded == 1)
            {
                Tournament frm = new Tournament();
                frm.Show();
            }
            else
            {
                LoadTournament frm = new LoadTournament();
                frm.Show();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("KhajiitBot was created by Dean the Cat. Please report any bugs to @DeanTheCat. Thank you. ");
        }

        
    }
}
