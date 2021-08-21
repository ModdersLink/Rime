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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 24)]
	public class DetonatedWeaponData : 
		WeaponData
	{
		protected CtrRef<LockingControllerData> m_LockingController = new CtrRef<LockingControllerData>();
		[ContainerField(Name: "LockingController", Offset: 16, NameHash: 1783566994, Flags: 53)]
		public CtrRef<LockingControllerData> LockingController { get { return m_LockingController; } set { if (OnPropertyChanging("DetonatedWeaponData." + nameof(LockingController), this, m_LockingController, value)) m_LockingController = value; } } // 0x10 (16)
		
		protected float m_Range = new float();
		[ContainerField(Name: "Range", Offset: 20, NameHash: 230112826, Flags: 49469), LayoutImmutable, Blittable]
		public float Range { get { return m_Range; } set { if (OnPropertyChanging("DetonatedWeaponData." + nameof(Range), this, m_Range, value)) m_Range = value; } } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1783566994:
					LockingController = (CtrRef<LockingControllerData>) p_Value;
					break;

				case 230112826:
					Range = (float) p_Value;
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
				case 1783566994:
					return LockingController;

				case 230112826:
					return Range;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1783566994:
					return typeof(DetonatedWeaponData).GetProperty(nameof(LockingController));

				case 230112826:
					return typeof(DetonatedWeaponData).GetProperty(nameof(Range));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
