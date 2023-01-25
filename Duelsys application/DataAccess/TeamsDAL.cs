using DataAccess.ExceptionModels;
using DuelSysLogic.Interfaces.DAL;
using DuelSysLogic.Managers;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace DataAccess
{
    public class TeamsDAL : ITeamsRepository
    {
        private int associationId;
        private MySqlConnection conn
        {
            get
            {
                return Connection.Connect;
            }
        }

        public TeamsDAL(int associationId)
        {
            this.associationId = associationId;
        }

        public void CreateTeam(Team newTeam)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("INSERT INTO `teams`" +
                    "(`AssociationId`,`Name`)" +
                    " VALUES (@ASSOCIATIONID,@NAME)"
                    , conn);

                cmd.Parameters.AddWithValue("ASSOCIATIONID", associationId);
                cmd.Parameters.AddWithValue("NAME", newTeam.Name);

                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                Connection.CloseConnection();
                Debug.WriteLine(ex.Message);
                throw new DALException("Couldn't Create a team", ex);
            }
        }

        public Team GetTeam(int teamId)
        {
            throw new NotImplementedException();
        }

        public List<Team> GetTeams()
        {
            throw new NotImplementedException();
        }

        public int GetTeamIdByMemeberId(string teamName)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(
                    "SELECT `Id` " +
                    "FROM `teams` " +
                    "WHERE Name = @Name", conn);

                cmd.Parameters.AddWithValue("Name", teamName);

                object teamId = cmd.ExecuteScalar();

                return teamId != DBNull.Value ? Convert.ToInt32(teamId) : 0;
            }
            catch (MySqlException ex)
            {
                Connection.CloseConnection();
                Debug.WriteLine(ex.Message);
                throw new DALException("Couldn't get team id", ex);
            }

        }
    }
}
