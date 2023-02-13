namespace Infrastructure.Model;

using System;
using System.Reflection.Metadata;

public class Post
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public DateTime CreationTime { get; set; }

    public Post(string title, string content, DateTime creationTime) => (Title, Content, CreationTime) = (title, content, creationTime);
}
