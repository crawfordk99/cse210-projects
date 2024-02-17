using System;

public class Scripture {

    private string _scripture;
    Reference reference = new Reference();
    public Scripture() {}

    public Scripture(string book, string chapter, string verse) {
        reference.SetBook(book);
        reference.SetChapter(chapter);
        reference.SetVerse(verse);
    }

    public Scripture(string book, string chapter, string verse, string endingVerse) {
        reference.SetBook(book);
        reference.SetChapter(chapter);
        reference.SetVerse(verse);
        reference.SetEndingVerse(endingVerse);
    }

    public string GetScripture() {
         _scripture = reference.GetReference();
         return _scripture;
    }
    
}