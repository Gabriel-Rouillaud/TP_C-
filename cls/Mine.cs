namespace Class
{
    class Mine
    {
        public int gain_stone;
        public int stone_cost;
        public int wood_cost;

        public Mine(){
            Console.WriteLine("Mine created");
        }

        public Mine(){
            this.gain_stone = 10;
            this.stone_cost = 2;
            this.wood_cost = 1;
        }
    }
}