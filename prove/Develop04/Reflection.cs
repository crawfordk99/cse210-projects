using System;

public class Reflection : Activity {
    public List<Reflection> _prompts = new List<Reflection>();

    public List<Reflection> _reflections =new List<Reflection>();
    public Reflection() {}

    public Reflection(string activity, string description, int duration) : base(activity, description, duration) {

    }

}