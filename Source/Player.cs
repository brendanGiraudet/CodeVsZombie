using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Save humans, destroy zombies!
 **/
class Player
{
    static void Main(string[] args)
    {
        string[] inputs;

        // game loop
        while (true)
        {
            var me = GetMyInfo();
            System.Console.Error.WriteLine("******** ME ********");
            System.Console.Error.WriteLine(me);

            var humans = GetHumans();
            System.Console.Error.WriteLine("******** HUMANS ********");
            humans.ForEach(System.Console.Error.WriteLine);
            
            var zombies = GetZombies();
            System.Console.Error.WriteLine("******** ZOMBIES ********");
            zombies.ForEach(System.Console.Error.WriteLine);

            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");

            Console.WriteLine("0 0"); // Your destination coordinates

        }
    }
    static Human GetMyInfo()
    {
        var inputs = Console.ReadLine().Split(' ');
        int x = int.Parse(inputs[0]);
        int y = int.Parse(inputs[1]);

        return new Human{ Id = 0, Latitude = y, Longitude = x};
    }
    static List<Human> GetHumans()
    {
        var humans = new List<Human>();
        int humanCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < humanCount; i++)
            {
                var inputs = Console.ReadLine().Split(' ');
                humans.Add(new Human{
                    Id=int.Parse(inputs[0]),
                    Latitude = int.Parse(inputs[1]),
                    Longitude = int.Parse(inputs[2])
                });
            }
            return humans;
    }
    static List<Zombie> GetZombies()
    {
        var zombies = new List<Zombie>();
        int zombieCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < zombieCount; i++)
            {
                var inputs = Console.ReadLine().Split(' ');
                zombies.Add(new Zombie{
                    Id = int.Parse(inputs[0]),
                    Latitude = int.Parse(inputs[1]),
                    Longitude = int.Parse(inputs[2]),
                    NextLatitude = int.Parse(inputs[3]),
                    NextLongitude = int.Parse(inputs[4])
                });
            }
            return zombies;
    }
}
class Human
{
    public int Id { get; set; }

    public int Latitude { get; set; }

    public int Longitude { get; set; }

    public override string ToString()
    {
        return $"Id: {Id}, Latitude: {Latitude}, Longitude: {Longitude}";
    }
}
class Zombie
{
    public int Id { get; set; }

    public int Latitude { get; set; }

    public int Longitude { get; set; }

    public int NextLatitude { get; set; }

    public int NextLongitude { get; set; }

    public override string ToString()
    {
        return $"Id: {Id}, Latitude: {Latitude}, Longitude: {Longitude}, NextLatitude: {NextLatitude}, NextLongitude: {NextLongitude}";
    }
}