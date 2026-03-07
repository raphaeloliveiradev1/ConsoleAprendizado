// See https://aka.ms/new-console-template for more information
using ConsoleApredizado;

Atleta primeiroAtleta = new Atleta();
primeiroAtleta.Nome = "Cristiano Ronaldo";
primeiroAtleta.DataNascimento = new DateTime(1990, 10, 28);
primeiroAtleta.Endereco = "Rua dos Atletas, 123";
primeiroAtleta.Base = "Futebol";
primeiroAtleta.PercentualMassa = 15.5f;
primeiroAtleta.PesoAtual = 85.0f;
primeiroAtleta.AreaAtuacao = "Atacante";
primeiroAtleta.EhBatedorDePenaltis = true;
primeiroAtleta.CanhatoOuDestro = true;

Atleta segundoAtleta = new Atleta();
segundoAtleta.Nome = "Lionel Messi";
segundoAtleta.DataNascimento = new DateTime(1987, 6, 24);
segundoAtleta.Endereco = "Avenida dos Craques, 456";
segundoAtleta.Base = "Futebol";
segundoAtleta.PercentualMassa = 12.3f;
segundoAtleta.PesoAtual = 72.0f;
segundoAtleta.AreaAtuacao = "Meio-campista";
segundoAtleta.EhBatedorDePenaltis = false;
segundoAtleta.CanhatoOuDestro = false;

Tecnico tecnico = new Tecnico();
Console.WriteLine("infome o nome do tecnico");
tecnico.Nome = Console.ReadLine();
Console.WriteLine(tecnico.Nome);
Console.WriteLine(tecnico);

Console.WriteLine($"Nome: {primeiroAtleta.Nome}");
Console.WriteLine($"Data de Nascimento: {primeiroAtleta.DataNascimento.ToShortDateString()}"); 
Console.WriteLine($"Endereço: {primeiroAtleta.Endereco}");
Console.WriteLine($"Base: {primeiroAtleta.Base}");
Console.WriteLine($"Percentual de Massa: {primeiroAtleta.PercentualMassa}%");
Console.WriteLine($"Peso Atual: {primeiroAtleta.PesoAtual} kg");
Console.WriteLine($"Área de Atuação: {primeiroAtleta.AreaAtuacao}");
Console.WriteLine($"É Batedor de Pênaltis: {(primeiroAtleta.EhBatedorDePenaltis ? "Sim" : "Não")}");
Console.WriteLine($"Canhoto ou Destros: {(primeiroAtleta.CanhatoOuDestro ? "Destro" : "Canhoto")}");   
Console.WriteLine("\n-----------------------------\n");
Console.WriteLine($"Nome: {segundoAtleta.Nome}");
Console.WriteLine($"Data de Nascimento: {segundoAtleta.DataNascimento.ToShortDateString()}");
Console.WriteLine($"Endereço: {segundoAtleta.Endereco}");
Console.WriteLine($"Base: {segundoAtleta.Base}");
Console.WriteLine($"Percentual de Massa: {segundoAtleta.PercentualMassa}%");
Console.WriteLine($"Peso Atual: {segundoAtleta.PesoAtual} kg");
Console.WriteLine($"Área de Atuação: {segundoAtleta.AreaAtuacao}");
Console.WriteLine($"É Batedor de Pênaltis: {(segundoAtleta.EhBatedorDePenaltis ? "Sim" : "Não")}");
Console.WriteLine($"Canhoto ou Destros: {(segundoAtleta.CanhatoOuDestro ? "Destro" : "Canhoto")}");
Console.WriteLine("\n-----------------------------\n");
