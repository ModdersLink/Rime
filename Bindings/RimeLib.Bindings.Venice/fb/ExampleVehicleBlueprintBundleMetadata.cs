///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class ExampleVehicleBlueprintBundleMetadata : 
		BlueprintBundleMetadata
	{
		[ContainerField(20)]
		public ExampleVehicleType ExampleVehicleType { get; set; } = new ExampleVehicleType(); // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3964640141:
					ExampleVehicleType = (ExampleVehicleType) Enum.ToObject(typeof(ExampleVehicleType), p_Value);
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
				case 3964640141:
					return ExampleVehicleType;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3964640141:
					return typeof(ExampleVehicleBlueprintBundleMetadata).GetProperty(nameof(ExampleVehicleType));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
