using Jobs;
using Core;



JobScheduler jobScheduler = new JobScheduler();

IJob job1 = new HelloWorldJob();
IJob job2 = new GoodbyeWorldJob();

jobScheduler.Run(job1);
jobScheduler.Run(job2);
