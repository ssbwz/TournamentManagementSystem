using DataAccess.ExceptionModels;
using DuelSys_Logic.Enums;
using DuelSys_Logic.Models;
using DuelSysLogic.Enums;
using DuelSysLogic.Enums.Sport;
using DuelSysLogic.Interfaces;
using DuelSysLogic.Models;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace DataAccess.UserManagement
{
    public class UserDAL : IUserRepository
    {
        private MySqlConnection conn
        {
            get
            {
                return Connection.Connect;
            }
        }

        public void CreateUser(User newUser)
        {
            try
            {
                string sql = " ";
                int lastUserId = getLastUserId();

                if (lastUserId == -1)
                {
                    throw new DALException("couldn't create new id");
                    Debug.WriteLine("couldn't create new id for user in data access layer");
                    return;
                }
                lastUserId++;

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                sql = "INSERT INTO `users` " +
                "(`AssociationId`,`Id`, `FirstName`, `LastName`, `Gender`, `BirthDate`, `PhoneNumber`, `Email`, `Username`, `Password`, `Salt`,`TYPE`) " +
                "VALUES (@ASSOCIATIONID,@ID,@FIRSTNAME,@LASTNAME,@GENDER,@BIRTHDAY,@PHONENUMBER,@EMAIL,@USERNAME,@PASSWORD,@SALT,@TYPE);";


                cmd.Parameters.AddWithValue("ID", lastUserId);
                cmd.Parameters.AddWithValue("FIRSTNAME", newUser.FirstName);
                cmd.Parameters.AddWithValue("LASTNAME", newUser.LastName);
                cmd.Parameters.AddWithValue("GENDER", newUser.Gender.ToString());
                cmd.Parameters.AddWithValue("BIRTHDAY", newUser.BirthDate);
                cmd.Parameters.AddWithValue("PHONENUMBER", newUser.PhoneNumber);
                cmd.Parameters.AddWithValue("EMAIL", newUser.Email);
                cmd.Parameters.AddWithValue("USERNAME", newUser.UserCredentials.UserName);
                cmd.Parameters.AddWithValue("PASSWORD", newUser.UserCredentials.HashedPassword);
                cmd.Parameters.AddWithValue("SALT", newUser.UserCredentials.Salt);
                cmd.Parameters.AddWithValue("ASSOCIATIONID", newUser.UserCredentials.AssociationId);
                cmd.Parameters.AddWithValue("TYPE", newUser.UserCredentials.UserType.ToString());

                if (newUser is Staff staff)
                {
                    sql += " " + "INSERT INTO `staffs`(`UserId`, `BSN`) " +
                        "VALUES (@USERID,@BSN)";

                    cmd.Parameters.AddWithValue("USERID", lastUserId);
                    cmd.Parameters.AddWithValue("BSN", staff.BSN);

                }
                if (newUser is Player player)
                {
                    sql += " " + "INSERT INTO `players`" +
                        "(`UserId`, `SportPreference`)" +
                        " VALUES (@USERID,@SPORTPREFERENCE)";

                    cmd.Parameters.AddWithValue("USERID", lastUserId);
                    cmd.Parameters.AddWithValue("SPORTPREFERENCE", player.SportPreference.ToString());
                }

                cmd.CommandText = sql;

                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                if (ex.Message.Contains("key"))
                {
                    if (ex.Message.Contains("UQ_AssocID_PhoneNumber"))
                    {
                        throw new PhoneNumberDuplicationException("This phone number is already used", ex);
                    }
                    if (ex.Message.Contains("UQ_AssocID_Email"))
                    {
                        throw new EmailDuplicationException("This email is already used", ex);
                    }
                    if (ex.Message.Contains("UQ_AssocID_Username"))
                    {
                        throw new UsernameDuplicationException("This username is already used", ex); ;
                    }
                }
                Connection.CloseConnection();
                Debug.WriteLine(ex.Message);
                throw new DALException("Couldn't create user", ex);
            }
        }

        public void DeleteUser(User selectedUser)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(
                    "DELETE FROM `users` WHERE id =@ID"
                    , conn);

                cmd.Parameters.AddWithValue("ID", selectedUser.UserCredentials.Id);

                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                Connection.CloseConnection();
                Debug.WriteLine(ex.Message);
                throw new DALException("User doesn't got deleted");
            }

        }

        public UserCredentials GetUserCredentials(string username)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT u.Id  Id,Username, Password, Salt, Type, AssociationId ,p.Id PlayerId " +
                    "FROM `users` u LEFT JOIN `players` p " +
                    "ON u.Id = p.UserId " +
                    "WHERE Username LIKE @USERNAME"
                    , conn);

                cmd.Parameters.AddWithValue("USERNAME", username);

                using (var reader = cmd.ExecuteReader())
                {
                    if (!reader.HasRows)
                    {
                        return null;
                    }
                    reader.Read();
                    UserCredentials userCredentials = null;

                    if (reader["PlayerId"] != DBNull.Value)
                    {
                        userCredentials = new UserCredentials(
                        reader.GetInt32("Id"),
                        reader.GetInt32("PlayerId"),
                        reader.GetString("Username"),
                        reader.GetString("Password"),
                        reader.GetString("Salt"),
                        (UserType)Enum.Parse(typeof(UserType), reader.GetString("Type")),
                        reader.GetInt32("AssociationId"));
                    }
                    else
                    {
                        userCredentials = new UserCredentials(
                           reader.GetInt32("Id"),
                           reader.GetString("Username"),
                           reader.GetString("Password"),
                           reader.GetString("Salt"),
                           (UserType)Enum.Parse(typeof(UserType), reader.GetString("Type")),
                           reader.GetInt32("AssociationId"));
                    }

                    return userCredentials;
                }
            }
            catch (MySqlException ex)
            {
                Connection.CloseConnection();
                Debug.WriteLine(ex.Message);
                throw new DALException("Couldn't get credentials");
                return null;
            }
            catch (InvalidOperationException ex)
            {
                Connection.CloseConnection();
                Debug.WriteLine(ex.Message);
                throw new DALException("Connection Issue");
                return null;
            }

        }

        public bool CheckDuplicationBSN(string bSN, int associationId)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) " +
                    "FROM users u INNER JOIN staffs s" +
                    " WHERE BSN LIKE @BSN AND u.AssociationId = @ASSOCIATIONID"
                    , conn);

                cmd.Parameters.AddWithValue("BSN", bSN);
                cmd.Parameters.AddWithValue("ASSOCIATIONID", associationId);

                return Convert.ToInt32(cmd.ExecuteScalar()) == 0 ? false : true;
            }
            catch (MySqlException ex)
            {
                Connection.CloseConnection();
                Debug.WriteLine(ex.Message);
                throw new DALException("Couldn't check BSN");
                return true;
            }
        }

        //ToDo: add query for filtering users list.
        public List<Staff> GetEightStaffEachTime(int group, int associationId, UserType userType)
        {
            try
            {

                if (userType != UserType.AssociationAdmin || userType != UserType.Admin || userType != UserType.Employee)
                {
                    --group;
                    int groupNum = group * 8;

                    List<Staff> staffs = new List<Staff>();

                    MySqlCommand cmd = new MySqlCommand(
                        $"SELECT u.*, s.BSN FROM users u LEFT JOIN staffs s ON u.Id = s.UserId" +
                        $" Where u.AssociationId = @ASSOCIATIONID AND Type = @TYPE LIMIT {groupNum}, 8", conn);


                    cmd.Parameters.AddWithValue("ASSOCIATIONID", associationId);
                    cmd.Parameters.AddWithValue("@TYPE", userType.ToString());

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            return null;
                        }
                        while (reader.Read())
                        {
                            if (getUser(reader) is Staff staff)
                            {
                                staffs.Add(staff);
                            }
                        }
                        return staffs;
                    }
                }
                return null;
            }
            catch (MySqlException ex)
            {
                Connection.CloseConnection();
                Debug.WriteLine(ex.Message);
                throw new DALException("Couldn't load employee list");
                return null;
            }
        }

        //This method doesn't support updating three tables or more
        public void UpdateUser(User oldUser, User updatedUser)
        {
            try
            {
                string sqlTables = "Update";
                string sqlSets = " SET";
                string sqlWhere = " Where";


                MySqlCommand cmd = new MySqlCommand(string.Empty, conn);


                sqlSets = addinSetsInSQlStatement(oldUser, updatedUser, sqlSets, cmd);

                if (sqlTables.Contains("players") || sqlTables.Contains("staffs"))
                {
                    sqlWhere += " UserId = @ID";
                }
                if (sqlTables.Contains("users"))
                {
                    sqlWhere += " Id = @ID";
                }
                AddAndInSqlWhere();

                cmd.Parameters.AddWithValue("ID", oldUser.UserCredentials.Id);

                //Incase there are no changes
                if (sqlTables == "Update" && sqlSets == " SET" && sqlWhere == " Where")
                {
                    return;
                }

                //Removing last comma
                sqlTables = sqlTables.Remove(sqlTables.Length - 1);
                sqlSets = sqlSets.Remove(sqlSets.Length - 1);


                cmd.CommandText = sqlTables + sqlSets + sqlWhere;

                cmd.ExecuteNonQuery();

                void AddAndInSqlWhere()
                {
                    if (sqlTables.Contains("players") || sqlTables.Contains("staffs") && sqlTables.Contains("users"))
                    {
                        sqlWhere = sqlWhere.Insert(19, " AND ");
                    }
                }

                void addingTablesNames(string requiredTable)
                {
                    if (requiredTable.ToLower().Contains("users") && !sqlTables.Contains(" users u"))
                    {
                        sqlTables += " users u,";
                    }
                    if (requiredTable.ToLower().Contains("players") && !sqlTables.Contains(" players p"))
                    {
                        sqlTables += " players p,";
                    }
                    if (requiredTable.ToLower().Contains("staffs") && !sqlTables.Contains(" staffs s"))
                    {
                        sqlTables += " staffs s,";
                    }
                }

                //Setting the sets for user tables if there are any change
                string addinSetsInSQlStatement(User oldUser, User updatedUser, string sqlSets, MySqlCommand cmd)
                {

                    if (oldUser.FirstName != updatedUser.FirstName)
                    {
                        addingTablesNames("users");
                        sqlSets += " u.FirstName = @FIRSTNAME,";

                        cmd.Parameters.AddWithValue("FIRSTNAME", updatedUser.FirstName);
                    }
                    if (oldUser.LastName != updatedUser.LastName)
                    {
                        addingTablesNames("users");
                        sqlSets += " u.LastName = @LASTNAME,";

                        cmd.Parameters.AddWithValue("LASTNAME", updatedUser.LastName);
                    }
                    if (oldUser.Gender != updatedUser.Gender)
                    {
                        addingTablesNames("users");
                        sqlSets += " u.Gender = @GENDER,";

                        cmd.Parameters.AddWithValue("GENDER", updatedUser.Gender.ToString());
                    }
                    if (oldUser.BirthDate != updatedUser.BirthDate)
                    {
                        addingTablesNames("users");
                        sqlSets += " u.BirthDate = @BIRTHDATE,";

                        cmd.Parameters.AddWithValue("BIRTHDATE", updatedUser.BirthDate);
                    }
                    if (oldUser.PhoneNumber != updatedUser.PhoneNumber)
                    {
                        addingTablesNames("users");
                        sqlSets += " u.PhoneNumber = @PHONENUMBER,";

                        cmd.Parameters.AddWithValue("PHONENUMBER", updatedUser.PhoneNumber);
                    }
                    if (oldUser.Email != updatedUser.Email)
                    {
                        addingTablesNames("users");
                        sqlSets += " u.Email = @EMAIL,";

                        cmd.Parameters.AddWithValue("EMAIL", updatedUser.Email);
                    }
                    if (oldUser.UserCredentials.UserName != updatedUser.UserCredentials.UserName)
                    {
                        addingTablesNames("users");
                        sqlSets += " u.Username = @USERNAME,";

                        cmd.Parameters.AddWithValue("USERNAME", updatedUser.UserCredentials.UserName);
                    }
                    if (oldUser.UserCredentials.HashedPassword != updatedUser.UserCredentials.HashedPassword)
                    {
                        addingTablesNames("users");
                        sqlSets += " u.Password = @PASSWORD,";

                        cmd.Parameters.AddWithValue("PASSWORD", updatedUser.UserCredentials.HashedPassword);
                    }
                    if (oldUser.UserCredentials.UserType != updatedUser.UserCredentials.UserType)
                    {
                        addingTablesNames("users");
                        sqlSets += " u.Type = @TYPE,";

                        cmd.Parameters.AddWithValue("TYPE", updatedUser.UserCredentials.UserType.ToString());
                    }
                    if (oldUser is Player oldPlayer && updatedUser is Player updatedPlayer)
                    {
                        if (oldPlayer.SportPreference != updatedPlayer.SportPreference)
                        {
                            addingTablesNames("players");
                            sqlSets += " p.SportPreference = @SPORTPREFERENCE,";

                            cmd.Parameters.AddWithValue("SPORTPREFERENCE", updatedPlayer.SportPreference);
                        }
                    }
                    if (oldUser is Staff oldStaff && updatedUser is Staff updatedStaff)
                    {
                        if (oldStaff.BSN != updatedStaff.BSN)
                        {
                            addingTablesNames("staffs");
                            sqlSets += " s.BSN = @BSN,";

                            cmd.Parameters.AddWithValue("BSN", updatedStaff.BSN);
                        }
                    }
                    return sqlSets;
                }
            }
            catch (MySqlException ex)
            {
                if (ex.Message.Contains("key"))
                {
                    if (ex.Message.Contains("UQ_AssocID_PhoneNumber"))
                    {
                        throw new PhoneNumberDuplicationException("This phone number is already used", ex);
                    }
                    if (ex.Message.Contains("UQ_AssocID_Email"))
                    {
                        throw new EmailDuplicationException("This email is already used", ex);
                    }
                    if (ex.Message.Contains("UQ_AssocID_Username"))
                    {
                        throw new UsernameDuplicationException("This username is already used", ex); ;
                    }
                }


                Connection.CloseConnection();
                Debug.WriteLine(ex.Message);
                throw new DALException("Couldn't update user");
            }
        }

        private int getLastUserId()
        {
            MySqlCommand cmd = new MySqlCommand(
                "Select Max(Id) from `users`"
                , conn);

            object lastUserId = cmd.ExecuteScalar();

            return lastUserId == DBNull.Value ? 0 : Convert.ToInt32(lastUserId);
        }

        private User getUser(MySqlDataReader reader)
        {
            if (!reader.HasRows)
            {
                return null;
            }

            string firstName = reader.GetString("FirstName");
            string lastName = reader.GetString("LastName");
            Gender gender = (Gender)Enum.Parse(typeof(Gender), reader.GetString("Gender"));
            string birthdate = reader.GetDateTime("BirthDate").ToString("dd/MM/yyyy");
            string phoneNumber = reader.GetString("PhoneNumber");
            string Email = reader.GetString("Email");
            UserCredentials credentials = new UserCredentials(reader.GetInt32("Id"),
                reader.GetString("Username"),
                reader.GetString("Password"),
                reader.GetString("Salt"),
                (UserType)Enum.Parse(typeof(UserType), reader.GetString("Type")),
                reader.GetInt32("AssociationId")
                );

            if (reader.GetString("Type") == "Player")
            {
                SportType sportType = (SportType)Enum.Parse(typeof(SportType), reader.GetString("SportPrefeerence"));

                return new Player(sportType, firstName, lastName, gender, birthdate, phoneNumber, Email, credentials);
            }
            if (reader.GetString("Type") == "Employee")
            {
                string BSN = reader.GetString("BSN");

                return new Staff(BSN, firstName, lastName, gender, birthdate, phoneNumber, Email, credentials);
            }
            if (reader.GetString("Type") == "Admin")
            {
                string BSN = reader.GetString("BSN");

                return new Staff(BSN, firstName, lastName, gender, birthdate, phoneNumber, Email, credentials);
            }
            if (reader.GetString("Type") == "AssociationAdmin")
            {
                string BSN = reader.GetString("BSN");

                return new Staff(BSN, firstName, lastName, gender, birthdate, phoneNumber, Email, credentials);
            }

            return null;

        }
    }
}
