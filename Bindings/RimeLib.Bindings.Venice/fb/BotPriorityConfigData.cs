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
	[ContainerType(16), MemberInfoFlag(53), ContainerClass]
	public class BotPriorityConfigData : 
		DataContainer
	{
		protected Vec3 m_DebugColor = new Vec3();
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(2612071465)]
		public Vec3 DebugColor { get { return m_DebugColor; } set { if (OnPropertyChanging("BotPriorityConfigData." + nameof(DebugColor), this, m_DebugColor, value)) m_DebugColor = value; } } // 0x10 (16)
		
		protected float m_Distance = new float();
		[ContainerField(32), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(408560070)]
		public float Distance { get { return m_Distance; } set { if (OnPropertyChanging("BotPriorityConfigData." + nameof(Distance), this, m_Distance, value)) m_Distance = value; } } // 0x20 (32)
		
		protected int m_Period = new int();
		[ContainerField(36), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(3366831232)]
		public int Period { get { return m_Period; } set { if (OnPropertyChanging("BotPriorityConfigData." + nameof(Period), this, m_Period, value)) m_Period = value; } } // 0x24 (36)
		
		protected float m_AngleOffset = new float();
		[ContainerField(40), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1865391177)]
		public float AngleOffset { get { return m_AngleOffset; } set { if (OnPropertyChanging("BotPriorityConfigData." + nameof(AngleOffset), this, m_AngleOffset, value)) m_AngleOffset = value; } } // 0x28 (40)
		
		protected bool m_AppliesToExecution = new bool();
		[ContainerField(44), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2757011902)]
		public bool AppliesToExecution { get { return m_AppliesToExecution; } set { if (OnPropertyChanging("BotPriorityConfigData." + nameof(AppliesToExecution), this, m_AppliesToExecution, value)) m_AppliesToExecution = value; } } // 0x2C (44)
		
		protected bool m_AppliesToDecisions = new bool();
		[ContainerField(45), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(4242821263)]
		public bool AppliesToDecisions { get { return m_AppliesToDecisions; } set { if (OnPropertyChanging("BotPriorityConfigData." + nameof(AppliesToDecisions), this, m_AppliesToDecisions, value)) m_AppliesToDecisions = value; } } // 0x2D (45)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2612071465:
					DebugColor = (Vec3) p_Value;
					break;

				case 408560070:
					Distance = (float) p_Value;
					break;

				case 3366831232:
					Period = (int) p_Value;
					break;

				case 1865391177:
					AngleOffset = (float) p_Value;
					break;

				case 2757011902:
					AppliesToExecution = (bool) p_Value;
					break;

				case 4242821263:
					AppliesToDecisions = (bool) p_Value;
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
				case 2612071465:
					return DebugColor;

				case 408560070:
					return Distance;

				case 3366831232:
					return Period;

				case 1865391177:
					return AngleOffset;

				case 2757011902:
					return AppliesToExecution;

				case 4242821263:
					return AppliesToDecisions;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2612071465:
					return typeof(BotPriorityConfigData).GetProperty(nameof(DebugColor));

				case 408560070:
					return typeof(BotPriorityConfigData).GetProperty(nameof(Distance));

				case 3366831232:
					return typeof(BotPriorityConfigData).GetProperty(nameof(Period));

				case 1865391177:
					return typeof(BotPriorityConfigData).GetProperty(nameof(AngleOffset));

				case 2757011902:
					return typeof(BotPriorityConfigData).GetProperty(nameof(AppliesToExecution));

				case 4242821263:
					return typeof(BotPriorityConfigData).GetProperty(nameof(AppliesToDecisions));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
