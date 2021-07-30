using System.Collections.Generic;

namespace FBCC.Containers
{
    class ContainerEnumValue
    {
        public string Name { get; private set; }

        public long Value
        {
            get
            {
                return m_Value;
            }
            set
            {
                m_Value = value;
                HasValue = true;
            }
        }

        public bool HasValue { get; private set; }

        public IContainerDefinition ParentDefinition { get; set; }

        public List<ContainerAttribute> Attributes { get; private set; }

        private long m_Value;

        public ContainerEnumValue(string p_Name)
        {
            Name = p_Name;
            m_Value = 0;
            HasValue = false;
            Attributes = new List<ContainerAttribute>();
        }

        public void AddAttribute(ContainerAttribute p_Attribute)
        {
	        p_Attribute.ParentValue = this;
            Attributes.Add(p_Attribute);
        }
    }
}
