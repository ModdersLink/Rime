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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 20)]
	public class MixerEntityData : 
		EntityData
	{
		protected CtrRef<MixerAsset> m_Mixer = new CtrRef<MixerAsset>();
		[ContainerField(Name: "Mixer", Offset: 12, NameHash: 209965422, Flags: 53)]
		public CtrRef<MixerAsset> Mixer { get { return m_Mixer; } set { if (OnPropertyChanging("MixerEntityData." + nameof(Mixer), this, m_Mixer, value)) m_Mixer = value; } } // 0xC (12)
		
		protected bool m_ActivateOnCreation = new bool();
		[ContainerField(Name: "ActivateOnCreation", Offset: 16, NameHash: 787232532, Flags: 49325), LayoutImmutable, Blittable]
		public bool ActivateOnCreation { get { return m_ActivateOnCreation; } set { if (OnPropertyChanging("MixerEntityData." + nameof(ActivateOnCreation), this, m_ActivateOnCreation, value)) m_ActivateOnCreation = value; } } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 209965422:
					Mixer = (CtrRef<MixerAsset>) p_Value;
					break;

				case 787232532:
					ActivateOnCreation = (bool) p_Value;
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
				case 209965422:
					return Mixer;

				case 787232532:
					return ActivateOnCreation;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 209965422:
					return typeof(MixerEntityData).GetProperty(nameof(Mixer));

				case 787232532:
					return typeof(MixerEntityData).GetProperty(nameof(ActivateOnCreation));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
