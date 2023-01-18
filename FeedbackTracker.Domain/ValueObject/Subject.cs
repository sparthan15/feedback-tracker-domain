using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedbackTracker.Domain.ValueObject
{
    public  class Subject
    {
        public int Id { get; }
        public string? Name { get; }

        public static Subject of(string subjectId)
        {
            return new Subject();
        }
    }
}
