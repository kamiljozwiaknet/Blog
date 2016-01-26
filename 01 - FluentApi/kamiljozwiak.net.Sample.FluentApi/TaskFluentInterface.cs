using System;
using System.Data;

namespace kamiljozwiak.net.Sample.FluentApi
{
    internal class TaskFluentInterface
    {
        private readonly Task _task;

        public TaskFluentInterface(Task task)
        {
            _task = task;
        }

        public TaskFluentInterface Subject(string subject)
        {
            _task.Subject = subject;
            return this;
        }

        public TaskFluentInterface Start(DateTime startDateTime)
        {
            _task.StartDateTime = startDateTime;
            return this;
        }

        public TaskFluentInterface StartNow()
        {
            _task.StartDateTime = DateTime.Now;
            return this;
        }

        public TaskFluentInterface DurationInMinuts(int duration)
        {
            _task.Duration = new TimeSpan(0,duration,0);
            return this;
        }

        public TaskFluentInterface Description(string description)
        {
            _task.Description = description;
            return this;
        }

        public TaskFluentInterface Comment(string body, DateTime creationDataTime)
        {
            _task.Comments.Add(new Comment {Body = body, CreationDateTime = creationDataTime});
            return this;
        }

        public TaskFluentInterface Comment(string body)
        {
            _task.Comments.Add(new Comment {Body = body, CreationDateTime = _task.StartDateTime});
            return this;
        }
    }
}