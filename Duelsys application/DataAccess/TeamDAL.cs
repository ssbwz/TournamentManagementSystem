using DataAccess.ExceptionModels;
using DuelSysLogic.Interfaces.DAL;
using DuelSysLogic.Models;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace DataAccess
{
    public class TeamDAL : ITeamRepository
    {
        private int teamId;

        public TeamDAL(int teamId)
        {
            this.teamId = teamId;
        }

        private MySqlConnection conn
        {
            get
            {
                return Connection.Connect;
            }
        }

        public void AddMember(int newMember)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("INSERT INTO `teams_members`(`teamId`, `playerId`) " +
                    "VALUES (@TEAMID,@PLAYERID)", conn);

                cmd.Parameters.AddWithValue("TEAMID", teamId);
                cmd.Parameters.AddWithValue("PLAYERID", newMember);

                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                Connection.CloseConnection();
                Debug.WriteLine(ex.Message);
                throw new DALException("Couldn't register a player in a team", ex);
            }
        }

        public List<Player> GetMemebers()
        {
            throw new NotImplementedException();
        }

        public void RemoveMember(int newMember)
        {
            throw new NotImplementedException();
        }
    }
}
