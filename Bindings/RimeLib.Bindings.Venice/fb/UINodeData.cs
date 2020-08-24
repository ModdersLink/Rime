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
	public class UINodeData : 
		DataContainer
	{
		protected string m_Name = string.Empty;
		[ContainerField(8), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(2088949890)]
		public string Name { get { return m_Name; } set { if (OnPropertyChanging("UINodeData." + nameof(Name), this, m_Name, value)) m_Name = value; } } // 0x8 (8)
		
		protected CtrRef<UIGraphAsset> m_ParentGraph = new CtrRef<UIGraphAsset>();
		[ContainerField(12), MemberInfoFlag(53), ContainerFieldNameHash(2657729557), ContainerCtrRef]
		public CtrRef<UIGraphAsset> ParentGraph { get { return m_ParentGraph; } set { if (OnPropertyChanging("UINodeData." + nameof(ParentGraph), this, m_ParentGraph, value)) m_ParentGraph = value; } } // 0xC (12)
		
		protected bool m_IsRootNode = new bool();
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3972191865)]
		public bool IsRootNode { get { return m_IsRootNode; } set { if (OnPropertyChanging("UINodeData." + nameof(IsRootNode), this, m_IsRootNode, value)) m_IsRootNode = value; } } // 0x10 (16)
		
		protected bool m_ParentIsScreen = new bool();
		[ContainerField(17), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2101493199)]
		public bool ParentIsScreen { get { return m_ParentIsScreen; } set { if (OnPropertyChanging("UINodeData." + nameof(ParentIsScreen), this, m_ParentIsScreen, value)) m_ParentIsScreen = value; } } // 0x11 (17)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2088949890:
					Name = (string) p_Value;
					break;

				case 2657729557:
					ParentGraph = (CtrRef<UIGraphAsset>) p_Value;
					break;

				case 3972191865:
					IsRootNode = (bool) p_Value;
					break;

				case 2101493199:
					ParentIsScreen = (bool) p_Value;
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
				case 2088949890:
					return Name;

				case 2657729557:
					return ParentGraph;

				case 3972191865:
					return IsRootNode;

				case 2101493199:
					return ParentIsScreen;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2088949890:
					return typeof(UINodeData).GetProperty(nameof(Name));

				case 2657729557:
					return typeof(UINodeData).GetProperty(nameof(ParentGraph));

				case 3972191865:
					return typeof(UINodeData).GetProperty(nameof(IsRootNode));

				case 2101493199:
					return typeof(UINodeData).GetProperty(nameof(ParentIsScreen));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
