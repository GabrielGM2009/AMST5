using System;
public class Car
{
    public string Model{get; private set;}

    public double Instant1{get; private set;}

    public double Instant2{get; private set;}

    public int Idcar{get; private set;}

    public double Diary{get; private set;}

    public double Valuephour{get; private set;}

    public int Dias{get; private set;}


    internal void Mensagem()
    {
      Console.WriteLine("Digite modelo do carro: ");  
      Model = Console.ReadLine();
      Console.WriteLine("Digite horario de retirada: ");  
      Instant1 = double.Parse(Console.ReadLine());
      Console.WriteLine("Digite horario de devolução: ");  
      Instant2 = double.Parse(Console.ReadLine());
      Console.WriteLine("Digite quantidade de dias de locação: ");  
      Dias = int.Parse(Console.ReadLine());
      Console.WriteLine("Digite id do carro: ");  
      Idcar = int.Parse(Console.ReadLine());
      Console.WriteLine("Digite preço por hora da locação: ");  
      Valuephour = double.Parse(Console.ReadLine());
      Console.WriteLine("Digite valor da diaria: ");  
      Diary = double.Parse(Console.ReadLine());

    }

    internal void Calculo()
    {
        if(Dias == 0 ) 
        {
            double subtra = Instant2 - Instant1;
            if(subtra < 12)
            {
                double valor = subtra*Valuephour;
                if(valor<100)
                {
                Console.WriteLine($"Valor a ser pago é {valor * 1.20} reais");//imposto de 20% sobre valores a baixo de 100 reais
                }
                else
                { 
                Console.WriteLine($"Valor a ser pago é {valor * 1.15} reais");//imposto de 15% sobre valores a cima de 100 reais
                }
            }
            else
            {
                Console.WriteLine($"Valor a ser pago é {Diary * 1.15} reais");
            }
        }
        else
        {
            Console.WriteLine($"Valor a ser pago é {(Diary * Dias)*1.15}");

        }
    }

    internal void NotaMensag()
    {
        Console.WriteLine("");
        Console.WriteLine("NOTA FISCAL:");
        Console.WriteLine($"Modelo do carro: {Model} ");
        Console.WriteLine($"Horario do Retiro: {Instant1} ");
        Console.WriteLine($"Quantidade de dias da locação do carro: {Dias} ");
        Console.WriteLine($"Horario da Devolução: {Instant2} ");
        Console.WriteLine($"ID do carro: {Idcar} ");
        Console.WriteLine($"Valor da diaria: {Diary} ");
        Console.WriteLine($"Valor da hora: {Valuephour} ");
    }
}
