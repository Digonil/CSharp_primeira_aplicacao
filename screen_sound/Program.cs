//Screen Sound

string mensagemDeBoasVindas = "Boas vindas ao Screen Sound!!!";

void ExibirMensagemDeBoasVindas() 
{
    //Verbatim Literal
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
/*  
void     ExibirOpcoesDoMenu() {
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");


    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;//! indica que o readline não pode ser nulo.
    //Aplicado parse no tipo pois não se aplica operador em tipos diferentes.
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica) {
        case 1:  Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica); 
            break;
        case 2:  Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica); 
            break;
        case 3:  Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica); 
            break;
        case 4:  Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica); 
            break;
        case -1:  Console.WriteLine("Tchau tchau :)"); 
            break;
        default: Console.WriteLine("Opção inválida");
            break;
    }
    //Exemplo de uso de interpolação de string
    Console.WriteLine($"texto teste, {opcaoEscolhida}");

    //Exemplo que permite substituir marcadores de posição
    Console.WriteLine("Olá, {0}!", opcaoEscolhida);
}
*/


//ExibirMensagemDeBoasVindas();
//ExibirOpcoesDoMenu();


Console.WriteLine("Digite um número de 1 a 5: ");
Random rand = new Random();
int valorAcertado = rand.Next(1, 5);
int numeroDigitadoConvertido;

do {
    string numeroDigitado = Console.ReadLine()!;
    numeroDigitadoConvertido = int.Parse(numeroDigitado);
    numeroDigitadoConvertido = int.Parse(numeroDigitado);
} while (numeroDigitadoConvertido != valorAcertado);

Console.WriteLine($"O valor acertado foi {valorAcertado}");

