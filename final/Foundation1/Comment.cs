using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

public class  Comment
{
    public string _namePerson;
    public string _textComment;
    
    
   public Comment(string namePerson , string textComment)
   {
     _namePerson = namePerson;
     _textComment = textComment;
   }
  
     public void DisplayComments()
     {
      Console.WriteLine($"#{_namePerson}:{_textComment}");
     }
}