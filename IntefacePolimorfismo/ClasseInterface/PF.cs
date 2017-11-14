namespace ClasseInterface {
    public class PF : Cliente, IAcao {
        public string Nome { get; set; }
        public string CPF { get; set; }

        public PF () {

        }
        public PF (int id, string email, string telefone, Endereco endereco) {

        }

        public string Cadastro () {
            throw new System.NotImplementedException ();
        }

        public string Consulta () {
            throw new System.NotImplementedException ();
        }
    }
}