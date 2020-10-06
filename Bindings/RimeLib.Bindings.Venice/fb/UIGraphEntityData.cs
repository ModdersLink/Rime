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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(32), ContainerClass]
	public class UIGraphEntityData : 
		EntityData
	{
		protected List<EventSpec> m_Events = new List<EventSpec>();
		[ContainerField(12), MemberInfoFlag(65), ContainerFieldNameHash(2352146554), ContainerArray]
		public List<EventSpec> Events { get { return m_Events; } set { if (OnPropertyChanging("UIGraphEntityData." + nameof(Events), this, m_Events, value)) m_Events = value; } } // 0xC (12)
		
		protected CtrRef<UIGraphAsset> m_GraphAsset = new CtrRef<UIGraphAsset>();
		[ContainerField(16), MemberInfoFlag(53), ContainerFieldNameHash(3545549337), ContainerCtrRef]
		public CtrRef<UIGraphAsset> GraphAsset { get { return m_GraphAsset; } set { if (OnPropertyChanging("UIGraphEntityData." + nameof(GraphAsset), this, m_GraphAsset, value)) m_GraphAsset = value; } } // 0x10 (16)
		
		protected UIGraphPriority m_GraphPriority = new UIGraphPriority();
		[ContainerField(20), MemberInfoFlag(137), ContainerFieldNameHash(2838537403)]
		public UIGraphPriority GraphPriority { get { return m_GraphPriority; } set { if (OnPropertyChanging("UIGraphEntityData." + nameof(GraphPriority), this, m_GraphPriority, value)) m_GraphPriority = value; } } // 0x14 (20)
		
		protected UIState m_State = new UIState();
		[ContainerField(24), MemberInfoFlag(137), ContainerFieldNameHash(230748402)]
		public UIState State { get { return m_State; } set { if (OnPropertyChanging("UIGraphEntityData." + nameof(State), this, m_State, value)) m_State = value; } } // 0x18 (24)
		
		protected bool m_PopPreviousGraph = new bool();
		[ContainerField(28), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3277878647)]
		public bool PopPreviousGraph { get { return m_PopPreviousGraph; } set { if (OnPropertyChanging("UIGraphEntityData." + nameof(PopPreviousGraph), this, m_PopPreviousGraph, value)) m_PopPreviousGraph = value; } } // 0x1C (28)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2352146554:
					Events = (List<EventSpec>) p_Value;
					break;

				case 3545549337:
					GraphAsset = (CtrRef<UIGraphAsset>) p_Value;
					break;

				case 2838537403:
					GraphPriority = (UIGraphPriority) Enum.ToObject(typeof(UIGraphPriority), p_Value);
					break;

				case 230748402:
					State = (UIState) Enum.ToObject(typeof(UIState), p_Value);
					break;

				case 3277878647:
					PopPreviousGraph = (bool) p_Value;
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
				case 2352146554:
					return Events;

				case 3545549337:
					return GraphAsset;

				case 2838537403:
					return GraphPriority;

				case 230748402:
					return State;

				case 3277878647:
					return PopPreviousGraph;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2352146554:
					return typeof(UIGraphEntityData).GetProperty(nameof(Events));

				case 3545549337:
					return typeof(UIGraphEntityData).GetProperty(nameof(GraphAsset));

				case 2838537403:
					return typeof(UIGraphEntityData).GetProperty(nameof(GraphPriority));

				case 230748402:
					return typeof(UIGraphEntityData).GetProperty(nameof(State));

				case 3277878647:
					return typeof(UIGraphEntityData).GetProperty(nameof(PopPreviousGraph));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
