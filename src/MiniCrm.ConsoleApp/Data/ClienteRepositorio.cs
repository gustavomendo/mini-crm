using MiniCrm.ConsoleApp.Modelos;
namespace MiniCrm.ConsoleApp.Data;

internal class ClienteRepositorio
{
    private readonly List<Cliente> lista = new()
{
    new Cliente("João Silva", "joao.silva@gmail.com", new DateOnly(2023, 1, 15)),
    new Cliente("Maria Santos", "maria.santos@gmail.com", new DateOnly(2023, 2, 20)),
    new Cliente("Pedro Costa", "pedro.costa@gmail.com", new DateOnly(2023, 3, 10)),
    new Cliente("Ana Rodrigues", "ana.rodrigues@gmail.com", new DateOnly(2023, 4, 2)),
    new Cliente("Rui Fernandes", "rui.fernandes@outlook.pt", new DateOnly(2023, 5, 18)),
    new Cliente("Sofia Marques", "sofia.marques@gmail.com", new DateOnly(2023, 6, 27)),
    new Cliente("Tiago Oliveira", "tiago.oliveira@sapo.pt", new DateOnly(2023, 7, 8)),
    new Cliente("Beatriz Carvalho", "beatriz.carvalho@gmail.com", new DateOnly(2023, 8, 14)),
    new Cliente("Miguel Ferreira", "miguel.ferreira@outlook.pt", new DateOnly(2023, 9, 30)),
    new Cliente("Catarina Lopes", "catarina.lopes@gmail.com", new DateOnly(2023, 10, 5)),
    new Cliente("André Pinto", "andre.pinto@sapo.pt", new DateOnly(2023, 11, 21)),
    new Cliente("Inês Gonçalves", "ines.goncalves@gmail.com", new DateOnly(2023, 12, 3)),
    new Cliente("Nuno Ribeiro", "nuno.ribeiro@outlook.pt", new DateOnly(2024, 1, 9)),
    new Cliente("Mariana Alves", "mariana.alves@gmail.com", new DateOnly(2024, 2, 16)),
    new Cliente("Ricardo Moreira", "ricardo.moreira@sapo.pt", new DateOnly(2024, 3, 24)),
    new Cliente("Carolina Dias", "carolina.dias@gmail.com", new DateOnly(2024, 4, 11)),
    new Cliente("Bruno Teixeira", "bruno.teixeira@outlook.pt", new DateOnly(2024, 5, 29)),
    new Cliente("Leonor Barbosa", "leonor.barbosa@gmail.com", new DateOnly(2024, 6, 7)),
    new Cliente("Diogo Cardoso", "diogo.cardoso@sapo.pt", new DateOnly(2024, 7, 19)),
    new Cliente("Matilde Nunes", "matilde.nunes@gmail.com", new DateOnly(2024, 8, 26))
};
    public List<Cliente> ListarClientes()
    {
        return lista;
    }

    public void Adicionar(Cliente cliente)
    {
        lista.Add(cliente);
    }

    public bool ExisteComEmail(string email)
    {
        return lista.Any(c => string.Equals(c.Email, email, StringComparison.OrdinalIgnoreCase));
    }

    public List<Cliente> ProcurarPorNome(string nome)
    {
        return lista
            .Where(c => c.Nome.Contains(nome, StringComparison.OrdinalIgnoreCase))
            .ToList();
    }
    public void RemoverPorId(Guid id)
    {
        Cliente? cliente = lista.FirstOrDefault(c => c.Id == id);

        if (cliente != null)
        {
            lista.Remove(cliente);
        }
    }
    public List<Cliente> ProcurarPorId(string inicioDoId)
    {
        return lista
            .Where(c => c.Id.ToString().StartsWith(inicioDoId, StringComparison.OrdinalIgnoreCase))
            .ToList();
    }
}
