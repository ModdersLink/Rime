///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Collections.Generic;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class DestructionVolumeData : 
		DataContainer
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public AxisAlignedBox BoundingBox { get; set; } = new AxisAlignedBox(); // 0x10 (16)
		
		[ContainerField(48)]
		public CtrRef<DestructionVolumeAsset> Asset { get; set; } = new CtrRef<DestructionVolumeAsset>(); // 0x30 (48)
		
		[ContainerField(52)]
		public List<Vec4> Impacts { get; set; } = new List<Vec4>(); // 0x34 (52)
		
		[ContainerField(56)]
		public List<uint> PartToImpactIndices { get; set; } = new List<uint>(); // 0x38 (56)
		
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
