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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 64)]
	public class DataStepNode : 
		UINodeData
	{
		protected CtrRef<UINodePort> m_In = new CtrRef<UINodePort>();
		[ContainerField(Name: "In", Offset: 20, NameHash: 5862146, Flags: 53)]
		public CtrRef<UINodePort> In { get { return m_In; } set { if (OnPropertyChanging("DataStepNode." + nameof(In), this, m_In, value)) m_In = value; } } // 0x14 (20)
		
		protected CtrRef<UINodePort> m_Out = new CtrRef<UINodePort>();
		[ContainerField(Name: "Out", Offset: 24, NameHash: 193453899, Flags: 53)]
		public CtrRef<UINodePort> Out { get { return m_Out; } set { if (OnPropertyChanging("DataStepNode." + nameof(Out), this, m_Out, value)) m_Out = value; } } // 0x18 (24)
		
		protected List<float> m_Steps = new List<float>();
		[ContainerField(Name: "Steps", Offset: 28, NameHash: 230752612, Flags: 65)]
		public List<float> Steps { get { return m_Steps; } set { if (OnPropertyChanging("DataStepNode." + nameof(Steps), this, m_Steps, value)) m_Steps = value; } } // 0x1C (28)
		
		protected UIDataSourceInfo m_CurrentStepDataSource = new UIDataSourceInfo();
		[ContainerField(Name: "CurrentStepDataSource", Offset: 32, NameHash: 3729599635, Flags: 41)]
		public UIDataSourceInfo CurrentStepDataSource { get { return m_CurrentStepDataSource; } set { if (OnPropertyChanging("DataStepNode." + nameof(CurrentStepDataSource), this, m_CurrentStepDataSource, value)) m_CurrentStepDataSource = value; } } // 0x20 (32)
		
		protected UIDataSourceInfo m_DataSource = new UIDataSourceInfo();
		[ContainerField(Name: "DataSource", Offset: 48, NameHash: 3810860200, Flags: 41)]
		public UIDataSourceInfo DataSource { get { return m_DataSource; } set { if (OnPropertyChanging("DataStepNode." + nameof(DataSource), this, m_DataSource, value)) m_DataSource = value; } } // 0x30 (48)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 5862146:
					In = (CtrRef<UINodePort>) p_Value;
					break;

				case 193453899:
					Out = (CtrRef<UINodePort>) p_Value;
					break;

				case 230752612:
					Steps = (List<float>) p_Value;
					break;

				case 3729599635:
					CurrentStepDataSource = (UIDataSourceInfo) p_Value;
					break;

				case 3810860200:
					DataSource = (UIDataSourceInfo) p_Value;
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

				case 193453899:
					return Out;

				case 230752612:
					return Steps;

				case 3729599635:
					return CurrentStepDataSource;

				case 3810860200:
					return DataSource;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 5862146:
					return typeof(DataStepNode).GetProperty(nameof(In));

				case 193453899:
					return typeof(DataStepNode).GetProperty(nameof(Out));

				case 230752612:
					return typeof(DataStepNode).GetProperty(nameof(Steps));

				case 3729599635:
					return typeof(DataStepNode).GetProperty(nameof(CurrentStepDataSource));

				case 3810860200:
					return typeof(DataStepNode).GetProperty(nameof(DataSource));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
