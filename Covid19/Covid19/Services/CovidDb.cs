using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Covid19.Services
{
     public class CovidDb
    {
        private SQLiteAsyncConnection _connection;

        public CovidDb(string dbPath)
        {
            _connection = new SQLiteAsyncConnection(dbPath);
            _connection.CreateTableAsync<LoggedinUser>();
        }

        //public IEnumerable<SQL_SelectedUserLan> GetSelectedLanID()
        //{
        //    return (from t in _connection.Table<SQL_SelectedUserLan>()
        //            select t).ToListAsync();
        //}




     
        //LOGIN MANAGEMENT
        public Task<List<LoggedinUser>> GetLoggedinUser()
        {
            return _connection.Table<LoggedinUser>().ToListAsync();

        }
        //public IEnumerable<LoggedinUser> GetLoggedinUser()
        //{
        //    return _connection.Table<LoggedinUser>().ToListAsync();
        //    return (from t in _connection.Table<LoggedinUser>()
        //            select t).ToList();
        //}

        //public LoggedinUser GetLoggedinUser(String username)
        //{
        //    return _connection.Table<LoggedinUser>().Where(t => t.Username == username).FirstOrDefaultAsync().Result;
        //   //  return _connection.Table<LoggedinUser>().FirstOrDefaultAsync(t => t.Username == Username);

        //}

        public void DeleteLoggedinUser(int id)
        {
            _connection.DeleteAsync<LoggedinUser>(id);
        }

        public void DeleteAllUser()
        {
            //  conn.ExecuteAsync("DELETE FROM TableName")
            //   _connection.DeleteAllAsync<LoggedinUser>();
            _connection.ExecuteAsync("DELETE FROM LoggedinUser");
        }



        public void AddLoggedinUser(string Username, String Password)
        {
            var newLoggedinUser = new LoggedinUser
            {
                email = Username,
                password = Password,
            };

            _connection.InsertAsync(newLoggedinUser);
        }
    }

    public class LoggedinUser
    {
        public string email { get; set; }
        public string password { get; set; }
    }
}
