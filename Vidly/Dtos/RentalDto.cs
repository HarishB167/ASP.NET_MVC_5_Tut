using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Dtos
{
    public class RentalDto
    {
        public string Customer { get; set; }
        public IEnumerable<string> Movies { get; set; }
    }
}