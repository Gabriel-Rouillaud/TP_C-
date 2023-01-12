namespace Class
{
    class Mine
    {
        static public int gain_stone = 10;
        static public int stone_cost = 2;
        static public int wood_cost = 1;

        public Mine(){
            Console.WriteLine("Mine created");
        }

        public int mineStone(int nbr_villageois){
            int result = nbr_villageois * gain_stone;

            return result;
        }
    }
}