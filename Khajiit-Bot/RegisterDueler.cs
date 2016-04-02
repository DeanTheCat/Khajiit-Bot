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
    public partial class RegisterDueler : Form
    {
        public RegisterDueler()
        {
            InitializeComponent();
        }

        private void lbl_name_Click(object sender, EventArgs e)
        {

        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            string name;
            int tID;
            int charClassNum = 0;
            string charClass;
            string buildType;
            int IsMag;
            string gear;
            int gearNum = 0;
            int level;
            int result;
            string faction;
            int factionNum = 0;


            name = tb_name.Text;
            charClass = ddl_class.SelectedItem.ToString();
            buildType = ddl_type.SelectedItem.ToString();
            gear = ddl_gear.SelectedItem.ToString();
            tID = KhajiitBot.tournament;
            faction = ddl_faction.SelectedItem.ToString();
            
            if (cb_VR.Checked)
            {
                level = Convert.ToInt32(tb_lvl.Text) + 50;
            }
            else
            {
                level = Convert.ToInt32(tb_lvl.Text);
            }

            switch(charClass)
            {
                case "Nightblade":
                    charClassNum = 1;
                    break;

                case "Templar":
                    charClassNum = 2;
                    break;

                case "Sorcerer":
                    charClassNum = 3;
                    break;

                case "Dragonknight":
                    charClassNum = 4;
                    break;
            }

            if (buildType == "Magicka")
            {
                IsMag = 1;
            }
            else
            {
                IsMag = 0;
            }

            switch(gear)
            {
                case "Blue":
                    gearNum = 1;
                    break;

                case "Purple":
                    gearNum = 2;
                    break;

                case "Gold":
                    gearNum = 3;
                    break;
            }

            switch(faction)
            {
                case "EP":
                    factionNum = 1;
                    break;

                case "AD":
                    factionNum = 2;
                    break;

                case "DC":
                    factionNum = 3;
                    break;
            }

            ProcessingLogic PL = new ProcessingLogic();

            result = PL.registerDueler(name, charClassNum, gearNum, IsMag, level, tID, factionNum);

            if (result == 1)
            {
                lbl_error.Text = "Dueler Successfully Registered";
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

        private void lbl_gear_Click(object sender, EventArgs e)
        {

        }
    }
}
