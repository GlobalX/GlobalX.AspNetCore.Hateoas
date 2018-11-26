﻿using Microsoft.Extensions.Options;

namespace GlobalX.AspNetCore.Hateoas.JsonApi
{
    public class JsonApiOptionsSetup : ConfigureOptions<JsonApiOptions>
    {
        public JsonApiOptionsSetup()
            : base(ConfigureSiren)
        {
        }

        public static void ConfigureSiren(JsonApiOptions options)
        {
        }
    }
}