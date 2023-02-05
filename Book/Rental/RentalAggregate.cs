using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Edument.CQRS;
using Events.Rental;
using System.Collections;

namespace Book.Something
{
    public class RentalAggregate : Aggregate,
        IHandleCommand<MarkBookRented>,
        IApplyEvent<BookRented>
    {
        private bool bookRented;

        public IEnumerable Handle(MarkBookRented c)
        {
            if (bookRented)
                throw new Rental.BookRented();

            yield return new BookRented
            {
                Id = c.Id,
                BookId = c.BookId
            };
        }

        public void Apply(BookRented e)
        {
            bookRented = true;
        }
    }
}
