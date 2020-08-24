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
	[ContainerType(16), MemberInfoFlag(53), ContainerClass]
	public class SoundEntityData : 
		EntityData
	{
		protected LinearTransform m_Transform = new LinearTransform();
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(2270319721)]
		public LinearTransform Transform { get { return m_Transform; } set { if (OnPropertyChanging("SoundEntityData." + nameof(Transform), this, m_Transform, value)) m_Transform = value; } } // 0x10 (16)
		
		protected CtrRef<SoundAsset> m_Sound = new CtrRef<SoundAsset>();
		[ContainerField(80), MemberInfoFlag(53), ContainerFieldNameHash(231353798), ContainerCtrRef]
		public CtrRef<SoundAsset> Sound { get { return m_Sound; } set { if (OnPropertyChanging("SoundEntityData." + nameof(Sound), this, m_Sound, value)) m_Sound = value; } } // 0x50 (80)
		
		protected int m_ObstructionHandle = new int();
		[ContainerField(84), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(2253671389)]
		public int ObstructionHandle { get { return m_ObstructionHandle; } set { if (OnPropertyChanging("SoundEntityData." + nameof(ObstructionHandle), this, m_ObstructionHandle, value)) m_ObstructionHandle = value; } } // 0x54 (84)
		
		protected bool m_PlayOnCreation = new bool();
		[ContainerField(88), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2168204873)]
		public bool PlayOnCreation { get { return m_PlayOnCreation; } set { if (OnPropertyChanging("SoundEntityData." + nameof(PlayOnCreation), this, m_PlayOnCreation, value)) m_PlayOnCreation = value; } } // 0x58 (88)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2270319721:
					Transform = (LinearTransform) p_Value;
					break;

				case 231353798:
					Sound = (CtrRef<SoundAsset>) p_Value;
					break;

				case 2253671389:
					ObstructionHandle = (int) p_Value;
					break;

				case 2168204873:
					PlayOnCreation = (bool) p_Value;
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
				case 2270319721:
					return Transform;

				case 231353798:
					return Sound;

				case 2253671389:
					return ObstructionHandle;

				case 2168204873:
					return PlayOnCreation;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2270319721:
					return typeof(SoundEntityData).GetProperty(nameof(Transform));

				case 231353798:
					return typeof(SoundEntityData).GetProperty(nameof(Sound));

				case 2253671389:
					return typeof(SoundEntityData).GetProperty(nameof(ObstructionHandle));

				case 2168204873:
					return typeof(SoundEntityData).GetProperty(nameof(PlayOnCreation));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
