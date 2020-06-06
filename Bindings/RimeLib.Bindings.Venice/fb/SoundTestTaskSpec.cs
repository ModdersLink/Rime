///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class SoundTestTaskSpec : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable]
		public string Description { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float Duration { get; set; } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1636673251:
					Description = (string) p_Value;
					break;

				case 1828507227:
					Duration = (float) p_Value;
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
				case 1636673251:
					return Description;

				case 1828507227:
					return Duration;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1636673251:
					return typeof(SoundTestTaskSpec).GetProperty(nameof(Description));

				case 1828507227:
					return typeof(SoundTestTaskSpec).GetProperty(nameof(Duration));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
