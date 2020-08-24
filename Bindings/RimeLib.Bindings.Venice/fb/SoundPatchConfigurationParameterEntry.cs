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
	public class SoundPatchConfigurationParameterEntry : 
		SoundPatchConfigurationEntry
	{
		protected uint m_NameHash = new uint();
		[ContainerField(8), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(994057744)]
		public uint NameHash { get { return m_NameHash; } set { if (OnPropertyChanging("SoundPatchConfigurationParameterEntry." + nameof(NameHash), this, m_NameHash, value)) m_NameHash = value; } } // 0x8 (8)
		
		protected float m_Value = new float();
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(225375086)]
		public float Value { get { return m_Value; } set { if (OnPropertyChanging("SoundPatchConfigurationParameterEntry." + nameof(Value), this, m_Value, value)) m_Value = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 994057744:
					NameHash = (uint) p_Value;
					break;

				case 225375086:
					Value = (float) p_Value;
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
				case 994057744:
					return NameHash;

				case 225375086:
					return Value;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 994057744:
					return typeof(SoundPatchConfigurationParameterEntry).GetProperty(nameof(NameHash));

				case 225375086:
					return typeof(SoundPatchConfigurationParameterEntry).GetProperty(nameof(Value));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
