using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Dynamic;
using System.Collections.Generic;

public class Video
{
 public string  _playTitle;
 public string _author;
 public int _length; 
 public List <Comment>_comments = new List<Comment>();
 public List <Video>_video = new List<Video>();

 public int _totalcomment;
 
 public Video()
 {

 }
public void NumberOfComments()
 {
   int ncomments = _comments.Count();
   _totalcomment += ncomments;
   Console.WriteLine($"The number of commens is: {ncomments}");
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

