﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasePage
{
    public class CustomerService
    {


        internal IResponse GetResponse(IRequest p)
        {
            return new DefaultResponse() { Message = "Hello Ganesh!" };
        }
    }
}
