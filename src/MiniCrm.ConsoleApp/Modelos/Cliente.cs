namespace MiniCrm.ConsoleApp.Modelos;

internal class Cliente
{
    public Guid Id { get;}
    public string Nome { get; private set; }
    public string Email { get; set; }
    public DateOnly DataRegisto { get; }

    //Constructor
    public Cliente(string nome, string email, DateOnly dataRegisto)
    {
        if (string.IsNullOrWhiteSpace(nome))
        {
            throw new ArgumentException("O nome do cliente não pode ser vazio.", nameof(nome));
        }
        Id = Guid.NewGuid();
        Nome = nome;
        Email = email;
        DataRegisto = dataRegisto;
    }

    public override string ToString()
    {
        return $"ID: {Id}\nNome: {Nome}\nEmail: {Email}\nData de Registo: {DataRegisto}\n";

    }
}
