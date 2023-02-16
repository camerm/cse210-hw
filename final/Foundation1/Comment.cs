using System;

class Comment
{

    private string _nameComment;
    private string _textComment;


    public Comment (string nameComment, string textComment)
    {
        _nameComment = nameComment;
        _textComment = textComment;
    }

    public void DisplayComment()
    {
        Console.WriteLine($"{_nameComment} - {_textComment}");
    }

}