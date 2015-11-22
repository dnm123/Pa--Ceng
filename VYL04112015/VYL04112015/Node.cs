using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VYL04112015
{
    class Node<T>
    {
        T value;
        Node<T> next;

        public T Value
        {
            get
            {
                return value;
            }

            set
            {
                this.value = value;
            }
        }

        internal Node<T> Next
        {
            get
            {
                return next;
            }

            set
            {
                next = value;
            }
        }

        public Node(T val)
        {
            Value = val;
            Next = null;
        }
    }
}
