namespace AdventOfCode;

public class Day01 : BaseDay
{
    private readonly string _input;
    private int _hitCounter;
    private int _Counter = 50;

    public Day01()
    {
        _input = File.ReadAllText(InputFilePath);


    }

    public override ValueTask<string> Solve_1()
    {
        foreach (var line in _input.Split('\n'))
        {
            char dir = line[0];
            int amount = int.Parse(line.Substring(1));

            for (int i = 0; i < amount; i++)
            {
                if (dir == 'R')
                {
                    _Counter = (_Counter + 1) % 100;
                }
                else if (dir == 'L')
                {
                    _Counter = (_Counter - 1 + 100) % 100;
                }
            }
            if (_Counter == 0)
            {
                _hitCounter++;
            }
        }
        return new($"{_hitCounter}");
    }

    public override ValueTask<string> Solve_2()
    {
        _Counter = 50;
        _hitCounter = 0;
        foreach (var line in _input.Split('\n'))
        {
            char dir = line[0];
            int amount = int.Parse(line.Substring(1));

            for (int i = 0; i < amount; i++)
            {
                if (dir == 'R')
                {
                    _Counter = (_Counter + 1) % 100;
                }
                else if (dir == 'L')
                {
                    _Counter = (_Counter - 1 + 100) % 100;
                }
                if (_Counter == 0)
                {
                    _hitCounter++;
                }
            }
        }
        return new($"{_hitCounter}");
    }
}
