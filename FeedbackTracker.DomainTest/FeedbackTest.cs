using FeedbackTracker.Domain;
using FeedbackTracker.Domain.Model;
using FeedbackTracker.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FeedbackTracker.DomainTest
{
    public class FeedbackTest
    {
        [Fact]
        public void CanCreateFeedback()
        {
            Feedback feedback = Feedback.builder()
                .Text("xxx")
                .Subject(Subject.of("1"))
                .build();
            Assert.NotNull(feedback);
        }

        [Fact]
        public void ValidProperties() {
            DateTime date = DateTime.Now;
            Feedback feedback = Feedback.builder()
                .Id(1)
                .Date(date)
                .Text("xxx")
                .Subject(Subject.of("1"))
                .build();
            Assert.Equal(1, feedback.Id);
            Assert.Equal("xxx", feedback.Text);
            Assert.Equal(date, feedback.Date);
            Assert.NotNull(feedback.Subject);
        }

        [Fact]
        public void givenFeedbackHasNoTextThenThrowAnException()
        {
            Feedback.Builder feedback = Feedback.builder();
            Assert.Throws<DomainException>(() => feedback.build());
        }

        [Fact]
        public void givenFeedBackHAsNoSubjectThenThrowAnException()
        {
            Feedback.Builder feedback = Feedback.builder()
                .Id(1)
                .Text("xxx");
            Assert.Throws<DomainException>(() => feedback.build());
        }
    }
}
