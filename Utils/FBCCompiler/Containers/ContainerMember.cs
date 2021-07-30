using System.Collections.Generic;

namespace FBCC.Containers
{
    class ContainerMember
    {
        public string Name { get; private set; }

        public ContainerMemberType MemberType { get; set; }

        public ContainerAccess Access { get; set; }

        public bool Array { get; set; }

        public ContainerNamespace ContainerType { get; set; }

        public ulong Offset { get; set; }

        public List<ContainerAttribute> Attributes { get; private set; }

        public IContainerDefinition ParentDefinition { get; set; }

        public ContainerMember(string p_Name)
        {
            Name = p_Name;
            Array = false;
            Offset = 0;
            ContainerType = null;
            Attributes = new List<ContainerAttribute>();
        }

        public void SetContainerType(string p_String)
        {
            ContainerType = new ContainerNamespace(p_String);
        }

        public void AddAttribute(ContainerAttribute p_Attribute)
        {
	        p_Attribute.ParentMember = this;
            Attributes.Add(p_Attribute);
        }

        public ulong GetSize()
        {
            // TODO
            return 0;
        }
    }
}
