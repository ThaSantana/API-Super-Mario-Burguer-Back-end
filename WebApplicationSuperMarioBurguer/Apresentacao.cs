namespace WebApplicationSuperMarioBurguer
{
    public class Apresentacao
    {
        public Apresentacao() {
            rotas = new List<string>();
            rotas.Add("/fornecedor");
        }
        private List<string> rotas { get; set; }
        public string Mensagem { get { return "Seja Bem Vindo"; } }
        public List<string> Rotas { get { return this.rotas; }}
    }
}
