using System;
using System.Collections.Generic;
using System.Linq;

namespace FBCC.Containers
{
    class ContainerNamespace
    {
        public List<string> Components { get; private set; } 

        public ContainerNamespace(string p_Namespace)
        {
            Components = p_Namespace.Split(new[] { "::" }, StringSplitOptions.RemoveEmptyEntries).ToList();
        }

        public override string ToString()
        {
            return string.Join("::", Components);
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }

        public override bool Equals(object p_Other)
        {
            return ToString() == p_Other.ToString();
        }
    }
}
