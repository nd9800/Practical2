using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practical2.Service;
using Practical2.Adapter;
using SQLitePCL;

namespace Practical2.Models 
{
    class Info : InfoService
    {
        public bool AddInfo(InfoItem item)
        {

            SQLiteHelper qLiteHelper = SQLiteHelper.GetInstance();
            SQLiteConnection sQLiteConnection = qLiteHelper.sQLiteConnection;
            string sql_txt = "insert into Info(name,passw) values(?,?)";
            var statement = sQLiteConnection.Prepare(sql_txt);
            statement.Bind(1, item.name);
            statement.Bind(2, item.passw);
            var rs = statement.Step();
            return rs == SQLiteResult.OK;
        }

        public List<InfoItem> GetInfo()
        {
            SQLiteHelper qLiteHelper = SQLiteHelper.GetInstance();
            SQLiteConnection sQLiteConnection = qLiteHelper.sQLiteConnection;
            string sql_txt = "SELECT * FROM Info";
            var statement = sQLiteConnection.Prepare(sql_txt);
            List<InfoItem> list = new List<InfoItem>();
            while (SQLiteResult.ROW == statement.Step())
            {
                string name = (string)statement[0];
                string passw = (string)statement[0];
                InfoItem i = new InfoItem(name, passw);
                list.Add(i);
            }
            return list;
        }
    }
}
