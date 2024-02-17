using System;

public class Reference {
    private string _book= "John";
    private string _chapter= "3";
    private string _verse= "16";
    private string _endingVerse = "";

    
    public void SetBook(string book) {
        _book = book;
    }
    public string GetBook() {
        return _book;
    }
    public void SetChapter(string chapter) {
        _chapter = chapter;
    }
    public string GetChapter() {
        return _chapter;
    }
    public void SetVerse(string verse) {
        _verse = verse;
    }
    public string GetVerse() {
        return _verse;
    }
    public void SetEndingVerse(string endingVerse) {
        _endingVerse = endingVerse;
    }
    public string GetEndingVerse() {
        return _endingVerse;
    }   

    public string GetReference() {
        string _reference = "";
        
        _reference = ($"{GetBook()} {GetChapter()}:{GetVerse()}");
        
        
        return _reference;
        
    }
    
}