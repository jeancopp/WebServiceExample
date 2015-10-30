using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebServiceExample.ModelBuilder
{
    interface Builder<T>
    {
        T build();
    }
}
