// See https://aka.ms/new-console-template for more information
using myPetShop;

Pet pet = new Pet(1,"Grey", "Male", "Extra-Large", 24, 4, "Jimbo", "Cute but stupid hippo", 1500);
pet.GetInfo();
pet.Sleep();
Dog d1 = new Dog(1, "Black", "Male", "Cane Corso", "Large", 7, 4, "Bear", "Cute but aggressive", 1500, false, true);
d1.GetInfo();
d1.Sleep();