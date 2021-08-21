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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 44)]
	public class AntPackageAsset : 
		Asset
	{
		protected string m_Win32FileName = string.Empty;
		[ContainerField(Name: "Win32FileName", Offset: 12, NameHash: 2932314709, Flags: 16509), LayoutImmutable]
		public string Win32FileName { get { return m_Win32FileName; } set { if (OnPropertyChanging("AntPackageAsset." + nameof(Win32FileName), this, m_Win32FileName, value)) m_Win32FileName = value; } } // 0xC (12)
		
		protected string m_XePs3FileName = string.Empty;
		[ContainerField(Name: "XePs3FileName", Offset: 16, NameHash: 726189609, Flags: 16509), LayoutImmutable]
		public string XePs3FileName { get { return m_XePs3FileName; } set { if (OnPropertyChanging("AntPackageAsset." + nameof(XePs3FileName), this, m_XePs3FileName, value)) m_XePs3FileName = value; } } // 0x10 (16)
		
		protected AntPackagingType m_PackagingType = new AntPackagingType();
		[ContainerField(Name: "PackagingType", Offset: 20, NameHash: 1490994978, Flags: 137)]
		public AntPackagingType PackagingType { get { return m_PackagingType; } set { if (OnPropertyChanging("AntPackageAsset." + nameof(PackagingType), this, m_PackagingType, value)) m_PackagingType = value; } } // 0x14 (20)
		
		protected GUID m_StreamingGuid = new GUID();
		[ContainerField(Name: "StreamingGuid", Offset: 24, NameHash: 24747526, Flags: 49501), LayoutImmutable, Blittable]
		public GUID StreamingGuid { get { return m_StreamingGuid; } set { if (OnPropertyChanging("AntPackageAsset." + nameof(StreamingGuid), this, m_StreamingGuid, value)) m_StreamingGuid = value; } } // 0x18 (24)
		
		protected uint m_ChunkSize = new uint();
		[ContainerField(Name: "ChunkSize", Offset: 40, NameHash: 3692630139, Flags: 49421), LayoutImmutable, Blittable]
		public uint ChunkSize { get { return m_ChunkSize; } set { if (OnPropertyChanging("AntPackageAsset." + nameof(ChunkSize), this, m_ChunkSize, value)) m_ChunkSize = value; } } // 0x28 (40)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2932314709:
					Win32FileName = (string) p_Value;
					break;

				case 726189609:
					XePs3FileName = (string) p_Value;
					break;

				case 1490994978:
					PackagingType = (AntPackagingType) Enum.ToObject(typeof(AntPackagingType), p_Value);
					break;

				case 24747526:
					StreamingGuid = (GUID) p_Value;
					break;

				case 3692630139:
					ChunkSize = (uint) p_Value;
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
				case 2932314709:
					return Win32FileName;

				case 726189609:
					return XePs3FileName;

				case 1490994978:
					return PackagingType;

				case 24747526:
					return StreamingGuid;

				case 3692630139:
					return ChunkSize;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2932314709:
					return typeof(AntPackageAsset).GetProperty(nameof(Win32FileName));

				case 726189609:
					return typeof(AntPackageAsset).GetProperty(nameof(XePs3FileName));

				case 1490994978:
					return typeof(AntPackageAsset).GetProperty(nameof(PackagingType));

				case 24747526:
					return typeof(AntPackageAsset).GetProperty(nameof(StreamingGuid));

				case 3692630139:
					return typeof(AntPackageAsset).GetProperty(nameof(ChunkSize));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
