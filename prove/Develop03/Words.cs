using System.Collections.Generic;
using System.IO;
public class Words{
  
    private string _text;
    public bool _hidden;
    public int Index;
    
    public Words(string text, int index)
    {
       _text = text;
       Index = index;
      _hidden = false;
   
    }

    public void Hide()
    {
      _hidden = true;
    }
    public override string ToString()
    {
      return _text;
        
    }
}