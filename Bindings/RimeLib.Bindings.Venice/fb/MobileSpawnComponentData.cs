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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 128)]
	public class MobileSpawnComponentData : 
		ComponentData
	{
		protected float m_ParachuteSpawnRadiusMin = new float();
		[ContainerField(Name: "ParachuteSpawnRadiusMin", Offset: 96, NameHash: 4214298113, Flags: 49469), LayoutImmutable, Blittable]
		public float ParachuteSpawnRadiusMin { get { return m_ParachuteSpawnRadiusMin; } set { if (OnPropertyChanging("MobileSpawnComponentData." + nameof(ParachuteSpawnRadiusMin), this, m_ParachuteSpawnRadiusMin, value)) m_ParachuteSpawnRadiusMin = value; } } // 0x60 (96)
		
		protected float m_ParachuteSpawnDistance = new float();
		[ContainerField(Name: "ParachuteSpawnDistance", Offset: 100, NameHash: 432257168, Flags: 49469), LayoutImmutable, Blittable]
		public float ParachuteSpawnDistance { get { return m_ParachuteSpawnDistance; } set { if (OnPropertyChanging("MobileSpawnComponentData." + nameof(ParachuteSpawnDistance), this, m_ParachuteSpawnDistance, value)) m_ParachuteSpawnDistance = value; } } // 0x64 (100)
		
		protected string m_NameSid = string.Empty;
		[ContainerField(Name: "NameSid", Offset: 104, NameHash: 3153745340, Flags: 16509), LayoutImmutable]
		public string NameSid { get { return m_NameSid; } set { if (OnPropertyChanging("MobileSpawnComponentData." + nameof(NameSid), this, m_NameSid, value)) m_NameSid = value; } } // 0x68 (104)
		
		protected float m_ParachuteSpawnRadiusMax = new float();
		[ContainerField(Name: "ParachuteSpawnRadiusMax", Offset: 108, NameHash: 4214297887, Flags: 49469), LayoutImmutable, Blittable]
		public float ParachuteSpawnRadiusMax { get { return m_ParachuteSpawnRadiusMax; } set { if (OnPropertyChanging("MobileSpawnComponentData." + nameof(ParachuteSpawnRadiusMax), this, m_ParachuteSpawnRadiusMax, value)) m_ParachuteSpawnRadiusMax = value; } } // 0x6C (108)
		
		protected bool m_EnterMobileSpawnPoint = new bool();
		[ContainerField(Name: "EnterMobileSpawnPoint", Offset: 112, NameHash: 1286056314, Flags: 49325), LayoutImmutable, Blittable]
		public bool EnterMobileSpawnPoint { get { return m_EnterMobileSpawnPoint; } set { if (OnPropertyChanging("MobileSpawnComponentData." + nameof(EnterMobileSpawnPoint), this, m_EnterMobileSpawnPoint, value)) m_EnterMobileSpawnPoint = value; } } // 0x70 (112)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4214298113:
					ParachuteSpawnRadiusMin = (float) p_Value;
					break;

				case 432257168:
					ParachuteSpawnDistance = (float) p_Value;
					break;

				case 3153745340:
					NameSid = (string) p_Value;
					break;

				case 4214297887:
					ParachuteSpawnRadiusMax = (float) p_Value;
					break;

				case 1286056314:
					EnterMobileSpawnPoint = (bool) p_Value;
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
				case 4214298113:
					return ParachuteSpawnRadiusMin;

				case 432257168:
					return ParachuteSpawnDistance;

				case 3153745340:
					return NameSid;

				case 4214297887:
					return ParachuteSpawnRadiusMax;

				case 1286056314:
					return EnterMobileSpawnPoint;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4214298113:
					return typeof(MobileSpawnComponentData).GetProperty(nameof(ParachuteSpawnRadiusMin));

				case 432257168:
					return typeof(MobileSpawnComponentData).GetProperty(nameof(ParachuteSpawnDistance));

				case 3153745340:
					return typeof(MobileSpawnComponentData).GetProperty(nameof(NameSid));

				case 4214297887:
					return typeof(MobileSpawnComponentData).GetProperty(nameof(ParachuteSpawnRadiusMax));

				case 1286056314:
					return typeof(MobileSpawnComponentData).GetProperty(nameof(EnterMobileSpawnPoint));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
