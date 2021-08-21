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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 28)]
	public class DuplicateSpawnScopeStrategyData : 
		SoundScopeStrategyData
	{
		protected float m_Time = new float();
		[ContainerField(Name: "Time", Offset: 12, NameHash: 2089313744, Flags: 49469), LayoutImmutable, Blittable]
		public float Time { get { return m_Time; } set { if (OnPropertyChanging("DuplicateSpawnScopeStrategyData." + nameof(Time), this, m_Time, value)) m_Time = value; } } // 0xC (12)
		
		protected float m_Distance = new float();
		[ContainerField(Name: "Distance", Offset: 16, NameHash: 408560070, Flags: 49469), LayoutImmutable, Blittable]
		public float Distance { get { return m_Distance; } set { if (OnPropertyChanging("DuplicateSpawnScopeStrategyData." + nameof(Distance), this, m_Distance, value)) m_Distance = value; } } // 0x10 (16)
		
		protected uint m_ClosestCount = new uint();
		[ContainerField(Name: "ClosestCount", Offset: 20, NameHash: 4143870103, Flags: 49421), LayoutImmutable, Blittable]
		public uint ClosestCount { get { return m_ClosestCount; } set { if (OnPropertyChanging("DuplicateSpawnScopeStrategyData." + nameof(ClosestCount), this, m_ClosestCount, value)) m_ClosestCount = value; } } // 0x14 (20)
		
		protected bool m_GroupTypes = new bool();
		[ContainerField(Name: "GroupTypes", Offset: 24, NameHash: 1801246673, Flags: 49325), LayoutImmutable, Blittable]
		public bool GroupTypes { get { return m_GroupTypes; } set { if (OnPropertyChanging("DuplicateSpawnScopeStrategyData." + nameof(GroupTypes), this, m_GroupTypes, value)) m_GroupTypes = value; } } // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2089313744:
					Time = (float) p_Value;
					break;

				case 408560070:
					Distance = (float) p_Value;
					break;

				case 4143870103:
					ClosestCount = (uint) p_Value;
					break;

				case 1801246673:
					GroupTypes = (bool) p_Value;
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
				case 2089313744:
					return Time;

				case 408560070:
					return Distance;

				case 4143870103:
					return ClosestCount;

				case 1801246673:
					return GroupTypes;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2089313744:
					return typeof(DuplicateSpawnScopeStrategyData).GetProperty(nameof(Time));

				case 408560070:
					return typeof(DuplicateSpawnScopeStrategyData).GetProperty(nameof(Distance));

				case 4143870103:
					return typeof(DuplicateSpawnScopeStrategyData).GetProperty(nameof(ClosestCount));

				case 1801246673:
					return typeof(DuplicateSpawnScopeStrategyData).GetProperty(nameof(GroupTypes));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
