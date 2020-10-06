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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(28), ContainerClass]
	public class UINodeConnection : 
		DataContainer
	{
		protected CtrRef<UINodeData> m_SourceNode = new CtrRef<UINodeData>();
		[ContainerField(8), MemberInfoFlag(53), ContainerFieldNameHash(1522571896), ContainerCtrRef]
		public CtrRef<UINodeData> SourceNode { get { return m_SourceNode; } set { if (OnPropertyChanging("UINodeConnection." + nameof(SourceNode), this, m_SourceNode, value)) m_SourceNode = value; } } // 0x8 (8)
		
		protected CtrRef<UINodeData> m_TargetNode = new CtrRef<UINodeData>();
		[ContainerField(12), MemberInfoFlag(53), ContainerFieldNameHash(328873140), ContainerCtrRef]
		public CtrRef<UINodeData> TargetNode { get { return m_TargetNode; } set { if (OnPropertyChanging("UINodeConnection." + nameof(TargetNode), this, m_TargetNode, value)) m_TargetNode = value; } } // 0xC (12)
		
		protected CtrRef<UINodePort> m_SourcePort = new CtrRef<UINodePort>();
		[ContainerField(16), MemberInfoFlag(53), ContainerFieldNameHash(1521925345), ContainerCtrRef]
		public CtrRef<UINodePort> SourcePort { get { return m_SourcePort; } set { if (OnPropertyChanging("UINodeConnection." + nameof(SourcePort), this, m_SourcePort, value)) m_SourcePort = value; } } // 0x10 (16)
		
		protected CtrRef<UINodePort> m_TargetPort = new CtrRef<UINodePort>();
		[ContainerField(20), MemberInfoFlag(53), ContainerFieldNameHash(328235565), ContainerCtrRef]
		public CtrRef<UINodePort> TargetPort { get { return m_TargetPort; } set { if (OnPropertyChanging("UINodeConnection." + nameof(TargetPort), this, m_TargetPort, value)) m_TargetPort = value; } } // 0x14 (20)
		
		protected int m_NumScreensToPop = new int();
		[ContainerField(24), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(1254751512)]
		public int NumScreensToPop { get { return m_NumScreensToPop; } set { if (OnPropertyChanging("UINodeConnection." + nameof(NumScreensToPop), this, m_NumScreensToPop, value)) m_NumScreensToPop = value; } } // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1522571896:
					SourceNode = (CtrRef<UINodeData>) p_Value;
					break;

				case 328873140:
					TargetNode = (CtrRef<UINodeData>) p_Value;
					break;

				case 1521925345:
					SourcePort = (CtrRef<UINodePort>) p_Value;
					break;

				case 328235565:
					TargetPort = (CtrRef<UINodePort>) p_Value;
					break;

				case 1254751512:
					NumScreensToPop = (int) p_Value;
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
				case 1522571896:
					return SourceNode;

				case 328873140:
					return TargetNode;

				case 1521925345:
					return SourcePort;

				case 328235565:
					return TargetPort;

				case 1254751512:
					return NumScreensToPop;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1522571896:
					return typeof(UINodeConnection).GetProperty(nameof(SourceNode));

				case 328873140:
					return typeof(UINodeConnection).GetProperty(nameof(TargetNode));

				case 1521925345:
					return typeof(UINodeConnection).GetProperty(nameof(SourcePort));

				case 328235565:
					return typeof(UINodeConnection).GetProperty(nameof(TargetPort));

				case 1254751512:
					return typeof(UINodeConnection).GetProperty(nameof(NumScreensToPop));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
