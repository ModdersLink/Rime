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
	public class AudioGraphNodePort : FrostbiteContainer
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public float UnconnectedValue { get; set; } // 0x0 (0)
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public ushort ValueIndex { get; set; } // 0x4 (4)
		
		[ContainerField(6), LayoutImmutable, Blittable]
		public bool IsConnected { get; set; } // 0x6 (6)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1858729834:
					UnconnectedValue = (float) p_Value;
					break;

				case 2085408208:
					ValueIndex = (ushort) p_Value;
					break;

				case 292566976:
					IsConnected = (bool) p_Value;
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
				case 1858729834:
					return UnconnectedValue;

				case 2085408208:
					return ValueIndex;

				case 292566976:
					return IsConnected;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1858729834:
					return typeof(AudioGraphNodePort).GetProperty(nameof(UnconnectedValue));

				case 2085408208:
					return typeof(AudioGraphNodePort).GetProperty(nameof(ValueIndex));

				case 292566976:
					return typeof(AudioGraphNodePort).GetProperty(nameof(IsConnected));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
