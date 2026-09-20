using MiniCrm.ConsoleApp.Data;
using MiniCrm.ConsoleApp.Modelos;

namespace MiniCrm.ConsoleApp.Services;

internal class ClienteServico
{
    private readonly ClienteRepositorio repositorio;

    public ClienteServico(ClienteRepositorio repositorio)
    {
        this.repositorio = repositorio;
    }

    public bool EmailJaExiste(string email)
    {
        return repositorio.ExisteComEmail(email);
    }

    public Cliente Adicionar(string nome, string email)
    {
        DateOnly dataRegisto = DateOnly.FromDateTime(DateTime.Today);
        Cliente cliente = new Cliente(nome, email, dataRegisto);

        repositorio.Adicionar(cliente);

        return cliente;
    }
}