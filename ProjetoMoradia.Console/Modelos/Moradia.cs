namespace ProjetoMoradia.Modelos
{
    public class Moradia
    {
        private string Endereco { get; set; }
        private int Cep { get; set; }
        protected double TamanhoEmMetros { get; set; }
        protected int QuantidadeDeQuartos { get; set; }
        protected int QuantidadeDeBanheiros { get; set; }
        private List<Morador> Moradores { get; set; }

        public Moradia ( string endereco, int cep, double tamanhoEmMetros, int quantidadeDeQuartos, 
                        int quantidadeDeBanheiros )
        {
            Endereco = endereco;
            Cep = cep;
            TamanhoEmMetros = tamanhoEmMetros;
            QuantidadeDeQuartos = quantidadeDeQuartos;
            QuantidadeDeBanheiros = quantidadeDeBanheiros;
            Moradores = new List<Morador>();
        }

        public string GetEndereco()
        {
            return Endereco;
        }
        public void SetEndereco ( string endereco )
        {
            Endereco = endereco;
        }
        public int GetCep()
        {
            return Cep;
        }
        public void SetCep ( int cep )
        {
            Cep = cep;
        }
        public double GetTamanhoEmMetros()
        {
            return TamanhoEmMetros;
        }
        public void SetTamanhoEmMetros ( double tamanhoEmMetros )
        {
            TamanhoEmMetros = tamanhoEmMetros;
        }
        public int GetQuantidadeDeQuartos()
        {
            return QuantidadeDeQuartos;
        } 
        public void SetQuantidadeDeQuatros ( int quantidadeDeQuartos )
        {
            QuantidadeDeQuartos = quantidadeDeQuartos;
        }
        public int GetQuantidadeDeBanheiros()
        {
            return QuantidadeDeBanheiros;
        }
        public void SetQuantidadeDeBanheiros ( int quantidadeDeBanheiros )
        {
            QuantidadeDeBanheiros = quantidadeDeBanheiros;
        }
        public virtual double CalcularValor()
        {
            var valor = 0.0;
            return valor;
        } 
        public void AdicionarMoradores(Morador morador)
        {
            Moradores.Add(morador);
        }
        public void RemoverMorador(string Cpf)
        {
            Moradores.RemoveAll(morador => morador.GetCpf() == Cpf);
        }

    }
}

