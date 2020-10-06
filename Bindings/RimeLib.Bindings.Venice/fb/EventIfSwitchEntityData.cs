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
	[ContainerType(16), MemberInfoFlag(53), ContainerSize(112), ContainerClass]
	public class EventIfSwitchEntityData : 
		GameEntityData
	{
		protected bool m_RunOnce = new bool();
		[ContainerField(96), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(709901739)]
		public bool RunOnce { get { return m_RunOnce; } set { if (OnPropertyChanging("EventIfSwitchEntityData." + nameof(RunOnce), this, m_RunOnce, value)) m_RunOnce = value; } } // 0x60 (96)
		
		protected bool m_StartState = new bool();
		[ContainerField(97), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2753617170)]
		public bool StartState { get { return m_StartState; } set { if (OnPropertyChanging("EventIfSwitchEntityData." + nameof(StartState), this, m_StartState, value)) m_StartState = value; } } // 0x61 (97)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 709901739:
					RunOnce = (bool) p_Value;
					break;

				case 2753617170:
					StartState = (bool) p_Value;
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

				case 2753617170:
					return StartState;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 709901739:
					return typeof(EventIfSwitchEntityData).GetProperty(nameof(RunOnce));

				case 2753617170:
					return typeof(EventIfSwitchEntityData).GetProperty(nameof(StartState));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
