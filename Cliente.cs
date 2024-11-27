using static System.Console;
using static System.Convert;
public class Cliente
{
    public string _nome;
    private string _cpf;
    public string _sexo;
    public string _dataNascimento;

    public void GetCpf(string c)
    {
         c = c.Replace(".", "").Replace("-", "");

        if (c.Length == 11)
        {
            _cpf = c;
        }
        else
        {
            throw new Exception("CPF inválido");
        }
    }
}
