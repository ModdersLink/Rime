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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 16)]
	public class UILevelStatData : FrostbiteContainer
	{
		[ContainerField(Name: "StatEasy", Offset: 0, NameHash: 3117395417, Flags: 16509), LayoutImmutable]
		public string StatEasy { get; set; } // 0x0 (0)
		
		[ContainerField(Name: "StatMedium", Offset: 4, NameHash: 2137844554, Flags: 16509), LayoutImmutable]
		public string StatMedium { get; set; } // 0x4 (4)
		
		[ContainerField(Name: "StatHard", Offset: 8, NameHash: 3117794824, Flags: 16509), LayoutImmutable]
		public string StatHard { get; set; } // 0x8 (8)
		
		[ContainerField(Name: "StatHardcore", Offset: 12, NameHash: 2618242163, Flags: 16509), LayoutImmutable]
		public string StatHardcore { get; set; } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3117395417:
					StatEasy = (string) p_Value;
					break;

				case 2137844554:
					StatMedium = (string) p_Value;
					break;

				case 3117794824:
					StatHard = (string) p_Value;
					break;

				case 2618242163:
					StatHardcore = (string) p_Value;
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
				case 3117395417:
					return StatEasy;

				case 2137844554:
					return StatMedium;

				case 3117794824:
					return StatHard;

				case 2618242163:
					return StatHardcore;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3117395417:
					return typeof(UILevelStatData).GetProperty(nameof(StatEasy));

				case 2137844554:
					return typeof(UILevelStatData).GetProperty(nameof(StatMedium));

				case 3117794824:
					return typeof(UILevelStatData).GetProperty(nameof(StatHard));

				case 2618242163:
					return typeof(UILevelStatData).GetProperty(nameof(StatHardcore));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
