using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp14
{
    class Array
    {

        public class Field
        {
            public string Name { get; set; }
        }

        public class Field<T> : Field
        {
            public T Value { get; set; }
        }



    }
}
