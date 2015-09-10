﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpCommerce.Data.Customers
{
    using Newtonsoft.Json;

    internal class CustomersBundle
    {
        [JsonProperty("customers")]
        public IEnumerable<Customer> Content { get; set; }
    }
}
