using Class;

Village myVillage = new Village("Phoenyx le createur");
myVillage.getName(); // affichera Phoenyx le createur

myVillage.cutWood(50); // affichera Il n'y a pas assez de villageois
Console.WriteLine(myVillage.getStone()); // afficher 10
Console.WriteLine(myVillage.getWood()); // afficher 10
myVillage.cutWood(6); // affichera Il n'y a pas assez de ressource
Console.WriteLine(myVillage.getStone()); // afficher 10
Console.WriteLine(myVillage.getWood()); // afficher 10
myVillage.cutWood(5);myVillage.cutWood(5); // affichera Il n'y a pas assez de ressource
Console.WriteLine(myVillage.getStone()); // afficher 0
Console.WriteLine(myVillage.getWood()); // afficher 55
myVillage.cutWood(5); // affichera Il n'y a pas assez de ressource