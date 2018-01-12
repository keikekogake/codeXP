using System.Data.SqlClient;

namespace projetoCidades.Repositorio {
    public class AcessaBD {
        public SqlConnection con;
        public SqlConnectionStringBuilder strBuild;
        public AcessaBD () {
            con = new SqlConnection ();
            strBuild = new SqlConnectionStringBuilder();
            strBuild.DataSource = @".\sqlexpress";
            strBuild.InitialCatalog = "ProjetoCidades";
            strBuild.UserID = "sa";
            strBuild.Password = "senai@123";
            con.ConnectionString = strBuild.ConnectionString;
            // con.ConnectionString = @"Data Source=.\sqlexpress;Initial Catalog=ProjetoCidades;User Id=sa;Password=senai@123";
        }
        public void Open () {
            con.Open ();
        }
        public void Close () {
            con.Close ();
        }
    }
}