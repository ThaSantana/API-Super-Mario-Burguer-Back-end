using Microsoft.Data.SqlClient;

namespace WebApplicationSuperMarioBurguer.Models
{
    public class FornecedorModel
    {
        public FornecedorModel() { }
        public int Id { get; set; }
        public string? Cnpj { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Cep { get; set; }
        public string? ProdutoOferecido { get; set; }

        public static List<FornecedorModel> Todos()
        {
            var lista = new List<FornecedorModel>();

            SqlConnection conn = new SqlConnection(Conexao.Dados);
            conn.Open();

            SqlCommand cmd = new SqlCommand("select * FROM Fornecedores", conn);
            
            //ler dados
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read()) 
            {
                lista.Add(new FornecedorModel
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Cnpj = reader["Cnpj"].ToString(),
                    Name = reader["Name"].ToString(),
                    Email = reader["Email"].ToString(),
                    Cep = reader["Cep"].ToString(),
                    ProdutoOferecido = reader["ProdutoOferecido"].ToString()

                });
            }
            conn.Close();
            conn.Dispose();
            cmd.Dispose();
            return lista;

        }

    }
}
