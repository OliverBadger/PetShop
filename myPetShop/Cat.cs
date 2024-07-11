namespace myPetShop;

class Cat : Pet
{

    public Cat(int id, string colour, string gender, string size, int age, 
        int numberOfLegs, string name, string description, 
        int price) : base(id, colour, gender, size, age, numberOfLegs, name, description, price)
    {
    }
}