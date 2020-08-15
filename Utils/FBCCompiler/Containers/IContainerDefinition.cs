using System.Collections.Generic;

namespace FBCC.Containers
{
    interface IContainerDefinition
    {
        ContainerDefinitionType DefinitionType { get; }
        FrostbiteContainer ParentContainer { get; set; }
		List<ContainerAttribute> Attributes { get; }

		void AddAttribute(ContainerAttribute p_Attribute);
    }
}
