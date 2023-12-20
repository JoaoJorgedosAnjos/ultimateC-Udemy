var dog = new Dog("Black", "Rusky", 30);
var dog1 = new Dog("Nemo", 15);
Console.WriteLine(dog.Describe());
Console.WriteLine(dog1.Describe());
class Dog
{
    string Name, Breed;
    int Weight;

    public Dog(string name, string breed, int weight)
    {
        Name = name;
        Breed = breed;
        Weight = weight;
    }
    public Dog(string name, int weight, string breed = "mixed-breed")
    {
        Name = name;
        Weight = weight;
        Breed = breed;
    }

    public string Describe()
    {
        string dogSize;
        switch (Weight)
        {
            case int w when w < 5:
                dogSize = "tiny";
                break;
            case int w when w < 30:
                dogSize = "medium";
                break;
            default:
                dogSize = "large";
                break;
        }
        return $"This dog is named {Name}, it's a {Breed}, and it weighs {Weight} kilograms, so it's a {dogSize} dog.";
    }
}

/*
using System;

namespace Coding.Exercise
{
    public class Dog
{
    string Name, Breed;
    int Weight;

    public Dog(string name, string breed, int weight)
    {
        Name = name;
        Breed = breed;
        Weight = weight;
    }
    public Dog(string name, int weight, string breed = "mixed-breed")
    {
        Name = name;
        Weight = weight;
        Breed = breed;
    }

    public string Describe()
    {
        string dogSize = "";
        if (Weight < 5)
        {
            dogSize = "tiny";
        }
        else if (Weight < 30)
        {
            dogSize = "medium";

        }
        else
        {
            dogSize = "large";
        }
        return $"This dog is named {Name}, it's a {Breed}, and it weighs {Weight} kilograms, so it's a {dogSize} dog.";
    }
}
}
*/