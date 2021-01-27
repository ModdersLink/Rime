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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 8)]
	public class OnlineEnvironmentUrlData : FrostbiteContainer
	{
		[ContainerField(Name: "Url", Offset: 0, NameHash: 193455022, Flags: 16509), LayoutImmutable]
		public string Url { get; set; } // 0x0 (0)
		
		[ContainerField(Name: "Environment", Offset: 4, NameHash: 2480382480, Flags: 137)]
		public OnlineEnvironment Environment { get; set; } = new OnlineEnvironment(); // 0x4 (4)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 193455022:
					Url = (string) p_Value;
					break;

				case 2480382480:
						Environment = (OnlineEnvironment) Enum.ToObject(typeof(OnlineEnvironment), p_Value);
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
				case 193455022:
					return Url;

				case 2480382480:
					return Environment;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 193455022:
					return typeof(OnlineEnvironmentUrlData).GetProperty(nameof(Url));

				case 2480382480:
					return typeof(OnlineEnvironmentUrlData).GetProperty(nameof(Environment));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
