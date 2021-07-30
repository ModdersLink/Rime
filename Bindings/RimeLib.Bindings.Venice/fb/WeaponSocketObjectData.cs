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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 24)]
	public class WeaponSocketObjectData : 
		SocketObjectDataBase
	{
		protected List<uint> m_ReferencedAssetHashes = new List<uint>();
		[ContainerField(Name: "ReferencedAssetHashes", Offset: 8, NameHash: 3589205886, Flags: 65)]
		public List<uint> ReferencedAssetHashes { get { return m_ReferencedAssetHashes; } set { if (OnPropertyChanging("WeaponSocketObjectData." + nameof(ReferencedAssetHashes), this, m_ReferencedAssetHashes, value)) m_ReferencedAssetHashes = value; } } // 0x8 (8)
		
		protected CtrRef<Asset> m_Asset1p = new CtrRef<Asset>();
		[ContainerField(Name: "Asset1p", Offset: 12, NameHash: 969622868, Flags: 53)]
		public CtrRef<Asset> Asset1p { get { return m_Asset1p; } set { if (OnPropertyChanging("WeaponSocketObjectData." + nameof(Asset1p), this, m_Asset1p, value)) m_Asset1p = value; } } // 0xC (12)
		
		protected CtrRef<Asset> m_Asset1pzoom = new CtrRef<Asset>();
		[ContainerField(Name: "Asset1pzoom", Offset: 16, NameHash: 230633315, Flags: 53)]
		public CtrRef<Asset> Asset1pzoom { get { return m_Asset1pzoom; } set { if (OnPropertyChanging("WeaponSocketObjectData." + nameof(Asset1pzoom), this, m_Asset1pzoom, value)) m_Asset1pzoom = value; } } // 0x10 (16)
		
		protected CtrRef<Asset> m_Asset3p = new CtrRef<Asset>();
		[ContainerField(Name: "Asset3p", Offset: 20, NameHash: 969622806, Flags: 53)]
		public CtrRef<Asset> Asset3p { get { return m_Asset3p; } set { if (OnPropertyChanging("WeaponSocketObjectData." + nameof(Asset3p), this, m_Asset3p, value)) m_Asset3p = value; } } // 0x14 (20)
		
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
