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
	public class LevelAudioObstructionAsset : 
		Asset
	{
		protected List<AudioObstructionMaterialInfo> m_MaterialMap = new List<AudioObstructionMaterialInfo>();
		[ContainerField(12), ContainerFieldNameHash(2868170514)]
		public List<AudioObstructionMaterialInfo> MaterialMap { get { return m_MaterialMap; } set { if (OnPropertyChanging("LevelAudioObstructionAsset." + nameof(MaterialMap), this, m_MaterialMap, value)) m_MaterialMap = value; } } // 0xC (12)
		
		protected float m_FrequencySlewRate = new float();
		[ContainerField(16), LayoutImmutable, Blittable, ContainerFieldNameHash(1368142094)]
		public float FrequencySlewRate { get { return m_FrequencySlewRate; } set { if (OnPropertyChanging("LevelAudioObstructionAsset." + nameof(FrequencySlewRate), this, m_FrequencySlewRate, value)) m_FrequencySlewRate = value; } } // 0x10 (16)
		
		protected float m_GainSlewRate = new float();
		[ContainerField(20), LayoutImmutable, Blittable, ContainerFieldNameHash(56498091)]
		public float GainSlewRate { get { return m_GainSlewRate; } set { if (OnPropertyChanging("LevelAudioObstructionAsset." + nameof(GainSlewRate), this, m_GainSlewRate, value)) m_GainSlewRate = value; } } // 0x14 (20)
		
		protected float m_MaxRaycastDistanceSquared = new float();
		[ContainerField(24), LayoutImmutable, Blittable, ContainerFieldNameHash(1365527576)]
		public float MaxRaycastDistanceSquared { get { return m_MaxRaycastDistanceSquared; } set { if (OnPropertyChanging("LevelAudioObstructionAsset." + nameof(MaxRaycastDistanceSquared), this, m_MaxRaycastDistanceSquared, value)) m_MaxRaycastDistanceSquared = value; } } // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2868170514:
					MaterialMap = (List<AudioObstructionMaterialInfo>) p_Value;
					break;

				case 1368142094:
					FrequencySlewRate = (float) p_Value;
					break;

				case 56498091:
					GainSlewRate = (float) p_Value;
					break;

				case 1365527576:
					MaxRaycastDistanceSquared = (float) p_Value;
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
				case 2868170514:
					return MaterialMap;

				case 1368142094:
					return FrequencySlewRate;

				case 56498091:
					return GainSlewRate;

				case 1365527576:
					return MaxRaycastDistanceSquared;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2868170514:
					return typeof(LevelAudioObstructionAsset).GetProperty(nameof(MaterialMap));

				case 1368142094:
					return typeof(LevelAudioObstructionAsset).GetProperty(nameof(FrequencySlewRate));

				case 56498091:
					return typeof(LevelAudioObstructionAsset).GetProperty(nameof(GainSlewRate));

				case 1365527576:
					return typeof(LevelAudioObstructionAsset).GetProperty(nameof(MaxRaycastDistanceSquared));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
