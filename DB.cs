using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Allatkorhaz
{
    public class DB
    {
        string server = "localhost";
        string user = "root";
        string database = "centrum";

        MySqlConnection conn;

        public DB()
        {
            string kapcs = $"server={server};user={user};database={database}";

            conn = new MySqlConnection(kapcs);
        }

        public MySqlConnection Conn { get => conn; set => conn = value; }
    }
}
