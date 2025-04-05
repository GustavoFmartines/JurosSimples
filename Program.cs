    Double capital;
    Double taxaJuros;
    Double tempoA;
    Double montante;
    Double juros;
    Double tempoB;


Console.Clear();

Console.WriteLine("Digite o valor do capital: ");
capital = Convert.ToDouble(Console.ReadLine()!);

Console.WriteLine("Digite o valor da taxa do juros: ");
taxaJuros = Convert.ToDouble(Console.ReadLine()!);

Console.WriteLine("Digitem a quatidade de meses: ");
tempoA = Convert.ToDouble(Console.ReadLine()!);

        tempoB = tempoA / 100;

        juros = capital * taxaJuros * tempoB;

        montante = capital + juros;

Console.WriteLine($"Capital(R$).......: {capital},00");
Console.WriteLine($"Taxa de Juros(%)..: {taxaJuros}");
Console.WriteLine($"Tempo(meses)......: {tempoA}");

Console.WriteLine($"Juros(R$)...: {juros},00");
Console.WriteLine($"Montante(R$)..:{montante},00");
