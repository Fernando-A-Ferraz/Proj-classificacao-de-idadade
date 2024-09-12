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
            Console.WriteLine("Grupo: " + person.GetAgeGroup());
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

    public string GetAgeGroup()
    {
        if (age >= 0 && age <= 12)
            return "Infantil";
        else if (age >= 13 && age <= 17)
            return "Adolescente";
        else if (age >= 18 && age <= 64)
            return "Adulto";
        else if (age >= 65)
            return "Idoso";
        else
            return "Idade inválida";
    }
}