///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class SupportedShootingComponentData : 
		ComponentData
	{
		[ContainerField(96)]
		public CtrRef<SupportedShootingCommonData> CommonData { get; set; } = new CtrRef<SupportedShootingCommonData>(); // 0x60 (96)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 760803064:
					CommonData = (CtrRef<SupportedShootingCommonData>) p_Value;
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
				case 760803064:
					return CommonData;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 760803064:
					return typeof(SupportedShootingComponentData).GetProperty(nameof(CommonData));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
