using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;

namespace DAL_KhajiitBot
{
    public class DatabaseControl
    {
        string DBConn = Properties.Settings.Default.DBConn;

        public int registerDueler(string nameIn, int ratingIn, int tIDIn, int factionIn)
        {
            int check;

            SqlConnection conn = new SqlConnection(DBConn);
            SqlCommand cmd = new SqlCommand("INSERT INTO Duelers (Name, Rating, tID, faction) VALUES ('" + nameIn + "' , "+ ratingIn + " , " + tIDIn + ", " + factionIn + ") ", conn);

            try
            {
                conn.Open();
                check = cmd.ExecuteNonQuery();
            }
            catch
            {
                check = -1;
            }
            finally
            {
                conn.Close();
            }

            return check;
            
        }

        public int getDuelerRating(string nameIn)
        {
            int rating;

            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand("SELECT Rating FROM Duelers WHERE Name = '" + nameIn + "'", conn);

            try
            {
                conn.Open();
                rating = (Int32)cmd.ExecuteScalar();
            }
            catch
            {
                rating = -1;
            }
            finally
            {
                conn.Close();
            }

            return rating;
        }

        public int registerTournament(string nameIn, int roundsIn, int useRating)
        {
            int check;

            SqlConnection conn = new SqlConnection(DBConn);
            SqlCommand cmd = new SqlCommand("INSERT INTO TournamentList (TournamentName, ERounds, UseRating) VALUES ('" + nameIn + "' , " + roundsIn + " , " + useRating + ") ", conn);

            try
            {
                conn.Open();
                check = cmd.ExecuteNonQuery();
            }
            catch
            {
                check = -1;
            }
            finally
            {
                conn.Close();
            }

            return check;

        }

        public int getTournamentID(string nameIn)
        {
            int id;

            SqlConnection conn = new SqlConnection(DBConn);
            SqlCommand cmd = new SqlCommand("SELECT Id FROM TournamentList WHERE TournamentName = '" + nameIn + "'", conn);

            try
            {
                conn.Open();
                id = (Int32)cmd.ExecuteScalar();
            }
            catch
            {
                id = -1;
            }
            finally
            {
                conn.Close();
            }

            return id;
        }

        public string getTournamentName(int tID)
        {
            string name;

            SqlConnection conn = new SqlConnection(DBConn);
            SqlCommand cmd = new SqlCommand("SELECT TournamentName FROM TournamentList WHERE Id = '" + tID + "'", conn);

            try
            {
                conn.Open();
                name = (String)cmd.ExecuteScalar();
            }
            catch
            {
                name = "-1";
            }
            finally
            {
                conn.Close();
            }

            return name;
        }

        public string[] getTournamentList()
        {
            List<string> TournamentNames;
            string[] TournamentNamesArray;

            SqlConnection conn = new SqlConnection(DBConn);
            SqlCommand cmd = new SqlCommand("SELECT TournamentName FROM TournamentList", conn);
            SqlDataReader rdr = null;

            try
            {
                conn.Open();
                rdr = cmd.ExecuteReader();

                TournamentNames = (from IDataRecord r in rdr
                                   select (string)r["TournamentName"]
                                   ).ToList();

                TournamentNamesArray = TournamentNames.ToArray();
            }
            catch
            {
                string[] error = new string[] { "-1" };
                return error;
            }
            finally
            {
                conn.Close();
            }

            return TournamentNamesArray;
        }

        public string[] getDuelerNameListFaction(int tNum, int faction)
        {
            List<string> DuelerNames;
            string[] DuelerNamesArray;

            SqlConnection conn = new SqlConnection(DBConn);
            SqlCommand cmd = new SqlCommand("SELECT Name FROM Duelers WHERE tID = '" + tNum + "' AND faction ='" + faction + "'", conn);
            SqlDataReader rdr = null;

            try
            {
                conn.Open();
                rdr = cmd.ExecuteReader();

                DuelerNames = (from IDataRecord r in rdr
                                   select (string)r["Name"]
                                   ).ToList();

                DuelerNamesArray = DuelerNames.ToArray();
            }
            catch
            {
                string[] error = new string[] { "-1" };
                return error;
            }
            finally
            {
                conn.Close();
            }

            return DuelerNamesArray;
        }

        public int[] getDuelerRatingListFaction(int tNum, int faction)
        {
            List<int> DuelerRating;
            int[] DuelerRatingArray;

            SqlConnection conn = new SqlConnection(DBConn);
            SqlCommand cmd = new SqlCommand("SELECT Rating FROM Duelers WHERE tID = '" + tNum + "' AND faction ='" + faction + "'", conn);
            SqlDataReader rdr = null;

            try
            {
                conn.Open();
                rdr = cmd.ExecuteReader();

                DuelerRating = (from IDataRecord r in rdr
                               select (int)r["Rating"]
                                   ).ToList();

                DuelerRatingArray = DuelerRating.ToArray();
            }
            catch
            {
                int[] error = new int[] { -1 };
                return error;
            }
            finally
            {
                conn.Close();
            }

            return DuelerRatingArray;
        }

        public int deleteDueler(string nameIn, int tIDIn)
        {
            int check;

            SqlConnection conn = new SqlConnection(DBConn);
            SqlCommand cmd = new SqlCommand("DELETE FROM Duelers WHERE Name = '" + nameIn + "' AND tID = '" + tIDIn + "'", conn);

            try
            {
                conn.Open();
                check = cmd.ExecuteNonQuery();
            }
            catch
            {
                check = -1;
            }
            finally
            {
                conn.Close();
            }

            return check;

        }
    }
}
