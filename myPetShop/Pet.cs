﻿namespace myPetShop;

abstract class Pet
{
    /* Variables */
    private int _id;
    private string _colour;
    private string _gender;
    private string _size;
    private int _age;
    private int _numberOfLegs;
    private string _name;
    private string _description;
    private int _price;

    /* Constructor */
    public Pet(int id, string colour, string gender, string size, int age, 
        int numberOfLegs, string name, string description, int price)
    {
        _id = id;
        _colour = colour;
        _gender = gender;
        _size = size;
        _age = age;
        _numberOfLegs = numberOfLegs;
        _name = name;
        _description = description;
        _price = price;
    }

    /* Getters and Setters */
    // ID is set once and not changeable
    public int Id { get => _id; }
    
    // Colour cannot change until a certain age
    public string Colour { get => _colour; }
    
    // Gender cannot change
    public string Gender { get => _gender; }
    
    // Bears gain weight for winter and lose it after
    public string Size { get => _size; set => _size = value; }
    
    // Age increases annually
    public int Age { get => _age; set => _age = value; }
    
    // Number of legs remains constant unless amputated
    public int NumberOfLegs { get => _numberOfLegs; }
    
    // Name usually doesn't change after birth
    public string Name { get => _name; }
    
    // Description may change based on other parameters
    public string Description { get => _description; set => _description = value; }
    
    // Price can change based on financial trends
    public int Price { get => _price; set => _price = value; }

    /* Methods */
    public void GetInfo()
    {
        Console.WriteLine($"""

            Name = { _name }
            Age = { _age }
            Description = { _description }
            Colour = {_colour}
            Price = £{_price:N0}
            """);
    }

    public void gettingOlder() => _age++;
    abstract public void Sleep();
    abstract public void Eat();
    abstract public void Poops();
}
