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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 28)]
	public class BigWorldSetting : 
		DataContainer
	{
		protected CtrRef<SoundAsset> m_Sound = new CtrRef<SoundAsset>();
		[ContainerField(Name: "Sound", Offset: 8, NameHash: 231353798, Flags: 53)]
		public CtrRef<SoundAsset> Sound { get { return m_Sound; } set { if (OnPropertyChanging("BigWorldSetting." + nameof(Sound), this, m_Sound, value)) m_Sound = value; } } // 0x8 (8)
		
		protected int m_MinDistance = new int();
		[ContainerField(Name: "MinDistance", Offset: 12, NameHash: 1885855628, Flags: 49405), LayoutImmutable, Blittable]
		public int MinDistance { get { return m_MinDistance; } set { if (OnPropertyChanging("BigWorldSetting." + nameof(MinDistance), this, m_MinDistance, value)) m_MinDistance = value; } } // 0xC (12)
		
		protected int m_MaxDistance = new int();
		[ContainerField(Name: "MaxDistance", Offset: 16, NameHash: 3520454034, Flags: 49405), LayoutImmutable, Blittable]
		public int MaxDistance { get { return m_MaxDistance; } set { if (OnPropertyChanging("BigWorldSetting." + nameof(MaxDistance), this, m_MaxDistance, value)) m_MaxDistance = value; } } // 0x10 (16)
		
		protected float m_MinDelayTimeInMinutes = new float();
		[ContainerField(Name: "MinDelayTimeInMinutes", Offset: 20, NameHash: 381594133, Flags: 49469), LayoutImmutable, Blittable]
		public float MinDelayTimeInMinutes { get { return m_MinDelayTimeInMinutes; } set { if (OnPropertyChanging("BigWorldSetting." + nameof(MinDelayTimeInMinutes), this, m_MinDelayTimeInMinutes, value)) m_MinDelayTimeInMinutes = value; } } // 0x14 (20)
		
		protected float m_MaxDelayTimeInMinutes = new float();
		[ContainerField(Name: "MaxDelayTimeInMinutes", Offset: 24, NameHash: 741272203, Flags: 49469), LayoutImmutable, Blittable]
		public float MaxDelayTimeInMinutes { get { return m_MaxDelayTimeInMinutes; } set { if (OnPropertyChanging("BigWorldSetting." + nameof(MaxDelayTimeInMinutes), this, m_MaxDelayTimeInMinutes, value)) m_MaxDelayTimeInMinutes = value; } } // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 231353798:
					Sound = (CtrRef<SoundAsset>) p_Value;
					break;

				case 1885855628:
					MinDistance = (int) p_Value;
					break;

				case 3520454034:
					MaxDistance = (int) p_Value;
					break;

				case 381594133:
					MinDelayTimeInMinutes = (float) p_Value;
					break;

				case 741272203:
					MaxDelayTimeInMinutes = (float) p_Value;
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

				case 1885855628:
					return MinDistance;

				case 3520454034:
					return MaxDistance;

				case 381594133:
					return MinDelayTimeInMinutes;

				case 741272203:
					return MaxDelayTimeInMinutes;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 231353798:
					return typeof(BigWorldSetting).GetProperty(nameof(Sound));

				case 1885855628:
					return typeof(BigWorldSetting).GetProperty(nameof(MinDistance));

				case 3520454034:
					return typeof(BigWorldSetting).GetProperty(nameof(MaxDistance));

				case 381594133:
					return typeof(BigWorldSetting).GetProperty(nameof(MinDelayTimeInMinutes));

				case 741272203:
					return typeof(BigWorldSetting).GetProperty(nameof(MaxDelayTimeInMinutes));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
