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
	[ContainerType(16), MemberInfoFlag(53), ContainerSize(112), ContainerClass]
	public class SoldierSoundComponentData : 
		ComponentData
	{
		protected float m_WalkVelocityThreshold = new float();
		[ContainerField(96), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2022862740)]
		public float WalkVelocityThreshold { get { return m_WalkVelocityThreshold; } set { if (OnPropertyChanging("SoldierSoundComponentData." + nameof(WalkVelocityThreshold), this, m_WalkVelocityThreshold, value)) m_WalkVelocityThreshold = value; } } // 0x60 (96)
		
		protected float m_RunVelocityThreshold = new float();
		[ContainerField(100), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(37427148)]
		public float RunVelocityThreshold { get { return m_RunVelocityThreshold; } set { if (OnPropertyChanging("SoldierSoundComponentData." + nameof(RunVelocityThreshold), this, m_RunVelocityThreshold, value)) m_RunVelocityThreshold = value; } } // 0x64 (100)
		
		protected float m_WalkPeriod = new float();
		[ContainerField(104), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2834426449)]
		public float WalkPeriod { get { return m_WalkPeriod; } set { if (OnPropertyChanging("SoldierSoundComponentData." + nameof(WalkPeriod), this, m_WalkPeriod, value)) m_WalkPeriod = value; } } // 0x68 (104)
		
		protected float m_RunPeriod = new float();
		[ContainerField(108), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(877844489)]
		public float RunPeriod { get { return m_RunPeriod; } set { if (OnPropertyChanging("SoldierSoundComponentData." + nameof(RunPeriod), this, m_RunPeriod, value)) m_RunPeriod = value; } } // 0x6C (108)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2022862740:
					WalkVelocityThreshold = (float) p_Value;
					break;

				case 37427148:
					RunVelocityThreshold = (float) p_Value;
					break;

				case 2834426449:
					WalkPeriod = (float) p_Value;
					break;

				case 877844489:
					RunPeriod = (float) p_Value;
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
				case 2022862740:
					return WalkVelocityThreshold;

				case 37427148:
					return RunVelocityThreshold;

				case 2834426449:
					return WalkPeriod;

				case 877844489:
					return RunPeriod;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2022862740:
					return typeof(SoldierSoundComponentData).GetProperty(nameof(WalkVelocityThreshold));

				case 37427148:
					return typeof(SoldierSoundComponentData).GetProperty(nameof(RunVelocityThreshold));

				case 2834426449:
					return typeof(SoldierSoundComponentData).GetProperty(nameof(WalkPeriod));

				case 877844489:
					return typeof(SoldierSoundComponentData).GetProperty(nameof(RunPeriod));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
