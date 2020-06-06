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
	public class DebrisSystemAsset : 
		Asset
	{
		[ContainerField(12)]
		public List<DebrisHavokInfo> HavokMeshes { get; set; } = new List<DebrisHavokInfo>(); // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public int HavokMeshCount { get; set; } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3852503739:
					HavokMeshes = (List<DebrisHavokInfo>) p_Value;
					break;

				case 3497183694:
					HavokMeshCount = (int) p_Value;
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
				case 3852503739:
					return HavokMeshes;

				case 3497183694:
					return HavokMeshCount;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3852503739:
					return typeof(DebrisSystemAsset).GetProperty(nameof(HavokMeshes));

				case 3497183694:
					return typeof(DebrisSystemAsset).GetProperty(nameof(HavokMeshCount));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
