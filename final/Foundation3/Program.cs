using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Foundation3 World!");
        Console.WriteLine("EVENTS:");
        
        Address address1 = new Address("Cordoba", "Road 23");
        Address address2 = new Address("California", "Stafford St");
        Address address3 = new Address("Ohio", "Rigby RD");
        
        Console.WriteLine();
        Lectures lectures = new Lectures("How to be hapier","The amazing Dr paul count is here to help...","Sept 20 6pm",34,address1,"Mels Robbinson", 30);
        lectures.GetStandardDetails();
        lectures.GetDetailLecture();
        Console.WriteLine();


        Receptions receptions = new Receptions("Wedding","Service.......","Oct 2", 9, address2 ,"confirmations@gmai.com");
        receptions.GetStandardDetails();
        receptions.GetDetailReceptions();
        Console.WriteLine();

        Outdoor outdoor = new Outdoor("Camping","Talk about how to light a campfire","Nov 30", 4 , address3, "Bright and sunny afternoon");
        outdoor.GetStandardDetails();
        outdoor.GetDetailOutdoor();
        Console.WriteLine();

        Console.WriteLine("Events"); 
        Console.Write("Lectures:");
        lectures.ShortDescription();
        Console.Write("Receptions:");
        receptions.ShortDescription();
        Console.Write("Outdoor:");
        outdoor.ShortDescription();
    }
}