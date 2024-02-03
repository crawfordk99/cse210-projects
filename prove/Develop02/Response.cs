using System;
using System.IO;

public class Response 
{
    public DateTime _entryDate;
    public string _prompt;
    public string _input;

    public Response() {

    }

    public Response(DateTime _entryDate1, string _prompt1, string _input1) {
        _entryDate = _entryDate1;
        _prompt = _prompt1;
        _input = _input1;
    }

    public void StoreInputToFile(string fileName) {
        Console.WriteLine($"{_entryDate}|{_prompt}|{_input}");
        using (StreamWriter writeToFile= new StreamWriter(fileName)) {
            writeToFile.WriteLine($"{_entryDate.ToShortDateString()}|{_prompt}|{_input}\n");
        }
    }
}