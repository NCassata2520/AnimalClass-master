using System;

namespace AbstractExample.Models
{
    public class Movie : Media
    {
        public string[] Genres { get; set; }

        public override string Display()
        {
            throw new NotImplementedException();
        }
    }
}
