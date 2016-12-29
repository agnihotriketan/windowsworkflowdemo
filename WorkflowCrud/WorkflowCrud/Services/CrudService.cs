using System;

namespace WorkflowCrud.Services
{
    public static class CrudService
    {
        public static string UpdateWatchList()
        {
            Console.WriteLine("UpdateWatchList");
            //todo call update service
            return "AwaitingApproval";
        }

        public static bool RemovalWatchList()
        {
            Console.WriteLine("RemovalWatchList");
            //todo call remove service
            return true;
        }

        public static bool RemovalCompleted()
        {
            Console.WriteLine("RemovalCompleted");
            //todo call remove complete
            return true;
        }
    }
}