namespace myPetShop;

class Goldfish : Pet
{
    public Goldfish(int id, string gender, string size, int age, 
        int numberOfLegs, string name, string description, 
        int price) : base(id, "Yellow", gender, size, age, numberOfLegs, name, description, price)
    {

    }
}
