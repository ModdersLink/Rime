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
	public class UIWidgetPathBinding : 
		UIDataBinding
	{
		[ContainerField(8)]
		public UIDataSourceInfo WidgetPathQuery { get; set; } = new UIDataSourceInfo(); // 0x8 (8)
		
		[ContainerField(24)]
		public UIDataSourceInfo Visibility { get; set; } = new UIDataSourceInfo(); // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4285486446:
					WidgetPathQuery = (UIDataSourceInfo) p_Value;
					break;

				case 1708270083:
					Visibility = (UIDataSourceInfo) p_Value;
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
				case 4285486446:
					return WidgetPathQuery;

				case 1708270083:
					return Visibility;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4285486446:
					return typeof(UIWidgetPathBinding).GetProperty(nameof(WidgetPathQuery));

				case 1708270083:
					return typeof(UIWidgetPathBinding).GetProperty(nameof(Visibility));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
