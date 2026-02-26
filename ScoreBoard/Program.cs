using System;
class ScoreBoard
{
    private string[] _names;
    private int[] _scores;
    private int _count;

    public ScoreBoard(int capacity)
    {
        _names = new string[capacity];
        _scores = new int[capacity];
        _count = 0;
    }

    public int Count => _count;

    public void Register(string name, int score)
    {
        if (_count < _names.Length)
        {
            _names[_count] = name;
            _scores[_count] = score;
            _count++;
        }
        else
        {
            Console.WriteLine("성적표가 가득 찼습니다.");
        }
    }

    public string this[int index]
    {
        get
        {
            if (index >= 0 && index < _count)
                return _names[index];
            return "";
        }
    }
    public int this[string name]
    {
        get
        {
            for (int i = 0; i < _count; i++)
            {
                if (_names[i] == name) return _scores[i];
            }
            return -1;
        }
        set
        {
            for (int i = 0; i < _count; i++)
            {
                if (_names[i] == name)
                {
                    _scores[i] = value;
                    return;
                }
            }
        }
    }
}
