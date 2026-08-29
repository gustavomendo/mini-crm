# Mini CRM de Clientes

Um CRM simples construído de raiz em C# / .NET, que evolui de uma aplicação de consola até uma
interface web, ao longo de 17 fases incrementais. Projeto pessoal de aprendizagem, desenvolvido
sem recorrer a soluções prontas — cada fase parte de objetivos e decisões de desenho, não de
código copiado.

## Sobre o projeto

O objetivo é gerir clientes e as suas compras, e a partir daí extrair informação útil: quanto
gastou cada cliente, quem são os melhores, e — a funcionalidade central — **detetar clientes
inativos ou em risco de abandono**.

A ideia não é chegar depressa ao resultado final. É atravessar, por ordem, as camadas que
compõem uma aplicação real:

| Etapa | O que entra |
|---|---|
| Fases 0–7 | C# base: classes, coleções, menus, validação, separação de responsabilidades |
| Fases 8–12 | Persistência em JSON, LINQ e relatórios, herança, interfaces, lógica de negócio |
| Fases 13–17 | Consumo de API externa, ASP.NET Core Web API, SQL Server + EF Core, interface web |

Nenhuma tecnologia entra antes de a versão anterior funcionar de ponta a ponta.

## Estado atual

**Fase 0 — Preparar o terreno.** Estrutura do repositório e aplicação de consola a arrancar.
Ainda sem lógica de negócio.

## Como correr

Requisitos: [.NET SDK 10.0](https://dotnet.microsoft.com/download) ou superior.

```bash
git clone https://github.com/gustavomendo/mini-crm.git
cd mini-crm
dotnet run --project src/MiniCrm.ConsoleApp
```

## Estrutura

```
mini-crm/
├── MiniCRM.slnx
├── .gitignore
├── README.md
└── src/
    └── MiniCrm.ConsoleApp/
        ├── MiniCrm.ConsoleApp.csproj
        └── Program.cs
```

A partir da Fase 5 aparecem as pastas `Models/`, `Services/`, `Data/` e `Ui/`. Na Fase 14 a
solução divide-se em vários projetos, para preparar a Web API.

## Roadmap

### Parte I — C# e consola

- [x] **Fase 0** — Preparação: repositório, `.gitignore`, README
- [ ] **Fase 1** — Modelo `Cliente`: classes, propriedades, encapsulamento
- [ ] **Fase 2** — Coleção de clientes
- [ ] **Fase 3** — Menu interativo e adicionar clientes
- [ ] **Fase 4** — Procurar e remover (primeiro contacto com LINQ)
- [ ] **Fase 5** — Separar responsabilidades: reorganizar em camadas
- [ ] **Fase 6** — Compras: segunda entidade e primeira relação entre entidades
- [ ] **Fase 7** — Validação e robustez
- [ ] **Fase 8** — Persistência em JSON
- [ ] **Fase 9** — LINQ, relatórios e estatísticas
- [ ] **Fase 10** — Herança e polimorfismo: tipos de cliente
- [ ] **Fase 11** — Exportação de relatórios (consola, texto, CSV) via interfaces
- [ ] **Fase 12** — Deteção de clientes inativos e em risco &nbsp;`v1.0.0`
- [ ] **Fase P** — Testes automatizados

### Parte II — Sair da consola

- [ ] **Fase 13** — Consumir uma API externa
- [ ] **Fase 14** — Reorganizar em vários projetos
- [ ] **Fase 15** — ASP.NET Core Web API &nbsp;`v2.0.0`
- [ ] **Fase 16** — SQL Server e Entity Framework Core &nbsp;`v3.0.0`
- [ ] **Fase 17** — Interface web &nbsp;`v4.0.0`

## Tecnologias

`C#` · `.NET 10` · `Git` — e, ao longo do roadmap: `System.Text.Json`, `LINQ`, `xUnit`,
`HttpClient`, `ASP.NET Core`, `Entity Framework Core`, `SQL Server`.

## Autor

**Gustavo Mendo** — projeto pessoal de aprendizagem em C# / .NET.
