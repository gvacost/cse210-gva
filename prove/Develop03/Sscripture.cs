using System; 

class Scriptures
{
    private List<HiddenWord> words;
    private Reference _scrReference;

    public Scriptures(Reference scrReference, string _scrip)
    {
        _scrReference = scrReference;
        words = new List<HiddenWord>();     //Necesito agregar esto acá porque sino me tira error ya que cuando creo la instance
        GetScriptures(_scrip);              //Me va a decir que no está "registrada" en el object (Scriptures en este caso)
    }

    public void GetScriptures(string _scrip)
    {
        // Here the scripture is splitted to a list. This list is a new list which was created in this method 
        // Is needed to be spliitte because in this way is possible select a random word to hide
        List<string> _scrsplit = _scrip.Split(' ').ToList(); 
        foreach (string word in _scrsplit)
        {
            // Here the class HiddenWord is created to be used in the List<HiddenWord>
            HiddenWord neword = new HiddenWord(word);
            words.Add(neword);
        }
        
    }

    public string GetHScripture()
    {
        string scrReference ="";
        foreach (HiddenWord neword in words)
        {
            if (neword.HideWord() == false)
            {
                scrReference += neword.GetWord() + " ";
            }
            else
            {
                scrReference += new string('_', neword.GetWord().Length) + " ";
            }

        }
    
        return ($"{_scrReference.GetReference()} {scrReference}");

    }

    public bool HasWordsLeft()
    {
        bool _retVal = false;

        foreach (HiddenWord neword in words)
        {
            if (neword.HideWord() == false)
            {
                _retVal = true;
            }
        }

        return _retVal;
    }

    public void Remove()
    {
        // Aca el instructor crea un random para remover determinadas palabras, yo quiero 
        // solo remover alguna random --> Como? 
                int numtorem = new Random().Next(1,3);
                int _wordsRemoved = 0;

                do 
                {
                    int _toremove = new Random().Next(0, words.Count());
                    
                    if  (words[_toremove].HideWord() == false)
                    {
                        words[_toremove].SetHideWord(true);
                        _wordsRemoved++;
                    }

                }while(_wordsRemoved != numtorem && HasWordsLeft() == true);
                
    }
}