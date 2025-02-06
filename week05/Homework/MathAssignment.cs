using System;

public class MathAssignment : Assignment
{
    private float _section;
    private string _problems;

    public MathAssignment(string studentName, string topic, float section, string problems)
        : base(studentName, topic) 
    {
        _section = section;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Section {_section} Problems {_problems}";
    }
}