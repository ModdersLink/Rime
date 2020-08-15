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
	public class RadioComponentData : 
		ComponentData
	{
		protected CtrRef<SoundAsset> m_SoundEffect = new CtrRef<SoundAsset>();
		[ContainerField(96), ContainerFieldNameHash(3556609201)]
		public CtrRef<SoundAsset> SoundEffect { get { return m_SoundEffect; } set { if (OnPropertyChanging("RadioComponentData." + nameof(SoundEffect), this, m_SoundEffect, value)) m_SoundEffect = value; } } // 0x60 (96)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3556609201:
					SoundEffect = (CtrRef<SoundAsset>) p_Value;
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
				case 3556609201:
					return SoundEffect;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3556609201:
					return typeof(RadioComponentData).GetProperty(nameof(SoundEffect));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
