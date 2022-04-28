namespace ProjetoMoradia.Modelos
{
    public class Casa : Moradia
    {
        private bool ComQuintal { get; set; }
    
        public Casa ( string endereco, int cep, double tamanhoEmMetros, int quantidadeDeQuartos, int quantidadeDeBanheiros, bool comQuintal ) 
                  : base ( endereco, cep, tamanhoEmMetros, quantidadeDeQuartos, quantidadeDeBanheiros )
        {
            ComQuintal = comQuintal;
        }
        public bool GetComQuintal()
        {
            return ComQuintal;
        }
        public void SetComQuintal ( bool comQuintal)
        {
            ComQuintal = comQuintal;
        }
        public override double CalcularValor()
        {
           var valor = 0.0;
           valor = (TamanhoEmMetros * 35) + (QuantidadeDeQuartos + 10) + (QuantidadeDeBanheiros * 5);
            if (ComQuintal == true)
              valor = valor * 1.1;
            return valor; 
        }
    }

}