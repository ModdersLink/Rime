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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 20)]
	public class SoldierWeaponMultiUnlock : 
		UnlockUserDataBase
	{
		protected CtrRef<UnlockAssetBase> m_First = new CtrRef<UnlockAssetBase>();
		[ContainerField(Name: "First", Offset: 12, NameHash: 206694335, Flags: 53)]
		public CtrRef<UnlockAssetBase> First { get { return m_First; } set { if (OnPropertyChanging("SoldierWeaponMultiUnlock." + nameof(First), this, m_First, value)) m_First = value; } } // 0xC (12)
		
		protected List<UnlockAssetPair> m_UnlockAssetPairs = new List<UnlockAssetPair>();
		[ContainerField(Name: "UnlockAssetPairs", Offset: 16, NameHash: 2683444764, Flags: 65)]
		public List<UnlockAssetPair> UnlockAssetPairs { get { return m_UnlockAssetPairs; } set { if (OnPropertyChanging("SoldierWeaponMultiUnlock." + nameof(UnlockAssetPairs), this, m_UnlockAssetPairs, value)) m_UnlockAssetPairs = value; } } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 206694335:
					First = (CtrRef<UnlockAssetBase>) p_Value;
					break;

				case 2683444764:
					UnlockAssetPairs = (List<UnlockAssetPair>) p_Value;
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
				case 206694335:
					return First;

				case 2683444764:
					return UnlockAssetPairs;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 206694335:
					return typeof(SoldierWeaponMultiUnlock).GetProperty(nameof(First));

				case 2683444764:
					return typeof(SoldierWeaponMultiUnlock).GetProperty(nameof(UnlockAssetPairs));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
