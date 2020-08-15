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
	public class RichPresencePresenceString : 
		DataContainer
	{
		protected string m_SID = new string();
		[ContainerField(8), LayoutImmutable, ContainerFieldNameHash(193467547)]
		public string SID { get { return m_SID; } set { if (OnPropertyChanging("RichPresencePresenceString." + nameof(SID), this, m_SID, value)) m_SID = value; } } // 0x8 (8)
		
		protected bool m_Interpolated = new bool();
		[ContainerField(12), LayoutImmutable, Blittable, ContainerFieldNameHash(3956040102)]
		public bool Interpolated { get { return m_Interpolated; } set { if (OnPropertyChanging("RichPresencePresenceString." + nameof(Interpolated), this, m_Interpolated, value)) m_Interpolated = value; } } // 0xC (12)
		
		protected sbyte m_Index = new sbyte();
		[ContainerField(13), LayoutImmutable, Blittable, ContainerFieldNameHash(214509467)]
		public sbyte Index { get { return m_Index; } set { if (OnPropertyChanging("RichPresencePresenceString." + nameof(Index), this, m_Index, value)) m_Index = value; } } // 0xD (13)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 193467547:
					SID = (string) p_Value;
					break;

				case 3956040102:
					Interpolated = (bool) p_Value;
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
				case 193467547:
					return SID;

				case 3956040102:
					return Interpolated;

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
				case 193467547:
					return typeof(RichPresencePresenceString).GetProperty(nameof(SID));

				case 3956040102:
					return typeof(RichPresencePresenceString).GetProperty(nameof(Interpolated));

				case 214509467:
					return typeof(RichPresencePresenceString).GetProperty(nameof(Index));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
