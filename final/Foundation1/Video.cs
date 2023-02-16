using System;

class Video
{

    private string _tittle;
    private string _author;
    private int _duration;
    private List<Comment> _comments;

    public Video (string tittle, string author, int duration)
    {
        _tittle = tittle;
        _author = author;
        _duration = duration;
        _comments = new List<Comment>();
    }

    public string setTittle()
    {
        return _tittle;
    }
    public string setAuthor()
    {
        return _author;
    }
    public int setDuration()
    {
        return _duration;
    }
    public List<Comment> getComment()
    {
        return _comments;
    }
    public void addComment(Comment comment)
    {
        _comments.Add(comment);
    }
    public int numberOfComments()
    {
        return _comments.Count();
    }

}