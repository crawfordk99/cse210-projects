using System;

public class Word {
    private string _word;
    private bool _isHidden;
    
    
    public Word() {

    }
    
    public Word(string word) {
        _word = word;
        _isHidden = false;
    }

    public void SetHiddenTrue(Word word) {
        if (word == new Word("___")) {
            _isHidden = true;
        }
    }
    

    public void PrintWords() {
        Console.Write($"{_word} ");
    }
   
    public bool IsHidden() {
        if (_isHidden == true) {
            return true;
        }
        return false;
    }
}