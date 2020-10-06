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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(20), ContainerClass]
	public class BlueprintAndVariationPair : 
		Asset
	{
		protected CtrRef<Asset> m_BaseAsset = new CtrRef<Asset>();
		[ContainerField(12), MemberInfoFlag(53), ContainerFieldNameHash(1696234240), ContainerCtrRef]
		public CtrRef<Asset> BaseAsset { get { return m_BaseAsset; } set { if (OnPropertyChanging("BlueprintAndVariationPair." + nameof(BaseAsset), this, m_BaseAsset, value)) m_BaseAsset = value; } } // 0xC (12)
		
		protected CtrRef<ObjectVariation> m_Variation = new CtrRef<ObjectVariation>();
		[ContainerField(16), MemberInfoFlag(53), ContainerFieldNameHash(2945980116), ContainerCtrRef]
		public CtrRef<ObjectVariation> Variation { get { return m_Variation; } set { if (OnPropertyChanging("BlueprintAndVariationPair." + nameof(Variation), this, m_Variation, value)) m_Variation = value; } } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1696234240:
					BaseAsset = (CtrRef<Asset>) p_Value;
					break;

				case 2945980116:
					Variation = (CtrRef<ObjectVariation>) p_Value;
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
				case 1696234240:
					return BaseAsset;

				case 2945980116:
					return Variation;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1696234240:
					return typeof(BlueprintAndVariationPair).GetProperty(nameof(BaseAsset));

				case 2945980116:
					return typeof(BlueprintAndVariationPair).GetProperty(nameof(Variation));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
