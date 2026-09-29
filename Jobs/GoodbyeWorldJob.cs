using Core;
public class GoodbyeWorldJob : IJob
{
    public string JobName {get; set;}

    public bool IsComplete {get; set;}

    public Guid Id {get; set;}

    public void Execute()
    {
        Console.WriteLine("Goodbye World!");
    }
}
