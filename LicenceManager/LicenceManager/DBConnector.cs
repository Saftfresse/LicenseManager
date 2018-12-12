using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LicenceManager.Form1;

namespace LicenceManager
{
    public class DBConnector
    {
        public string myConnectionString = "SERVER=localhost;" +
                            "PORT=3306;" +
                            "DATABASE=dev;" +
                            "UID=root;" +
                            "PASSWORD=root;" +
                            "SslMode=none";
        MySqlConnection conn;

        public MySqlConnection Conn { get => conn; set => conn = value; }
        public delegate void MyEventHandler(bool connected);
        public event MyEventHandler OnConnectionStateChanged;
        bool lastState = false;

        public DBConnector()
        {
            Conn = new MySqlConnection(myConnectionString);
            //lastState = Conn.State.ToString();
            checkConnection();
            OnConnectionStateChanged?.Invoke(lastState);
        }

        public bool checkDB_Conn()
        {
            var conn_info = myConnectionString;
            bool isConn = false;
            MySqlConnection conn = null;
            try
            {
                conn = new MySqlConnection(conn_info);
                conn.Open();
                isConn = true;
            }
            catch (ArgumentException a_ex)
            {
            }
            catch (MySqlException ex)
            {
                isConn = false;
                switch (ex.Number)
                {
                    case 1042:
                        break;
                    case 0:
                        break;
                    default:
                        break;
                }
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return isConn;
        }

        async void checkConnection()
        {
            while (true)
            {
                bool state = checkDB_Conn();
                Console.WriteLine(state);
                if (state != lastState)
                {
                    lastState = state;
                    if (OnConnectionStateChanged != null)
                    {
                        OnConnectionStateChanged(state);
                    }
                }
                await Task.Delay(1000);
            }
        }
        
        public MySqlDataReader getResult(string query)
        {
            MySqlCommand command = Conn.CreateCommand();
            command.CommandText = query;
            MySqlDataReader Reader;
            Conn.Open();
            Reader = command.ExecuteReader();
            return Reader;
        }

        public List<Gruppe> GetGroups()
        {
            List<Gruppe> ret = new List<Gruppe>();
            MySqlDataReader g = getResult("select * from gruppe");
            while (g.Read())
            {
                string name = g.GetString("name");
                int id = int.TryParse(g.GetString("id"), out int _id) ? _id : 0;
                ret.Add(new Gruppe() { Number = id, Text = name });
            }
            closeConn();
            return ret;
        }

        public List<Untergruppe> GetSubGroups()
        {
            List<Untergruppe> ret = new List<Untergruppe>();
            MySqlDataReader g = getResult("select * from untergruppe");
            while (g.Read())
            {
                string name = g.GetString("name");
                int id = int.TryParse(g.GetString("id"), out int _id) ? _id : 0;
                int parentId = int.TryParse(g.GetString("gruppe"), out int _pid) ? _pid : 0;
                ret.Add(new Untergruppe() { Number = id, Text = name, GroupId = parentId });
            }
            closeConn();
            return ret;
        }

        public void closeConn()
        {
            Conn.Close();
        }

        public void sendStatementOpenConn(string statement)
        {
            MySqlCommand command = Conn.CreateCommand();
            command.CommandText = statement;
            try
            {
                command.ExecuteNonQuery();
            } catch (Exception) {  }
        }

        public void sendStatement(string statement)
        {
            MySqlCommand command = Conn.CreateCommand();
            command.CommandText = statement;
            Conn.Open();
            try
            {
                command.ExecuteNonQuery();
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }
            closeConn();
        }
    }

}
