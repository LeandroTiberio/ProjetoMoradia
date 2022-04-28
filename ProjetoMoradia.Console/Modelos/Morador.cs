namespace ProjetoMoradia.Modelos
{
    public class Morador
    {
        public string Nome { get; set;}
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }

        public Morador ( string nome, string cpf, string dataNascimento )
        {
            SetNome (nome);
            SetCpf (cpf);
            SetDataNascimento (dataNascimento);
        }
        public string GetNome()
        {
            return Nome;
        }
        public void SetNome ( string nome )
        {
            Nome = nome;
        }
        public string GetCpf()
        {
            return Cpf;
        }
        public void SetCpf ( string cpf )
        {
            Cpf = cpf;
        }
        public DateTime GetDataNascimento()
        {
            return DataNascimento;
        }
        public void SetDataNascimento ( string dataNascimento )
        {
            DataNascimento = DateTime.Parse (dataNascimento);
        }
    }
}