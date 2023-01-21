public class Scripture 
{
    
  
    private string _scripture;
    private Reference _scriptureReference;

    public Scripture(Reference scriptureReference, string scripture)
    {
        _scripture = scripture;
        _scriptureReference = scriptureReference;
    }
    public string getScripture()
    {
        return $"{_scripture}";
    }

}