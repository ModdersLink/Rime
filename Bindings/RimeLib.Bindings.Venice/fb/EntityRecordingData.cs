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
	public class EntityRecordingData : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public GUID EntityGuid { get; set; } // 0x8 (8)
		
		[ContainerField(24)]
		public RefArray<PropertyRecordingData> Data { get; set; } = new RefArray<PropertyRecordingData>(); // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1697800481:
					EntityGuid = (GUID) p_Value;
					break;

				case 2088730869:
					Data = (RefArray<PropertyRecordingData>) p_Value;
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
				case 1697800481:
					return EntityGuid;

				case 2088730869:
					return Data;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1697800481:
					return typeof(EntityRecordingData).GetProperty(nameof(EntityGuid));

				case 2088730869:
					return typeof(EntityRecordingData).GetProperty(nameof(Data));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
