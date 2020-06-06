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
	public class SoldierWeaponMultiUnlock : 
		UnlockUserDataBase
	{
		[ContainerField(12)]
		public CtrRef<UnlockAssetBase> First { get; set; } = new CtrRef<UnlockAssetBase>(); // 0xC (12)
		
		[ContainerField(16)]
		public List<UnlockAssetPair> UnlockAssetPairs { get; set; } = new List<UnlockAssetPair>(); // 0x10 (16)
		
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
