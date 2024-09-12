using System;

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person();
        
        Console.Write("Digite a sua idade: ");
        int idade;
        if (int.TryParse(Console.ReadLine(), out idade))
        {
            person.Age = idade;
            Console.WriteLine("Idade definida com sucesso: " + person.Age);
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor, insira um número inteiro.");
        }
    }
}

class Person
{
    private int age = 0;
    public int Age
    {
        get { return age; }
        set
        {
            if (value > 0)
                age = value;
        }
    }
}