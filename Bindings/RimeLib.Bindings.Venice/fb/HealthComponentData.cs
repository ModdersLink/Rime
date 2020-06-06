///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class HealthComponentData : 
		ComponentData
	{
		[ContainerField(96), LayoutImmutable, Blittable]
		public float Health { get; set; } // 0x60 (96)
		
		[ContainerField(100)]
		public CtrRef<MaterialContainerPair> MaterialPair { get; set; } = new CtrRef<MaterialContainerPair>(); // 0x64 (100)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3054337113:
					Health = (float) p_Value;
					break;

				case 161392100:
					MaterialPair = (CtrRef<MaterialContainerPair>) p_Value;
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
				case 3054337113:
					return Health;

				case 161392100:
					return MaterialPair;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3054337113:
					return typeof(HealthComponentData).GetProperty(nameof(Health));

				case 161392100:
					return typeof(HealthComponentData).GetProperty(nameof(MaterialPair));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
