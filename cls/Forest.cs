namespace Class
{
    class Forest
    {
        static public int gain_wood = 10;
        static public int stone_cost = 2;
        static public int wood_cost = 1;

        public Forest(){
            Console.WriteLine("Forest found");
        }

        public int cutWood(int nbr_villageois){
            int result = nbr_villageois * gain_wood;

            return 0;
        }
    }
}