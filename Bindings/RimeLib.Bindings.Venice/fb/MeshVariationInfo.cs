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
	[ContainerType(4), MemberInfoFlag(41), ContainerSize(12), ContainerStruct]
	public class MeshVariationInfo : FrostbiteContainer
	{
		[ContainerField(0), MemberInfoFlag(53), ContainerCtrRef]
		public CtrRef<MeshAsset> MeshAsset { get; set; } = new CtrRef<MeshAsset>(); // 0x0 (0)
		
		[ContainerField(4), MemberInfoFlag(53), ContainerCtrRef]
		public CtrRef<MeshAsset> OrigMeshAsset { get; set; } = new CtrRef<MeshAsset>(); // 0x4 (4)
		
		[ContainerField(8), MemberInfoFlag(53), ContainerCtrRef]
		public CtrRef<ObjectVariation> VariationAsset { get; set; } = new CtrRef<ObjectVariation>(); // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 15738982:
					MeshAsset = (CtrRef<MeshAsset>) p_Value;
					break;

				case 4164356213:
					OrigMeshAsset = (CtrRef<MeshAsset>) p_Value;
					break;

				case 1781705092:
					VariationAsset = (CtrRef<ObjectVariation>) p_Value;
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
				case 15738982:
					return MeshAsset;

				case 4164356213:
					return OrigMeshAsset;

				case 1781705092:
					return VariationAsset;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 15738982:
					return typeof(MeshVariationInfo).GetProperty(nameof(MeshAsset));

				case 4164356213:
					return typeof(MeshVariationInfo).GetProperty(nameof(OrigMeshAsset));

				case 1781705092:
					return typeof(MeshVariationInfo).GetProperty(nameof(VariationAsset));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
