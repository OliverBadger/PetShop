﻿// See https://aka.ms/new-console-template for more information
using myPetShop;

//Pet pet = new Pet(1,"Grey", "Male", "Extra-Large", 24, 4, "Jimbo", "Cute but stupid hippo", 1500000);
//pet.GetInfo();
//pet.Sleep();

Dog d1 = new Dog(1, "Black", "Male", "Cane Corso", "Large", 7, 4, "Bear", "Cutest and Goodest boy!", 1500, false, true);
d1.GetInfo();
d1.Sleep();
d1.Poops();
d1.Eat();

Cat c1 = new Cat(1, "Cream", "Female", "Jess", "Small", 4, 4, "Spawn of Satan", "That one with no hair", 15000, false, true);
c1.GetInfo();
c1.Sleep();
c1.Poops();
c1.Eat();

Goldfish g1 = new Goldfish(1, "Female", "Tiny", 1, 0, "The Destroyer", "He knows nothing but pain!", 15000);
g1.GetInfo();
g1.Sleep();
g1.Poops();
g1.Eat();