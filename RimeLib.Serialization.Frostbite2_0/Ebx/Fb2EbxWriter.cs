using RimeLib.Serialization.Ebx;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RimeLib.Serialization.Frostbite2_0.Ebx
{
    class Fb2EbxWriter
    {
        private FrostbitePartition m_Partition;
        private string m_OutputPath;

        public Fb2EbxWriter(FrostbitePartition p_Partition, string p_Path, bool p_Overwrite = true)
        {
            m_Partition = p_Partition;

            if (File.Exists(p_Path) && p_Overwrite)
                File.Delete(p_Path);
            else
                throw new FileNotFoundException($"File: {p_Path} exists.");

            m_OutputPath = p_Path;
        }

        public bool Serialize(bool p_BigEndian = false)
        {
            
            // First we need to satisfy each dependency/field in the header
            var s_Header = new StreamingPartitionHeader
            {
                
            };

            // First we start at the primary instance and scale out
            var s_PrimaryInstance = m_Partition.PrimaryInstance;

            // TODO: Check to ensure that we have not already serialized this partition

            // TODO: Then we need to iterate through each of the imported partitions and serialize those
            // (recursively, dependency chain)

            // TODO: We need to serialize all instances, (and their referenced partitions)
            
            // TODO: Build each instance into a proper binary format

            // TODO: Serialize arrays, exports, import tables

            // TODO: Verify

            // TODO: Save file
            return true;
        }

        /*
         * Ebx Serialization Passes
         * 
         * This is similar to Halo and the Tag format which has been iterated upon (although in a simpler state) in Mutation
         * 
         * The idea is to take the same principals that were used for Halo and apply them to Frostbite as they have a similar way in how
         * data is intertwined with tags (aka ebx for Frostbite)
         * 
         * Currently there's the ContainerField(offset) for each of the classes that inherit DataContainer
         * We should implement a few more flags to make it easier for reflection via namehash
         * NameHashAttribute(...)
         * 
         * This means that this paticular field is added for editor purposes and should not be serialized
         * EditorOnly(...)
         * 
         * All property fields will need to implement the PropertyChanged/PropertyChanging flags
         * This can be done at generation type by having a private instance of each field
         * <Type> m_<Name>
         * 
         * Then for each of the get/set factors implement a few different listener events
         * 
         * This will involve a multi-pass system that will need to be carefully designed (probably will crash and burn the first time)
         * 
         * 1. The first pass will start by gathering all partitions that are referenced in a main partition and build a dependency tree
         * 
         * This will give us the count of EBX files that the current one you are trying to serialize is linked to
         * 
         * 2. Next we will do a second pass over all of those dependencies creating a type map for each of the partitions
         * 
         * Once all of the type information has been parsed we can create the equivalent of the StreamingPartitionTypeDescriptors
         * 
         * 3. Make another pass to get all of the field information creation of the equivalent StreamingPartitionFieldDescriptor
         * 
         * 4. This pass will go through and figure out all of the "imports" that are references to other ebx files
         * 
         * This should update/finalize all of the dependencies that are required
         * 
         * 5. Look for all of the partition's specific array entries and create placeholders for them, we may have to write blanks to the file for now
         * 
         * After everything is "solved for" as far as all of the types, dependencies, imports then we will go through and start serializing each of the partitions
         * This will also take in account for Arrays and where the data will be placed and re-writing any of the placeholder data that was held for reasons
         * 
         * 6. Serialize all of the data in the order that it was read
         * 
         * 7. Pray we have a working ebx file?
        */
    }
}
