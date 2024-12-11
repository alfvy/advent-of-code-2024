using System;

public class Day1
{
    private string _inputFile = "Days\\Day1\\input.txt";
    private List<int> _list1;
    private List<int> _list2;

    public Day1()
    {
        _list1 = new();
        _list2 = new();
        GetInput();
        FirstTask();
        SecondTask();
    }

    public void GetInput()
    {
        var dir = Directory.GetCurrentDirectory();
        var inputDir = $"{dir}\\{_inputFile}";
        var fileRead = File.ReadAllText(inputDir).Split("\n").ToList();
        foreach(var line in fileRead)
        {
            var splt = line.Split(" ");
            _list1.Add(int.Parse(splt[0]));
            _list2.Add(int.Parse(splt[3]));
        }
    }

    public void FirstTask()
    {
        _list1.Sort();
        _list2.Sort();
        Int64 sum = 0;
        for(int i = 0; i < _list1.Count;i++)
        {
            sum += Math.Abs(_list1[i] - _list2[i]);
        }
        System.Console.WriteLine($"The Accumelative Difference between the two lists is {sum}");
    }
    
    public void SecondTask()
    {
        Int64 sum = 0;
        for(int i = 0; i < _list1.Count;i++)
        {
            var count = _list2.Count(e => e == _list1[i]);
            sum += _list1[i] * count;
        }
        System.Console.WriteLine($"The Similarity Score Is {sum}");
    }
}