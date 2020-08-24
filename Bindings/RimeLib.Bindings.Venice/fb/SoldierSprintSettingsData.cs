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
	[ContainerType(4), MemberInfoFlag(53), ContainerClass]
	public class SoldierSprintSettingsData : 
		DataContainer
	{
		protected float m_Fov = new float();
		[ContainerField(8), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(193443802)]
		public float Fov { get { return m_Fov; } set { if (OnPropertyChanging("SoldierSprintSettingsData." + nameof(Fov), this, m_Fov, value)) m_Fov = value; } } // 0x8 (8)
		
		protected float m_FovInDelay = new float();
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2914334632)]
		public float FovInDelay { get { return m_FovInDelay; } set { if (OnPropertyChanging("SoldierSprintSettingsData." + nameof(FovInDelay), this, m_FovInDelay, value)) m_FovInDelay = value; } } // 0xC (12)
		
		protected float m_FovInTime = new float();
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1259080584)]
		public float FovInTime { get { return m_FovInTime; } set { if (OnPropertyChanging("SoldierSprintSettingsData." + nameof(FovInTime), this, m_FovInTime, value)) m_FovInTime = value; } } // 0x10 (16)
		
		protected float m_FovOutDelay = new float();
		[ContainerField(20), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(401599137)]
		public float FovOutDelay { get { return m_FovOutDelay; } set { if (OnPropertyChanging("SoldierSprintSettingsData." + nameof(FovOutDelay), this, m_FovOutDelay, value)) m_FovOutDelay = value; } } // 0x14 (20)
		
		protected float m_FovOutTime = new float();
		[ContainerField(24), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3785964001)]
		public float FovOutTime { get { return m_FovOutTime; } set { if (OnPropertyChanging("SoldierSprintSettingsData." + nameof(FovOutTime), this, m_FovOutTime, value)) m_FovOutTime = value; } } // 0x18 (24)
		
		protected float m_RecoverTime = new float();
		[ContainerField(28), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3786458634)]
		public float RecoverTime { get { return m_RecoverTime; } set { if (OnPropertyChanging("SoldierSprintSettingsData." + nameof(RecoverTime), this, m_RecoverTime, value)) m_RecoverTime = value; } } // 0x1C (28)
		
		protected float m_SprintToProneRecoverTime = new float();
		[ContainerField(32), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(498825685)]
		public float SprintToProneRecoverTime { get { return m_SprintToProneRecoverTime; } set { if (OnPropertyChanging("SoldierSprintSettingsData." + nameof(SprintToProneRecoverTime), this, m_SprintToProneRecoverTime, value)) m_SprintToProneRecoverTime = value; } } // 0x20 (32)
		
		protected List<EntryInputActionEnum> m_InterruptingActions = new List<EntryInputActionEnum>();
		[ContainerField(36), MemberInfoFlag(65), ContainerFieldNameHash(1860467119), ContainerArray]
		public List<EntryInputActionEnum> InterruptingActions { get { return m_InterruptingActions; } set { if (OnPropertyChanging("SoldierSprintSettingsData." + nameof(InterruptingActions), this, m_InterruptingActions, value)) m_InterruptingActions = value; } } // 0x24 (36)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 193443802:
					Fov = (float) p_Value;
					break;

				case 2914334632:
					FovInDelay = (float) p_Value;
					break;

				case 1259080584:
					FovInTime = (float) p_Value;
					break;

				case 401599137:
					FovOutDelay = (float) p_Value;
					break;

				case 3785964001:
					FovOutTime = (float) p_Value;
					break;

				case 3786458634:
					RecoverTime = (float) p_Value;
					break;

				case 498825685:
					SprintToProneRecoverTime = (float) p_Value;
					break;

				case 1860467119:
					if (p_Value.GetType() == typeof (List<uint>))
						InterruptingActions = ((List<uint>) p_Value).Select(x => (EntryInputActionEnum) Enum.ToObject(typeof(EntryInputActionEnum), x)).ToList();
					else
						InterruptingActions = (List<EntryInputActionEnum>) p_Value;
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
				case 193443802:
					return Fov;

				case 2914334632:
					return FovInDelay;

				case 1259080584:
					return FovInTime;

				case 401599137:
					return FovOutDelay;

				case 3785964001:
					return FovOutTime;

				case 3786458634:
					return RecoverTime;

				case 498825685:
					return SprintToProneRecoverTime;

				case 1860467119:
					return InterruptingActions;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 193443802:
					return typeof(SoldierSprintSettingsData).GetProperty(nameof(Fov));

				case 2914334632:
					return typeof(SoldierSprintSettingsData).GetProperty(nameof(FovInDelay));

				case 1259080584:
					return typeof(SoldierSprintSettingsData).GetProperty(nameof(FovInTime));

				case 401599137:
					return typeof(SoldierSprintSettingsData).GetProperty(nameof(FovOutDelay));

				case 3785964001:
					return typeof(SoldierSprintSettingsData).GetProperty(nameof(FovOutTime));

				case 3786458634:
					return typeof(SoldierSprintSettingsData).GetProperty(nameof(RecoverTime));

				case 498825685:
					return typeof(SoldierSprintSettingsData).GetProperty(nameof(SprintToProneRecoverTime));

				case 1860467119:
					return typeof(SoldierSprintSettingsData).GetProperty(nameof(InterruptingActions));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
