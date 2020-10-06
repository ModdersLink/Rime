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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(24), ContainerClass]
	public class DetonatedWeaponData : 
		WeaponData
	{
		protected CtrRef<LockingControllerData> m_LockingController = new CtrRef<LockingControllerData>();
		[ContainerField(16), MemberInfoFlag(53), ContainerFieldNameHash(1783566994), ContainerCtrRef]
		public CtrRef<LockingControllerData> LockingController { get { return m_LockingController; } set { if (OnPropertyChanging("DetonatedWeaponData." + nameof(LockingController), this, m_LockingController, value)) m_LockingController = value; } } // 0x10 (16)
		
		protected float m_Range = new float();
		[ContainerField(20), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(230112826)]
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
