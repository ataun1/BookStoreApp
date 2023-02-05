using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Book.Something;
using Edument.CQRS;
using Events.Rental;
using Book.Rental;

namespace BookTests
{
    [TestFixture]
    public class RentalTests : BDDTest<RentalAggregate>
    {
        private Guid testId;
        private string testBookId;

        [SetUp]
        public void Setup()
        {
            testId = Guid.NewGuid();
            testBookId = "1";
        }

        [Test]
        public void SomethingCanHappenOnlyOnce()
        {
            Test(
                Given(new Events.Rental.BookRented
                {
                    Id = testId,
                    BookId = "Boom!"
                }),
                When(new MarkBookRented
                {
                    Id = testId,
                    BookId = "Boom!"
                }),
                ThenFailWith<Book.Rental.BookRented>());
        }
    }
}
