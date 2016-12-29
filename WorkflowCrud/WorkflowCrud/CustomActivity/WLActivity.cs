using System;
using System.Activities;
using System.Activities.Tracking;
using System.Collections.Generic;
using WorkflowCrud.Models;

namespace WorkflowCrud.CustomActivity
{

    public sealed class WLActivity : CodeActivity
    {
        // Define an activity input argument of type string
        public InArgument<string> Text { get; set; }

        // If your activity returns a value, derive from CodeActivity<TResult>
        // and return the value from the Execute method.
        protected override void Execute(CodeActivityContext context)
        {
            // Obtain the runtime value of the Text input argument
            string text = context.GetValue(this.Text);
            Console.WriteLine("Hello World!");
            RecordCustomTracking(context);
        }

        private void RecordCustomTracking(CodeActivityContext context)
        {
            CustomTrackingRecord record = new CustomTrackingRecord("MyRecord");
            record.Data.Add(new KeyValuePair<String, Object>("ExecutionTime", new WatchList
            {
                ActivityStatus = Status.InProcess.ToString(),
                WlPlacement = "On"
            }));
            context.Track(record);  
        }
    }
}
