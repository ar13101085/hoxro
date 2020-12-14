using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hoxro.Models
{
    public class DefaultPayloadModel<T>
    {
        public bool Status { get; set; }
        public string Message { get; set; }
        public T Result { get; set; }
    }
}
