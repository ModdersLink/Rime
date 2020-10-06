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
	[ContainerType(16), MemberInfoFlag(53), ContainerSize(128), ContainerClass]
	public class BFTargetEvaluatorComponentData : 
		TargetEvaluatorComponentData
	{
		protected CtrRef<TargetEvaluationConstantData> m_Settings = new CtrRef<TargetEvaluationConstantData>();
		[ContainerField(112), MemberInfoFlag(53), ContainerFieldNameHash(649772672), ContainerCtrRef]
		public CtrRef<TargetEvaluationConstantData> Settings { get { return m_Settings; } set { if (OnPropertyChanging("BFTargetEvaluatorComponentData." + nameof(Settings), this, m_Settings, value)) m_Settings = value; } } // 0x70 (112)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 649772672:
					Settings = (CtrRef<TargetEvaluationConstantData>) p_Value;
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
				case 649772672:
					return Settings;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 649772672:
					return typeof(BFTargetEvaluatorComponentData).GetProperty(nameof(Settings));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
