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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 48)]
	public class ComparisonLogicNode : 
		UINodeData
	{
		protected CtrRef<UINodePort> m_In = new CtrRef<UINodePort>();
		[ContainerField(Name: "In", Offset: 20, NameHash: 5862146, Flags: 53)]
		public CtrRef<UINodePort> In { get { return m_In; } set { if (OnPropertyChanging("ComparisonLogicNode." + nameof(In), this, m_In, value)) m_In = value; } } // 0x14 (20)
		
		protected RefArray<UINodePort> m_Outputs = new RefArray<UINodePort>();
		[ContainerField(Name: "Outputs", Offset: 24, NameHash: 1070022089, Flags: 65)]
		public RefArray<UINodePort> Outputs { get { return m_Outputs; } set { if (OnPropertyChanging("ComparisonLogicNode." + nameof(Outputs), this, m_Outputs, value)) m_Outputs = value; } } // 0x18 (24)
		
		protected UIDataSourceInfo m_DataSourceInfo = new UIDataSourceInfo();
		[ContainerField(Name: "DataSourceInfo", Offset: 28, NameHash: 4099162406, Flags: 41)]
		public UIDataSourceInfo DataSourceInfo { get { return m_DataSourceInfo; } set { if (OnPropertyChanging("ComparisonLogicNode." + nameof(DataSourceInfo), this, m_DataSourceInfo, value)) m_DataSourceInfo = value; } } // 0x1C (28)
		
		protected bool m_SkipFractionals = new bool();
		[ContainerField(Name: "SkipFractionals", Offset: 44, NameHash: 4155242992, Flags: 49325), LayoutImmutable, Blittable]
		public bool SkipFractionals { get { return m_SkipFractionals; } set { if (OnPropertyChanging("ComparisonLogicNode." + nameof(SkipFractionals), this, m_SkipFractionals, value)) m_SkipFractionals = value; } } // 0x2C (44)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 5862146:
					In = (CtrRef<UINodePort>) p_Value;
					break;

				case 1070022089:
					Outputs = (RefArray<UINodePort>) p_Value;
					break;

				case 4099162406:
					DataSourceInfo = (UIDataSourceInfo) p_Value;
					break;

				case 4155242992:
					SkipFractionals = (bool) p_Value;
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

				case 1070022089:
					return Outputs;

				case 4099162406:
					return DataSourceInfo;

				case 4155242992:
					return SkipFractionals;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 5862146:
					return typeof(ComparisonLogicNode).GetProperty(nameof(In));

				case 1070022089:
					return typeof(ComparisonLogicNode).GetProperty(nameof(Outputs));

				case 4099162406:
					return typeof(ComparisonLogicNode).GetProperty(nameof(DataSourceInfo));

				case 4155242992:
					return typeof(ComparisonLogicNode).GetProperty(nameof(SkipFractionals));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
