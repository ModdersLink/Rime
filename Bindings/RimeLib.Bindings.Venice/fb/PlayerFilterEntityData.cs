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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(20), ContainerClass]
	public class PlayerFilterEntityData : 
		EntityData
	{
		protected Realm m_Realm = new Realm();
		[ContainerField(12), MemberInfoFlag(137), ContainerFieldNameHash(229961746)]
		public Realm Realm { get { return m_Realm; } set { if (OnPropertyChanging("PlayerFilterEntityData." + nameof(Realm), this, m_Realm, value)) m_Realm = value; } } // 0xC (12)
		
		protected bool m_InvertFilter = new bool();
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2846947863)]
		public bool InvertFilter { get { return m_InvertFilter; } set { if (OnPropertyChanging("PlayerFilterEntityData." + nameof(InvertFilter), this, m_InvertFilter, value)) m_InvertFilter = value; } } // 0x10 (16)
		
		protected bool m_ForwardToSpectators = new bool();
		[ContainerField(17), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1753756911)]
		public bool ForwardToSpectators { get { return m_ForwardToSpectators; } set { if (OnPropertyChanging("PlayerFilterEntityData." + nameof(ForwardToSpectators), this, m_ForwardToSpectators, value)) m_ForwardToSpectators = value; } } // 0x11 (17)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 229961746:
					Realm = (Realm) Enum.ToObject(typeof(Realm), p_Value);
					break;

				case 2846947863:
					InvertFilter = (bool) p_Value;
					break;

				case 1753756911:
					ForwardToSpectators = (bool) p_Value;
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
				case 229961746:
					return Realm;

				case 2846947863:
					return InvertFilter;

				case 1753756911:
					return ForwardToSpectators;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 229961746:
					return typeof(PlayerFilterEntityData).GetProperty(nameof(Realm));

				case 2846947863:
					return typeof(PlayerFilterEntityData).GetProperty(nameof(InvertFilter));

				case 1753756911:
					return typeof(PlayerFilterEntityData).GetProperty(nameof(ForwardToSpectators));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
