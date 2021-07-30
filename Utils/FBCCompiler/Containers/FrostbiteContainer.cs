using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FBCC.Containers
{
    class FrostbiteContainer
    {
        public List<string> Includes { get; private set; }

        public ContainerNamespace Namespace { get; private set; }

        public List<IContainerDefinition> Definitions { get; private set; }

        public string Name { get; private set; }

        public string FilePath { get; private set; }

        public string BaseFolder { get; private set; }

        public FrostbiteContainer(string p_FilePath)
        {
            Includes = new List<string>();
            Definitions = new List<IContainerDefinition>();
            Namespace = null;

            FilePath = p_FilePath;
            BaseFolder = Path.GetDirectoryName(FilePath);
            Name = Path.GetFileNameWithoutExtension(FilePath);
        }

        public void AddInclude(string p_Include)
        {
            var s_Include = p_Include.Trim('<', '>');

            if (s_Include.ToLowerInvariant().EndsWith(".fbc"))
                s_Include = s_Include.Substring(0, s_Include.Length - 4);

            if (!Includes.Contains(s_Include))
                Includes.Add(s_Include);
        }

        public void SetNamespace(string p_Namespace)
        {
            Namespace = new ContainerNamespace(p_Namespace);
        }

        public void AddDefinition(IContainerDefinition p_Definition)
        {
            p_Definition.ParentContainer = this;
            Definitions.Add(p_Definition);
        }

        public IEnumerable<ContainerClass> GetClasses()
        {
            return Definitions
                .Where(p_Definition => p_Definition.DefinitionType == ContainerDefinitionType.Class)
                .Select(p_Definition => (ContainerClass) p_Definition);
        }

        public IEnumerable<ContainerStruct> GetStructs()
        {
            return Definitions
                .Where(p_Definition => p_Definition.DefinitionType == ContainerDefinitionType.Struct)
                .Select(p_Definition => (ContainerStruct) p_Definition);
        }

        public IEnumerable<ContainerEnum> GetEnums()
        {
            return Definitions
                .Where(p_Definition => p_Definition.DefinitionType == ContainerDefinitionType.Enum)
                .Select(p_Definition => (ContainerEnum)p_Definition);
        }
    }
}
