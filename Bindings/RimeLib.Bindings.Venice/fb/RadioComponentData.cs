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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 112)]
	public class RadioComponentData : 
		ComponentData
	{
		protected CtrRef<SoundAsset> m_SoundEffect = new CtrRef<SoundAsset>();
		[ContainerField(Name: "SoundEffect", Offset: 96, NameHash: 3556609201, Flags: 53)]
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
