namespace IteratorsAndComparators
{
    using System.Collections.Generic;

    public class Book
    {
        private string title;
        private int year;
        private List<string> authors;

        public Book(string title, int year, params string[] authors)
        {
            this.Title = title;
            this.Year = year;
            this.authors = new List<string>(authors);
        }

        public string Title
        {
            get { return this.title; }
            private set { this.title = value; }
        }

        public int Year
        {
            get { return this.year; }
            private set { this.year = value; }
        }

        public IReadOnlyList<string> Authors
        {
            get { return this.authors; }
        }
    }
}
