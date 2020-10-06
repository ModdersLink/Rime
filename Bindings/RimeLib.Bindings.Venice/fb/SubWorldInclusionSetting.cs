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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(16), ContainerClass]
	public class SubWorldInclusionSetting : 
		DataContainer
	{
		protected CtrRef<SubWorldInclusionCriterion> m_Criterion = new CtrRef<SubWorldInclusionCriterion>();
		[ContainerField(8), MemberInfoFlag(53), ContainerFieldNameHash(2480005462), ContainerCtrRef]
		public CtrRef<SubWorldInclusionCriterion> Criterion { get { return m_Criterion; } set { if (OnPropertyChanging("SubWorldInclusionSetting." + nameof(Criterion), this, m_Criterion, value)) m_Criterion = value; } } // 0x8 (8)
		
		protected List<string> m_EnabledOptions = new List<string>();
		[ContainerField(12), MemberInfoFlag(65), ContainerFieldNameHash(2588709552), ContainerArray]
		public List<string> EnabledOptions { get { return m_EnabledOptions; } set { if (OnPropertyChanging("SubWorldInclusionSetting." + nameof(EnabledOptions), this, m_EnabledOptions, value)) m_EnabledOptions = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2480005462:
					Criterion = (CtrRef<SubWorldInclusionCriterion>) p_Value;
					break;

				case 2588709552:
					EnabledOptions = (List<string>) p_Value;
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
				case 2480005462:
					return Criterion;

				case 2588709552:
					return EnabledOptions;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2480005462:
					return typeof(SubWorldInclusionSetting).GetProperty(nameof(Criterion));

				case 2588709552:
					return typeof(SubWorldInclusionSetting).GetProperty(nameof(EnabledOptions));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
