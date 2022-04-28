using ProjetoMoradia.Modelos;
namespace ProjetoMoradia;

public class Program
{
    static void Main(string[] args)
    {
        Moradia Moradia = new Casa ("Rua Major Baracca", 02232000, 140, 4, 3, false);
        Moradia.AdicionarMoradores(new Morador (" Leandro Tiberio", "11122233311", "03/09/1978"));
        Moradia.AdicionarMoradores(new Morador (" Carla Tiberio", "11122233322", "07/09/1978"));
        Moradia.AdicionarMoradores(new Morador (" Lucas Tiberio", "11122233333", "19/06/2001"));
        Moradia.AdicionarMoradores(new Morador (" Aryane Tiberio", "11122233344", "28/03/2003"));


        Moradia = new Apartamento ("Rua Dos Aposentados", 08730510, 70, 3, 2 );
        Moradia.AdicionarMoradores(new Morador (" Leandro da Silva Tiberio", "11122233355", "09/03/1978"));
        Moradia.AdicionarMoradores(new Morador (" Carla Luiza Tiberio", "11122233366", "07/07/1978"));
        Moradia.AdicionarMoradores(new Morador (" Lucas Moraes Tiberio", "11122233377", "19/12/2001"));
        Moradia.AdicionarMoradores(new Morador (" Aryane Moraes Tiberio", "11122233388", "28/12/2003"));


        Moradia = new Kitnet ("Rua CandidoVale", 08730510, 70, 2, 1);
        Moradia.AdicionarMoradores(new Morador (" Calil Tiberio", "11122233399", "03/09/1970"));
        Moradia.AdicionarMoradores(new Morador (" Carmela Tiberio", "11122233300", "07/09/1970"));
        Moradia.AdicionarMoradores(new Morador (" Rubens Tiberio", "11122233301", "19/06/2010"));
        Moradia.AdicionarMoradores(new Morador (" Giovana Tiberio", "11122233302", "28/03/2013"));

        Console.WriteLine("Digite o CPF de quem vai removido da lista");
        var CpfRetirar = Console.ReadLine();
        Moradia.RemoverMorador(CpfRetirar);
        Console.WriteLine (Moradia.CalcularValor());
        Console.ReadLine();

    }
 
}
