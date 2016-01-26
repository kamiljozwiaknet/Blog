using System;

namespace kamiljozwiak.net.Sample.FluentApi
{
    internal class FluentApiMain
    {
        private static void Main(string[] args)
        {
            var normalTask = new Task();
            MakeNormal(normalTask);

            var fluentTask = new Task();
            MakeFluent(fluentTask);
        }

        public static void MakeNormal(Task task)
        {
            task.Subject = "Fluent Api";
            task.Description = "Write blog post about Fluent Api";
            task.StartDateTime = new DateTime(2016, 01, 25);
            task.Duration = new TimeSpan(1, 15, 0);

            var comment1 = new Comment();
            comment1.Body = "First Comment";
            comment1.CreationDateTime = DateTime.Now;
            task.Comments.Add(comment1);

            var comment2 = new Comment();
            comment2.Body = "First Comment";
            comment2.CreationDateTime = DateTime.Now;
            task.Comments.Add(comment2);
        }

        public static void MakeFluent(Task task)
        {
            task.Set
                .Subject("Fluent Api")
                .Description("Write blog post about Fluent Api")
                .StartNow()
                .DurationInMinuts(75)
                .Comment("First Comment")
                .Comment("First Comment");
        }
    }
}