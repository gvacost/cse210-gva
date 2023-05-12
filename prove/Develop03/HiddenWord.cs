using System;

class HiddenWord
{
    private string neword;
    private bool _hide;

    public HiddenWord(string _hword)
    {
        neword = _hword;
    }

    public bool HideWord()
    {
       return _hide;   

    }
    public void SetHideWord( bool hide)
    {
        _hide = hide;
    }
    public string GetWord()
    {
        return neword;
    }
}