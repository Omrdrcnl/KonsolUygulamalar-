namespace BasicApps2
{
    class program
    {
        public static void Main(string[] args)
        {
            //Dictionary key-value pair system

        Dictionary<int,string> dict = new Dictionary<int,string>();

            dict[2] = "ali";
            dict[1] = "baba";
            dict[3] = "hosşgeldin";



            foreach (var item in dict.Keys)
            {
                Console.WriteLine("Keys: " + item);
            }

            foreach (var item in dict.Values)
            {
                Console.WriteLine("Values: " + item);
            }

            foreach (var item in dict)
            {
                Console.WriteLine("Keys: " + item.Key + " Values: " + item.Value);
            }
            Console.ReadLine();

            dict.Add(4, "Adem");

            dict.Remove(2);
            
            foreach (var item in dict)
            {
                Console.WriteLine("Keys: " + item.Key + " Values: " + item.Value);
            }
            Console.ReadLine();
        }
    }
}