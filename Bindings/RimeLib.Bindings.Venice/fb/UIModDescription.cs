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
	public class UIModDescription : 
		UIItemDescription
	{
		[ContainerField(16), LayoutImmutable]
		public string Identifier { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable]
		public string ShortName { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable]
		public string FullName { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable]
		public string Desc { get; set; } // 0x1C (28)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3512790342:
					Identifier = (string) p_Value;
					break;

				case 1803010032:
					ShortName = (string) p_Value;
					break;

				case 4054333169:
					FullName = (string) p_Value;
					break;

				case 2088734996:
					Desc = (string) p_Value;
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
				case 3512790342:
					return Identifier;

				case 1803010032:
					return ShortName;

				case 4054333169:
					return FullName;

				case 2088734996:
					return Desc;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3512790342:
					return typeof(UIModDescription).GetProperty(nameof(Identifier));

				case 1803010032:
					return typeof(UIModDescription).GetProperty(nameof(ShortName));

				case 4054333169:
					return typeof(UIModDescription).GetProperty(nameof(FullName));

				case 2088734996:
					return typeof(UIModDescription).GetProperty(nameof(Desc));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
