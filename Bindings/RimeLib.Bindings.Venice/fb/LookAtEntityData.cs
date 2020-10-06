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
	public class LookAtEntityData : 
		SpatialEntityData
	{
		protected bool m_RunOnce = new bool();
		[ContainerField(80), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(709901739)]
		public bool RunOnce { get { return m_RunOnce; } set { if (OnPropertyChanging("LookAtEntityData." + nameof(RunOnce), this, m_RunOnce, value)) m_RunOnce = value; } } // 0x50 (80)
		
		protected bool m_UseStaticDirection = new bool();
		[ContainerField(81), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(597626235)]
		public bool UseStaticDirection { get { return m_UseStaticDirection; } set { if (OnPropertyChanging("LookAtEntityData." + nameof(UseStaticDirection), this, m_UseStaticDirection, value)) m_UseStaticDirection = value; } } // 0x51 (81)
		
		protected bool m_Enabled = new bool();
		[ContainerField(82), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2662400)]
		public bool Enabled { get { return m_Enabled; } set { if (OnPropertyChanging("LookAtEntityData." + nameof(Enabled), this, m_Enabled, value)) m_Enabled = value; } } // 0x52 (82)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 709901739:
					RunOnce = (bool) p_Value;
					break;

				case 597626235:
					UseStaticDirection = (bool) p_Value;
					break;

				case 2662400:
					Enabled = (bool) p_Value;
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
				case 709901739:
					return RunOnce;

				case 597626235:
					return UseStaticDirection;

				case 2662400:
					return Enabled;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 709901739:
					return typeof(LookAtEntityData).GetProperty(nameof(RunOnce));

				case 597626235:
					return typeof(LookAtEntityData).GetProperty(nameof(UseStaticDirection));

				case 2662400:
					return typeof(LookAtEntityData).GetProperty(nameof(Enabled));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
