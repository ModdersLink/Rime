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
	[ContainerType(16)]
	public class MobileSpawnComponentData : 
		ComponentData
	{
		protected float m_ParachuteSpawnRadiusMin = new float();
		[ContainerField(96), LayoutImmutable, Blittable, ContainerFieldNameHash(4214298113)]
		public float ParachuteSpawnRadiusMin { get { return m_ParachuteSpawnRadiusMin; } set { if (OnPropertyChanging("MobileSpawnComponentData." + nameof(ParachuteSpawnRadiusMin), this, m_ParachuteSpawnRadiusMin, value)) m_ParachuteSpawnRadiusMin = value; } } // 0x60 (96)
		
		protected float m_ParachuteSpawnDistance = new float();
		[ContainerField(100), LayoutImmutable, Blittable, ContainerFieldNameHash(432257168)]
		public float ParachuteSpawnDistance { get { return m_ParachuteSpawnDistance; } set { if (OnPropertyChanging("MobileSpawnComponentData." + nameof(ParachuteSpawnDistance), this, m_ParachuteSpawnDistance, value)) m_ParachuteSpawnDistance = value; } } // 0x64 (100)
		
		protected string m_NameSid = string.Empty;
		[ContainerField(104), LayoutImmutable, ContainerFieldNameHash(3153745340)]
		public string NameSid { get { return m_NameSid; } set { if (OnPropertyChanging("MobileSpawnComponentData." + nameof(NameSid), this, m_NameSid, value)) m_NameSid = value; } } // 0x68 (104)
		
		protected float m_ParachuteSpawnRadiusMax = new float();
		[ContainerField(108), LayoutImmutable, Blittable, ContainerFieldNameHash(4214297887)]
		public float ParachuteSpawnRadiusMax { get { return m_ParachuteSpawnRadiusMax; } set { if (OnPropertyChanging("MobileSpawnComponentData." + nameof(ParachuteSpawnRadiusMax), this, m_ParachuteSpawnRadiusMax, value)) m_ParachuteSpawnRadiusMax = value; } } // 0x6C (108)
		
		protected bool m_EnterMobileSpawnPoint = new bool();
		[ContainerField(112), LayoutImmutable, Blittable, ContainerFieldNameHash(1286056314)]
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
