using MySql.Data.MySqlClient;

namespace Conexoes {
    public class AcessaBD {
        public string server = "";
        public string user = "";
        public string database = "";
        public string porta = "";
        public string senha = "";

        public void ConectaBD () {
            string strCon = "server=" + server + ";user=" + user + ";database=" + database + ";port=" + porta + ";password=" + senha + "";
            MySqlConnection conn = new MySqlConnection(strCon);
        }
    }
}