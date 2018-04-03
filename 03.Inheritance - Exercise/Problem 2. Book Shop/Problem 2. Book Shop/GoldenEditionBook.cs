﻿namespace Problem_2.Book_Shop
{
    public class GoldenEditionBook : Book
    {
        public GoldenEditionBook(string author, string title, decimal price) : base(author, title, price)
        {
        }

        public override decimal Price
        {
            protected set { base.Price = value * 1.3m; }
        }
    }
}
