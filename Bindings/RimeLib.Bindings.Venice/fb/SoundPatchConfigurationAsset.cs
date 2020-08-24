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
	[ContainerType(4), MemberInfoFlag(53), ContainerClass]
	public class SoundPatchConfigurationAsset : 
		SoundAsset
	{
		protected CtrRef<SoundPatchAsset> m_Sound = new CtrRef<SoundPatchAsset>();
		[ContainerField(16), MemberInfoFlag(53), ContainerFieldNameHash(231353798), ContainerCtrRef]
		public CtrRef<SoundPatchAsset> Sound { get { return m_Sound; } set { if (OnPropertyChanging("SoundPatchConfigurationAsset." + nameof(Sound), this, m_Sound, value)) m_Sound = value; } } // 0x10 (16)
		
		protected RefArray<SoundPatchConfigurationEntry> m_Entries = new RefArray<SoundPatchConfigurationEntry>();
		[ContainerField(20), MemberInfoFlag(65), ContainerFieldNameHash(8238103), ContainerRefArray]
		public RefArray<SoundPatchConfigurationEntry> Entries { get { return m_Entries; } set { if (OnPropertyChanging("SoundPatchConfigurationAsset." + nameof(Entries), this, m_Entries, value)) m_Entries = value; } } // 0x14 (20)
		
		protected float m_Loudness = new float();
		[ContainerField(24), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2678891068)]
		public float Loudness { get { return m_Loudness; } set { if (OnPropertyChanging("SoundPatchConfigurationAsset." + nameof(Loudness), this, m_Loudness, value)) m_Loudness = value; } } // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 231353798:
					Sound = (CtrRef<SoundPatchAsset>) p_Value;
					break;

				case 8238103:
					Entries = (RefArray<SoundPatchConfigurationEntry>) p_Value;
					break;

				case 2678891068:
					Loudness = (float) p_Value;
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

				case 8238103:
					return Entries;

				case 2678891068:
					return Loudness;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 231353798:
					return typeof(SoundPatchConfigurationAsset).GetProperty(nameof(Sound));

				case 8238103:
					return typeof(SoundPatchConfigurationAsset).GetProperty(nameof(Entries));

				case 2678891068:
					return typeof(SoundPatchConfigurationAsset).GetProperty(nameof(Loudness));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
