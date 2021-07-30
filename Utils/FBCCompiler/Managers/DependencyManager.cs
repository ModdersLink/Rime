using System;
using System.IO;
using FBCC.Containers;

namespace FBCC.Managers
{
    static class DependencyManager
    {
        public static void ResolveDependencies()
        {
            var s_Containers = ContainerManager.GetContainers();

            // Resolve dependencies for all the containers.
            foreach (var s_Container in s_Containers)
                ResolveDependencies(s_Container);

            foreach (var s_Container in s_Containers)
            {
                // Resolve class dependencies.
                foreach (var s_Class in s_Container.GetClasses())
                {
                    // Do our superclasses exist?
                    foreach (var s_Inherited in s_Class.InheritedClasses)
                        if (!ContainerManager.HasClass(s_Inherited))
                            throw new Exception("Class '" + s_Class.Name + "' inherits from unknown type '" + s_Inherited + "'.");
                    
                    // Do our member types exist?
                    foreach (var s_Member in s_Class.Members)
                        if (s_Member.MemberType == ContainerMemberType.Container && !ContainerManager.HasType(s_Member.ContainerType))
                            throw new Exception("Unknown type '" + s_Member.ContainerType + "' for member '" + s_Member.Name + "' of class '" + s_Class.Name + "'.");
                }

                // Resolve struct dependencies.
                foreach (var s_Struct in s_Container.GetStructs())
                {
                    // Do our member types exist?
                    foreach (var s_Member in s_Struct.Members)
                        if (s_Member.MemberType == ContainerMemberType.Container && !ContainerManager.HasType(s_Member.ContainerType))
                            throw new Exception("Unknown type '" + s_Member.ContainerType + "' for member '" + s_Member.Name + "' of struct '" + s_Struct.Name + "'.");
                }
            }
        }

        /// <summary>
        /// Resolves, parses, and registers referenced containers.
        /// </summary>
        /// <param name="p_Container"></param>
        public static void ResolveDependencies(FrostbiteContainer p_Container)
        {
            foreach (var s_Include in p_Container.Includes)
            {
                var s_IncludePath = Path.Combine(p_Container.BaseFolder, s_Include + ".fbc");

                if (!File.Exists(s_IncludePath))
                    throw new Exception("Could not find file '" + s_Include + ".fbc' included from '" + p_Container.Name + "'.");

                // Parse include.
                bool s_Exists;
                var s_Container = ContainerManager.RegisterContainer(s_IncludePath, false, out s_Exists);

                // Container didn't already exist. Parse it's dependencies.
                if (!s_Exists)
                    ResolveDependencies(s_Container);
            }
        }
    }
}
