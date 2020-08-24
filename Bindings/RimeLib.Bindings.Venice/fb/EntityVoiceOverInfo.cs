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
	public class EntityVoiceOverInfo : 
		DataContainer
	{
		protected CtrRef<VoiceOverObject> m_VoiceOverType = new CtrRef<VoiceOverObject>();
		[ContainerField(8), MemberInfoFlag(53), ContainerFieldNameHash(1260359781), ContainerCtrRef]
		public CtrRef<VoiceOverObject> VoiceOverType { get { return m_VoiceOverType; } set { if (OnPropertyChanging("EntityVoiceOverInfo." + nameof(VoiceOverType), this, m_VoiceOverType, value)) m_VoiceOverType = value; } } // 0x8 (8)
		
		protected RefArray<VoiceOverLabel> m_Labels = new RefArray<VoiceOverLabel>();
		[ContainerField(12), MemberInfoFlag(65), ContainerFieldNameHash(2902520752), ContainerRefArray]
		public RefArray<VoiceOverLabel> Labels { get { return m_Labels; } set { if (OnPropertyChanging("EntityVoiceOverInfo." + nameof(Labels), this, m_Labels, value)) m_Labels = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1260359781:
					VoiceOverType = (CtrRef<VoiceOverObject>) p_Value;
					break;

				case 2902520752:
					Labels = (RefArray<VoiceOverLabel>) p_Value;
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
				case 1260359781:
					return VoiceOverType;

				case 2902520752:
					return Labels;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1260359781:
					return typeof(EntityVoiceOverInfo).GetProperty(nameof(VoiceOverType));

				case 2902520752:
					return typeof(EntityVoiceOverInfo).GetProperty(nameof(Labels));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
