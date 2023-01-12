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
            
            if(stones <= 0){
                Console.WriteLine("Vous ne pouvez pas plus utiliser de pierres.");
            }else{
                stones -= stones - nbr;
            }  
        }

        public void useWood(int nbr){
            if(woods <= 0){
                Console.WriteLine("Vous ne pouvez pas plus utiliser de bois.");
            }else{
                woods -= woods - nbr;
            }
        }
    }
}