namespace WorkflowCrud.Services
{
    public interface ICrudService
    { 
        bool UpdateWatchList(bool status);

        bool RemovalWatchList(bool status);

        bool RemovalCompleted(bool status); 
    }
}