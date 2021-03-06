﻿namespace GlobalX.AspNetCore.Hateoas.Siren.Core
{
    public class Entity
    {
        public Class Class { get; set; } = new Class();

        public object Properties { get; set; } = new object();

        public Entities Entities { get; set; } = new Entities();

        public Links Links { get; set; } = new Links();

        public Actions Actions { get; set; } = new Actions();

        public Rel Rel { get; set; } = new Rel();

        public Href Href { get; set; } = null;

        public override string ToString()
        {
            return Properties.ToString();
        }
    }
}