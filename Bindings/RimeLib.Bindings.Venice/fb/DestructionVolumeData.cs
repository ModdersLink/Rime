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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 64)]
	public class DestructionVolumeData : 
		DataContainer
	{
		protected AxisAlignedBox m_BoundingBox = new AxisAlignedBox();
		[ContainerField(Name: "BoundingBox", Offset: 16, NameHash: 2648132290, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public AxisAlignedBox BoundingBox { get { return m_BoundingBox; } set { if (OnPropertyChanging("DestructionVolumeData." + nameof(BoundingBox), this, m_BoundingBox, value)) m_BoundingBox = value; } } // 0x10 (16)
		
		protected CtrRef<DestructionVolumeAsset> m_Asset = new CtrRef<DestructionVolumeAsset>();
		[ContainerField(Name: "Asset", Offset: 48, NameHash: 205976053, Flags: 53)]
		public CtrRef<DestructionVolumeAsset> Asset { get { return m_Asset; } set { if (OnPropertyChanging("DestructionVolumeData." + nameof(Asset), this, m_Asset, value)) m_Asset = value; } } // 0x30 (48)
		
		protected List<Vec4> m_Impacts = new List<Vec4>();
		[ContainerField(Name: "Impacts", Offset: 52, NameHash: 1723826932, Flags: 65)]
		public List<Vec4> Impacts { get { return m_Impacts; } set { if (OnPropertyChanging("DestructionVolumeData." + nameof(Impacts), this, m_Impacts, value)) m_Impacts = value; } } // 0x34 (52)
		
		protected List<uint> m_PartToImpactIndices = new List<uint>();
		[ContainerField(Name: "PartToImpactIndices", Offset: 56, NameHash: 4119124564, Flags: 65)]
		public List<uint> PartToImpactIndices { get { return m_PartToImpactIndices; } set { if (OnPropertyChanging("DestructionVolumeData." + nameof(PartToImpactIndices), this, m_PartToImpactIndices, value)) m_PartToImpactIndices = value; } } // 0x38 (56)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2648132290:
					BoundingBox = (AxisAlignedBox) p_Value;
					break;

				case 205976053:
					Asset = (CtrRef<DestructionVolumeAsset>) p_Value;
					break;

				case 1723826932:
					Impacts = (List<Vec4>) p_Value;
					break;

				case 4119124564:
					PartToImpactIndices = (List<uint>) p_Value;
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
				case 2648132290:
					return BoundingBox;

				case 205976053:
					return Asset;

				case 1723826932:
					return Impacts;

				case 4119124564:
					return PartToImpactIndices;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2648132290:
					return typeof(DestructionVolumeData).GetProperty(nameof(BoundingBox));

				case 205976053:
					return typeof(DestructionVolumeData).GetProperty(nameof(Asset));

				case 1723826932:
					return typeof(DestructionVolumeData).GetProperty(nameof(Impacts));

				case 4119124564:
					return typeof(DestructionVolumeData).GetProperty(nameof(PartToImpactIndices));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
