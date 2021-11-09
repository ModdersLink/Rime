using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RimeLib.Serialization
{
    public class ArrayTable
    {
        public class ArrayEntry
        {
            /// <summary>
            /// Partition Instance ID for this array
            /// </summary>
            public Guid InstanceId { get; set; } = Guid.Empty;

            /// <summary>
            /// Base type <T>
            /// </summary>
            public string BaseType { get; set; } = string.Empty;

            /// <summary>
            /// List of items in this array
            /// </summary>
            public List<dynamic> Items { get; set; } = new List<dynamic>();
        }

        // Total entries in the Partition
        public List<ArrayEntry> Entries { get; set; } = new List<ArrayEntry>();

        public bool AddArray(dynamic p_Object)
        {
            if (p_Object is null)
                return false;

            // Get the base type of the object
            var s_BaseType = p_Object.GetType();

            // Get the type name
            var s_BaseTypeName = s_BaseType.Name;

            // See if there exists an array entry already with this type to add to
            var s_Entry = Entries.FirstOrDefault(p_Entry => p_Entry.BaseType == s_BaseTypeName);
            if (s_Entry is null)
            {
                // Create a new array entry
                s_Entry = new ArrayEntry
                {
                    BaseType = s_BaseTypeName
                };

                // Add our object to this type list
                s_Entry.Items.Add(p_Object);

                Entries.Add(s_Entry);
            }
            else
            {
                s_Entry.Items.Add(p_Object);
            }

            return true;
        }
    }
}
