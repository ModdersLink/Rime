///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class UnlockComponentData : 
		ComponentData
	{
		[ContainerField(96)]
		public CtrRef<UnlockAssetBase> UnlockAsset { get; set; } = new CtrRef<UnlockAssetBase>(); // 0x60 (96)
		
		[ContainerField(100), LayoutImmutable, Blittable]
		public uint UnlockDataKey { get; set; } // 0x64 (100)
		
		[ContainerField(104), LayoutImmutable, Blittable]
		public bool UnlockableFromAllEntries { get; set; } // 0x68 (104)
		
		[ContainerField(105), LayoutImmutable, Blittable]
		public bool InvertUnlockTest { get; set; } // 0x69 (105)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4135652293:
					UnlockAsset = (CtrRef<UnlockAssetBase>) p_Value;
					break;

				case 955698258:
					UnlockDataKey = (uint) p_Value;
					break;

				case 2298992538:
					UnlockableFromAllEntries = (bool) p_Value;
					break;

				case 1973219505:
					InvertUnlockTest = (bool) p_Value;
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
				case 4135652293:
					return UnlockAsset;

				case 955698258:
					return UnlockDataKey;

				case 2298992538:
					return UnlockableFromAllEntries;

				case 1973219505:
					return InvertUnlockTest;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4135652293:
					return typeof(UnlockComponentData).GetProperty(nameof(UnlockAsset));

				case 955698258:
					return typeof(UnlockComponentData).GetProperty(nameof(UnlockDataKey));

				case 2298992538:
					return typeof(UnlockComponentData).GetProperty(nameof(UnlockableFromAllEntries));

				case 1973219505:
					return typeof(UnlockComponentData).GetProperty(nameof(InvertUnlockTest));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
