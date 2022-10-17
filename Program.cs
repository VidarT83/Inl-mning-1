{
    Random rt = new Random(); 
    int söktal = rt.Next(1,101);
    int i = 0;
    int t = 0;
    Console.WriteLine("Skriv ett heltal mellan 1 och 100");
    while (t != söktal)
    {
        i++;
        while (true)
        {
            t = int.Parse(Console.ReadLine());
            if (t > 0 && t < 101)
            {
                break;
            }
            Console.WriteLine("Felaktigt (Skriv ett tal mellan 1 och 100)");
        }
        if (t < söktal)
        {
            Console.WriteLine("Talet är högre");
        }
        if (t > söktal)
        {
            Console.WriteLine("Talet är lägre");
        }
    }
    Console.WriteLine("Talet " + t +" är rätt!");
    Console.WriteLine("Antalet gissningar var: " + i);
}