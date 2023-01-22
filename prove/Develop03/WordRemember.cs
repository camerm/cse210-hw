public class WordRemember
{
    private Scripture _sentence;
    private List<string> _sentenceTextList;

    public WordRemember( Scripture sentence)
    {
        _sentence = sentence;
        _sentenceTextList = new List<string>();
        convertTextToList();

    }
    private void convertTextToList()
    {
        _sentenceTextList = _sentence.getScripture().Split(' ').ToList();
    }
    public void removeWordsFromText()
    {
        int numbWordsToRemove = new Random().Next(2, 4);
        int wordsRemoved = 0;

        do
        {
            int rndIndex= new Random().Next(0, _sentenceTextList.Count());

            if (_sentenceTextList[rndIndex].Contains('_') == false)
            {
                _sentenceTextList[rndIndex] = new string('_', _sentenceTextList[rndIndex].Count());
                wordsRemoved++;
            }

        }while (wordsRemoved != numbWordsToRemove);
    }
    public string getWordRemember()
    {
        return string.Join(' ', _sentenceTextList);
    }
    public bool hasWordsLeft()
    {
        bool retvalue =false;

        foreach (string word in _sentenceTextList)
        {
            if(word.Contains('_') == false)
            {
                retvalue = true;
                break;
            }
        }

        return retvalue;
    }

}