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

        public Mine villageMine;

        public Forest villageForest;


        //Constructor

        public Village(string name){
            this.name = name;
            this.villageois = House.villageois;
            this.myRessources = new Ressources();
            this.listHouse = new House[1];
            this.chefHome = new House();
            listHouse[0] = chefHome; 
            this.villageMine = new Mine();
            this.villageForest = new Forest();

        } 

        //Getters

        public string getName(){
            Console.WriteLine(this.name);
            return this.name;
        }

        public int getWood(){
            int woods = myRessources.getWood();

            return woods;
        }

        public int getStone(){
           int stones = myRessources.getStone();

           return stones;
        }

        public int getVillageois(){
            int result = listHouse.Length * House.villageois;

            return result;
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

        public void mineStone(int nbr_villageois){
            //Vérifier si j'ai assez de villageois par rapport nbr_villageois
            //Vérifier si j'ai suffisement de pierre et du bois avant d'aller miner
            //Si condition = true alors mineStone

            if(nbr_villageois > villageois){
                Console.WriteLine("Vous n'avez pas assez de villageois");
            }else if(getWood() < Mine.wood_cost * nbr_villageois || getStone() < Mine.stone_cost * nbr_villageois){
                Console.WriteLine("Vous n'avez pas assez de ressources");
            }else{
                myRessources.useWood(Mine.wood_cost * nbr_villageois);
                myRessources.useStone(Mine.stone_cost * nbr_villageois);
                myRessources.addStone(Mine.gain_stone * nbr_villageois);
            }
        }

        public void cutWood(int nbr_villageois){
          if(nbr_villageois > villageois){
            Console.WriteLine("Vous n'avez pas assez de villageois");
          }else if(getWood() < Forest.wood_cost * nbr_villageois || getStone() < Forest.stone_cost * nbr_villageois){
            Console.WriteLine("Vous n'avez pas assez de ressources");
          }else{
            myRessources.useWood(Forest.wood_cost * nbr_villageois);
            myRessources.useStone(Forest.stone_cost * nbr_villageois);
            myRessources.addWoods(Forest.gain_wood * nbr_villageois);
          }  
        }

        public void buildHouse(int nbr_house){
            if(getWood() < House.wood_needed * nbr_house || getStone() < House.stone_needed * nbr_house){
                Console.WriteLine("Vous n'avez pas assez de ressources pour construire ce batiment");
            }else{
                myRessources.useWood(House.stone_needed * nbr_house);
                myRessources.useStone(House.stone_needed * nbr_house);

                for (int i = 0; i < nbr_house; i++) // Pas possible de multiplier par un nombre une méthode, passer par une boucle pour répéter plusieurs fois la méthode si besoin
                {
                    this.addHouse(new House());
                }

                villageois = getVillageois();
            }
        }
    }
}