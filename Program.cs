using static System.Console;
using static System.Convert;

public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            Cliente c = new Cliente();
            Write("Digite o nome: ");
            c._nome = ReadLine();
            Write("Digite o cpf: ");
            string cpf = ReadLine();
            c.GetCpf(cpf);
            Write("Digite o sexo: ");
            c._sexo = ReadLine();
            Write("Digite a Data de nascimento: ");
            c._dataNascimento = ReadLine();
        }
        catch (Exception ex) 
        { 
            WriteLine(ex.Message);
        }

    }
}