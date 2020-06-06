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
	public class CustomizeCharacterEntityData : 
		CustomizeBaseEntityData
	{
		[ContainerField(16)]
		public CtrRef<CustomizeCharacterData> CustomizeCharacterData { get; set; } = new CtrRef<CustomizeCharacterData>(); // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3784213897:
					CustomizeCharacterData = (CtrRef<CustomizeCharacterData>) p_Value;
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
				case 3784213897:
					return CustomizeCharacterData;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3784213897:
					return typeof(CustomizeCharacterEntityData).GetProperty(nameof(CustomizeCharacterData));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
