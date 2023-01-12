namespace Class
{
    class Village
    {
        private string name;

        public string Name {
            get {return name;}
        }

        public int villageois;

        private Ressources myRessources;
        
        public House[] listHouse;

        public House chefHome;


        //Constructor

        public Village(string name){
            this.name = name;
            this.villageois = House.villageois;
            this.myRessources = new Ressources();
            this.listHouse = new House[1];
            this.chefHome = new House();
            listHouse[0] = chefHome; 
        }

        

        //Getters

        public string getName(){
            Console.WriteLine(this.name);
            return this.name;
        }

        public int getWood(){
            return myRessources.getWood();
        }

        public int getStone(){
           return myRessources.getStone();
        }

        public int getVillageois(){
            int result = listHouse.Length * House.villageois;
            Console.WriteLine(result);

            return this.villageois;
        }

        //Methods

        //Ajouter un élement à un tableau
        //Incrémenter la taille de mon tableau
        //Créer un nouveau tableau qui aurait pour taille la condition ci-dessus
        //Attribuer les élements de l'ancien tableau
        //Appeler le tableau pour lui attribuer un nouvel élement
        private void addHouse(House maison){
            House[] newTab = new House[listHouse.Length + 1];

            for (int i = 0; i < listHouse.Length; i++) // Parcours toutes le valeurs de 0 à toute la longueur de mon tableau
            {
                newTab[i] = listHouse[i];  //Attribuer les anciennes valeurs à mon nouveau tableau à l'index [i] 
            }

            newTab[newTab.Length - 1] = maison; // J'appelle mon tableau à l'index lenght - 1 (dernier élement de mon tableau) et je lui attribue un nouvel élément.

            listHouse = newTab; // Je remplace l'ancien tableau sans accéder aux valeurs par le nouveau tableau
        }
    }
}