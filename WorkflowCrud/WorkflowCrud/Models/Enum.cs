namespace WorkflowCrud.Models
{
    enum Status
    {
        InProcess,
        AwaitingApproval,
        AwaitingERMApproval,
        Completed, Rejected, Cancelled
    }
}
