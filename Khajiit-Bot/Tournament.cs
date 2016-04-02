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
    public partial class Tournament : Form
    {
        RatingLogic RL = new RatingLogic();
        ProcessingLogic PL = new ProcessingLogic();

        string name;
        int round = 1;
        int tID;
        string[] EPDuelerName;
        int[] EPDuelerRating;
        string[] ADDuelerName;
        int[] ADDuelerRating;
        string[] DCDuelerName;
        int[] DCDuelerRating;
        string[] EPSorted;
        string[] ADSorted;
        string[] DCSorted;
        int count = 1;
        int cycle = 1;
        int diff;
        int EPPass;
        int ADPass;
        int DCPass;
        int max;
        int EP;
        int AD;
        int DC;
        int min;
        string contestant1;
        string contestant2;
        

        public Tournament()
        {
            InitializeComponent();

            tID = KhajiitBot.tournament;

            name = PL.getTournamentName(tID);

            lbl_name.Text = name;

            lbl_round.Text = Convert.ToString(round);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            EPDuelerName = PL.getDuelerNameList(tID, 1);
            EPDuelerRating = PL.getDuelerRatingList(tID, 1);
            ADDuelerName = PL.getDuelerNameList(tID, 2);
            ADDuelerRating = PL.getDuelerRatingList(tID, 2);
            DCDuelerName = PL.getDuelerNameList(tID, 3);
            DCDuelerRating = PL.getDuelerRatingList(tID, 3);

            EPSorted = RL.sortByRating(EPDuelerRating, EPDuelerName);
            ADSorted = RL.sortByRating(ADDuelerRating, ADDuelerName);
            DCSorted = RL.sortByRating(DCDuelerRating, DCDuelerName);

            EP = EPSorted.Length;
            AD = ADSorted.Length;
            DC = DCSorted.Length;

            var list = new[] { EP, AD, DC };
            min = list.Min();
            max = list.Max();
            diff = max - min;

            if(min <= 3 && diff <= 3)
            {
                tb_pairings.AppendText("Final Round");
                tb_pairings.AppendText(Environment.NewLine);
                tb_pairings.AppendText(Environment.NewLine);

                if(EP == min)
                {
                    switch (EP)
                    {
                        case 1:
                            tb_pairings.AppendText("Best of 3: Championship");
                            tb_pairings.AppendText(Environment.NewLine);

                            contestant1 = EPSorted[EP - 1];
                            contestant2 = ADSorted[AD - 1];
                            tb_pairings.AppendText(contestant1 + " vs " + contestant2);
                            tb_pairings.AppendText(Environment.NewLine);

                            contestant1 = DCSorted[DC - 1];
                            contestant2 = ADSorted[AD - 1];
                            tb_pairings.AppendText(contestant1 + " vs " + contestant2);
                            tb_pairings.AppendText(Environment.NewLine);

                            contestant1 = EPSorted[EP - 1];
                            contestant2 = DCSorted[DC - 1];
                            tb_pairings.AppendText(contestant1 + " vs " + contestant2);
                            tb_pairings.AppendText(Environment.NewLine);
                            tb_pairings.AppendText(Environment.NewLine);

                            tb_pairings.AppendText("Best of 3: 1st Runner Up");
                            tb_pairings.AppendText(Environment.NewLine);
                            contestant1 = DCSorted[DC - 2];
                            contestant2 = ADSorted[AD - 2];
                            tb_pairings.AppendText(contestant1 + " vs " + contestant2);
                            tb_pairings.AppendText(Environment.NewLine);
                            tb_pairings.AppendText(Environment.NewLine);

                            tb_pairings.AppendText("Best of 3: 2nd Runner Up");
                            tb_pairings.AppendText(Environment.NewLine);
                            contestant1 = DCSorted[DC - 3];
                            contestant2 = ADSorted[AD - 3];
                            tb_pairings.AppendText(contestant1 + " vs " + contestant2);
                            tb_pairings.AppendText(Environment.NewLine);
                            break;



                        case 2:
                            tb_pairings.AppendText("Best of 3: Championship");
                            tb_pairings.AppendText(Environment.NewLine);

                            contestant1 = EPSorted[EP - 1];
                            contestant2 = ADSorted[AD - 1];
                            tb_pairings.AppendText(contestant1 + " vs " + contestant2);
                            tb_pairings.AppendText(Environment.NewLine);

                            contestant1 = DCSorted[DC - 1];
                            contestant2 = ADSorted[AD - 1];
                            tb_pairings.AppendText(contestant1 + " vs " + contestant2);
                            tb_pairings.AppendText(Environment.NewLine);

                            contestant1 = EPSorted[EP - 1];
                            contestant2 = DCSorted[DC - 1];
                            tb_pairings.AppendText(contestant1 + " vs " + contestant2);
                            tb_pairings.AppendText(Environment.NewLine);
                            tb_pairings.AppendText(Environment.NewLine);

                            tb_pairings.AppendText("Best of 3: 1st Runner Up");
                            tb_pairings.AppendText(Environment.NewLine);

                            contestant1 = EPSorted[EP - 2];
                            contestant2 = ADSorted[AD - 2];
                            tb_pairings.AppendText(contestant1 + " vs " + contestant2);
                            tb_pairings.AppendText(Environment.NewLine);

                            contestant1 = DCSorted[DC - 2];
                            contestant2 = ADSorted[AD - 2];
                            tb_pairings.AppendText(contestant1 + " vs " + contestant2);
                            tb_pairings.AppendText(Environment.NewLine);

                            contestant1 = EPSorted[EP - 2];
                            contestant2 = DCSorted[DC - 2];
                            tb_pairings.AppendText(contestant1 + " vs " + contestant2);
                            tb_pairings.AppendText(Environment.NewLine);
                            tb_pairings.AppendText(Environment.NewLine);

                            tb_pairings.AppendText("Best of 3: 2nd Runner Up");
                            tb_pairings.AppendText(Environment.NewLine);
                            contestant1 = DCSorted[DC - 3];
                            contestant2 = ADSorted[AD - 3];
                            tb_pairings.AppendText(contestant1 + " vs " + contestant2);
                            tb_pairings.AppendText(Environment.NewLine);
                            break;

                        case 3:
                            tb_pairings.AppendText("Best of 3: Championship");
                            tb_pairings.AppendText(Environment.NewLine);

                            contestant1 = EPSorted[EP - 1];
                            contestant2 = ADSorted[AD - 1];
                            tb_pairings.AppendText(contestant1 + " vs " + contestant2);
                            tb_pairings.AppendText(Environment.NewLine);

                            contestant1 = DCSorted[DC - 1];
                            contestant2 = ADSorted[AD - 1];
                            tb_pairings.AppendText(contestant1 + " vs " + contestant2);
                            tb_pairings.AppendText(Environment.NewLine);

                            contestant1 = EPSorted[EP - 1];
                            contestant2 = DCSorted[DC - 1];
                            tb_pairings.AppendText(contestant1 + " vs " + contestant2);
                            tb_pairings.AppendText(Environment.NewLine);
                            tb_pairings.AppendText(Environment.NewLine);

                            tb_pairings.AppendText("Best of 3: 1st Runner Up");
                            tb_pairings.AppendText(Environment.NewLine);

                            contestant1 = EPSorted[EP - 2];
                            contestant2 = ADSorted[AD - 2];
                            tb_pairings.AppendText(contestant1 + " vs " + contestant2);
                            tb_pairings.AppendText(Environment.NewLine);

                            contestant1 = DCSorted[DC - 2];
                            contestant2 = ADSorted[AD - 2];
                            tb_pairings.AppendText(contestant1 + " vs " + contestant2);
                            tb_pairings.AppendText(Environment.NewLine);

                            contestant1 = EPSorted[EP - 2];
                            contestant2 = DCSorted[DC - 2];
                            tb_pairings.AppendText(contestant1 + " vs " + contestant2);
                            tb_pairings.AppendText(Environment.NewLine);
                            tb_pairings.AppendText(Environment.NewLine);

                            tb_pairings.AppendText("Best of 3: 2nd Runner Up");
                            tb_pairings.AppendText(Environment.NewLine);

                            contestant1 = EPSorted[EP - 3];
                            contestant2 = ADSorted[AD - 3];
                            tb_pairings.AppendText(contestant1 + " vs " + contestant2);
                            tb_pairings.AppendText(Environment.NewLine);

                            contestant1 = DCSorted[DC - 3];
                            contestant2 = ADSorted[AD - 3];
                            tb_pairings.AppendText(contestant1 + " vs " + contestant2);
                            tb_pairings.AppendText(Environment.NewLine);

                            contestant1 = EPSorted[EP - 3];
                            contestant2 = DCSorted[DC - 3];
                            tb_pairings.AppendText(contestant1 + " vs " + contestant2);
                            tb_pairings.AppendText(Environment.NewLine);
                            tb_pairings.AppendText(Environment.NewLine);
                            break;
                    


                    }
                    
                }else if (AD == min)
                {
                    {
                        switch (AD)
                        {
                            case 1:
                                tb_pairings.AppendText("Best of 3: Championship");
                                tb_pairings.AppendText(Environment.NewLine);

                                contestant1 = EPSorted[EP - 1];
                                contestant2 = ADSorted[AD - 1];
                                tb_pairings.AppendText(contestant1 + " vs " + contestant2);
                                tb_pairings.AppendText(Environment.NewLine);

                                contestant1 = DCSorted[DC - 1];
                                contestant2 = ADSorted[AD - 1];
                                tb_pairings.AppendText(contestant1 + " vs " + contestant2);
                                tb_pairings.AppendText(Environment.NewLine);

                                contestant1 = EPSorted[EP - 1];
                                contestant2 = DCSorted[DC - 1];
                                tb_pairings.AppendText(contestant1 + " vs " + contestant2);
                                tb_pairings.AppendText(Environment.NewLine);
                                tb_pairings.AppendText(Environment.NewLine);

                                tb_pairings.AppendText("Best of 3: 1st Runner Up");
                                tb_pairings.AppendText(Environment.NewLine);
                                contestant1 = DCSorted[DC - 2];
                                contestant2 = EPSorted[EP - 2];
                                tb_pairings.AppendText(contestant1 + " vs " + contestant2);
                                tb_pairings.AppendText(Environment.NewLine);
                                tb_pairings.AppendText(Environment.NewLine);

                                tb_pairings.AppendText("Best of 3: 2nd Runner Up");
                                tb_pairings.AppendText(Environment.NewLine);
                                contestant1 = DCSorted[DC - 3];
                                contestant2 = EPSorted[EP - 3];
                                tb_pairings.AppendText(contestant1 + " vs " + contestant2);
                                tb_pairings.AppendText(Environment.NewLine);
                                break;



                            case 2:
                                tb_pairings.AppendText("Best of 3: Championship");
                                tb_pairings.AppendText(Environment.NewLine);

                                contestant1 = EPSorted[EP - 1];
                                contestant2 = ADSorted[AD - 1];
                                tb_pairings.AppendText(contestant1 + " vs " + contestant2);
                                tb_pairings.AppendText(Environment.NewLine);

                                contestant1 = DCSorted[DC - 1];
                                contestant2 = ADSorted[AD - 1];
                                tb_pairings.AppendText(contestant1 + " vs " + contestant2);
                                tb_pairings.AppendText(Environment.NewLine);

                                contestant1 = EPSorted[EP - 1];
                                contestant2 = DCSorted[DC - 1];
                                tb_pairings.AppendText(contestant1 + " vs " + contestant2);
                                tb_pairings.AppendText(Environment.NewLine);
                                tb_pairings.AppendText(Environment.NewLine);

                                tb_pairings.AppendText("Best of 3: 1st Runner Up");
                                tb_pairings.AppendText(Environment.NewLine);

                                contestant1 = EPSorted[EP - 2];
                                contestant2 = ADSorted[AD - 2];
                                tb_pairings.AppendText(contestant1 + " vs " + contestant2);
                                tb_pairings.AppendText(Environment.NewLine);

                                contestant1 = DCSorted[DC - 2];
                                contestant2 = ADSorted[AD - 2];
                                tb_pairings.AppendText(contestant1 + " vs " + contestant2);
                                tb_pairings.AppendText(Environment.NewLine);

                                contestant1 = EPSorted[EP - 2];
                                contestant2 = DCSorted[DC - 2];
                                tb_pairings.AppendText(contestant1 + " vs " + contestant2);
                                tb_pairings.AppendText(Environment.NewLine);
                                tb_pairings.AppendText(Environment.NewLine);

                                tb_pairings.AppendText("Best of 3: 2nd Runner Up");
                                tb_pairings.AppendText(Environment.NewLine);
                                contestant1 = DCSorted[DC - 3];
                                contestant2 = EPSorted[EP - 3];
                                tb_pairings.AppendText(contestant1 + " vs " + contestant2);
                                tb_pairings.AppendText(Environment.NewLine);
                                break;

                            case 3:
                                tb_pairings.AppendText("Best of 3: Championship");
                                tb_pairings.AppendText(Environment.NewLine);

                                contestant1 = EPSorted[EP - 1];
                                contestant2 = ADSorted[AD - 1];
                                tb_pairings.AppendText(contestant1 + " vs " + contestant2);
                                tb_pairings.AppendText(Environment.NewLine);

                                contestant1 = DCSorted[DC - 1];
                                contestant2 = ADSorted[AD - 1];
                                tb_pairings.AppendText(contestant1 + " vs " + contestant2);
                                tb_pairings.AppendText(Environment.NewLine);

                                contestant1 = EPSorted[EP - 1];
                                contestant2 = DCSorted[DC - 1];
                                tb_pairings.AppendText(contestant1 + " vs " + contestant2);
                                tb_pairings.AppendText(Environment.NewLine);
                                tb_pairings.AppendText(Environment.NewLine);

                                tb_pairings.AppendText("Best of 3: 1st Runner Up");
                                tb_pairings.AppendText(Environment.NewLine);

                                contestant1 = EPSorted[EP - 2];
                                contestant2 = ADSorted[AD - 2];
                                tb_pairings.AppendText(contestant1 + " vs " + contestant2);
                                tb_pairings.AppendText(Environment.NewLine);

                                contestant1 = DCSorted[DC - 2];
                                contestant2 = ADSorted[AD - 2];
                                tb_pairings.AppendText(contestant1 + " vs " + contestant2);
                                tb_pairings.AppendText(Environment.NewLine);

                                contestant1 = EPSorted[EP - 2];
                                contestant2 = DCSorted[DC - 2];
                                tb_pairings.AppendText(contestant1 + " vs " + contestant2);
                                tb_pairings.AppendText(Environment.NewLine);
                                tb_pairings.AppendText(Environment.NewLine);

                                tb_pairings.AppendText("Best of 3: 2nd Runner Up");
                                tb_pairings.AppendText(Environment.NewLine);

                                contestant1 = EPSorted[EP - 3];
                                contestant2 = ADSorted[AD - 3];
                                tb_pairings.AppendText(contestant1 + " vs " + contestant2);
                                tb_pairings.AppendText(Environment.NewLine);

                                contestant1 = DCSorted[DC - 3];
                                contestant2 = ADSorted[AD - 3];
                                tb_pairings.AppendText(contestant1 + " vs " + contestant2);
                                tb_pairings.AppendText(Environment.NewLine);

                                contestant1 = EPSorted[EP - 3];
                                contestant2 = DCSorted[DC - 3];
                                tb_pairings.AppendText(contestant1 + " vs " + contestant2);
                                tb_pairings.AppendText(Environment.NewLine);
                                tb_pairings.AppendText(Environment.NewLine);
                                break;


                        }
                    }
                    }else
                {
                    {
                        switch (DC)
                        {
                            case 1:
                                tb_pairings.AppendText("Best of 3: Championship");
                                tb_pairings.AppendText(Environment.NewLine);

                                contestant1 = EPSorted[EP - 1];
                                contestant2 = ADSorted[AD - 1];
                                tb_pairings.AppendText(contestant1 + " vs " + contestant2);
                                tb_pairings.AppendText(Environment.NewLine);

                                contestant1 = DCSorted[DC - 1];
                                contestant2 = ADSorted[AD - 1];
                                tb_pairings.AppendText(contestant1 + " vs " + contestant2);
                                tb_pairings.AppendText(Environment.NewLine);

                                contestant1 = EPSorted[EP - 1];
                                contestant2 = DCSorted[DC - 1];
                                tb_pairings.AppendText(contestant1 + " vs " + contestant2);
                                tb_pairings.AppendText(Environment.NewLine);
                                tb_pairings.AppendText(Environment.NewLine);

                                tb_pairings.AppendText("Best of 3: 1st Runner Up");
                                tb_pairings.AppendText(Environment.NewLine);
                                contestant1 = DCSorted[AD - 2];
                                contestant2 = EPSorted[EP - 2];
                                tb_pairings.AppendText(contestant1 + " vs " + contestant2);
                                tb_pairings.AppendText(Environment.NewLine);
                                tb_pairings.AppendText(Environment.NewLine);

                                tb_pairings.AppendText("Best of 3: 2nd Runner Up");
                                tb_pairings.AppendText(Environment.NewLine);
                                contestant1 = DCSorted[AD - 3];
                                contestant2 = EPSorted[EP - 3];
                                tb_pairings.AppendText(contestant1 + " vs " + contestant2);
                                tb_pairings.AppendText(Environment.NewLine);
                                break;



                            case 2:
                                tb_pairings.AppendText("Best of 3: Championship");
                                tb_pairings.AppendText(Environment.NewLine);

                                contestant1 = EPSorted[EP - 1];
                                contestant2 = ADSorted[AD - 1];
                                tb_pairings.AppendText(contestant1 + " vs " + contestant2);
                                tb_pairings.AppendText(Environment.NewLine);

                                contestant1 = DCSorted[DC - 1];
                                contestant2 = ADSorted[AD - 1];
                                tb_pairings.AppendText(contestant1 + " vs " + contestant2);
                                tb_pairings.AppendText(Environment.NewLine);

                                contestant1 = EPSorted[EP - 1];
                                contestant2 = DCSorted[DC - 1];
                                tb_pairings.AppendText(contestant1 + " vs " + contestant2);
                                tb_pairings.AppendText(Environment.NewLine);
                                tb_pairings.AppendText(Environment.NewLine);

                                tb_pairings.AppendText("Best of 3: 1st Runner Up");
                                tb_pairings.AppendText(Environment.NewLine);

                                contestant1 = EPSorted[EP - 2];
                                contestant2 = ADSorted[AD - 2];
                                tb_pairings.AppendText(contestant1 + " vs " + contestant2);
                                tb_pairings.AppendText(Environment.NewLine);

                                contestant1 = DCSorted[DC - 2];
                                contestant2 = ADSorted[AD - 2];
                                tb_pairings.AppendText(contestant1 + " vs " + contestant2);
                                tb_pairings.AppendText(Environment.NewLine);

                                contestant1 = EPSorted[EP - 2];
                                contestant2 = DCSorted[DC - 2];
                                tb_pairings.AppendText(contestant1 + " vs " + contestant2);
                                tb_pairings.AppendText(Environment.NewLine);
                                tb_pairings.AppendText(Environment.NewLine);

                                tb_pairings.AppendText("Best of 3: 2nd Runner Up");
                                tb_pairings.AppendText(Environment.NewLine);
                                contestant1 = DCSorted[AD - 3];
                                contestant2 = EPSorted[EP - 3];
                                tb_pairings.AppendText(contestant1 + " vs " + contestant2);
                                tb_pairings.AppendText(Environment.NewLine);
                                break;

                            case 3:
                                tb_pairings.AppendText("Best of 3: Championship");
                                tb_pairings.AppendText(Environment.NewLine);

                                contestant1 = EPSorted[EP - 1];
                                contestant2 = ADSorted[AD - 1];
                                tb_pairings.AppendText(contestant1 + " vs " + contestant2);
                                tb_pairings.AppendText(Environment.NewLine);

                                contestant1 = DCSorted[DC - 1];
                                contestant2 = ADSorted[AD - 1];
                                tb_pairings.AppendText(contestant1 + " vs " + contestant2);
                                tb_pairings.AppendText(Environment.NewLine);

                                contestant1 = EPSorted[EP - 1];
                                contestant2 = DCSorted[DC - 1];
                                tb_pairings.AppendText(contestant1 + " vs " + contestant2);
                                tb_pairings.AppendText(Environment.NewLine);
                                tb_pairings.AppendText(Environment.NewLine);

                                tb_pairings.AppendText("Best of 3: 1st Runner Up");
                                tb_pairings.AppendText(Environment.NewLine);

                                contestant1 = EPSorted[EP - 2];
                                contestant2 = ADSorted[AD - 2];
                                tb_pairings.AppendText(contestant1 + " vs " + contestant2);
                                tb_pairings.AppendText(Environment.NewLine);

                                contestant1 = DCSorted[DC - 2];
                                contestant2 = ADSorted[AD - 2];
                                tb_pairings.AppendText(contestant1 + " vs " + contestant2);
                                tb_pairings.AppendText(Environment.NewLine);

                                contestant1 = EPSorted[EP - 2];
                                contestant2 = DCSorted[DC - 2];
                                tb_pairings.AppendText(contestant1 + " vs " + contestant2);
                                tb_pairings.AppendText(Environment.NewLine);
                                tb_pairings.AppendText(Environment.NewLine);

                                tb_pairings.AppendText("Best of 3: 2nd Runner Up");
                                tb_pairings.AppendText(Environment.NewLine);

                                contestant1 = EPSorted[EP - 3];
                                contestant2 = ADSorted[AD - 3];
                                tb_pairings.AppendText(contestant1 + " vs " + contestant2);
                                tb_pairings.AppendText(Environment.NewLine);

                                contestant1 = DCSorted[DC - 3];
                                contestant2 = ADSorted[AD - 3];
                                tb_pairings.AppendText(contestant1 + " vs " + contestant2);
                                tb_pairings.AppendText(Environment.NewLine);

                                contestant1 = EPSorted[EP - 3];
                                contestant2 = DCSorted[DC - 3];
                                tb_pairings.AppendText(contestant1 + " vs " + contestant2);
                                tb_pairings.AppendText(Environment.NewLine);
                                tb_pairings.AppendText(Environment.NewLine);
                                break;


                        }
                    }
                }
            }
            else
            {
                tb_pairings.AppendText("Elimination Rounds");
                tb_pairings.AppendText(Environment.NewLine);
                tb_pairings.AppendText(Environment.NewLine);

                cycle = 1;
                EPPass = 0;
                ADPass = 0;
                DCPass = 0;

                while (EPPass < min || ADPass < min || DCPass < min)
                {
                    if (cycle == 1)
                    {
                        contestant1 = EPSorted[EPPass];
                        contestant2 = ADSorted[ADPass];
                        cycle = cycle + 1;
                        tb_pairings.AppendText(contestant1 + " vs " + contestant2);
                        tb_pairings.AppendText(Environment.NewLine);
                        EPPass = EPPass + 1;
                        ADPass = ADPass + 1;
                    }
                    else if (cycle == 2)
                    {
                        contestant1 = ADSorted[ADPass];
                        contestant2 = DCSorted[DCPass];
                        cycle = cycle + 1;
                        tb_pairings.AppendText(contestant1 + " vs " + contestant2);
                        tb_pairings.AppendText(Environment.NewLine);
                        ADPass = ADPass + 1;
                        DCPass = DCPass + 1;
                    }
                    else
                    {
                        contestant1 = DCSorted[DCPass];
                        contestant2 = EPSorted[EPPass];
                        cycle = 1;
                        tb_pairings.AppendText(contestant1 + " vs " + contestant2);
                        tb_pairings.AppendText(Environment.NewLine);
                        EPPass = EPPass + 1;
                        DCPass = DCPass + 1;
                    }
                }

                if (EP == min)
                {
                    count = min;

                    if (AD < DC)
                    {
                        diff = DC - AD;
                        max = max - diff;

                        while (count < max)
                        {
                            contestant1 = ADSorted[(count - 1)];
                            contestant2 = DCSorted[(count - 1)];
                            count = count + 1;
                            tb_pairings.AppendText(contestant1 + " vs " + contestant2);
                            tb_pairings.AppendText(Environment.NewLine);
                        }

                        tb_pairings.AppendText("Any contestant who does not have their name appear here gets a bye");
                    } else if (DC < AD)
                    {
                        diff = AD - DC;
                        max = max - diff;

                        while (count < max)
                        {
                            contestant1 = ADSorted[(count - 1)];
                            contestant2 = DCSorted[(count - 1)];
                            count = count + 1;
                            tb_pairings.AppendText(contestant1 + " vs " + contestant2);
                            tb_pairings.AppendText(Environment.NewLine);
                        }

                        tb_pairings.AppendText("Any contestant who does not have their name appear here gets a bye");
                    }else
                    {
                        while (count < max)
                        {
                            contestant1 = ADSorted[count - 1];
                            contestant2 = DCSorted[count - 1];
                            count = count + 1;
                            tb_pairings.AppendText(contestant1 + " vs " + contestant2);
                            tb_pairings.AppendText(Environment.NewLine);
                        }
                    }
                }
                else if (AD == min)
                {
                    count = 1;

                    if (EP < DC)
                    {
                        diff = DC - EP;
                        max = max - diff;

                        while (count < max)
                        {
                            contestant1 = EPSorted[(count - 1)];
                            contestant2 = DCSorted[(count - 1)];
                            count = count + 1;
                            tb_pairings.AppendText(contestant1 + " vs " + contestant2);
                            tb_pairings.AppendText(Environment.NewLine);
                        }

                        tb_pairings.AppendText("Any contestant who does not have their name appear here gets a bye");
                    }
                    else if (DC < EP)
                    {
                        diff = EP - DC;
                        max = max - diff;

                        while (count < max)
                        {
                            contestant1 = EPSorted[(count - 1)];
                            contestant2 = DCSorted[(count - 1)];
                            count = count + 1;
                            tb_pairings.AppendText(contestant1 + " vs " + contestant2);
                            tb_pairings.AppendText(Environment.NewLine);
                        }

                        tb_pairings.AppendText("Any contestant who does not have their name appear here gets a bye");
                    }
                    else
                    {
                        while (count < max)
                        {
                            contestant1 = EPSorted[(count - 1)];
                            contestant2 = DCSorted[(count - 1)];
                            count = count + 1;
                            tb_pairings.AppendText(contestant1 + " vs " + contestant2);
                            tb_pairings.AppendText(Environment.NewLine);
                        }
                    }
                }
                else
                {
                    count = 1;

                    if (AD < EP)
                    {
                        diff = EP - AD;
                        max = max - diff;

                        while (count < max)
                        {
                            contestant1 = ADSorted[(count - 1)];
                            contestant2 = EPSorted[(count - 1)];
                            count = count + 1;
                            tb_pairings.AppendText(contestant1 + " vs " + contestant2);
                            tb_pairings.AppendText(Environment.NewLine);
                        }

                        tb_pairings.AppendText("Any contestant who does not have their name appear here gets a bye");
                    }
                    else if (EP < AD)
                    {
                        diff = AD - EP;
                        max = max - diff;

                        while (count < max)
                        {
                            contestant1 = ADSorted[(count - 1)];
                            contestant2 = EPSorted[(count - 1)];
                            count = count + 1;
                            tb_pairings.AppendText(contestant1 + " vs " + contestant2);
                            tb_pairings.AppendText(Environment.NewLine);
                        }

                        tb_pairings.AppendText("Any contestant who does not have their name appear here gets a bye");
                    }
                    else
                    {
                        while (count < max)
                        {
                            contestant1 = ADSorted[(count - 1)];
                            contestant2 = EPSorted[(count - 1)];
                            count = count + 1;
                            tb_pairings.AppendText(contestant1 + " vs " + contestant2);
                            tb_pairings.AppendText(Environment.NewLine);
                        }
                    }
                }
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            tb_pairings.Text = "";
            round = round + 1;
            lbl_round.Text = Convert.ToString(round);

        }

        private void btn_execute_Click(object sender, EventArgs e)
        {
            int result;
            string eliminate = tb_eliminate.Text;

            result = PL.deleteDueler(eliminate, tID);

            if (result == 1)
            {
                lbl_error.Text = "Dueler Successfully Eliminated";
            }
            else if (result == -1)
            {
                lbl_error.Text = "An error has occured";
            }
            else
            {
                lbl_error.Text = "Elimination Unsuccessful";
            }
        }
    }
}
