using RimeLib.Frostbite.Containers;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace RimeLib.Serialization.Ebx
{
    public class FrostbitePartition
    {
        public GUID PartitionGuid { get; set; }

        public List<DataContainer> Instances { get; set; }

        public GUID PrimaryInstanceGuid { get; private set; }
        public DataContainer? PrimaryInstance { get; protected set; }

        public string Name { get; set; }

        public FrostbitePartition()
        {
            PartitionGuid = new GUID(Guid.NewGuid());
            Instances = new List<DataContainer>();
            PrimaryInstanceGuid = GUID.Empty;
            PrimaryInstance = null;
            Name = "";
        }

        public void AddInstance(DataContainer p_Container, bool p_Primary = false)
        {
            if (p_Container == null)
                return;

            // Generate GUIDs for newly introduced instances.
            // TODO: Do we need to do this here?
            // TODO: Do we need to iterate through all instance to make sure the GUID is unique, or is that just me being super paranoid?
            if (p_Container.InstanceGuid == Guid.Empty)
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
                        Name = s_DynamicInstance?.Name ?? string.Empty;
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

        public DataContainer? LookupContainer(GUID p_Guid)
        {
            return Instances.FirstOrDefault(p_Instance => p_Instance.InstanceGuid == p_Guid);
        }

        public byte[] Serialize()
        {
            throw new NotImplementedException();
        }

        public uint GetImportCount(bool p_TotalImportCount = false, bool p_Recursive = true)
        {
            uint s_ImportCount = 0;

            PropertyInfo[]? s_Properties;

            if (p_Recursive)
                s_Properties = GetType().GetProperties();
            else
                s_Properties = GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);

            foreach (var s_Property in s_Properties)
            {
                // Check to see if this property is browsable or not
                var s_Browsable = (BrowsableAttribute[])s_Property.GetCustomAttributes(typeof(BrowsableAttribute), false);

                var s_NotBrowsable = s_Browsable.Any(p_Attr => !p_Attr.Browsable);

                if (s_NotBrowsable)
                    continue;

                // Check to ensure that this property has a ContainerField attribute
                var s_FieldAttributes = s_Property.GetCustomAttribute<ContainerFieldAttribute>();
                if (s_FieldAttributes == null)
                    continue;

                if (!typeof(CtrRefBase).IsAssignableFrom(s_Property.PropertyType))
                    continue;

                var s_Value = s_Property.GetValue(this);
                if (s_Value == null)
                    continue;

                var s_CtrRef = (CtrRefBase)s_Value;

                if (p_TotalImportCount)
                    s_ImportCount++;
                else if (s_CtrRef.PartitionGuid != GUID.Empty && s_CtrRef.InstanceGuid != GUID.Empty && s_CtrRef.PartitionGuid != PartitionGuid)
                    s_ImportCount++;
            }

            return s_ImportCount;
        }

        public uint GetInternalCount(bool p_TotalImportCount = false, bool p_Recursive = true)
        {
            uint s_InternalCount = 0;

            PropertyInfo[]? s_Properties;

            if (p_Recursive)
                s_Properties = GetType().GetProperties();
            else
                s_Properties = GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);

            foreach (var s_Property in s_Properties)
            {
                // Check to see if this property is browsable or not
                var s_Browsable = (BrowsableAttribute[])s_Property.GetCustomAttributes(typeof(BrowsableAttribute), false);

                var s_NotBrowsable = s_Browsable.Any(p_Attr => !p_Attr.Browsable);

                if (s_NotBrowsable)
                    continue;

                // Check to ensure that this property has a ContainerField attribute
                var s_FieldAttributes = s_Property.GetCustomAttribute<ContainerFieldAttribute>();
                if (s_FieldAttributes == null)
                    continue;

                if (!typeof(CtrRefBase).IsAssignableFrom(s_Property.PropertyType))
                    continue;

                var s_Value = s_Property.GetValue(this);
                if (s_Value == null)
                    continue;

                var s_CtrRef = (CtrRefBase)s_Value;

                if (p_TotalImportCount)
                    s_InternalCount++;
                else if (s_CtrRef.PartitionGuid != GUID.Empty && s_CtrRef.InstanceGuid != GUID.Empty && s_CtrRef.PartitionGuid == PartitionGuid)
                    s_InternalCount++;
            }

            return s_InternalCount;
        }
    }
}
