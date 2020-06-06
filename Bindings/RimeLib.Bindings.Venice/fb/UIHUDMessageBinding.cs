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
	public class UIHUDMessageBinding : 
		UIDataBinding
	{
		[ContainerField(8)]
		public UIDataSourceInfo MessageQuery { get; set; } = new UIDataSourceInfo(); // 0x8 (8)
		
		[ContainerField(24)]
		public UIDataSourceInfo VisibilityQuery { get; set; } = new UIDataSourceInfo(); // 0x18 (24)
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public int NumberOfRows { get; set; } // 0x28 (40)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 501651684:
					MessageQuery = (UIDataSourceInfo) p_Value;
					break;

				case 734252745:
					VisibilityQuery = (UIDataSourceInfo) p_Value;
					break;

				case 2507942582:
					NumberOfRows = (int) p_Value;
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
				case 501651684:
					return MessageQuery;

				case 734252745:
					return VisibilityQuery;

				case 2507942582:
					return NumberOfRows;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 501651684:
					return typeof(UIHUDMessageBinding).GetProperty(nameof(MessageQuery));

				case 734252745:
					return typeof(UIHUDMessageBinding).GetProperty(nameof(VisibilityQuery));

				case 2507942582:
					return typeof(UIHUDMessageBinding).GetProperty(nameof(NumberOfRows));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
