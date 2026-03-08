// See https://aka.ms/new-console-template for more information
using ConsoleApredizado;
using ConsoleAprendizado;

Console.WriteLine("\n-----------------------------\n");
Console.WriteLine("Vamos cadastrar A instituição");
Console.WriteLine("\n-----------------------------\n");

Instituicao instituicao = new Instituicao();
Console.WriteLine("Informe o nome da instituição");
instituicao.Nome = Console.ReadLine();

Console.WriteLine("Informe o nome fantasia da instituição");
instituicao.NomeFantasia = Console.ReadLine();

Console.WriteLine("Informe o CNPJ da instituição");
instituicao.CNPJ = int.Parse(Console.ReadLine());

Console.WriteLine("Informe o telefone da instituição");
instituicao.Telefone = int.Parse(Console.ReadLine());

Console.WriteLine("Informe o endereço da instituição");
instituicao.Endereco = Console.ReadLine();

Console.WriteLine("Informe o ano de fundação da instituição (MM/dd/yyyy):");
instituicao.AnoDeFundacao = DateTime.Parse(Console.ReadLine());

Console.WriteLine("Informe o presidente da instituição");
instituicao.Presidente = Console.ReadLine();

Console.WriteLine("\n-----------------------------\n");
Console.WriteLine("Vamos cadastrar um Atleta");
Console.WriteLine("\n-----------------------------\n");

Atleta primeiroAtleta = new Atleta();
Console.WriteLine("Informe o nome do atleta:");
primeiroAtleta.Nome = Console.ReadLine();

Console.WriteLine("Informe a data de nascimento do atleta (MM/dd/yyyy):");
primeiroAtleta.DataNascimento = DateTime.Parse(Console.ReadLine());

Console.WriteLine("Informe o Endereço");
primeiroAtleta.Endereco = Console.ReadLine();

Console.WriteLine("Inforeme a base do atleta");
primeiroAtleta.Base = Console.ReadLine();

Console.WriteLine("Infomer o percentual de massa do atleta");
primeiroAtleta.PercentualMassa = float.Parse(Console.ReadLine());

Console.WriteLine("Informe o peso atual do atleta");
primeiroAtleta.PesoAtual = float.Parse(Console.ReadLine());

Console.WriteLine("informe a área de atuação do atleta");
primeiroAtleta.AreaAtuacao = Console.ReadLine();

Console.WriteLine("Informe se o atleta é batedor de pênaltis (True/False)");
primeiroAtleta.EhBatedorDePenaltis = Boolean.Parse(Console.ReadLine());

Console.WriteLine("informe se o atleta é canhoto ou destro (True/False)");
primeiroAtleta.CanhatoOuDestro = Boolean.Parse(Console.ReadLine());

Console.WriteLine("\n-----------------------------\n");
Console.WriteLine("Vamos cadastrar um Técnico");
Console.WriteLine("\n-----------------------------\n");

Tecnico tecnico = new Tecnico();
Console.WriteLine("infome o nome do tecnico");
tecnico.Nome = Console.ReadLine();

Console.WriteLine("Informe a data de nascimento do técnico (MM/dd/yyyy):");
tecnico.DataNascimento = DateTime.Parse(Console.ReadLine());

Console.WriteLine("informe a idade do técnico");
tecnico.Idade = int.Parse(Console.ReadLine());

Console.WriteLine("Informe o endereço do técnico");
tecnico.Endereco = Console.ReadLine();

Console.WriteLine("Informe o CPF do técnico");
tecnico.CPF = Console.ReadLine();

Console.WriteLine("Informe o telefone do técnico");
tecnico.Telefone = Console.ReadLine();

Console.WriteLine("Informe se o técnico possui comissão técnica (True/False)");
tecnico.PossuiComissaoTecnica = Boolean.Parse(Console.ReadLine());

Console.WriteLine("Informe o tempo de contrato do técnico (MM/dd/yyyy):");
tecnico.TempoDeContrato = DateTime.Parse(Console.ReadLine());   

Console.WriteLine("Informe o salário do técnico");
tecnico.Salario = float.Parse(Console.ReadLine());

Console.WriteLine("Informe o perfil técnico do técnico");
tecnico.PerfilTecnico = Console.ReadLine();

Console.WriteLine("Informe o último clube do técnico");
tecnico.UltimoClube = Console.ReadLine();

Console.WriteLine("\n-----------------------------\n");
Console.WriteLine("Vamos cadastrar mebros da comissão Técnica");
Console.WriteLine("\n-----------------------------\n");

ComissaoTecnica comissaoTecnica = new ComissaoTecnica();    
Console.WriteLine("Informe o nome do membro da comissão técnica");
comissaoTecnica.Nome = Console.ReadLine();

Console.WriteLine("Informe o telefone do membro da comissão técnica");
comissaoTecnica.Telefone = int.Parse(Console.ReadLine());

Console.WriteLine("Informe o endereço do membro da comissão técnica");
comissaoTecnica.Endereco = Console.ReadLine();

Console.WriteLine("Informe a data de nascimento do membro da comissão técnica (MM/dd/yyyy):");
comissaoTecnica.DataNascimento = DateTime.Parse(Console.ReadLine());

Console.WriteLine("Informe o cargo do membro da comissão técnica");
comissaoTecnica.Cargo = Console.ReadLine();

Console.WriteLine("Informe a formação do membro da comissão técnica");
comissaoTecnica.Formação = Console.ReadLine();

Console.WriteLine("Informe o tempo de experiência do membro da comissão técnica");
comissaoTecnica.TempoExperiencia = int.Parse(Console.ReadLine());


   

