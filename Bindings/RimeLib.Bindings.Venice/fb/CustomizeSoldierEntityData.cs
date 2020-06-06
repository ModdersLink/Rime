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
	public class CustomizeSoldierEntityData : 
		CustomizeBaseEntityData
	{
		[ContainerField(16)]
		public CtrRef<CustomizeSoldierData> CustomizeSoldierData { get; set; } = new CtrRef<CustomizeSoldierData>(); // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2875154650:
					CustomizeSoldierData = (CtrRef<CustomizeSoldierData>) p_Value;
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
				case 2875154650:
					return CustomizeSoldierData;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2875154650:
					return typeof(CustomizeSoldierEntityData).GetProperty(nameof(CustomizeSoldierData));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
