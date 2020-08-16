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
	public class DataSetNode : 
		UINodeData
	{
		protected CtrRef<UINodePort> m_In = new CtrRef<UINodePort>();
		[ContainerField(20), ContainerFieldNameHash(5862146)]
		public CtrRef<UINodePort> In { get { return m_In; } set { if (OnPropertyChanging("DataSetNode." + nameof(In), this, m_In, value)) m_In = value; } } // 0x14 (20)
		
		protected CtrRef<UINodePort> m_Out = new CtrRef<UINodePort>();
		[ContainerField(24), ContainerFieldNameHash(193453899)]
		public CtrRef<UINodePort> Out { get { return m_Out; } set { if (OnPropertyChanging("DataSetNode." + nameof(Out), this, m_Out, value)) m_Out = value; } } // 0x18 (24)
		
		protected string m_Param = string.Empty;
		[ContainerField(28), LayoutImmutable, ContainerFieldNameHash(232319210)]
		public string Param { get { return m_Param; } set { if (OnPropertyChanging("DataSetNode." + nameof(Param), this, m_Param, value)) m_Param = value; } } // 0x1C (28)
		
		protected UIDataSourceInfo m_DataSource = new UIDataSourceInfo();
		[ContainerField(32), ContainerFieldNameHash(3810860200)]
		public UIDataSourceInfo DataSource { get { return m_DataSource; } set { if (OnPropertyChanging("DataSetNode." + nameof(DataSource), this, m_DataSource, value)) m_DataSource = value; } } // 0x20 (32)
		
		protected bool m_SetToEmptyString = new bool();
		[ContainerField(48), LayoutImmutable, Blittable, ContainerFieldNameHash(2535912156)]
		public bool SetToEmptyString { get { return m_SetToEmptyString; } set { if (OnPropertyChanging("DataSetNode." + nameof(SetToEmptyString), this, m_SetToEmptyString, value)) m_SetToEmptyString = value; } } // 0x30 (48)
		
		protected bool m_ForceUpdate = new bool();
		[ContainerField(49), LayoutImmutable, Blittable, ContainerFieldNameHash(4101084969)]
		public bool ForceUpdate { get { return m_ForceUpdate; } set { if (OnPropertyChanging("DataSetNode." + nameof(ForceUpdate), this, m_ForceUpdate, value)) m_ForceUpdate = value; } } // 0x31 (49)
		
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

				case 232319210:
					Param = (string) p_Value;
					break;

				case 3810860200:
					DataSource = (UIDataSourceInfo) p_Value;
					break;

				case 2535912156:
					SetToEmptyString = (bool) p_Value;
					break;

				case 4101084969:
					ForceUpdate = (bool) p_Value;
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

				case 232319210:
					return Param;

				case 3810860200:
					return DataSource;

				case 2535912156:
					return SetToEmptyString;

				case 4101084969:
					return ForceUpdate;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 5862146:
					return typeof(DataSetNode).GetProperty(nameof(In));

				case 193453899:
					return typeof(DataSetNode).GetProperty(nameof(Out));

				case 232319210:
					return typeof(DataSetNode).GetProperty(nameof(Param));

				case 3810860200:
					return typeof(DataSetNode).GetProperty(nameof(DataSource));

				case 2535912156:
					return typeof(DataSetNode).GetProperty(nameof(SetToEmptyString));

				case 4101084969:
					return typeof(DataSetNode).GetProperty(nameof(ForceUpdate));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
