﻿using System.Collections.Generic;

namespace GlobalX.AspNetCore.Hateoas.JsonApi.Core
{
    public class Included : List<Resource>
    {
        public Included()
        {
        }

        public Included(IEnumerable<Resource> collection)
            : base(collection)
        {
        }
    }
}