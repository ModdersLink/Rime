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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 16)]
	public class VoiceOverDialogGroup : 
		DataContainer
	{
		protected CtrRef<SoundAsset> m_Sound = new CtrRef<SoundAsset>();
		[ContainerField(Name: "Sound", Offset: 8, NameHash: 231353798, Flags: 53)]
		public CtrRef<SoundAsset> Sound { get { return m_Sound; } set { if (OnPropertyChanging("VoiceOverDialogGroup." + nameof(Sound), this, m_Sound, value)) m_Sound = value; } } // 0x8 (8)
		
		protected RefArray<VoiceOverDialogTrack> m_Tracks = new RefArray<VoiceOverDialogTrack>();
		[ContainerField(Name: "Tracks", Offset: 12, NameHash: 3202301561, Flags: 65)]
		public RefArray<VoiceOverDialogTrack> Tracks { get { return m_Tracks; } set { if (OnPropertyChanging("VoiceOverDialogGroup." + nameof(Tracks), this, m_Tracks, value)) m_Tracks = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 231353798:
					Sound = (CtrRef<SoundAsset>) p_Value;
					break;

				case 3202301561:
					Tracks = (RefArray<VoiceOverDialogTrack>) p_Value;
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

				case 3202301561:
					return Tracks;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 231353798:
					return typeof(VoiceOverDialogGroup).GetProperty(nameof(Sound));

				case 3202301561:
					return typeof(VoiceOverDialogGroup).GetProperty(nameof(Tracks));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
