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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(36), ContainerClass]
	public class FriendlyFireEntityData : 
		EntityData
	{
		protected List<TeamId> m_Teams = new List<TeamId>();
		[ContainerField(12), MemberInfoFlag(65), ContainerFieldNameHash(227737643), ContainerArray]
		public List<TeamId> Teams { get { return m_Teams; } set { if (OnPropertyChanging("FriendlyFireEntityData." + nameof(Teams), this, m_Teams, value)) m_Teams = value; } } // 0xC (12)
		
		protected float m_EnemyCommitmentAllocation = new float();
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2175171884)]
		public float EnemyCommitmentAllocation { get { return m_EnemyCommitmentAllocation; } set { if (OnPropertyChanging("FriendlyFireEntityData." + nameof(EnemyCommitmentAllocation), this, m_EnemyCommitmentAllocation, value)) m_EnemyCommitmentAllocation = value; } } // 0x10 (16)
		
		protected float m_FriendlyCommitmentAllocation = new float();
		[ContainerField(20), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(4158058161)]
		public float FriendlyCommitmentAllocation { get { return m_FriendlyCommitmentAllocation; } set { if (OnPropertyChanging("FriendlyFireEntityData." + nameof(FriendlyCommitmentAllocation), this, m_FriendlyCommitmentAllocation, value)) m_FriendlyCommitmentAllocation = value; } } // 0x14 (20)
		
		protected float m_MaxCommitment = new float();
		[ContainerField(24), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2794924786)]
		public float MaxCommitment { get { return m_MaxCommitment; } set { if (OnPropertyChanging("FriendlyFireEntityData." + nameof(MaxCommitment), this, m_MaxCommitment, value)) m_MaxCommitment = value; } } // 0x18 (24)
		
		protected float m_FailureThreshold = new float();
		[ContainerField(28), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(280940370)]
		public float FailureThreshold { get { return m_FailureThreshold; } set { if (OnPropertyChanging("FriendlyFireEntityData." + nameof(FailureThreshold), this, m_FailureThreshold, value)) m_FailureThreshold = value; } } // 0x1C (28)
		
		protected float m_DecayRate = new float();
		[ContainerField(32), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3274236317)]
		public float DecayRate { get { return m_DecayRate; } set { if (OnPropertyChanging("FriendlyFireEntityData." + nameof(DecayRate), this, m_DecayRate, value)) m_DecayRate = value; } } // 0x20 (32)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 227737643:
					if (p_Value.GetType() == typeof (List<uint>))
						Teams = ((List<uint>) p_Value).Select(x => (TeamId) Enum.ToObject(typeof(TeamId), x)).ToList();
					else
						Teams = (List<TeamId>) p_Value;
					break;

				case 2175171884:
					EnemyCommitmentAllocation = (float) p_Value;
					break;

				case 4158058161:
					FriendlyCommitmentAllocation = (float) p_Value;
					break;

				case 2794924786:
					MaxCommitment = (float) p_Value;
					break;

				case 280940370:
					FailureThreshold = (float) p_Value;
					break;

				case 3274236317:
					DecayRate = (float) p_Value;
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
				case 227737643:
					return Teams;

				case 2175171884:
					return EnemyCommitmentAllocation;

				case 4158058161:
					return FriendlyCommitmentAllocation;

				case 2794924786:
					return MaxCommitment;

				case 280940370:
					return FailureThreshold;

				case 3274236317:
					return DecayRate;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 227737643:
					return typeof(FriendlyFireEntityData).GetProperty(nameof(Teams));

				case 2175171884:
					return typeof(FriendlyFireEntityData).GetProperty(nameof(EnemyCommitmentAllocation));

				case 4158058161:
					return typeof(FriendlyFireEntityData).GetProperty(nameof(FriendlyCommitmentAllocation));

				case 2794924786:
					return typeof(FriendlyFireEntityData).GetProperty(nameof(MaxCommitment));

				case 280940370:
					return typeof(FriendlyFireEntityData).GetProperty(nameof(FailureThreshold));

				case 3274236317:
					return typeof(FriendlyFireEntityData).GetProperty(nameof(DecayRate));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
