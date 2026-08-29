using MiniCrm.ConsoleApp.Modelos;

List<Cliente> lista = new List<Cliente>()
{
   
};

var cliente1 = new Cliente("João Silva", "joao.silva@gmail.com", new DateOnly(2023, 1, 15));
var cliente2 = new Cliente("Maria Santos", "maria.santos@gmail.com", new DateOnly(2023, 2, 20));
var cliente3 = new Cliente("Pedro Costa", "pedro.costa@gmail.com", new DateOnly(2023, 3, 10));
lista.Add(cliente1);
lista.Add(cliente2);
lista.Add(cliente3);
foreach (Cliente cliente in lista)
{
    Console.WriteLine(cliente);
}
