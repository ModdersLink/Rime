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
	public class CameraComponentSoundData : 
		DataContainer
	{
		protected CtrRef<SoundAsset> m_SwitchToAlternateViewSound = new CtrRef<SoundAsset>();
		[ContainerField(8), ContainerFieldNameHash(1181169106)]
		public CtrRef<SoundAsset> SwitchToAlternateViewSound { get { return m_SwitchToAlternateViewSound; } set { if (OnPropertyChanging("CameraComponentSoundData." + nameof(SwitchToAlternateViewSound), this, m_SwitchToAlternateViewSound, value)) m_SwitchToAlternateViewSound = value; } } // 0x8 (8)
		
		protected CtrRef<SoundAsset> m_SwitchToNormalViewSound = new CtrRef<SoundAsset>();
		[ContainerField(12), ContainerFieldNameHash(3067038865)]
		public CtrRef<SoundAsset> SwitchToNormalViewSound { get { return m_SwitchToNormalViewSound; } set { if (OnPropertyChanging("CameraComponentSoundData." + nameof(SwitchToNormalViewSound), this, m_SwitchToNormalViewSound, value)) m_SwitchToNormalViewSound = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1181169106:
					SwitchToAlternateViewSound = (CtrRef<SoundAsset>) p_Value;
					break;

				case 3067038865:
					SwitchToNormalViewSound = (CtrRef<SoundAsset>) p_Value;
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
				case 1181169106:
					return SwitchToAlternateViewSound;

				case 3067038865:
					return SwitchToNormalViewSound;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1181169106:
					return typeof(CameraComponentSoundData).GetProperty(nameof(SwitchToAlternateViewSound));

				case 3067038865:
					return typeof(CameraComponentSoundData).GetProperty(nameof(SwitchToNormalViewSound));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
