﻿// ---------------------------------------------------------------
// Copyright (c) Hassan Habib & Alice Luo  All rights reserved.
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// ---------------------------------------------------------------

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RESTFulSense.Models
{
    public class MisdirectedRequestObjectResult : ObjectResult
    {
        public MisdirectedRequestObjectResult(object value) : base(value) =>
            StatusCode = StatusCodes.Status421MisdirectedRequest;
    }
}