namespace Classe
{
    class Village
    {
        private string name;
        private  myRessource = new Ressources();

        

        public string[] listHouse;

        public string getName(){
            return this.name;
        }

        public Village(string name, Ressources){
        this.name = name; 
        myRessource = new Ressources();
    }
    }
}