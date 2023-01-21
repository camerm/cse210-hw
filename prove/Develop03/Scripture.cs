public class Scripture 
{
    
  
    private string _scripture;

    public Scripture(string scripture)
    {
        _scripture = scripture;
    }
    public string getScripture()
    {
        return $"{_scripture}";
        //return string.Format("{0} {1}:{2}", _book, _chapter, _verse);
    }

}