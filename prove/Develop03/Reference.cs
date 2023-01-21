using System;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }
    
    public string getReference()
    {
        //return the format of the passage
        return $"{_book} {_chapter}:{_verse}";
        //return string.Format("{0} {1}:{2}", _book, _chapter, _verse);
    }

}