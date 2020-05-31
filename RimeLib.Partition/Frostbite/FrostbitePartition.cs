using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace RimeLib.Partition.Frostbite
{
    public class FrostbitePartition
    {
        public GUID PartitionGuid { get; set; }

        public List<DataContainer> Instances { get; set; }

        public GUID PrimaryInstanceGuid { get; private set; }
        public DataContainer PrimaryInstance { get; protected set; }

        public string Name { get; set; }

        public FrostbitePartition()
        {
            PartitionGuid = new GUID(Guid.NewGuid());
            Instances = new List<DataContainer>();
        }

        public void AddInstance(DataContainer p_Container, bool p_Primary = false)
        {
            if (p_Container == null)
                return;

            // Generate GUIDs for newly introduced instances.
            // TODO: Do we need to do this here?
            // TODO: Do we need to iterate through all instance to make sure the GUID is unique, or is that just me being super paranoid?
            if (p_Container.InstanceGuid == null)
                p_Container.InstanceGuid = Guid.NewGuid();

            p_Container.PartitionGuid = PartitionGuid;

            // Set the primary instance if this is it.
            if (p_Primary)
            {
                PrimaryInstanceGuid = p_Container.InstanceGuid;
                PrimaryInstance = p_Container;

                if (PrimaryInstance != null)
                {
                    dynamic s_DynamicInstance = PrimaryInstance;

                    try
                    {
                        Name = s_DynamicInstance.Name;
                    }
                    catch
                    {
                        // ignored
                    }
                }
            }

            // Add the instance to our list of instances.
            Instances.Add(p_Container);
        }

        public DataContainer LookupContainer(GUID p_Guid)
        {
            return Instances.FirstOrDefault(p_Instance => p_Instance.InstanceGuid == p_Guid);
        }

        public byte[] Serialize()
        {
            throw new NotImplementedException();
        }
    }

}
