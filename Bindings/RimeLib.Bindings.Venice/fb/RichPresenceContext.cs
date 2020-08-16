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
	public class RichPresenceContext : 
		DataContainer
	{
		protected string m_Name = string.Empty;
		[ContainerField(8), LayoutImmutable, ContainerFieldNameHash(2088949890)]
		public string Name { get { return m_Name; } set { if (OnPropertyChanging("RichPresenceContext." + nameof(Name), this, m_Name, value)) m_Name = value; } } // 0x8 (8)
		
		protected RefArray<RichPresenceContextValue> m_Values = new RefArray<RichPresenceContextValue>();
		[ContainerField(12), ContainerFieldNameHash(3142410589)]
		public RefArray<RichPresenceContextValue> Values { get { return m_Values; } set { if (OnPropertyChanging("RichPresenceContext." + nameof(Values), this, m_Values, value)) m_Values = value; } } // 0xC (12)
		
		protected CtrRef<RichPresenceContextValue> m_DefaultValue = new CtrRef<RichPresenceContextValue>();
		[ContainerField(16), ContainerFieldNameHash(2066049125)]
		public CtrRef<RichPresenceContextValue> DefaultValue { get { return m_DefaultValue; } set { if (OnPropertyChanging("RichPresenceContext." + nameof(DefaultValue), this, m_DefaultValue, value)) m_DefaultValue = value; } } // 0x10 (16)
		
		protected sbyte m_Index = new sbyte();
		[ContainerField(20), LayoutImmutable, Blittable, ContainerFieldNameHash(214509467)]
		public sbyte Index { get { return m_Index; } set { if (OnPropertyChanging("RichPresenceContext." + nameof(Index), this, m_Index, value)) m_Index = value; } } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2088949890:
					Name = (string) p_Value;
					break;

				case 3142410589:
					Values = (RefArray<RichPresenceContextValue>) p_Value;
					break;

				case 2066049125:
					DefaultValue = (CtrRef<RichPresenceContextValue>) p_Value;
					break;

				case 214509467:
					Index = (sbyte) p_Value;
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
				case 2088949890:
					return Name;

				case 3142410589:
					return Values;

				case 2066049125:
					return DefaultValue;

				case 214509467:
					return Index;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2088949890:
					return typeof(RichPresenceContext).GetProperty(nameof(Name));

				case 3142410589:
					return typeof(RichPresenceContext).GetProperty(nameof(Values));

				case 2066049125:
					return typeof(RichPresenceContext).GetProperty(nameof(DefaultValue));

				case 214509467:
					return typeof(RichPresenceContext).GetProperty(nameof(Index));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
