using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Dynamic;

public class Video
{
 public string  _playTitle;
 public string _author;
 public int _length; 
 public List <Comment>_comments = new List<Comment>();
 
 public Video()
 {}
   public void NumberOfComments()
    {
      int ncomments = _comments.Count();
      Console.WriteLine($"The number of commens is: {ncomments}");
      return; 
   }         
    

 public void GetCommentRepresentation()
 {
   Console.WriteLine($"Song title:{_playTitle} by Author: {_author}Duration ({_length} second)");
 }

 public void Display()
 {
   foreach(Comment comment in _comments)
   {
      comment.DisplayComments();
   }
 }
}