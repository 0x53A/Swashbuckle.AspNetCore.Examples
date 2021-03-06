﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.Examples;
using System;

namespace Swashbuckle.AspNetCore.SwaggerGen.Test
{
    public class FakeControllers
    {
        public class NotAnnotated
        {}

        public class TestController
        {}

        [Authorize]
        public class AuthController
        {
            [AllowAnonymous]
            public IActionResult AllowAnonymous()
            {
                throw new NotImplementedException();
            }

            public IActionResult None()
            {
                throw new NotImplementedException();
            }
        }

        [SwaggerResponse(200, type: typeof(PersonResponse))]
        [SwaggerResponseExample(200, typeof(PersonResponseExample))]
        public class SwaggerResponseExampleController
        {
            public IActionResult None()
            {
                throw new NotImplementedException();
            }
        }
    }
}