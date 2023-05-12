using RimeLib.Ant.EA.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RimeLib.Ant.EA.Types
{
    public abstract class AntObject
    {



        public AntGuid InstanceId { get; set; } = new();

        public string Name { get; set; } = string.Empty;


        public bool ContainsHash(uint p_Hash)
        {

            Type? s_IteratorType = this.GetType();

            while (s_IteratorType != null && 
                   s_IteratorType != typeof(AntObject))
            {
                var s_Type = s_IteratorType;

                s_IteratorType = s_IteratorType.BaseType;

                var s_BindingAttribute = s_Type.GetCustomAttribute<AntBindingAttribute>()!;

                if (s_BindingAttribute.Hash == p_Hash)
                    return true;

            }

            return false;
            
        }
    }
}
