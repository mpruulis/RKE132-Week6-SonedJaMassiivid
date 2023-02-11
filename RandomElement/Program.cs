string[] snacks = { "pitsa", "võileib", "kana", "McDonals", "KFC", "Wrapp", "nälg" };

Random rnd = new Random();
int randomIndex = rnd.Next(0, snacks.Length);

Console.WriteLine($"Täna sööme me {snacks[randomIndex]}.");