
namespace myPetShop;
internal class Eagle : Pet, IFly
{
    public Eagle(int id, string colour, string gender, string size, 
        int age, int numberOfLegs, string name, string description, 
        int price) : base(id, colour, gender, size, age, numberOfLegs, name, description, price)
    {

    }

    public override void Eat() => throw new NotImplementedException();

    public void GainHeight() => throw new NotImplementedException();

    public void Land() => throw new NotImplementedException();

    public override void Poops() => throw new NotImplementedException();

    public override void Sleep() => throw new NotImplementedException();

    public void TakeOff() => throw new NotImplementedException();
}
