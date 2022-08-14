using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITalent_Collection
{
    public class Node<T>
    {
        public T data;
        public Node<T> nextNode;

        public override string ToString()
        {
            return data.ToString();
        }
    }
}
