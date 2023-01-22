using System;

class Program
{
    static void Main(string[] args)
    {

        Reference passage = new Reference("Isaiah", 1, 18);
        Scripture scripture = new Scripture(passage, "Come now, and let us areason together, saith the Lord: though your bsins be as scarlet, they shall be as cwhite as snow; though they be red like crimson, they shall be as wool.");
        WordRemember wordRemember = new WordRemember(scripture);

        String userImput = "";

        while (userImput != "quit" && wordRemember.hasWordsLeft() == true)
        {
            Console.Clear();
            //Call to the reference and scripture
            Console.WriteLine(string.Format("{0} {1}", passage.getReference(), wordRemember.getWordRemember()));
            //ReadLine method blocks until the user presses the Enter key.
            Console.ReadLine();
            //star to remove the words
            wordRemember.removeWordsFromText();

        }   
      
    }

}