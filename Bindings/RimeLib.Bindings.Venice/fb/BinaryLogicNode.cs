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
	public class BinaryLogicNode : 
		UINodeData
	{
		protected CtrRef<UINodePort> m_In = new CtrRef<UINodePort>();
		[ContainerField(20), MemberInfoFlag(53), ContainerFieldNameHash(5862146), ContainerCtrRef]
		public CtrRef<UINodePort> In { get { return m_In; } set { if (OnPropertyChanging("BinaryLogicNode." + nameof(In), this, m_In, value)) m_In = value; } } // 0x14 (20)
		
		protected CtrRef<UINodePort> m_True = new CtrRef<UINodePort>();
		[ContainerField(24), MemberInfoFlag(53), ContainerFieldNameHash(2089293587), ContainerCtrRef]
		public CtrRef<UINodePort> True { get { return m_True; } set { if (OnPropertyChanging("BinaryLogicNode." + nameof(True), this, m_True, value)) m_True = value; } } // 0x18 (24)
		
		protected CtrRef<UINodePort> m_False = new CtrRef<UINodePort>();
		[ContainerField(28), MemberInfoFlag(53), ContainerFieldNameHash(206401336), ContainerCtrRef]
		public CtrRef<UINodePort> False { get { return m_False; } set { if (OnPropertyChanging("BinaryLogicNode." + nameof(False), this, m_False, value)) m_False = value; } } // 0x1C (28)
		
		protected UIDataSourceInfo m_DataSourceInfo = new UIDataSourceInfo();
		[ContainerField(32), MemberInfoFlag(41), ContainerFieldNameHash(4099162406)]
		public UIDataSourceInfo DataSourceInfo { get { return m_DataSourceInfo; } set { if (OnPropertyChanging("BinaryLogicNode." + nameof(DataSourceInfo), this, m_DataSourceInfo, value)) m_DataSourceInfo = value; } } // 0x20 (32)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 5862146:
					In = (CtrRef<UINodePort>) p_Value;
					break;

				case 2089293587:
					True = (CtrRef<UINodePort>) p_Value;
					break;

				case 206401336:
					False = (CtrRef<UINodePort>) p_Value;
					break;

				case 4099162406:
					DataSourceInfo = (UIDataSourceInfo) p_Value;
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

				case 2089293587:
					return True;

				case 206401336:
					return False;

				case 4099162406:
					return DataSourceInfo;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 5862146:
					return typeof(BinaryLogicNode).GetProperty(nameof(In));

				case 2089293587:
					return typeof(BinaryLogicNode).GetProperty(nameof(True));

				case 206401336:
					return typeof(BinaryLogicNode).GetProperty(nameof(False));

				case 4099162406:
					return typeof(BinaryLogicNode).GetProperty(nameof(DataSourceInfo));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
