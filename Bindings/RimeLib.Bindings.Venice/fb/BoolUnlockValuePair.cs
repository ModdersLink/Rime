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
	public class BoolUnlockValuePair : 
		UnlockValuePair
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public bool DefaultValue { get; set; } // 0xC (12)
		
		[ContainerField(13), LayoutImmutable, Blittable]
		public bool UnlockedValue { get; set; } // 0xD (13)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2066049125:
					DefaultValue = (bool) p_Value;
					break;

				case 2493912799:
					UnlockedValue = (bool) p_Value;
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

				case 2493912799:
					return UnlockedValue;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2066049125:
					return typeof(BoolUnlockValuePair).GetProperty(nameof(DefaultValue));

				case 2493912799:
					return typeof(BoolUnlockValuePair).GetProperty(nameof(UnlockedValue));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
