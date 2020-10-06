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
	[ContainerType(16), MemberInfoFlag(53), ContainerSize(144), ContainerClass]
	public class ControllableEntityData : 
		GamePhysicsEntityData
	{
		protected float m_LowHealthThreshold = new float();
		[ContainerField(112), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1532389018)]
		public float LowHealthThreshold { get { return m_LowHealthThreshold; } set { if (OnPropertyChanging("ControllableEntityData." + nameof(LowHealthThreshold), this, m_LowHealthThreshold, value)) m_LowHealthThreshold = value; } } // 0x70 (112)
		
		protected TeamId m_DefaultTeam = new TeamId();
		[ContainerField(116), MemberInfoFlag(137), ContainerFieldNameHash(2015081331)]
		public TeamId DefaultTeam { get { return m_DefaultTeam; } set { if (OnPropertyChanging("ControllableEntityData." + nameof(DefaultTeam), this, m_DefaultTeam, value)) m_DefaultTeam = value; } } // 0x74 (116)
		
		protected CtrRef<MaterialContainerPair> m_MaterialPair = new CtrRef<MaterialContainerPair>();
		[ContainerField(120), MemberInfoFlag(53), ContainerFieldNameHash(161392100), ContainerCtrRef]
		public CtrRef<MaterialContainerPair> MaterialPair { get { return m_MaterialPair; } set { if (OnPropertyChanging("ControllableEntityData." + nameof(MaterialPair), this, m_MaterialPair, value)) m_MaterialPair = value; } } // 0x78 (120)
		
		protected bool m_ResetTeamOnLastPlayerExits = new bool();
		[ContainerField(124), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3958982630)]
		public bool ResetTeamOnLastPlayerExits { get { return m_ResetTeamOnLastPlayerExits; } set { if (OnPropertyChanging("ControllableEntityData." + nameof(ResetTeamOnLastPlayerExits), this, m_ResetTeamOnLastPlayerExits, value)) m_ResetTeamOnLastPlayerExits = value; } } // 0x7C (124)
		
		protected bool m_FakeImmortal = new bool();
		[ContainerField(125), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(875726273)]
		public bool FakeImmortal { get { return m_FakeImmortal; } set { if (OnPropertyChanging("ControllableEntityData." + nameof(FakeImmortal), this, m_FakeImmortal, value)) m_FakeImmortal = value; } } // 0x7D (125)
		
		protected bool m_UsePrediction = new bool();
		[ContainerField(126), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1407937619)]
		public bool UsePrediction { get { return m_UsePrediction; } set { if (OnPropertyChanging("ControllableEntityData." + nameof(UsePrediction), this, m_UsePrediction, value)) m_UsePrediction = value; } } // 0x7E (126)
		
		protected bool m_Immortal = new bool();
		[ContainerField(127), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(922982664)]
		public bool Immortal { get { return m_Immortal; } set { if (OnPropertyChanging("ControllableEntityData." + nameof(Immortal), this, m_Immortal, value)) m_Immortal = value; } } // 0x7F (127)
		
		protected bool m_ForceForegroundRendering = new bool();
		[ContainerField(128), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(251630665)]
		public bool ForceForegroundRendering { get { return m_ForceForegroundRendering; } set { if (OnPropertyChanging("ControllableEntityData." + nameof(ForceForegroundRendering), this, m_ForceForegroundRendering, value)) m_ForceForegroundRendering = value; } } // 0x80 (128)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1532389018:
					LowHealthThreshold = (float) p_Value;
					break;

				case 2015081331:
					DefaultTeam = (TeamId) Enum.ToObject(typeof(TeamId), p_Value);
					break;

				case 161392100:
					MaterialPair = (CtrRef<MaterialContainerPair>) p_Value;
					break;

				case 3958982630:
					ResetTeamOnLastPlayerExits = (bool) p_Value;
					break;

				case 875726273:
					FakeImmortal = (bool) p_Value;
					break;

				case 1407937619:
					UsePrediction = (bool) p_Value;
					break;

				case 922982664:
					Immortal = (bool) p_Value;
					break;

				case 251630665:
					ForceForegroundRendering = (bool) p_Value;
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
				case 1532389018:
					return LowHealthThreshold;

				case 2015081331:
					return DefaultTeam;

				case 161392100:
					return MaterialPair;

				case 3958982630:
					return ResetTeamOnLastPlayerExits;

				case 875726273:
					return FakeImmortal;

				case 1407937619:
					return UsePrediction;

				case 922982664:
					return Immortal;

				case 251630665:
					return ForceForegroundRendering;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1532389018:
					return typeof(ControllableEntityData).GetProperty(nameof(LowHealthThreshold));

				case 2015081331:
					return typeof(ControllableEntityData).GetProperty(nameof(DefaultTeam));

				case 161392100:
					return typeof(ControllableEntityData).GetProperty(nameof(MaterialPair));

				case 3958982630:
					return typeof(ControllableEntityData).GetProperty(nameof(ResetTeamOnLastPlayerExits));

				case 875726273:
					return typeof(ControllableEntityData).GetProperty(nameof(FakeImmortal));

				case 1407937619:
					return typeof(ControllableEntityData).GetProperty(nameof(UsePrediction));

				case 922982664:
					return typeof(ControllableEntityData).GetProperty(nameof(Immortal));

				case 251630665:
					return typeof(ControllableEntityData).GetProperty(nameof(ForceForegroundRendering));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
