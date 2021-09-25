namespace TheBattleoftheFiveArmies
{
    using System;
    using System.Linq;
    using System.Text;

    public class Startup
    {
        private const char Orcs = 'O';
        private const char Army = 'A';
        private const char Death = 'X';
        private const char Mordor = 'M';
        private const char Empty = '-';
        private const string Up = "up";
        private const string Down = "down";
        private const string Left = "left";
        private const string Right = "right";
        private static int ArmyArmor;
        private static bool ArmyLive = true;

        public static void Main(string[] args)
        {
            ArmyArmor = int.Parse(Console.ReadLine());
            var numberOfRows = int.Parse(Console.ReadLine());

            char[][] world = MatrixCreator(numberOfRows);

            var command = new string[] { };
            var direction = string.Empty;
            var spawnRow = 0;
            var spawnColl = 0;


            while (true)
            {
                command = Console.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
               .ToArray();
                direction = command[0];
                spawnRow = int.Parse(command[1]);
                spawnColl = int.Parse(command[2]);

                OrcSpawner(world, spawnRow, spawnColl);
                Mover(world, direction);

                if (!ArmyLive || MordorDeathCheck(world))
                {
                    break;
                }
            }

            if (!ArmyLive)
            {
                var deathPosition = DeathFinder(world);

                Console.WriteLine($"The army was defeated at {deathPosition[0]};{deathPosition[1]}.");
            }
            else if (ArmyLive)
            {
                Console.WriteLine($"The army managed to free the Middle World! Armor left: {ArmyArmor}");
            }

            WorldPrinter(world);
        }

        public static char[][] MatrixCreator(int numberOfRows)
        {
            char[][] world = new char[numberOfRows][];
            var rows = new char[] { };

            for (int i = 0; i < numberOfRows; i++)
            {
                rows = Console.ReadLine().ToCharArray();
                world[i] = new char[rows.Length];

                for (int k = 0; k < rows.Length; k++)
                {
                    world[i][k] = rows[k];
                }
            }

            return world;
        }

        public static void OrcSpawner(char[][] world, int spawnRow, int spawnColl)
        {
            world[spawnRow][spawnColl] = Orcs;
        }

        public static void Mover(char[][] world, string direction)
        {
            var armyPosition = ArmyLocator(world);

            if (direction == Up)
            {
                if (armyPosition[0] - 1 < 0)
                {
                    ArmyArmor--;
                    DeathMarker(world, armyPosition);
                }
                else if (world[armyPosition[0] - 1][armyPosition[1]] == Empty)
                {
                    world[armyPosition[0]][armyPosition[1]] = Empty;
                    world[armyPosition[0] - 1][armyPosition[1]] = Army;
                    ArmyArmor--;
                    DeathMarker(world, armyPosition);
                }
                else if (world[armyPosition[0] - 1][armyPosition[1]] == Orcs)
                {
                    ArmyArmor -= 3;
                    if (ArmyDeathCheck(world))
                    {
                        world[armyPosition[0]][armyPosition[1]] = Empty;
                        world[armyPosition[0] - 1][armyPosition[1]] = Death;
                    }
                    else
                    {
                        world[armyPosition[0]][armyPosition[1]] = Empty;
                        world[armyPosition[0] - 1][armyPosition[1]] = Army;
                    }
                }
                else if (world[armyPosition[0] - 1][armyPosition[1]] == Mordor)
                {
                    world[armyPosition[0] - 1][armyPosition[1]] = Empty;
                    world[armyPosition[0]][armyPosition[1]] = Empty;
                    ArmyArmor--;
                    DeathMarker(world, armyPosition);
                }
            }
            else if (direction == Down)
            {
                if (armyPosition[0] + 1 > world.GetLength(0))
                {
                    ArmyArmor--;
                    DeathMarker(world, armyPosition);
                }
                else if (world[armyPosition[0] + 1][armyPosition[1]] == Empty)
                {
                    world[armyPosition[0]][armyPosition[1]] = Empty;
                    world[armyPosition[0] + 1][armyPosition[1]] = Army;
                    ArmyArmor--;
                    DeathMarker(world, armyPosition);
                }
                else if (world[armyPosition[0] + 1][armyPosition[1]] == Orcs)
                {
                    ArmyArmor -= 2;
                    if (ArmyDeathCheck(world))
                    {
                        world[armyPosition[0] + 1][armyPosition[1]] = Death;
                    }
                    else
                    {
                        world[armyPosition[0]][armyPosition[1]] = Empty;
                        world[armyPosition[0] + 1][armyPosition[1]] = Army;
                    }
                }
                else if (world[armyPosition[0] + 1][armyPosition[1]] == Mordor)
                {
                    world[armyPosition[0]][armyPosition[1]] = Empty;
                    world[armyPosition[0] + 1][armyPosition[1]] = Empty;
                    ArmyArmor--;
                    DeathMarker(world, armyPosition);
                }
            }
            else if (direction == Left)
            {
                if (armyPosition[1] - 1 < 0)
                {
                    ArmyArmor--;
                    DeathMarker(world, armyPosition);
                }
                else if (world[armyPosition[0]][armyPosition[1] - 1] == Empty)
                {
                    world[armyPosition[0]][armyPosition[1]] = Empty;
                    world[armyPosition[0]][armyPosition[1] - 1] = Army;
                    ArmyArmor--;
                    DeathMarker(world, armyPosition);
                }
                else if (world[armyPosition[0]][armyPosition[1] - 1] == Orcs)
                {
                    ArmyArmor -= 2;
                    if (ArmyDeathCheck(world))
                    {
                        world[armyPosition[0]][armyPosition[1] - 1] = Death;
                    }
                    else
                    {
                        world[armyPosition[0]][armyPosition[1]] = Empty;
                        world[armyPosition[0]][armyPosition[1] - 1] = Army;
                    }
                }
                else if (world[armyPosition[0]][armyPosition[1] - 1] == Mordor)
                {
                    world[armyPosition[0]][armyPosition[1]] = Empty;
                    world[armyPosition[0]][armyPosition[1] - 1] = Empty;
                    ArmyArmor--;
                    DeathMarker(world, armyPosition);
                }
            }
            else if (direction == Right)
            {
                if (armyPosition[1] + 1 > world[armyPosition[1]].Length)
                {
                    ArmyArmor--;
                    DeathMarker(world, armyPosition);
                }
                else if (world[armyPosition[0]][armyPosition[1] + 1] == Empty)
                {
                    world[armyPosition[0]][armyPosition[1]] = Empty;
                    world[armyPosition[0]][armyPosition[1] + 1] = Army;
                    ArmyArmor--;
                    DeathMarker(world, armyPosition);
                }
                else if (world[armyPosition[0]][armyPosition[1] + 1] == Orcs)
                {
                    ArmyArmor -= 2;
                    if (ArmyDeathCheck(world))
                    {
                        world[armyPosition[0]][armyPosition[1] + 1] = Death;
                    }
                    else
                    {
                        world[armyPosition[0]][armyPosition[1]] = Empty;
                        world[armyPosition[0]][armyPosition[1] + 1] = Army;
                    }
                }
                else if (world[armyPosition[0]][armyPosition[1] + 1] == Mordor)
                {
                    world[armyPosition[0]][armyPosition[1]] = Empty;
                    world[armyPosition[0]][armyPosition[1] + 1] = Empty;
                    ArmyArmor--;
                    DeathMarker(world, armyPosition);
                }
            }
        }

        public static int[] ArmyLocator(char[][] world)
        {
            var position = new int[2];

            for (int row = 0; row < world.GetLength(0); row++)
            {
                for (int coll = 0; coll < world[row].Length; coll++)
                {
                    if (world[row][coll] == Army)
                    {
                        position[0] = row;
                        position[1] = coll;

                        break;
                    }
                }
            }

            return position;
        }

        public static bool ArmyDeathCheck(char[][] world)
        {
            var armyPosition = ArmyLocator(world);

            if (ArmyArmor <= 0)
            {
                ArmyLive = false;
                return true;
            }

            return false;
        }

        public static bool MordorDeathCheck(char[][] world)
        {
            for (int i = 0; i < world.GetLength(0); i++)
            {
                for (int k = 0; k < world[i].Length; k++)
                {
                    if (world[i][k] == Mordor)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public static int[] DeathFinder(char[][] world)
        {
            var deathPosition = new int[2];

            for (int row = 0; row < world.GetLength(0); row++)
            {
                for (int coll = 0; coll < world[row].Length; coll++)
                {
                    if (world[row][coll] == Death)
                    {
                        deathPosition[0] = row;
                        deathPosition[1] = coll;

                        break;
                    }
                }
            }

            return deathPosition;
        }

        public static void WorldPrinter(char[][] world)
        {
            var sb = new StringBuilder();

            for (int row = 0; row < world.GetLength(0); row++)
            {
                sb.AppendLine();
                for (int coll = 0; coll < world[row].Length; coll++)
                {
                    sb.Append(world[row][coll]);
                    // Console.Write($"{world[row, coll]}");
                }
            }

            Console.WriteLine(sb.ToString().Trim());
        }

        public static void DeathMarker(char[][] world, int[] armyPosition)
        {
            if (ArmyDeathCheck(world))
            {
                world[armyPosition[0]][armyPosition[1]] = Death;
            }
        }
    }
}
