using System;

class Reference
{

    private string _book, _chapter, _verse, _versend;
    public Reference(string book, string chapter, string verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _versend = "";
    }

    public Reference (string book, string chapter, string verse, string versend)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _versend = versend;
    }

    public string GetReference()
    {
        if (_versend == "")     // Esto quiere decir que estoy en el caso de un solo versiculo
        {
            return ($"{_book} {_chapter}:{_verse}");
        }
       else
       {
            return ($"{_book} {_chapter}:{_verse}-{_versend}");
       }
    }
}