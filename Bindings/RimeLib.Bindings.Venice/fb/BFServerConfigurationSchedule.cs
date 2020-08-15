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
	[ContainerType(4)]
	public class BFServerConfigurationSchedule : FrostbiteContainer
	{
		[ContainerField(0)]
		public List<string> Licenses { get; set; } = new List<string>(); // 0x0 (0)
		
		[ContainerField(4)]
		public List<string> Levels { get; set; } = new List<string>(); // 0x4 (4)
		
		[ContainerField(8)]
		public BFServerConfigurationData Data { get; set; } = new BFServerConfigurationData(); // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2259172461:
					Licenses = (List<string>) p_Value;
					break;

				case 2907695648:
					Levels = (List<string>) p_Value;
					break;

				case 2088730869:
					Data = (BFServerConfigurationData) p_Value;
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
				case 2259172461:
					return Licenses;

				case 2907695648:
					return Levels;

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
				case 2259172461:
					return typeof(BFServerConfigurationSchedule).GetProperty(nameof(Licenses));

				case 2907695648:
					return typeof(BFServerConfigurationSchedule).GetProperty(nameof(Levels));

				case 2088730869:
					return typeof(BFServerConfigurationSchedule).GetProperty(nameof(Data));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
