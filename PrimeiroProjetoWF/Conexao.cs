using System.Data.SqlClient;

namespace PrimeiroProjetoWF {
    public class Conexao {
        public SqlConnection conn = new SqlConnection(@"Data Source=LUCASNOTEBOOK\MSSQLSERVER01;Initial Catalog=LucasS;Integrated Security=True");

        public void Conectar() {
            conn.Open();
        }

        public void Desconectar() {
            conn.Close();
        }
    }
}
