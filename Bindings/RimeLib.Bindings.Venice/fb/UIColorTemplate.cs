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
	public class UIColorTemplate : 
		Asset
	{
		[ContainerField(12)]
		public RefArray<UIColor> Colors { get; set; } = new RefArray<UIColor>(); // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public bool Active { get; set; } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2713814155:
					Colors = (RefArray<UIColor>) p_Value;
					break;

				case 2484178249:
					Active = (bool) p_Value;
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
				case 2713814155:
					return Colors;

				case 2484178249:
					return Active;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2713814155:
					return typeof(UIColorTemplate).GetProperty(nameof(Colors));

				case 2484178249:
					return typeof(UIColorTemplate).GetProperty(nameof(Active));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
