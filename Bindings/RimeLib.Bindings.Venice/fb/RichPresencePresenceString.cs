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
	public class RichPresencePresenceString : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable]
		public string SID { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public bool Interpolated { get; set; } // 0xC (12)
		
		[ContainerField(13), LayoutImmutable, Blittable]
		public sbyte Index { get; set; } // 0xD (13)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 193467547:
					SID = (string) p_Value;
					break;

				case 3956040102:
					Interpolated = (bool) p_Value;
					break;

				case 214509467:
					Index = (sbyte) p_Value;
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
				case 193467547:
					return SID;

				case 3956040102:
					return Interpolated;

				case 214509467:
					return Index;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 193467547:
					return typeof(RichPresencePresenceString).GetProperty(nameof(SID));

				case 3956040102:
					return typeof(RichPresencePresenceString).GetProperty(nameof(Interpolated));

				case 214509467:
					return typeof(RichPresencePresenceString).GetProperty(nameof(Index));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
