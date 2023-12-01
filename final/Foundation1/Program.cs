using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using System.Transactions;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Schema;


class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Foundation1 World!");
        
        List <Video>_video = new List<Video>();
      

        Video v1 = new Video();
        v1._playTitle = "What A Wonderful World";
        v1._author = "Jon Batiste";
        v1._length = 240;

        Comment c1 = new Comment("Lexander","The more I learn about who Jon Batiste really is, the more I love him");
        Comment c2 = new Comment("Ralph","This world so badly needs the loving soul of Job Batiste right now.");

        Video v2 = new Video();
        v2._playTitle ="Keeping Me Alive";
        v2._author = "Jonathan Roy";
        v2._length = 300;

        Comment c3 = new Comment("Simon","Wow,beautiful");
        Comment c4 = new Comment("Ariana","This song.. the lyrics , the voice. Wow !" );

        Video v3 = new Video();
        v3._playTitle = "What Was I Made For?";
        v3._author = "Billie Eilish";
        v3._length = 250;

        Comment c5 = new Comment("Sara","Can we talk about her perfect vocals on this");
        Comment c6 = new Comment("Peter"," How her voice can express the emotions soo well"); 

        Video v4 = new Video();
        v4._playTitle = "Let Me Love You";
        v4._author = "Teddy Swims";
        v4._length = 270;

        Comment c7 = new Comment("Louise","His voice is clearer than my future");
        Comment c8 = new Comment("Lemuel","Personally his voice is such a stress reliever.");
        Comment c9 = new Comment("Paula","Que voz maravilhosa!!");
        Comment c10 = new Comment("Mirei","Omg, you sound so amazing! This is the best version I've heard so far! ");
   
        v1._comments.Add(c1);
        v1._comments.Add(c2);
        v2._comments.Add(c3);
        v2._comments.Add(c4);
        v3._comments.Add(c5);
        v3._comments.Add(c6);
        v4._comments.Add(c7);
        v4._comments.Add(c8);
        v4._comments.Add(c9);
        v4._comments.Add(c10);
        
        
        _video.Add(v1);
        _video.Add(v2);
        _video.Add(v3);
        _video.Add(v4); 

          
        foreach (Video v in _video)
        {
           Console.WriteLine();
           v.GetCommentRepresentation();
           v.Display();
           v.NumberOfComments();  
        }
        //Console.WriteLine($"The total of comments are: {_totalcomment}");      
             
}};