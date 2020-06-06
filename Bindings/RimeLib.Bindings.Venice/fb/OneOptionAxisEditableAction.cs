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
	public class OneOptionAxisEditableAction : 
		EditableAction
	{
		[ContainerField(12), LayoutImmutable]
		public string Header { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public bool Invert { get; set; } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3054345338:
					Header = (string) p_Value;
					break;

				case 2784486295:
					Invert = (bool) p_Value;
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
				case 3054345338:
					return Header;

				case 2784486295:
					return Invert;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3054345338:
					return typeof(OneOptionAxisEditableAction).GetProperty(nameof(Header));

				case 2784486295:
					return typeof(OneOptionAxisEditableAction).GetProperty(nameof(Invert));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
