using System;

namespace AbstractExample.Models
{
    public class Show : Media
    {
        public int Episode { get; set; }
        public int Season { get; set; }
        public string[] Writers { get; set; }

        public override string Display()
        {
            throw new NotImplementedException();
        }
    }
}
