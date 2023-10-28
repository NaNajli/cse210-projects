using System.Collections.Generic;
using System.Data;
using System.IO;
public class Reference
{
    private string _book;
    private string _chapter;
   
    public Reference(string book , string chapter)
    {
      _book = book;
      _chapter = chapter;

    } 
    public string GetReference()
    {
       return $"{_book}:{_chapter}";
    }
};
