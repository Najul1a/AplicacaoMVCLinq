namespace AplicacaoMVCLinq.Models
{
    public class Clientes
    {
        public int clienteId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public DateOnly DataNasc { get; set; }



        public Clientes(int id, string nome, string email, string telefone, DateOnly datanasc)
        {
            this.clienteId = id;
            this.Nome = nome;
            this.Email = email;
            this.Telefone = telefone;
            this.DataNasc = datanasc;

        }
    }
}
