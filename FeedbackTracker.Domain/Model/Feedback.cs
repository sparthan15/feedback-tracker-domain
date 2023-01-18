using FeedbackTracker.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FeedbackTracker.Domain.Model
{
    public sealed class Feedback
    {
        public int Id { get; }
        public string Text { get;  }
        public DateTime Date { get; }
        public Subject Subject { get; }

        private Feedback(Builder builder) {
            this.Id = builder.Id();
            this.Text = builder.Text();
            this.Date = builder.Date();
            this.Subject = builder.Subject();
        }

        public static Builder builder()
        {
            return new Builder();
        }

        public class Builder
        {
            private int _id;
            private string _text;
            private DateTime _date;
            private Subject _subject;

            public Builder Id(int id)
            {
                _id = id;
                return this;
            }

            public Builder Text(string text)
            {
                _text = text;  
                return this;
            }

            public Builder Date(DateTime date)
            {
                _date = date;
                return this;   
            }

            public Builder Subject(Subject subject)
            {
                _subject = subject;
                return this;
            }

          public int Id()
            {
                return _id;
            }

            public string? Text()
            {
                return _text;
            }

            public DateTime Date()
            {
                return _date;
            }

            public Subject Subject() {
                return _subject;

            }

            public Feedback build()
            {
                if (string.IsNullOrEmpty(_text))
                {
                    throw new DomainException("Text is mandatory");
                }
                if (_subject == null)
                {
                    throw new DomainException("Subject is mandatory");
                }
                   
                return new Feedback(this);
            }
        }        

    }
}
