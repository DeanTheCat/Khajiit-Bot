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
    public partial class CreateTournament : Form
    {
        public CreateTournament()
        {
            InitializeComponent();
        }

        private void btn_tCreate_Click(object sender, EventArgs e)
        {
            string tName;
            int eRounds;
            int rating;
            int result;

            tName = tb_tName.Text;
            eRounds = trb_rounds.Value;
            if (cb_tRating.Checked)
            {
                rating = 1;
            }
            else
            {
                rating = 0;
            }

            ProcessingLogic PL = new ProcessingLogic();

            result = PL.registerTournament(tName, eRounds, rating);

            if (result == 1)
            {
                lbl_error.Text = "Tournament Successfully Registered";
            }
            else if (result == -1)
            {
                lbl_error.Text = "An error has occured";
            }
            else
            {
                lbl_error.Text = "Registration Unsuccessful";
            }
        }
    }
}
