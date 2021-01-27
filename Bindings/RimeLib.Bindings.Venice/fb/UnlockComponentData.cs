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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 112)]
	public class UnlockComponentData : 
		ComponentData
	{
		protected CtrRef<UnlockAssetBase> m_UnlockAsset = new CtrRef<UnlockAssetBase>();
		[ContainerField(Name: "UnlockAsset", Offset: 96, NameHash: 4135652293, Flags: 53)]
		public CtrRef<UnlockAssetBase> UnlockAsset { get { return m_UnlockAsset; } set { if (OnPropertyChanging("UnlockComponentData." + nameof(UnlockAsset), this, m_UnlockAsset, value)) m_UnlockAsset = value; } } // 0x60 (96)
		
		protected uint m_UnlockDataKey = new uint();
		[ContainerField(Name: "UnlockDataKey", Offset: 100, NameHash: 955698258, Flags: 49421), LayoutImmutable, Blittable]
		public uint UnlockDataKey { get { return m_UnlockDataKey; } set { if (OnPropertyChanging("UnlockComponentData." + nameof(UnlockDataKey), this, m_UnlockDataKey, value)) m_UnlockDataKey = value; } } // 0x64 (100)
		
		protected bool m_UnlockableFromAllEntries = new bool();
		[ContainerField(Name: "UnlockableFromAllEntries", Offset: 104, NameHash: 2298992538, Flags: 49325), LayoutImmutable, Blittable]
		public bool UnlockableFromAllEntries { get { return m_UnlockableFromAllEntries; } set { if (OnPropertyChanging("UnlockComponentData." + nameof(UnlockableFromAllEntries), this, m_UnlockableFromAllEntries, value)) m_UnlockableFromAllEntries = value; } } // 0x68 (104)
		
		protected bool m_InvertUnlockTest = new bool();
		[ContainerField(Name: "InvertUnlockTest", Offset: 105, NameHash: 1973219505, Flags: 49325), LayoutImmutable, Blittable]
		public bool InvertUnlockTest { get { return m_InvertUnlockTest; } set { if (OnPropertyChanging("UnlockComponentData." + nameof(InvertUnlockTest), this, m_InvertUnlockTest, value)) m_InvertUnlockTest = value; } } // 0x69 (105)
		
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
