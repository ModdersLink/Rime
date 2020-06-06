///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;


namespace fb
{
    [ContainerType(4)]
	public class AntPackageAsset : 
		Asset
	{
		[ContainerField(12), LayoutImmutable]
		public string Win32FileName { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable]
		public string XePs3FileName { get; set; } // 0x10 (16)
		
		[ContainerField(20)]
		public AntPackagingType PackagingType { get; set; } = new AntPackagingType(); // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public GUID StreamingGuid { get; set; } // 0x18 (24)
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public uint ChunkSize { get; set; } // 0x28 (40)
		
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
