using System;
using System.Collections.Generic;

namespace kamiljozwiak.net.Sample.FluentApi
{
    internal class Task
    {
        private readonly TaskFluentInterface _set;

        public Task()
        {
            Comments = new List<Comment>();
            _set = new TaskFluentInterface(this);
        }

        public string Subject { get; set; }
        public DateTime StartDateTime { get; set; }
        public TimeSpan Duration { get; set; }
        public string Description { get; set; }
        public ICollection<Comment> Comments { get; set; }

        public TaskFluentInterface Set
        {
            get { return _set; }
        }
    }
}