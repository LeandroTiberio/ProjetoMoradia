namespace ProjetoMoradia.Modelos
{
    public class Apartamento : Moradia
    {
        private int Andar { get; set; }
        private double ValorCondominio { get; set; }

        public Apartamento ( string endereco, int cep, double tamanhoEmMetros, int quantidadeDeQuartos, int quantidadeDeBanheiros ) 
                            : base ( endereco, cep, tamanhoEmMetros, quantidadeDeQuartos, quantidadeDeBanheiros )
        {
            SetAndar ( Andar );
            SetValorCondominio ( ValorCondominio);
        }
        public int GetAndar()
        {
            return Andar;
        }
        public void SetAndar ( int andar )
        {
            Andar = andar;
        }
        public double GetValorCondominio()
        {
            return ValorCondominio;
        }
        public void SetValorCondominio ( double valorCondominio )
        {
            ValorCondominio = valorCondominio;
        }
        public override double CalcularValor() 
        {
            var valor = 0.0;
            valor = ( TamanhoEmMetros * 40 ) + ( QuantidadeDeQuartos * 10) + (QuantidadeDeBanheiros) + ValorCondominio;
            return valor;


        }


    }


}
