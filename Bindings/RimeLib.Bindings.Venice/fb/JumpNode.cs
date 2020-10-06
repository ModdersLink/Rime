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
	public class JumpNode : 
		UINodeData
	{
		protected CtrRef<UINodePort> m_In = new CtrRef<UINodePort>();
		[ContainerField(20), MemberInfoFlag(53), ContainerFieldNameHash(5862146), ContainerCtrRef]
		public CtrRef<UINodePort> In { get { return m_In; } set { if (OnPropertyChanging("JumpNode." + nameof(In), this, m_In, value)) m_In = value; } } // 0x14 (20)
		
		protected CtrRef<UINodeData> m_TargetNode = new CtrRef<UINodeData>();
		[ContainerField(24), MemberInfoFlag(53), ContainerFieldNameHash(328873140), ContainerCtrRef]
		public CtrRef<UINodeData> TargetNode { get { return m_TargetNode; } set { if (OnPropertyChanging("JumpNode." + nameof(TargetNode), this, m_TargetNode, value)) m_TargetNode = value; } } // 0x18 (24)
		
		protected CtrRef<UINodePort> m_TargetPort = new CtrRef<UINodePort>();
		[ContainerField(28), MemberInfoFlag(53), ContainerFieldNameHash(328235565), ContainerCtrRef]
		public CtrRef<UINodePort> TargetPort { get { return m_TargetPort; } set { if (OnPropertyChanging("JumpNode." + nameof(TargetPort), this, m_TargetPort, value)) m_TargetPort = value; } } // 0x1C (28)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 5862146:
					In = (CtrRef<UINodePort>) p_Value;
					break;

				case 328873140:
					TargetNode = (CtrRef<UINodeData>) p_Value;
					break;

				case 328235565:
					TargetPort = (CtrRef<UINodePort>) p_Value;
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
				case 5862146:
					return In;

				case 328873140:
					return TargetNode;

				case 328235565:
					return TargetPort;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 5862146:
					return typeof(JumpNode).GetProperty(nameof(In));

				case 328873140:
					return typeof(JumpNode).GetProperty(nameof(TargetNode));

				case 328235565:
					return typeof(JumpNode).GetProperty(nameof(TargetPort));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
