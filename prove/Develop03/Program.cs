using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!\n");

        var refer = new Reference("Mark", 12, 42);
        string text = "And there came a certain poor widow, and she threw in two mites, which make a farthing.";
        var script = new Scripture(refer, text);
        script.DisplayScripture();
        string input = "";
        Console.WriteLine("\nPress Enter to hide three words, or type G to give up.");
        input = Console.ReadLine();
        while(input == "") {
            for (int i = 0; i < 3; i++) {
                if (script.check == false) {
                    script.HideWords();
                }
                else {
                    break;
                }
            }
            script.DisplayScripture();
            if (script.check == false) {
                Console.WriteLine("\nPress Enter to hide three more words, or type G to give up.");
                input = Console.ReadLine();
            }
            else {
                Console.WriteLine("\nText has been fully hidden.\n");
                break;
            }
        }
        Console.WriteLine("\nPress enter to reveal scripture.\n");
        Console.ReadLine();
        script.RevealWords();
        script.DisplayScripture();
    }
    
}

class Scripture {
    private string[] _splitText;
    private List<Word> _words = new List<Word>();
    private Reference _reference;
    private Random randomGen = new Random();
    private int random = 0;
    private List<int> temp = new List<int>();
    public bool check;

    public Scripture(Reference reference, string text) {
        _splitText = text.Split(" ");
        foreach (string groupOfLetters in _splitText) {
            Word word = new Word(groupOfLetters);
            _words.Add(word);
        }
        _reference = reference;
    }

    public void DisplayScripture() {
        Console.WriteLine(_reference.reference);
        foreach(Word word in _words) {
            Console.Write($"{word.GetText()}"+" ");
        }
        Console.WriteLine();
    }

    public void HideWords() {
        random = 0;
        random = randomGen.Next(0, _words.Count() - 1);
        while ((_words[random].GetText()).Substring(0,1) == "_") {
            if (random == _words.Count() - 1) {
                random = 0;
            }
            else {
                random += 1;
            }
        }
        _words[random].Hide();  
        foreach(Word word in _words) {
            if (word.GetText().Substring(0,1) == "_") {
                check = true;
            }
            else{
                check = false;
                break;
            }
        }
    }

    public void RevealWords() {
        foreach (Word word in _words) {
            word.unHide();
        }
    }
}



class Reference {
    private string _book;
    private int _chapter;
    private int _verse;
    private int _verse2;
    public string reference;

    public Reference(string book, int chapter, int verse) {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        reference = ($"{_book} {_chapter}: {_verse}");
    }

    public Reference(string book, int chapter, int verse, int verse2) {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _verse2 = verse2;
        reference = ($"{_book} {_chapter}: {_verse}-{_verse2}");
    }
}

class Word {
    private string _letters;
    private bool _isHidden;

    public Word(string letters) {
        _letters = letters;
        _isHidden = false;
    }

    public void Hide() {
        _isHidden = true;
    }
    public void unHide() {
        _isHidden = false;
    }
    public string GetText() {
        if (_isHidden) {
            string underscores = "";
            int numLetters = _letters.Length;
            for (int i = 0; i < numLetters; i++) {
                underscores += "_";
            }
            return underscores;
        }
        else {
            return _letters;
        }
    }
}