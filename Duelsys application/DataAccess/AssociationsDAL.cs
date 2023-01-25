using DataAccess.ExceptionModels;
using DuelSysLogic.Interfaces;
using DuelSysLogic.Managers;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace DataAccess
{
    public class AssociationsDAL : IAssociationsRepository
    {
        private MySqlConnection conn
        {
            get
            {
                return Connection.Connect;
            }
        }

        public void CreateAssociation(Association newAssocation)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("INSERT INTO `associations` " +
                    "(`Name`)" +
                    "VALUES(@NAME)"
                     , conn);

                cmd.Parameters.AddWithValue("NAME", newAssocation.Name);

                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                Connection.CloseConnection();
                Debug.WriteLine(ex.Message);
                throw new DALException("Couldn't Create assoication", ex);
            }
        }

        public Association GetAssociationById(int assocationId)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT Id, Name" +
                " FROM associations" +
                " WHERE Id = @ID"
                 , conn);

                cmd.Parameters.AddWithValue("ID", assocationId);

                using (var reader = cmd.ExecuteReader())
                {
                    reader.Read();

                    int id = reader.GetInt32("Id");
                    string name = reader.GetString("Name");
                    IAssociationRepository associationRepository = new AssociationDAL(id);

                    return new Association(id, name,associationRepository);
                }
            }
            catch (MySqlException ex)
            {
                Connection.CloseConnection();
                Debug.WriteLine(ex.Message);
                throw new DALException("Couldn't get a association", ex);
                return null;
            }
        }

        public List<Association> GetEightAssociationEachTime(int pageNumber)
        {
            try
            {
                --pageNumber;
                int groupNum = pageNumber * 8;

                List<Association> associationsDetails = new List<Association>();

                // Id is zero that is the DuelSys id
                MySqlCommand cmd = new MySqlCommand(
                    $"SELECT *" +
                    $"FROM associations " +
                    $"Where id != 0 " +
                    $"LIMIT {groupNum},8", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32("Id");
                        string name = reader.GetString("Name");
                        IAssociationRepository associationRepository = new AssociationDAL(id);

                        associationsDetails.Add(new Association(id, name, associationRepository));
                    }

                    return associationsDetails;
                }
            }
            catch (MySqlException ex)
            {
                Connection.CloseConnection();
                Debug.WriteLine(ex.Message);
                throw new DALException("Couldn't get associations list", ex);
                return null;
            }
        }

        public List<Association> GetAllAssociations()
        {
            try
            {

                List<Association> associationsDetails = new List<Association>();

                // Id is zero that is the DuelSys id
                MySqlCommand cmd = new MySqlCommand(
                    $"SELECT *" +
                    $"FROM associations " +
                    $"Where id != 0 ", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32("Id");
                        string name = reader.GetString("Name");
                        IAssociationRepository associationRepository = new AssociationDAL(id);

                        associationsDetails.Add(new Association(id, name, associationRepository));
                    }

                    return associationsDetails;
                }
            }
            catch (MySqlException ex)
            {
                Connection.CloseConnection();
                Debug.WriteLine(ex.Message);
                throw new DALException("Couldn't get associations list", ex);
                return null;
            }
        }
    }
}
