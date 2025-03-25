using System;

class Program
{
    
    static void Main(string[] args)
    {
        List<Video> _videos = new List<Video>();

        Video bugs = new Video("James","Fun with Bugs", 344);
        bugs.addComment(new Comment("Tilly","Great video"));
        bugs.addComment(new Comment("Tabby","Do another one about beatles"));
        bugs.addComment(new Comment("Ratchel","I had a pet bug once"));
        _videos.Add(bugs);

        Video cars = new Video("Billy Bob", "I have a car", 232);
        cars.addComment(new Comment("SamTheMan","I have a car too!!!"));
        cars.addComment(new Comment("Burgman","You can use duct tape to hold that door on"));
        cars.addComment(new Comment("PapaJo","You should paint your car red."));
        cars.addComment(new Comment("PapaJo","No, you should paint it purple."));
        _videos.Add(cars);

        Video turtles = new Video("Timmy", "Checkout this turtle!", 655);
        turtles.addComment(new Comment("Shmertal","Neat turtle"));
        turtles.addComment(new Comment("Kilburn","I had a turtle once"));
        turtles.addComment(new Comment("Globster","Why do turtles have shells?"));
        _videos.Add(turtles);

        Console.Clear();
        foreach (Video video in _videos)
        {
            video.display();
        }
    }
}