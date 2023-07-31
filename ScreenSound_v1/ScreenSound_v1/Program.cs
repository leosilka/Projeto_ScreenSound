// Screen Sound
string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
//Em C# a lista precisa informar o tipo desta lista (Exemplo: List<int>)
// List<string> listaDasBandas = new List<string> {"U2", "The Beatles", "Calypso" };
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>(); // cria um dicionario chamado bandasRegistradas que ira associar o nome das bandas a lista de notas
bandasRegistradas.Add("Linkin Park", new List<int> { 10, 8, 6 });
bandasRegistradas.Add("The Beatles", new List<int>());

void ExibirLogo()
{
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirSaudacaoFinal()
{
    Console.Clear();
    Console.WriteLine(@"

 █████╗ ████████╗███████╗    ███╗   ███╗ █████╗ ██╗███████╗         
██╔══██╗╚══██╔══╝██╔════╝    ████╗ ████║██╔══██╗██║██╔════╝         
███████║   ██║   █████╗      ██╔████╔██║███████║██║███████╗         
██╔══██║   ██║   ██╔══╝      ██║╚██╔╝██║██╔══██║██║╚════██║         
██║  ██║   ██║   ███████╗    ██║ ╚═╝ ██║██║  ██║██║███████║██╗██╗██╗
╚═╝  ╚═╝   ╚═╝   ╚══════╝    ╚═╝     ╚═╝╚═╝  ╚═╝╚═╝╚══════╝╚═╝╚═╝╚═╝
                                                                    
powered by: Leo Silka®
");
    Thread.Sleep(3000);
}

void  ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine(@"

[1] - Registrar uma banda
[2] - Mostrar todas as bandas
[3] - Avaliar uma banda
[4] - Exibir a media de uma banda (Desafio Final)
[9] - Sair
");
    Console.Write("Escolha uma opcao: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1: //Registro de Bandas
            RegistrarBanda();
            break;
        case 2:
            ExibirBandas();
            break;
        case 3:
            AvaliarUmaBanda();
            break;
        case 4:
            VisualizarMediaDasBandas();
            break;
        case 9:
            ExibirSaudacaoFinal();
            break;
        default:
            Console.WriteLine("Opcao Invalida!");
            break;

    } 
}

void RegistrarBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registro das Bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>()); 
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(4000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void ExibirBandas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibindo todas as bandas registradas");
    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    //for (int i = 0; i < listaDasBandas.Count; i++)
    //{
    //    Console.WriteLine($"Banda: {listaDasBandas[i]}");
    //}
    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal. ");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length; // conta a quantidade de caracteres que existe no titulo
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*'); // A quantidade de * e a mesma quantidade do titulo da opcao
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

void AvaliarUmaBanda()
{
    //digite qual banda deseja avaliar
    //se a banda existir no dicionario >> atribuir uma nota
    //se a banda nao existir, volta para o menu principal
    Console.Clear();
    ExibirTituloDaOpcao("Avaliar Banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
        int nota = int.Parse(Console.ReadLine()!); //lendo a nota para banda
        bandasRegistradas[nomeDaBanda].Add(nota); //atribuindo uma nota a banda, ela acessa a lista de notas dda banda utilizando a chave nomeDaBanda e adiciona a nota na lista
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}!\n");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    } else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} nao foi encontrada!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal.");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}

void VisualizarMediaDasBandas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Media das Bandas");
    Console.Write("Digite o nome da banda que deseja visualizar a media: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        /*  
            METODO DO INSTRUTOR
        List<int> notasDaBanda = bandasRegistradas[nomeDaBanda];
        Console.WriteLine($\n"A média da banda {nomeDaBanda} é {notasDaBanda.Average()}.");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal.");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();         
        */
        List<int> notasDaBanda = bandasRegistradas[nomeDaBanda];
        // Console.WriteLine(nota); // Adicionado para verificar se esta puxando todos os valores dentro da lista.
        //List<int> numeroDasNotas = bandasRegistradas[nomeDaBanda];
        int somaNotas = notasDaBanda.Sum();
        //Console.WriteLine($"A soma dos valores da banda {nomeDaBanda} e: {somaNotas}"); // colocado para verificar se estava somando as notas
        int quantidadeNotas = bandasRegistradas[nomeDaBanda].Count();
        //Console.WriteLine($"A quantidade de notas da banda {nomeDaBanda} sao de: {quantidadeNotas}"); // colocado para verificar se estava retornando a quantidade de nota
        int mediaNotas = somaNotas / quantidadeNotas;
        Console.WriteLine($"A media da banda {nomeDaBanda} e de: {mediaNotas}\n");
        Thread.Sleep(5000);
        Console.Clear();
        ExibirOpcoesDoMenu();

    } else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} nao foi encontrada!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal.");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}

ExibirOpcoesDoMenu();