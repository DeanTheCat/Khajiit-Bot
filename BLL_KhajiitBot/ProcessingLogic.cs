using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_KhajiitBot;

namespace BLL_KhajiitBot
{
    public class ProcessingLogic
    {
        DatabaseControl DBConn = new DatabaseControl();
        RatingLogic RL = new RatingLogic();

        public int registerDueler(string name, int charClass, int gear, int IsMag, int level, int tournament, int faction)
        {
            int rating;
            int result;

            rating = RL.calculateRating(charClass, IsMag, gear, level);

            result = DBConn.registerDueler(name, rating, tournament, faction);

            return result;
        }

        public int registerTournament(string tournamentName, int eRounds, int rating)
        {
            int result;

            result = DBConn.registerTournament(tournamentName, eRounds, rating);

            return result;
        }

        public string[] getTournamentList()
        {
            string[] result;

            result = DBConn.getTournamentList();

            return result;
        }

        public int getTournamentId(string name)
        {
            int result;

            result = DBConn.getTournamentID(name);

            return result;
        }

        public string getTournamentName(int tID)
        {
            string result;

            result = DBConn.getTournamentName(tID);

            return result;
        }

        public string[] getDuelerNameList(int tID, int faction)
        {
            string[] result;

            result = DBConn.getDuelerNameListFaction(tID, faction);

            return result;
        }

        public int[] getDuelerRatingList(int tID, int faction)
        {
            int[] result;

            result = DBConn.getDuelerRatingListFaction(tID, faction);

            return result;
        }

        public int deleteDueler(string name, int tID)
        {
            int result;

            result = DBConn.deleteDueler(name, tID);

            return result;
        }
    }
}
