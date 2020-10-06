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
	[ContainerType(4), MemberInfoFlag(41), ContainerSize(24), ContainerStruct]
	public class GunSwayRecoilData : FrostbiteContainer
	{
		[ContainerField(0), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float RecoilAmplitudeMax { get; set; } // 0x0 (0)
		
		[ContainerField(4), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float RecoilAmplitudeIncPerShot { get; set; } // 0x4 (4)
		
		[ContainerField(8), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float HorizontalRecoilAmplitudeIncPerShotMin { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float HorizontalRecoilAmplitudeIncPerShotMax { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float HorizontalRecoilAmplitudeMax { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float RecoilAmplitudeDecreaseFactor { get; set; } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2197654614:
					RecoilAmplitudeMax = (float) p_Value;
					break;

				case 2578458785:
					RecoilAmplitudeIncPerShot = (float) p_Value;
					break;

				case 301051253:
					HorizontalRecoilAmplitudeIncPerShotMin = (float) p_Value;
					break;

				case 301050987:
					HorizontalRecoilAmplitudeIncPerShotMax = (float) p_Value;
					break;

				case 3300506952:
					HorizontalRecoilAmplitudeMax = (float) p_Value;
					break;

				case 255021325:
					RecoilAmplitudeDecreaseFactor = (float) p_Value;
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
				case 2197654614:
					return RecoilAmplitudeMax;

				case 2578458785:
					return RecoilAmplitudeIncPerShot;

				case 301051253:
					return HorizontalRecoilAmplitudeIncPerShotMin;

				case 301050987:
					return HorizontalRecoilAmplitudeIncPerShotMax;

				case 3300506952:
					return HorizontalRecoilAmplitudeMax;

				case 255021325:
					return RecoilAmplitudeDecreaseFactor;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2197654614:
					return typeof(GunSwayRecoilData).GetProperty(nameof(RecoilAmplitudeMax));

				case 2578458785:
					return typeof(GunSwayRecoilData).GetProperty(nameof(RecoilAmplitudeIncPerShot));

				case 301051253:
					return typeof(GunSwayRecoilData).GetProperty(nameof(HorizontalRecoilAmplitudeIncPerShotMin));

				case 301050987:
					return typeof(GunSwayRecoilData).GetProperty(nameof(HorizontalRecoilAmplitudeIncPerShotMax));

				case 3300506952:
					return typeof(GunSwayRecoilData).GetProperty(nameof(HorizontalRecoilAmplitudeMax));

				case 255021325:
					return typeof(GunSwayRecoilData).GetProperty(nameof(RecoilAmplitudeDecreaseFactor));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
