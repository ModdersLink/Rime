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
	public class AudioGraphParameter : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public float DefaultValue { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public uint NameHash { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public ushort ValueIndex { get; set; } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2066049125:
					DefaultValue = (float) p_Value;
					break;

				case 994057744:
					NameHash = (uint) p_Value;
					break;

				case 2085408208:
					ValueIndex = (ushort) p_Value;
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
				case 2066049125:
					return DefaultValue;

				case 994057744:
					return NameHash;

				case 2085408208:
					return ValueIndex;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2066049125:
					return typeof(AudioGraphParameter).GetProperty(nameof(DefaultValue));

				case 994057744:
					return typeof(AudioGraphParameter).GetProperty(nameof(NameHash));

				case 2085408208:
					return typeof(AudioGraphParameter).GetProperty(nameof(ValueIndex));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
