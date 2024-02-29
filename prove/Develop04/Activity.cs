using System;

public class Activity {
    private string _activity;
    private string _description;
    private int _duration;

    public Activity () {

    }
    public Activity (string activity, string description, int duration) {
        _activity = activity;
        _description = description;
        _duration = duration;
    }
    public string GetDescription() {
        return _description;
    }

}