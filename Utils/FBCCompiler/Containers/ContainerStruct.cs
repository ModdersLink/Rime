using System.Collections.Generic;

namespace FBCC.Containers
{
    class ContainerStruct : IContainerDefinition
    {
        public ContainerDefinitionType DefinitionType => ContainerDefinitionType.Struct;

	    public FrostbiteContainer ParentContainer { get; set; }

        public string Name { get; private set; }

        public ushort Alignment { get; set; }

        public List<ContainerAttribute> Attributes { get; private set; }

        public List<ContainerMember> Members { get; private set; }

        public ContainerStruct(string p_Name)
        {
            Name = p_Name;
            Alignment = (ushort) (Program.Archx64 ? 8 : 4);
            Attributes = new List<ContainerAttribute>();
            Members = new List<ContainerMember>();
        }

        public void AddAttribute(ContainerAttribute p_Attribute)
        {
	        p_Attribute.ParentDefinition = this;
			Attributes.Add(p_Attribute);
        }

        public void AddMember(ContainerMember p_Member)
        {
            p_Member.ParentDefinition = this;
            Members.Add(p_Member);
        }

        public void CloseStruct()
        {
            // Fix member offsets
            // TODO
        }

        public ulong GetSize()
        {
            // TODO
            return 0;
        }
    }
}
