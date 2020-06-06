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
	public class UIGeoLatitude : FrostbiteContainer
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public int Degrees { get; set; } // 0x0 (0)
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public int Minuites { get; set; } // 0x4 (4)
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public int Seconds { get; set; } // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3998015778:
					Degrees = (int) p_Value;
					break;

				case 3334936657:
					Minuites = (int) p_Value;
					break;

				case 2761379558:
					Seconds = (int) p_Value;
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
				case 3998015778:
					return Degrees;

				case 3334936657:
					return Minuites;

				case 2761379558:
					return Seconds;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3998015778:
					return typeof(UIGeoLatitude).GetProperty(nameof(Degrees));

				case 3334936657:
					return typeof(UIGeoLatitude).GetProperty(nameof(Minuites));

				case 2761379558:
					return typeof(UIGeoLatitude).GetProperty(nameof(Seconds));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
