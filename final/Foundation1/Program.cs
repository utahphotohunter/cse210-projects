using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\n");
// ------------------------------------------------------------------------------------------
        Video puppyLove = new Video();
        Comment puppyLoveC1 = new Comment();
        Comment puppyLoveC2 = new Comment();
        Comment puppyLoveC3 = new Comment();

        puppyLove.SetAuthor("lovelySParKles23");
        puppyLove.SetTitle("Cute Puppy Loves Mommy");
        puppyLove.SetLength(120);

        puppyLoveC1.SetAuthor("DarkHorseman");
        puppyLoveC1.SetText("The cutest thing EVER!!!");
        puppyLoveC2.SetAuthor("spottedowl19");
        puppyLoveC2.SetText("I want that puppy in my life!");
        puppyLoveC3.SetAuthor("RainbowloVer98");
        puppyLoveC3.SetText("CGI");

        puppyLoveC1.MakeComment(puppyLoveC1.GetAuthor(), puppyLoveC1.GetText());
        puppyLoveC2.MakeComment(puppyLoveC2.GetAuthor(), puppyLoveC2.GetText());
        puppyLoveC3.MakeComment(puppyLoveC3.GetAuthor(), puppyLoveC3.GetText());

        puppyLove.AddComments(puppyLoveC1.GetComment());
        puppyLove.AddComments(puppyLoveC2.GetComment());
        puppyLove.AddComments(puppyLoveC3.GetComment());

        puppyLove.VideoSummary();
// ------------------------------------------------------------------------------------------
        Video superSonic = new Video();
        Comment superSonicC1 = new Comment();
        Comment superSonicC2 = new Comment();
        Comment superSonicC3 = new Comment();
        Comment superSonicC4 = new Comment();

        superSonic.SetAuthor("BasicPilot22");
        superSonic.SetLength(350);
        superSonic.SetTitle("F22 Goes Hypersonic For 1st Time!");

        superSonicC1.SetAuthor("NiceGuy19");
        superSonicC1.SetText("Awesome Video!!!!");
        superSonicC2.SetAuthor("lazygirl0");
        superSonicC2.SetText("meh");
        superSonicC3.SetAuthor("organizedchaos3");
        superSonicC3.SetText("DUDE IS THIS FOR REAL?????");
        superSonicC4.SetAuthor("CrazyIvansPizzaria");
        superSonicC4.SetText("Now delivering internationally in 10 minutes or less.");

        superSonicC1.MakeComment(superSonicC1.GetAuthor(), superSonicC1.GetText());
        superSonicC2.MakeComment(superSonicC2.GetAuthor(), superSonicC2.GetText());
        superSonicC3.MakeComment(superSonicC3.GetAuthor(), superSonicC3.GetText());
        superSonicC4.MakeComment(superSonicC4.GetAuthor(), superSonicC4.GetText());

        superSonic.AddComments(superSonicC1.GetComment());
        superSonic.AddComments(superSonicC2.GetComment());
        superSonic.AddComments(superSonicC3.GetComment());
        superSonic.AddComments(superSonicC4.GetComment());

        superSonic.VideoSummary();
// ------------------------------------------------------------------------------------------
        Video inkJetPrinter = new Video();
        Comment inkJetPrinterC1 = new Comment();
        Comment inkJetPrinterC2 = new Comment();
        Comment inkJetPrinterC3 = new Comment();

        inkJetPrinter.SetTitle("The Ink Jet 600 Features and Operations");
        inkJetPrinter.SetLength(3600);
        inkJetPrinter.SetAuthor("Ink Jet Printers Inc");

        inkJetPrinterC1.SetAuthor("Sublimation Printers Inc");
        inkJetPrinterC1.SetText("Still not as good as ours.");
        inkJetPrinterC2.SetAuthor("mike91");
        inkJetPrinterC2.SetText("Very informative or our staff.");
        inkJetPrinterC3.SetAuthor("lazygirl0");
        inkJetPrinterC3.SetText("I need one.");

        inkJetPrinterC1.MakeComment(inkJetPrinterC1.GetAuthor(), inkJetPrinterC1.GetText());
        inkJetPrinterC2.MakeComment(inkJetPrinterC2.GetAuthor(), inkJetPrinterC2.GetText());
        inkJetPrinterC3.MakeComment(inkJetPrinterC3.GetAuthor(), inkJetPrinterC3.GetText());

        inkJetPrinter.AddComments(inkJetPrinterC1.GetComment());
        inkJetPrinter.AddComments(inkJetPrinterC2.GetComment());
        inkJetPrinter.AddComments(inkJetPrinterC3.GetComment());

        inkJetPrinter.VideoSummary();
    }
}