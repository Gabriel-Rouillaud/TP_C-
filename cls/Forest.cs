namespace Class
{
    class Forest
    {
        public int gain_wood;
        public int stone_cost;
        public int wood_cost;

        public Forest(){
            this.gain_wood = 10;
            this.stone_cost = 2;
            this.wood_cost = 1;

            Console.WriteLine("Forest found");
        }

        public int cutWood(int nbr_villageois){
            int result = nbr_villageois * gain_wood;

            return result;
        }
    }
}