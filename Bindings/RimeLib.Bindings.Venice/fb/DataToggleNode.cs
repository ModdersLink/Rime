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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 44)]
	public class DataToggleNode : 
		UINodeData
	{
		protected CtrRef<UINodePort> m_In = new CtrRef<UINodePort>();
		[ContainerField(Name: "In", Offset: 20, NameHash: 5862146, Flags: 53)]
		public CtrRef<UINodePort> In { get { return m_In; } set { if (OnPropertyChanging("DataToggleNode." + nameof(In), this, m_In, value)) m_In = value; } } // 0x14 (20)
		
		protected CtrRef<UINodePort> m_Out = new CtrRef<UINodePort>();
		[ContainerField(Name: "Out", Offset: 24, NameHash: 193453899, Flags: 53)]
		public CtrRef<UINodePort> Out { get { return m_Out; } set { if (OnPropertyChanging("DataToggleNode." + nameof(Out), this, m_Out, value)) m_Out = value; } } // 0x18 (24)
		
		protected UIDataSourceInfo m_DataSource = new UIDataSourceInfo();
		[ContainerField(Name: "DataSource", Offset: 28, NameHash: 3810860200, Flags: 41)]
		public UIDataSourceInfo DataSource { get { return m_DataSource; } set { if (OnPropertyChanging("DataToggleNode." + nameof(DataSource), this, m_DataSource, value)) m_DataSource = value; } } // 0x1C (28)
		
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
					return typeof(DataToggleNode).GetProperty(nameof(In));

				case 193453899:
					return typeof(DataToggleNode).GetProperty(nameof(Out));

				case 3810860200:
					return typeof(DataToggleNode).GetProperty(nameof(DataSource));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
