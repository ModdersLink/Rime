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
	[ContainerType(4)]
	public class InstanceNode : 
		UINodeData
	{
		protected CtrRef<UIGraphAsset> m_UIGraph = new CtrRef<UIGraphAsset>();
		[ContainerField(20), ContainerFieldNameHash(209526997)]
		public CtrRef<UIGraphAsset> UIGraph { get { return m_UIGraph; } set { if (OnPropertyChanging("InstanceNode." + nameof(UIGraph), this, m_UIGraph, value)) m_UIGraph = value; } } // 0x14 (20)
		
		protected RefArray<UINodePort> m_Inputs = new RefArray<UINodePort>();
		[ContainerField(24), ContainerFieldNameHash(2784267136)]
		public RefArray<UINodePort> Inputs { get { return m_Inputs; } set { if (OnPropertyChanging("InstanceNode." + nameof(Inputs), this, m_Inputs, value)) m_Inputs = value; } } // 0x18 (24)
		
		protected RefArray<UINodePort> m_Outputs = new RefArray<UINodePort>();
		[ContainerField(28), ContainerFieldNameHash(1070022089)]
		public RefArray<UINodePort> Outputs { get { return m_Outputs; } set { if (OnPropertyChanging("InstanceNode." + nameof(Outputs), this, m_Outputs, value)) m_Outputs = value; } } // 0x1C (28)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 209526997:
					UIGraph = (CtrRef<UIGraphAsset>) p_Value;
					break;

				case 2784267136:
					Inputs = (RefArray<UINodePort>) p_Value;
					break;

				case 1070022089:
					Outputs = (RefArray<UINodePort>) p_Value;
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
				case 209526997:
					return UIGraph;

				case 2784267136:
					return Inputs;

				case 1070022089:
					return Outputs;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 209526997:
					return typeof(InstanceNode).GetProperty(nameof(UIGraph));

				case 2784267136:
					return typeof(InstanceNode).GetProperty(nameof(Inputs));

				case 1070022089:
					return typeof(InstanceNode).GetProperty(nameof(Outputs));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
