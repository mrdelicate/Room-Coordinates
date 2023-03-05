while (true)
{
    DetermineIfTwoRandomCoordinatesAreAdjacent();
    Console.ReadLine();
}

void DetermineIfTwoRandomCoordinatesAreAdjacent()
{
    Random random = new();
    Coordinate coordinate1 = new Coordinate(random.Next(0,3), random.Next(1,3));
    Coordinate coordinate2 = new Coordinate(random.Next(0, 3), random.Next(1, 3));
    Console.WriteLine($"Coordinate1: ({coordinate1.Row}, {coordinate1.Col}) Coordinate2: ({coordinate2.Row}, {coordinate2.Col}) Adjacent: {CheckAdjacency(coordinate1, coordinate2)}");
}

static bool CheckAdjacency(Coordinate coordinate1, Coordinate coordinate2)
{
    if ((Math.Abs(coordinate1.Row - coordinate2.Row) == 1 && Math.Abs(coordinate1.Col - coordinate2.Col) == 0) || (Math.Abs(coordinate1.Row - coordinate2.Row) == 0 && Math.Abs(coordinate1.Col - coordinate2.Col) == 1))
        return true;
    return false;
}

public struct Coordinate
{
    public int Row { get; init; }
    public int Col { get; init; }

    public Coordinate()
    {
        Row = 0;
        Col = 0;
    }

    public Coordinate(int row, int col)
    {
        Row = row;
        Col= col;
    }
}

