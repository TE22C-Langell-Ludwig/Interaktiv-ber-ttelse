string text;
bool forre = false; 
bool utomhus = false;



Console.WriteLine("Du vaknar och du känner bara för att antingen köra fortnite eller gå utomhus");
Console.WriteLine("a.Fortnite och b,utomhus");
text = Console.ReadLine().ToLower();
if (text == "a" && utomhus == false)
{
    forre = true;
    Console.WriteLine("Du väljer att gibba lite forre och efter att du bootat upp forre och efter du landat så ser du någon");
    Console.WriteLine("a,loota upp och attackera eller b, gå iväg");
    text = Console.ReadLine().ToLower();
    if (text == "a")
    {
        Console.WriteLine("Han typ crankar 90s på dig och du dör 💀");
        Console.WriteLine("   ");
        Console.WriteLine("Bad Ending");
        Console.ReadLine();
    } else if (text == "b")
    {
        Console.WriteLine("Du går iväg och lyckas loota up och vinner tillslut matchen");
        Console.WriteLine("   ");
        Console.WriteLine("Good Ending?");
        Console.ReadLine();
    }

}
if (text == "b" && forre == false)
{
    utomhus = true;
    Console.WriteLine("Du väljer att gå utomhus och märker att gräset ser grönare ut och du ser en hund på trottoaren");
    Console.WriteLine("Vill du gå till a, Parken eller b, hiking plats");
    text = Console.ReadLine().ToLower();
    if (text == "a")
    {
        Console.WriteLine("Du går till parken och ser en hund som ser väldigt fin ut som du sätter dig ner och klappar");
        Console.WriteLine("   ");
        Console.WriteLine("Dog Ending");
        Console.ReadLine();
    }
    if (text == "b")
    {
        Console.WriteLine("Du väljer att gå till en hiking plats och gör en natur vandring i skogen och njuter av utsikten");
        Console.WriteLine("   ");
        Console.WriteLine("Nature Ending");
        Console.ReadLine();
    }
}