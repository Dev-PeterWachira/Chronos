namespace Core
{
    public interface IJob
     {
         string JobName {get; set;}

         bool IsComplete{get;set;} 

         Guid Id {get; set;} 

        void Execute();



    }  
}