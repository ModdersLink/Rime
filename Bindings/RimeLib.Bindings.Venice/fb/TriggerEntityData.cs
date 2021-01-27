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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 112)]
	public class TriggerEntityData : 
		GameEntityData
	{
		protected float m_Delay = new float();
		[ContainerField(Name: "Delay", Offset: 96, NameHash: 208768368, Flags: 49469), LayoutImmutable, Blittable]
		public float Delay { get { return m_Delay; } set { if (OnPropertyChanging("TriggerEntityData." + nameof(Delay), this, m_Delay, value)) m_Delay = value; } } // 0x60 (96)
		
		protected bool m_RunOnce = new bool();
		[ContainerField(Name: "RunOnce", Offset: 100, NameHash: 709901739, Flags: 49325), LayoutImmutable, Blittable]
		public bool RunOnce { get { return m_RunOnce; } set { if (OnPropertyChanging("TriggerEntityData." + nameof(RunOnce), this, m_RunOnce, value)) m_RunOnce = value; } } // 0x64 (100)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 208768368:
					Delay = (float) p_Value;
					break;

				case 709901739:
					RunOnce = (bool) p_Value;
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
				case 208768368:
					return Delay;

				case 709901739:
					return RunOnce;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 208768368:
					return typeof(TriggerEntityData).GetProperty(nameof(Delay));

				case 709901739:
					return typeof(TriggerEntityData).GetProperty(nameof(RunOnce));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
