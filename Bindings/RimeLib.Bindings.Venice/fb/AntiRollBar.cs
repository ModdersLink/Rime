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
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 4,  Flags: 53, Size: 16)]
	public class AntiRollBar : 
		DataContainer
	{
		protected float m_Stiffness = new float();
		[ContainerField(Name: "Stiffness", Offset: 8, NameHash: 721813632, Flags: 49469), LayoutImmutable, Blittable]
		public float Stiffness { get { return m_Stiffness; } set { if (OnPropertyChanging("AntiRollBar." + nameof(Stiffness), this, m_Stiffness, value)) m_Stiffness = value; } } // 0x8 (8)
		
		protected float m_TorqueActivationLimit = new float();
		[ContainerField(Name: "TorqueActivationLimit", Offset: 12, NameHash: 2156176460, Flags: 49469), LayoutImmutable, Blittable]
		public float TorqueActivationLimit { get { return m_TorqueActivationLimit; } set { if (OnPropertyChanging("AntiRollBar." + nameof(TorqueActivationLimit), this, m_TorqueActivationLimit, value)) m_TorqueActivationLimit = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 721813632:
					Stiffness = (float) p_Value;
					break;

				case 2156176460:
					TorqueActivationLimit = (float) p_Value;
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
				case 721813632:
					return Stiffness;

				case 2156176460:
					return TorqueActivationLimit;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 721813632:
					return typeof(AntiRollBar).GetProperty(nameof(Stiffness));

				case 2156176460:
					return typeof(AntiRollBar).GetProperty(nameof(TorqueActivationLimit));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
