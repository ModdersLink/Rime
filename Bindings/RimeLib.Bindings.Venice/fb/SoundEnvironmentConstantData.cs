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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 24)]
	public class SoundEnvironmentConstantData : 
		Asset
	{
		protected float m_HumanPlayerSoldierMovementVolumeOverride = new float();
		[ContainerField(Name: "HumanPlayerSoldierMovementVolumeOverride", Offset: 12, NameHash: 2922581308, Flags: 49469), LayoutImmutable, Blittable]
		public float HumanPlayerSoldierMovementVolumeOverride { get { return m_HumanPlayerSoldierMovementVolumeOverride; } set { if (OnPropertyChanging("SoundEnvironmentConstantData." + nameof(HumanPlayerSoldierMovementVolumeOverride), this, m_HumanPlayerSoldierMovementVolumeOverride, value)) m_HumanPlayerSoldierMovementVolumeOverride = value; } } // 0xC (12)
		
		protected float m_MemoryTime = new float();
		[ContainerField(Name: "MemoryTime", Offset: 16, NameHash: 1308283505, Flags: 49469), LayoutImmutable, Blittable]
		public float MemoryTime { get { return m_MemoryTime; } set { if (OnPropertyChanging("SoundEnvironmentConstantData." + nameof(MemoryTime), this, m_MemoryTime, value)) m_MemoryTime = value; } } // 0x10 (16)
		
		protected float m_MinimumLoudness = new float();
		[ContainerField(Name: "MinimumLoudness", Offset: 20, NameHash: 1173996714, Flags: 49469), LayoutImmutable, Blittable]
		public float MinimumLoudness { get { return m_MinimumLoudness; } set { if (OnPropertyChanging("SoundEnvironmentConstantData." + nameof(MinimumLoudness), this, m_MinimumLoudness, value)) m_MinimumLoudness = value; } } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2922581308:
					HumanPlayerSoldierMovementVolumeOverride = (float) p_Value;
					break;

				case 1308283505:
					MemoryTime = (float) p_Value;
					break;

				case 1173996714:
					MinimumLoudness = (float) p_Value;
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
				case 2922581308:
					return HumanPlayerSoldierMovementVolumeOverride;

				case 1308283505:
					return MemoryTime;

				case 1173996714:
					return MinimumLoudness;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2922581308:
					return typeof(SoundEnvironmentConstantData).GetProperty(nameof(HumanPlayerSoldierMovementVolumeOverride));

				case 1308283505:
					return typeof(SoundEnvironmentConstantData).GetProperty(nameof(MemoryTime));

				case 1173996714:
					return typeof(SoundEnvironmentConstantData).GetProperty(nameof(MinimumLoudness));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
