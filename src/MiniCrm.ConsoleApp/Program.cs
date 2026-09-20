using MiniCrm.ConsoleApp.Data;
using MiniCrm.ConsoleApp.Services;
using MiniCrm.ConsoleApp.Ui;

var repositorio = new ClienteRepositorio();
var servico = new ClienteServico(repositorio);
var menu = new MenuPrincipal(repositorio, servico);

menu.Executar();