using System;

namespace WorkflowCrud.Services
{
    public class CrudServiceNonStatic : ICrudService
    {
        public bool UpdateWatchList(bool status)
        {
            Console.WriteLine("UpdateWatchList");
            return true;
        }

        public bool RemovalWatchList(bool status)
        {
            Console.WriteLine("RemovalWatchList");
            return true;
        }

        public bool RemovalCompleted(bool status)
        {
            Console.WriteLine("RemovalCompleted");
            return true;
        }
    } 
}