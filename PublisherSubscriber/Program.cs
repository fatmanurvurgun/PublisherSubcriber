using System;

namespace PublisherSubscriber
{
    class Program
    {
        static void Main(string[] args)
        {
            Publisher bbc = new Publisher("bbc.com");
            Publisher ntv = new Publisher("ntv.com");

            Subscriber subscriber1 = new Subscriber("Fatmanur");
            Subscriber subscriber2 = new Subscriber("Enes");

            subscriber1.Subscribe(bbc);
            subscriber1.Subscribe(ntv);

            subscriber2.Subscribe(ntv);

            bbc.Publish();
            ntv.Publish();

        }
    }
}
