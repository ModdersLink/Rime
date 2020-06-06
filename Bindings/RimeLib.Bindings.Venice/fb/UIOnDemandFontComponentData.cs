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
	public class UIOnDemandFontComponentData : 
		UIComponentData
	{
		[ContainerField(28)]
		public RefArray<UIFontCollection> FontCollections { get; set; } = new RefArray<UIFontCollection>(); // 0x1C (28)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2744963667:
					FontCollections = (RefArray<UIFontCollection>) p_Value;
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
				case 2744963667:
					return FontCollections;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2744963667:
					return typeof(UIOnDemandFontComponentData).GetProperty(nameof(FontCollections));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
