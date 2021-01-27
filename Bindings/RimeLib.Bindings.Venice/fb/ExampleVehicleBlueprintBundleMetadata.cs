///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using RimeLib.IO;
using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 4,  Flags: 53, Size: 24)]
	public class ExampleVehicleBlueprintBundleMetadata : 
		BlueprintBundleMetadata
	{
		protected ExampleVehicleType m_ExampleVehicleType = new ExampleVehicleType();
		[ContainerField(Name: "ExampleVehicleType", Offset: 20, NameHash: 3964640141, Flags: 137)]
		public ExampleVehicleType ExampleVehicleType { get { return m_ExampleVehicleType; } set { if (OnPropertyChanging("ExampleVehicleBlueprintBundleMetadata." + nameof(ExampleVehicleType), this, m_ExampleVehicleType, value)) m_ExampleVehicleType = value; } } // 0x14 (20)
		
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
