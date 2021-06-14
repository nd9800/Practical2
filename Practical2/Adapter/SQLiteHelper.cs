using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLitePCL;
namespace Practical2.Adapter
{
    class SQLiteHelper
    {
        private readonly string dbName = "info.db";

        private static SQLiteHelper sQLiteHelper;
        public static SQLiteHelper GetInstance()
        {
            if (sQLiteHelper == null)
            {
                sQLiteHelper = new SQLiteHelper();
            }
            return sQLiteHelper;
        }
        private SQLiteHelper()
        {
            sQLiteConnection = new SQLiteConnection(dbName);
            CreateInfoTable();
        }
        public SQLiteConnection sQLiteConnection { get; private set; }
        public void CreateInfoTable()
        {
            var sql_txt = @"CREATE TABLE IF NOT EXISTS Info(name varchar(200), passw varchar(200))";
            var statement = sQLiteConnection.Prepare(sql_txt);
            statement.Step();
        }
    }
}
