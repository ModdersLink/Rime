///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class PersistentCriteriaStatRef : 
		AbstractPersistentStatRef
	{
		[ContainerField(8)]
		public CtrRef<CriteriaData> Criteria { get; set; } = new CtrRef<CriteriaData>(); // 0x8 (8)
		
		[ContainerField(12)]
		public CtrRef<StatsCategoryBaseData> ParamX { get; set; } = new CtrRef<StatsCategoryBaseData>(); // 0xC (12)
		
		[ContainerField(16)]
		public CtrRef<StatsCategoryBaseData> ParamY { get; set; } = new CtrRef<StatsCategoryBaseData>(); // 0x10 (16)
		
		[ContainerField(20)]
		public CtrRef<AwardData> CriteriaOwner { get; set; } = new CtrRef<AwardData>(); // 0x14 (20)
		
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
