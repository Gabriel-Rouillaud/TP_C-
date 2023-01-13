namespace Class
{
    class Ressources
    {
        private int woods;
        private int stones;

        //Constructor

        public Ressources(){
        this.woods = 10;
        this.stones = 10;
        }

        //Getters

        public int getWood(){
            return this.woods;
        }

        public int getStone(){
            return this.stones;
        }

        //Methods

        public void useStone(int nbr){
            
            if(nbr > stones){
                Console.WriteLine("Vous ne pouvez pas plus utiliser de pierres.");
            }else{
                stones -= nbr;
            }  
        }

        public void useWood(int nbr){
            if(nbr > woods){
                Console.WriteLine("Vous ne pouvez pas plus utiliser de bois.");
            }else{
                woods -= nbr;
            }
        }

        public void addStone(int nbr){
            stones += nbr;
        }

        public void addWoods(int nbr){
            woods += nbr;
        }
    }
}