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
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 4,  Flags: 53, Size: 24)]
	public class PersistentCriteriaStatRef : 
		AbstractPersistentStatRef
	{
		protected CtrRef<CriteriaData> m_Criteria = new CtrRef<CriteriaData>();
		[ContainerField(Name: "Criteria", Offset: 8, NameHash: 335452726, Flags: 53)]
		public CtrRef<CriteriaData> Criteria { get { return m_Criteria; } set { if (OnPropertyChanging("PersistentCriteriaStatRef." + nameof(Criteria), this, m_Criteria, value)) m_Criteria = value; } } // 0x8 (8)
		
		protected CtrRef<StatsCategoryBaseData> m_ParamX = new CtrRef<StatsCategoryBaseData>();
		[ContainerField(Name: "ParamX", Offset: 12, NameHash: 3371566706, Flags: 53)]
		public CtrRef<StatsCategoryBaseData> ParamX { get { return m_ParamX; } set { if (OnPropertyChanging("PersistentCriteriaStatRef." + nameof(ParamX), this, m_ParamX, value)) m_ParamX = value; } } // 0xC (12)
		
		protected CtrRef<StatsCategoryBaseData> m_ParamY = new CtrRef<StatsCategoryBaseData>();
		[ContainerField(Name: "ParamY", Offset: 16, NameHash: 3371566707, Flags: 53)]
		public CtrRef<StatsCategoryBaseData> ParamY { get { return m_ParamY; } set { if (OnPropertyChanging("PersistentCriteriaStatRef." + nameof(ParamY), this, m_ParamY, value)) m_ParamY = value; } } // 0x10 (16)
		
		protected CtrRef<AwardData> m_CriteriaOwner = new CtrRef<AwardData>();
		[ContainerField(Name: "CriteriaOwner", Offset: 20, NameHash: 4139530871, Flags: 53)]
		public CtrRef<AwardData> CriteriaOwner { get { return m_CriteriaOwner; } set { if (OnPropertyChanging("PersistentCriteriaStatRef." + nameof(CriteriaOwner), this, m_CriteriaOwner, value)) m_CriteriaOwner = value; } } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 335452726:
					Criteria = (CtrRef<CriteriaData>) p_Value;
					break;

				case 3371566706:
					ParamX = (CtrRef<StatsCategoryBaseData>) p_Value;
					break;

				case 3371566707:
					ParamY = (CtrRef<StatsCategoryBaseData>) p_Value;
					break;

				case 4139530871:
					CriteriaOwner = (CtrRef<AwardData>) p_Value;
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
				case 335452726:
					return Criteria;

				case 3371566706:
					return ParamX;

				case 3371566707:
					return ParamY;

				case 4139530871:
					return CriteriaOwner;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 335452726:
					return typeof(PersistentCriteriaStatRef).GetProperty(nameof(Criteria));

				case 3371566706:
					return typeof(PersistentCriteriaStatRef).GetProperty(nameof(ParamX));

				case 3371566707:
					return typeof(PersistentCriteriaStatRef).GetProperty(nameof(ParamY));

				case 4139530871:
					return typeof(PersistentCriteriaStatRef).GetProperty(nameof(CriteriaOwner));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
