using System;
using System.Collections.Generic;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return _comments.Count;
    }

    public string GetDisplayText()
    {
        string result = $"{_title} ({_author}) - {_length} seconds\n";
        result += $"Number of comments: {GetCommentCount()}\n";

        foreach (Comment comment in _comments)
        {
            result += comment.GetText() + "\n";
        }

        return result;
    }
}