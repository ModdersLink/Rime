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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 24)]
	public class Boost : FrostbiteContainer
	{
		[ContainerField(Name: "ForwardStrength", Offset: 0, NameHash: 91624507, Flags: 49469), LayoutImmutable, Blittable]
		public float ForwardStrength { get; set; } // 0x0 (0)
		
		[ContainerField(Name: "ReverseStrength", Offset: 4, NameHash: 91172096, Flags: 49469), LayoutImmutable, Blittable]
		public float ReverseStrength { get; set; } // 0x4 (4)
		
		[ContainerField(Name: "DissipationTime", Offset: 8, NameHash: 3822739865, Flags: 49469), LayoutImmutable, Blittable]
		public float DissipationTime { get; set; } // 0x8 (8)
		
		[ContainerField(Name: "RecoveryTime", Offset: 12, NameHash: 359615635, Flags: 49469), LayoutImmutable, Blittable]
		public float RecoveryTime { get; set; } // 0xC (12)
		
		[ContainerField(Name: "CrawlStrength", Offset: 16, NameHash: 3643856331, Flags: 49469), LayoutImmutable, Blittable]
		public float CrawlStrength { get; set; } // 0x10 (16)
		
		[ContainerField(Name: "AccelerationScale", Offset: 20, NameHash: 116231199, Flags: 49469), LayoutImmutable, Blittable]
		public float AccelerationScale { get; set; } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 91624507:
					ForwardStrength = (float) p_Value;
					break;

				case 91172096:
					ReverseStrength = (float) p_Value;
					break;

				case 3822739865:
					DissipationTime = (float) p_Value;
					break;

				case 359615635:
					RecoveryTime = (float) p_Value;
					break;

				case 3643856331:
					CrawlStrength = (float) p_Value;
					break;

				case 116231199:
					AccelerationScale = (float) p_Value;
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
				case 91624507:
					return ForwardStrength;

				case 91172096:
					return ReverseStrength;

				case 3822739865:
					return DissipationTime;

				case 359615635:
					return RecoveryTime;

				case 3643856331:
					return CrawlStrength;

				case 116231199:
					return AccelerationScale;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 91624507:
					return typeof(Boost).GetProperty(nameof(ForwardStrength));

				case 91172096:
					return typeof(Boost).GetProperty(nameof(ReverseStrength));

				case 3822739865:
					return typeof(Boost).GetProperty(nameof(DissipationTime));

				case 359615635:
					return typeof(Boost).GetProperty(nameof(RecoveryTime));

				case 3643856331:
					return typeof(Boost).GetProperty(nameof(CrawlStrength));

				case 116231199:
					return typeof(Boost).GetProperty(nameof(AccelerationScale));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
