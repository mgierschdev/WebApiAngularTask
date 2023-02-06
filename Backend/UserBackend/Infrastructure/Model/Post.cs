namespace Infrastructure.Model;

using System;
using System.Reflection.Metadata;

public class Post
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public DateTime CreationTime { get; set; }
}
