using System;

class Program
{

    static void Main(string[] args)
    {
        Video bugs = new Video("James","Fun with Bugs", 344);
        Video cars = new Video("Billy Bob", "I have a car", 232);
        Video turtles = new Video("Timmy", "Checkout this turtle!", 655);

        bugs.addComment(new Comment("Tilly","Great video"));
        bugs.addComment(new Comment("Tabby","Do another one about beatles"));
        bugs.addComment(new Comment("Ratchel","I had a pet bug once"));

        cars.addComment(new Comment("SamTheMan","I have a car too!!!"));
        cars.addComment(new Comment("Burgman","You can use duct tape to hold that door on"));
        cars.addComment(new Comment("PapaJo","You should paint your car red."));
        cars.addComment(new Comment("PapaJo","No, you should paint it purple."));

        turtles.addComment(new Comment("Shmertal","Neat turtle"));
        turtles.addComment(new Comment("Kilburn","I had a turtle once"));
        turtles.addComment(new Comment("Globster","Why do turtles have shells?"));

        Console.Clear();
        bugs.display();
        cars.display();
        turtles.display();
    }
}