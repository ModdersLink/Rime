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
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 4,  Flags: 41, Size: 12)]
	public class ServerBackendAttributeMapping : FrostbiteContainer
	{
		[ContainerField(Name: "Attribute", Offset: 0, NameHash: 2715851769, Flags: 137)]
		public ServerBackendAttribute Attribute { get; set; } = new ServerBackendAttribute(); // 0x0 (0)
		
		[ContainerField(Name: "Setting", Offset: 4, NameHash: 2752851091, Flags: 16509), LayoutImmutable]
		public string Setting { get; set; } // 0x4 (4)
		
		[ContainerField(Name: "DefaultValue", Offset: 8, NameHash: 2066049125, Flags: 16509), LayoutImmutable]
		public string DefaultValue { get; set; } // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2715851769:
						Attribute = (ServerBackendAttribute) Enum.ToObject(typeof(ServerBackendAttribute), p_Value);
					break;

				case 2752851091:
					Setting = (string) p_Value;
					break;

				case 2066049125:
					DefaultValue = (string) p_Value;
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
				case 2715851769:
					return Attribute;

				case 2752851091:
					return Setting;

				case 2066049125:
					return DefaultValue;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2715851769:
					return typeof(ServerBackendAttributeMapping).GetProperty(nameof(Attribute));

				case 2752851091:
					return typeof(ServerBackendAttributeMapping).GetProperty(nameof(Setting));

				case 2066049125:
					return typeof(ServerBackendAttributeMapping).GetProperty(nameof(DefaultValue));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
