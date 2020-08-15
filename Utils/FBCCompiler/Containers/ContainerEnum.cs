using System.Collections.Generic;

namespace FBCC.Containers
{
    class ContainerEnum : IContainerDefinition
    {
        public ContainerDefinitionType DefinitionType => ContainerDefinitionType.Enum;

	    public FrostbiteContainer ParentContainer { get; set; }

        public string Name { get; private set; }

        public ContainerEnumType EnumType { get; set; }

        public List<ContainerAttribute> Attributes { get; private set; }

        public List<ContainerEnumValue> Values { get; private set; }

        public ContainerEnum(string p_Name)
        {
            Name = p_Name;
            EnumType = ContainerEnumType.Int32;
            Attributes = new List<ContainerAttribute>();
            Values = new List<ContainerEnumValue>();
        }

        public void AddAttribute(ContainerAttribute p_Attribute)
        {
	        p_Attribute.ParentDefinition = this;
			Attributes.Add(p_Attribute);
        }

        public void AddValue(ContainerEnumValue p_Value)
        {
            p_Value.ParentDefinition = this;
            Values.Add(p_Value);
        }

        public void CloseEnum()
        {
            if (Values.Count == 0)
                return;

            // Fix enum values.
            if (!Values[0].HasValue)
                Values[0].Value = 0;

            for (var i = 1; i < Values.Count; ++i)
                if (!Values[i].HasValue)
                    Values[i].Value = Values[i - 1].Value + 1;
        }
    }
}
