
using Core;

public class JobScheduler
{
    public void Run(IJob job)
    {
        job.Execute();
        
    }
}