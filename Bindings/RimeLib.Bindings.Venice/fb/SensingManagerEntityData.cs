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
	public class SensingManagerEntityData : 
		EntityData
	{
		[ContainerField(12)]
		public List<SensingSphere> SenseTerrainAreas { get; set; } = new List<SensingSphere>(); // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1470254904:
					SenseTerrainAreas = (List<SensingSphere>) p_Value;
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
				case 1470254904:
					return SenseTerrainAreas;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1470254904:
					return typeof(SensingManagerEntityData).GetProperty(nameof(SenseTerrainAreas));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
