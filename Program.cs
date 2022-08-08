int[,] m = new int[5, 5]
{
{3, 8, 6, 2, 4},
{6, 3, 2, 0, 5},
{1, 5, 7, 4, 9},
{8, 9, 2, 3, 1},
{2, 3, 9, 8, 0}

};

int[] sums = new int[5];

for (int i = 0; i < 5; i++)
{
for (int j = 0; j < 5; j++)
{
sums[i] += m[i, j];
}
}

Console.WriteLine( Array.IndexOf(sums, sums.Min()));
