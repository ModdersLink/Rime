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
	public class SoundAreaEntityData : 
		EntityData
	{
		[ContainerField(12)]
		public CtrRef<SoundAsset> Sound { get; set; } = new CtrRef<SoundAsset>(); // 0xC (12)
		
		[ContainerField(16)]
		public CtrRef<BigWorldSettingsAsset> BigWorld { get; set; } = new CtrRef<BigWorldSettingsAsset>(); // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float FadeWidth { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float ProximityMultiplier { get; set; } // 0x18 (24)
		
		[ContainerField(28)]
		public FadeCurveType FadeCurve { get; set; } = new FadeCurveType(); // 0x1C (28)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 231353798:
					Sound = (CtrRef<SoundAsset>) p_Value;
					break;

				case 4205700235:
					BigWorld = (CtrRef<BigWorldSettingsAsset>) p_Value;
					break;

				case 3185416613:
					FadeWidth = (float) p_Value;
					break;

				case 1947336347:
					ProximityMultiplier = (float) p_Value;
					break;

				case 3162123636:
					FadeCurve = (FadeCurveType) Enum.ToObject(typeof(FadeCurveType), p_Value);
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
				case 231353798:
					return Sound;

				case 4205700235:
					return BigWorld;

				case 3185416613:
					return FadeWidth;

				case 1947336347:
					return ProximityMultiplier;

				case 3162123636:
					return FadeCurve;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 231353798:
					return typeof(SoundAreaEntityData).GetProperty(nameof(Sound));

				case 4205700235:
					return typeof(SoundAreaEntityData).GetProperty(nameof(BigWorld));

				case 3185416613:
					return typeof(SoundAreaEntityData).GetProperty(nameof(FadeWidth));

				case 1947336347:
					return typeof(SoundAreaEntityData).GetProperty(nameof(ProximityMultiplier));

				case 3162123636:
					return typeof(SoundAreaEntityData).GetProperty(nameof(FadeCurve));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
