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
	public class AlternateSpawnEntityData : 
		SpatialEntityData
	{
		protected TeamId m_Team = new TeamId();
		[ContainerField(80), MemberInfoFlag(137), ContainerFieldNameHash(2089309528)]
		public TeamId Team { get { return m_Team; } set { if (OnPropertyChanging("AlternateSpawnEntityData." + nameof(Team), this, m_Team, value)) m_Team = value; } } // 0x50 (80)
		
		protected float m_Priority = new float();
		[ContainerField(84), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3062102871)]
		public float Priority { get { return m_Priority; } set { if (OnPropertyChanging("AlternateSpawnEntityData." + nameof(Priority), this, m_Priority, value)) m_Priority = value; } } // 0x54 (84)
		
		protected bool m_Enabled = new bool();
		[ContainerField(88), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2662400)]
		public bool Enabled { get { return m_Enabled; } set { if (OnPropertyChanging("AlternateSpawnEntityData." + nameof(Enabled), this, m_Enabled, value)) m_Enabled = value; } } // 0x58 (88)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2089309528:
					Team = (TeamId) Enum.ToObject(typeof(TeamId), p_Value);
					break;

				case 3062102871:
					Priority = (float) p_Value;
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
				case 2089309528:
					return Team;

				case 3062102871:
					return Priority;

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
				case 2089309528:
					return typeof(AlternateSpawnEntityData).GetProperty(nameof(Team));

				case 3062102871:
					return typeof(AlternateSpawnEntityData).GetProperty(nameof(Priority));

				case 2662400:
					return typeof(AlternateSpawnEntityData).GetProperty(nameof(Enabled));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
