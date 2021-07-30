using System.Collections.Generic;

namespace FBCC.Containers
{
    class ContainerAttribute
    {
        public string Attribute { get; }

		public List<IContainerAttributeParam> Parameters { get; private set; } 

        public IContainerDefinition ParentDefinition { get; set; }

        public ContainerMember ParentMember { get; set; }

        public ContainerEnumValue ParentValue { get; set; }

        public ContainerAttribute(string p_Attribute)
        {
            Attribute = p_Attribute.Trim('[', ']');
	        Parameters = new List<IContainerAttributeParam>();
        }

        public override string ToString()
        {
			if (Parameters.Count == 0)
				return Attribute;

            return Attribute + "(" + string.Join(", ", Parameters) + ")";
        }
    }
}
