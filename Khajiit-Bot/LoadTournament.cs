using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_KhajiitBot;

namespace Khajiit_Bot
{
    public partial class LoadTournament : Form
    {
        ProcessingLogic PL = new ProcessingLogic();

        public LoadTournament()
        {
            InitializeComponent();

            string[] tournamentList = PL.getTournamentList();

            ddl_tournament.DataSource = tournamentList;

        }

        private void lbl_loadHeader_Load(object sender, EventArgs e)
        {

        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            int result;
            string selected = ddl_tournament.SelectedValue.ToString();
            result = PL.getTournamentId(selected);

            KhajiitBot.tournament = result;
            KhajiitBot.tournamentLoaded = 1;

            lbl_error.Text = "Tournament Loaded";
        }
    }
}
