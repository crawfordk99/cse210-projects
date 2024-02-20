using System;

public class MathAssignment : Assignment {
    private string _textbookSections;
    private string _problems;

    public MathAssignment(string studentName, string topic, string textbookSections, string problems) : base(studentName, topic) {
        _textbookSections = textbookSections;
        _problems = problems;
        
    }
    public string GetHomeworkList() {
        return base.GetSummary() + "\n" + _textbookSections + " " + _problems;
    }
}