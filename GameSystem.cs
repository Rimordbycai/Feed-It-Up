public class GameSystem
{
    public void SaveGame()
    {
        // Simple save to a file (can be expanded with serialization)
        using (StreamWriter writer = new StreamWriter("savegame.txt"))
        {
            writer.WriteLine(PlayerFish.Instance.Name);
            writer.WriteLine(PlayerFish.Instance.Size);
            writer.WriteLine(PlayerFish.Instance.Health);
            writer.WriteLine(PlayerFish.Instance.Level);
            Console.WriteLine("Game saved successfully.");
        }
    }

    public void LoadGame()
    {
        // Simple load from a file (can be expanded with serialization)
        if (File.Exists("savegame.txt"))
        {
            using (StreamReader reader = new StreamReader("savegame.txt"))
            {
                PlayerFish.Instance.Name = reader.ReadLine();
                PlayerFish.Instance.Size = int.Parse(reader.ReadLine());
                PlayerFish.Instance.Health = int.Parse(reader.ReadLine());
                PlayerFish.Instance.Level = int.Parse(reader.ReadLine());
                Console.WriteLine("Game loaded successfully.");
            }
        }
        else
        {
            Console.WriteLine("No save game found.");
        }
    }
}
