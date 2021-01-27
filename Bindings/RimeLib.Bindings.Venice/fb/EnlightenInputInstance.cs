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
	[ContainerType(Alignment: 16,  Flags: 41, Size: 80)]
	public class EnlightenInputInstance : FrostbiteContainer
	{
		[ContainerField(Name: "Transform", Offset: 0, NameHash: 2270319721, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform Transform { get; set; } = new LinearTransform(); // 0x0 (0)
		
		[ContainerField(Name: "Asset", Offset: 64, NameHash: 205976053, Flags: 16509), LayoutImmutable]
		public string Asset { get; set; } // 0x40 (64)
		
		[ContainerField(Name: "ObjectVariation", Offset: 68, NameHash: 3624336577, Flags: 16509), LayoutImmutable]
		public string ObjectVariation { get; set; } // 0x44 (68)
		
		[ContainerField(Name: "SystemId", Offset: 72, NameHash: 643121549, Flags: 49405), LayoutImmutable, Blittable]
		public int SystemId { get; set; } // 0x48 (72)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2270319721:
					Transform = (LinearTransform) p_Value;
					break;

				case 205976053:
					Asset = (string) p_Value;
					break;

				case 3624336577:
					ObjectVariation = (string) p_Value;
					break;

				case 643121549:
					SystemId = (int) p_Value;
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
				case 2270319721:
					return Transform;

				case 205976053:
					return Asset;

				case 3624336577:
					return ObjectVariation;

				case 643121549:
					return SystemId;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2270319721:
					return typeof(EnlightenInputInstance).GetProperty(nameof(Transform));

				case 205976053:
					return typeof(EnlightenInputInstance).GetProperty(nameof(Asset));

				case 3624336577:
					return typeof(EnlightenInputInstance).GetProperty(nameof(ObjectVariation));

				case 643121549:
					return typeof(EnlightenInputInstance).GetProperty(nameof(SystemId));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
