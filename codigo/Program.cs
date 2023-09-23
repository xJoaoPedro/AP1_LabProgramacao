int loop = 1;
int idade;
double altura;
double peso;
string? nome;
string? categoriaIMC;
string? faixaetaria;

do
{

    Console.WriteLine("\nDigite seu nome:");
    nome = Console.ReadLine();

    Console.WriteLine("\nDigite sua idade:");
    idade = Convert.ToInt32(Console.ReadLine());
    while (idade < 0 || idade > 121)
    {
        Console.WriteLine("\nIdade inválida, digite uma idade válida:");
        idade = Convert.ToInt32(Console.ReadLine());
    }

    Console.WriteLine("\nDigite sua altura:");
    altura = Convert.ToDouble(Console.ReadLine());
    while (altura < 0 || altura > 2.45)
    {
        Console.WriteLine("\nAltura inválida, digite uma altura válida:");
        altura = Convert.ToDouble(Console.ReadLine());
    }

    Console.WriteLine("\nDigite seu peso:");
    peso = Convert.ToDouble(Console.ReadLine());
    while (peso < 0 || peso > 394)
    {
        Console.WriteLine("\nPeso inválido, digite um peso válido:");
        peso = Convert.ToDouble(Console.ReadLine());
    }

    double IMC = peso / (altura * altura);
    if (IMC < 18.5)
    {
        categoriaIMC = "Abaixo do peso";
    } 
    else if (IMC >= 18.5 && IMC <= 24.9)
    {
        categoriaIMC = "Normal";
    }
    else if (IMC >= 25 && IMC <= 29.9)
    {
        categoriaIMC = "Sobrepeso";
    }
    else if (IMC >= 30)
    {
        categoriaIMC = "Obeso";
    }
    else
    {
        categoriaIMC = "inválido";
    }

    switch (idade)
    {
        case > 0 when (idade < 15):
            faixaetaria = "Criança";
            break;
        case > 0 when (idade >= 15 && idade <= 17):
            faixaetaria = "Adolescente";
            break;
        case > 0 when (idade >= 18 && idade <= 59):
            faixaetaria = "Adulto";
            break;
        case > 0 when (idade > 59):
            faixaetaria = "Idoso";
            break;
        default:
            faixaetaria = "Inválido";
            break;
    }

    //Relatório
    Console.WriteLine("\n===============RELATÓRIO DE IMC===============");
    Console.WriteLine(" Nome: " + nome);
    Console.WriteLine(" Idade: " + idade + " anos");
    Console.WriteLine($" Altura: {altura} metros \n Peso: {peso} quilos \n Faixa etária: {faixaetaria} \n IMC: {IMC:F2} \n Categoria de IMC: {categoriaIMC} \n==============================================");

    //encerramento ou continuação
    Console.WriteLine("\nDeseja continuar? [1-Sim/2-Não]");
    loop = Convert.ToInt32(Console.ReadLine());
    while (loop != 1 && loop != 2)
    {
        Console.WriteLine("Comando inválido, digite 1 para continuar e 2 para sair");
        loop = Convert.ToInt32(Console.ReadLine());
    }

} while (loop == 1);

Console.WriteLine("\nObrigado por usar a nossa calculadora de IMC!");