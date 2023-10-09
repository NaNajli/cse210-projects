using System.Collections.Generic;
using System.IO;

public class Journal{
    public List<Entry>entries = new List<Entry>();
    public string _loadFile;

    public void AddEntry(Entry entry)
     {
        entries.Add(entry);
     }
    public void Display() 
    {
        foreach (Entry entry in entries)
        {
            System.Console.WriteLine(entry.ToString());
        }
    }
	public void SaveFile() 

    {   string filename = "journalFile.txt";

        using (StreamWriter outPutfile = new StreamWriter(filename))
        {
            foreach (Entry entry in entries)
            {
            outPutfile.WriteLine($"{entry.Prompt} : {entry.Answer}  {entry.Date}.");
             }
        }
    }

	public void LoadFile(string filename) 
    {
      _loadFile = System.IO.File.ReadAllText(filename);
      Console.WriteLine(_loadFile);
    
    }

}