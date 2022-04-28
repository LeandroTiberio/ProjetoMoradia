namespace ProjetoMoradia.Modelos
{
    public class Kitnet : Moradia
    {
       public Kitnet ( string endereco, int cep, double tamanhoEmMetros, int quantidadeDeQuartos, int quantidadeDeBanheiros) 
                        : base ( endereco, cep, tamanhoEmMetros, quantidadeDeQuartos, quantidadeDeBanheiros)
        {

        }

        public override double CalcularValor()
        {
            var valor = 0.0;
            valor = TamanhoEmMetros * 30;
            return valor;
        }
        
     
    }
}