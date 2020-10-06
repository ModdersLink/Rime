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
	[ContainerType(16), MemberInfoFlag(53), ContainerSize(96), ContainerClass]
	public class MeleeTriggerEntityData : 
		EntityData
	{
		protected LinearTransform m_ConnectTransform = new LinearTransform();
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(1194494871)]
		public LinearTransform ConnectTransform { get { return m_ConnectTransform; } set { if (OnPropertyChanging("MeleeTriggerEntityData." + nameof(ConnectTransform), this, m_ConnectTransform, value)) m_ConnectTransform = value; } } // 0x10 (16)
		
		protected CtrRef<AntEnumeration> m_MeleeType = new CtrRef<AntEnumeration>();
		[ContainerField(80), MemberInfoFlag(53), ContainerFieldNameHash(2762192025), ContainerCtrRef]
		public CtrRef<AntEnumeration> MeleeType { get { return m_MeleeType; } set { if (OnPropertyChanging("MeleeTriggerEntityData." + nameof(MeleeType), this, m_MeleeType, value)) m_MeleeType = value; } } // 0x50 (80)
		
		protected bool m_MeleeEnabled = new bool();
		[ContainerField(84), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1976811876)]
		public bool MeleeEnabled { get { return m_MeleeEnabled; } set { if (OnPropertyChanging("MeleeTriggerEntityData." + nameof(MeleeEnabled), this, m_MeleeEnabled, value)) m_MeleeEnabled = value; } } // 0x54 (84)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1194494871:
					ConnectTransform = (LinearTransform) p_Value;
					break;

				case 2762192025:
					MeleeType = (CtrRef<AntEnumeration>) p_Value;
					break;

				case 1976811876:
					MeleeEnabled = (bool) p_Value;
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
				case 1194494871:
					return ConnectTransform;

				case 2762192025:
					return MeleeType;

				case 1976811876:
					return MeleeEnabled;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1194494871:
					return typeof(MeleeTriggerEntityData).GetProperty(nameof(ConnectTransform));

				case 2762192025:
					return typeof(MeleeTriggerEntityData).GetProperty(nameof(MeleeType));

				case 1976811876:
					return typeof(MeleeTriggerEntityData).GetProperty(nameof(MeleeEnabled));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
