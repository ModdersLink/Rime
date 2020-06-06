///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Collections.Generic;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class PathfindingSystemEntityData : 
		EntityData
	{
		[ContainerField(12)]
		public List<uint> PathfindingTypesOnLevel { get; set; } = new List<uint>(); // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2264269169:
					PathfindingTypesOnLevel = (List<uint>) p_Value;
					break;

				default:
					base.Bind(p_Descriptor, p_Value);
					break;
			}
		}

		public override object GetFieldValueByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2264269169:
					return PathfindingTypesOnLevel;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2264269169:
					return typeof(PathfindingSystemEntityData).GetProperty(nameof(PathfindingTypesOnLevel));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
