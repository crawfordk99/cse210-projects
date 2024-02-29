using System;

public class Listing : Activity {
    private int _responseCounter;

    public Listing() {
        
    }

    public Listing(string activity, string description, int duration) : base(activity, description, duration) {

    }
    public List<Listing> _promptsList = new List<Listing>();

    public int GetResponseCounter() {
        return _responseCounter++;
    }
}