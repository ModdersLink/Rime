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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 32)]
	public class SoundAreaEntityData : 
		EntityData
	{
		protected CtrRef<SoundAsset> m_Sound = new CtrRef<SoundAsset>();
		[ContainerField(Name: "Sound", Offset: 12, NameHash: 231353798, Flags: 53)]
		public CtrRef<SoundAsset> Sound { get { return m_Sound; } set { if (OnPropertyChanging("SoundAreaEntityData." + nameof(Sound), this, m_Sound, value)) m_Sound = value; } } // 0xC (12)
		
		protected CtrRef<BigWorldSettingsAsset> m_BigWorld = new CtrRef<BigWorldSettingsAsset>();
		[ContainerField(Name: "BigWorld", Offset: 16, NameHash: 4205700235, Flags: 53)]
		public CtrRef<BigWorldSettingsAsset> BigWorld { get { return m_BigWorld; } set { if (OnPropertyChanging("SoundAreaEntityData." + nameof(BigWorld), this, m_BigWorld, value)) m_BigWorld = value; } } // 0x10 (16)
		
		protected float m_FadeWidth = new float();
		[ContainerField(Name: "FadeWidth", Offset: 20, NameHash: 3185416613, Flags: 49469), LayoutImmutable, Blittable]
		public float FadeWidth { get { return m_FadeWidth; } set { if (OnPropertyChanging("SoundAreaEntityData." + nameof(FadeWidth), this, m_FadeWidth, value)) m_FadeWidth = value; } } // 0x14 (20)
		
		protected float m_ProximityMultiplier = new float();
		[ContainerField(Name: "ProximityMultiplier", Offset: 24, NameHash: 1947336347, Flags: 49469), LayoutImmutable, Blittable]
		public float ProximityMultiplier { get { return m_ProximityMultiplier; } set { if (OnPropertyChanging("SoundAreaEntityData." + nameof(ProximityMultiplier), this, m_ProximityMultiplier, value)) m_ProximityMultiplier = value; } } // 0x18 (24)
		
		protected FadeCurveType m_FadeCurve = new FadeCurveType();
		[ContainerField(Name: "FadeCurve", Offset: 28, NameHash: 3162123636, Flags: 137)]
		public FadeCurveType FadeCurve { get { return m_FadeCurve; } set { if (OnPropertyChanging("SoundAreaEntityData." + nameof(FadeCurve), this, m_FadeCurve, value)) m_FadeCurve = value; } } // 0x1C (28)
		
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
