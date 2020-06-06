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
	public class UIItemDescriptionAsset : 
		Asset
	{
		[ContainerField(12)]
		public RefArray<UIItemDescriptionAsset> Children { get; set; } = new RefArray<UIItemDescriptionAsset>(); // 0xC (12)
		
		[ContainerField(16)]
		public RefArray<UIItemDescription> Items { get; set; } = new RefArray<UIItemDescription>(); // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1297796054:
					Children = (RefArray<UIItemDescriptionAsset>) p_Value;
					break;

				case 215446531:
					Items = (RefArray<UIItemDescription>) p_Value;
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
				case 1297796054:
					return Children;

				case 215446531:
					return Items;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1297796054:
					return typeof(UIItemDescriptionAsset).GetProperty(nameof(Children));

				case 215446531:
					return typeof(UIItemDescriptionAsset).GetProperty(nameof(Items));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
