using RimeLib.Animation.EA.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RimeLib.Animation.EA.Types
{
    public abstract class AntObject
    {



        public AntGuid InstanceId { get; set; } = new();

        public string ObjectName { get; set; } = string.Empty;


        public bool ContainsHash(uint p_Hash)
        {

            Type? s_IteratorType = this.GetType();

            while (s_IteratorType != null && 
                   s_IteratorType != typeof(AntObject))
            {
                var s_Type = s_IteratorType;

                s_IteratorType = s_IteratorType.BaseType;

                // A class can carry several bindings (retail + drifted-schema hashes, e.g. BF3 alpha).
                foreach (var s_BindingAttribute in s_Type.GetCustomAttributes<AntBindingAttribute>(false))
                    if (s_BindingAttribute.Hash == p_Hash)
                        return true;

            }

            return false;
            
        }
    }
}
