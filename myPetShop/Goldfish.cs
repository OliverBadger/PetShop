namespace myPetShop;

class Goldfish : Pet
{
    public Goldfish(int id, string colour, string gender, string size, int age, 
        int numberOfLegs, string name, string description, 
        int price) : base(id, colour, gender, size, age, numberOfLegs, name, description, price)
    {
        Colour = "Gold";
    }
}
