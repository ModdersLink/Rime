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
	public class InstanceOutputNode : 
		UINodeData
	{
		protected CtrRef<UINodePort> m_In = new CtrRef<UINodePort>();
		[ContainerField(20), MemberInfoFlag(53), ContainerFieldNameHash(5862146), ContainerCtrRef]
		public CtrRef<UINodePort> In { get { return m_In; } set { if (OnPropertyChanging("InstanceOutputNode." + nameof(In), this, m_In, value)) m_In = value; } } // 0x14 (20)
		
		protected int m_Id = new int();
		[ContainerField(24), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(5862152)]
		public int Id { get { return m_Id; } set { if (OnPropertyChanging("InstanceOutputNode." + nameof(Id), this, m_Id, value)) m_Id = value; } } // 0x18 (24)
		
		protected bool m_DestroyGraph = new bool();
		[ContainerField(28), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3848224203)]
		public bool DestroyGraph { get { return m_DestroyGraph; } set { if (OnPropertyChanging("InstanceOutputNode." + nameof(DestroyGraph), this, m_DestroyGraph, value)) m_DestroyGraph = value; } } // 0x1C (28)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 5862146:
					In = (CtrRef<UINodePort>) p_Value;
					break;

				case 5862152:
					Id = (int) p_Value;
					break;

				case 3848224203:
					DestroyGraph = (bool) p_Value;
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

				case 5862152:
					return Id;

				case 3848224203:
					return DestroyGraph;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 5862146:
					return typeof(InstanceOutputNode).GetProperty(nameof(In));

				case 5862152:
					return typeof(InstanceOutputNode).GetProperty(nameof(Id));

				case 3848224203:
					return typeof(InstanceOutputNode).GetProperty(nameof(DestroyGraph));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
