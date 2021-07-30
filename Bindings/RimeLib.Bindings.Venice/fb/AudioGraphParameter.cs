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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 20)]
	public class AudioGraphParameter : 
		DataContainer
	{
		protected float m_DefaultValue = new float();
		[ContainerField(Name: "DefaultValue", Offset: 8, NameHash: 2066049125, Flags: 49469), LayoutImmutable, Blittable]
		public float DefaultValue { get { return m_DefaultValue; } set { if (OnPropertyChanging("AudioGraphParameter." + nameof(DefaultValue), this, m_DefaultValue, value)) m_DefaultValue = value; } } // 0x8 (8)
		
		protected uint m_NameHash = new uint();
		[ContainerField(Name: "NameHash", Offset: 12, NameHash: 994057744, Flags: 49421), LayoutImmutable, Blittable]
		public uint NameHash { get { return m_NameHash; } set { if (OnPropertyChanging("AudioGraphParameter." + nameof(NameHash), this, m_NameHash, value)) m_NameHash = value; } } // 0xC (12)
		
		protected ushort m_ValueIndex = new ushort();
		[ContainerField(Name: "ValueIndex", Offset: 16, NameHash: 2085408208, Flags: 49389), LayoutImmutable, Blittable]
		public ushort ValueIndex { get { return m_ValueIndex; } set { if (OnPropertyChanging("AudioGraphParameter." + nameof(ValueIndex), this, m_ValueIndex, value)) m_ValueIndex = value; } } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2066049125:
					DefaultValue = (float) p_Value;
					break;

				case 994057744:
					NameHash = (uint) p_Value;
					break;

				case 2085408208:
					ValueIndex = (ushort) p_Value;
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
				case 2066049125:
					return DefaultValue;

				case 994057744:
					return NameHash;

				case 2085408208:
					return ValueIndex;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2066049125:
					return typeof(AudioGraphParameter).GetProperty(nameof(DefaultValue));

				case 994057744:
					return typeof(AudioGraphParameter).GetProperty(nameof(NameHash));

				case 2085408208:
					return typeof(AudioGraphParameter).GetProperty(nameof(ValueIndex));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
