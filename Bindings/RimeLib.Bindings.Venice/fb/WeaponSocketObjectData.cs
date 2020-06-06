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
    [ContainerType(4)]
	public class WeaponSocketObjectData : 
		SocketObjectDataBase
	{
		[ContainerField(8)]
		public List<uint> ReferencedAssetHashes { get; set; } = new List<uint>(); // 0x8 (8)
		
		[ContainerField(12)]
		public CtrRef<Asset> Asset1p { get; set; } = new CtrRef<Asset>(); // 0xC (12)
		
		[ContainerField(16)]
		public CtrRef<Asset> Asset1pzoom { get; set; } = new CtrRef<Asset>(); // 0x10 (16)
		
		[ContainerField(20)]
		public CtrRef<Asset> Asset3p { get; set; } = new CtrRef<Asset>(); // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3589205886:
					ReferencedAssetHashes = (List<uint>) p_Value;
					break;

				case 969622868:
					Asset1p = (CtrRef<Asset>) p_Value;
					break;

				case 230633315:
					Asset1pzoom = (CtrRef<Asset>) p_Value;
					break;

				case 969622806:
					Asset3p = (CtrRef<Asset>) p_Value;
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
				case 3589205886:
					return ReferencedAssetHashes;

				case 969622868:
					return Asset1p;

				case 230633315:
					return Asset1pzoom;

				case 969622806:
					return Asset3p;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3589205886:
					return typeof(WeaponSocketObjectData).GetProperty(nameof(ReferencedAssetHashes));

				case 969622868:
					return typeof(WeaponSocketObjectData).GetProperty(nameof(Asset1p));

				case 230633315:
					return typeof(WeaponSocketObjectData).GetProperty(nameof(Asset1pzoom));

				case 969622806:
					return typeof(WeaponSocketObjectData).GetProperty(nameof(Asset3p));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
