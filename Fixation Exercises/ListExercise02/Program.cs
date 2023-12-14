
string[] linesAndColumns = Console.ReadLine().Split(' ');

int lines = int.Parse(linesAndColumns[0]);
int columns = int.Parse(linesAndColumns[1]);

int[,] mat = new int[lines, columns];

for (int i = 0; i < lines; i++)
{
    string[] values = Console.ReadLine().Split(' ');

    for (int j = 0; j < columns; j++)
    {
        mat[i, j] = int.Parse(values[j]);
    }
}

int x = int.Parse(Console.ReadLine());

for (int i = 0; i < lines; i++)
{
    for (int j = 0; j < columns; j++)
    {
        if (mat[i, j] == x)
        {
            Console.WriteLine($"Position {i}, {j}:");

            if (j > 0)
            {
                Console.WriteLine($"Left: {mat[i,j - 1]}");
            }

            if (i > 0)
            {
                Console.WriteLine($"Up: {mat[i - 1, j]}");
            }

            if (j < columns - 1)
            {
                Console.WriteLine($"Right: {mat[i, j + 1]}");
            }

            if (i < lines - 1)
            {
                Console.WriteLine($"Down: {mat[i + 1, j]}");
            }
        }
    }
}