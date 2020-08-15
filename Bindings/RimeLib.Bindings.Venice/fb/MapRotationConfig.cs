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
	public class MapRotationConfig : FrostbiteContainer
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public int MapRotationId { get; set; } // 0x0 (0)
		
		[ContainerField(4), LayoutImmutable]
		public string NameSid { get; set; } // 0x4 (4)
		
		[ContainerField(8), LayoutImmutable]
		public string DescSid { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable]
		public string Mod { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable]
		public string GameMode { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public bool RandomizeStartingMap { get; set; } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3190659456:
					MapRotationId = (int) p_Value;
					break;

				case 3153745340:
					NameSid = (string) p_Value;
					break;

				case 4021143274:
					DescSid = (string) p_Value;
					break;

				case 193446659:
					Mod = (string) p_Value;
					break;

				case 509558056:
					GameMode = (string) p_Value;
					break;

				case 514866356:
					RandomizeStartingMap = (bool) p_Value;
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
				case 3190659456:
					return MapRotationId;

				case 3153745340:
					return NameSid;

				case 4021143274:
					return DescSid;

				case 193446659:
					return Mod;

				case 509558056:
					return GameMode;

				case 514866356:
					return RandomizeStartingMap;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3190659456:
					return typeof(MapRotationConfig).GetProperty(nameof(MapRotationId));

				case 3153745340:
					return typeof(MapRotationConfig).GetProperty(nameof(NameSid));

				case 4021143274:
					return typeof(MapRotationConfig).GetProperty(nameof(DescSid));

				case 193446659:
					return typeof(MapRotationConfig).GetProperty(nameof(Mod));

				case 509558056:
					return typeof(MapRotationConfig).GetProperty(nameof(GameMode));

				case 514866356:
					return typeof(MapRotationConfig).GetProperty(nameof(RandomizeStartingMap));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
