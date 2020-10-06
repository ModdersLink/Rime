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
	[ContainerType(4), MemberInfoFlag(41), ContainerSize(8), ContainerStruct]
	public class WeaponModifierData : FrostbiteContainer
	{
		[ContainerField(0), MemberInfoFlag(53), ContainerCtrRef]
		public CtrRef<UnlockAssetBase> UnlockAsset { get; set; } = new CtrRef<UnlockAssetBase>(); // 0x0 (0)
		
		[ContainerField(4), MemberInfoFlag(65), ContainerRefArray]
		public RefArray<WeaponModifierBase> Modifiers { get; set; } = new RefArray<WeaponModifierBase>(); // 0x4 (4)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4135652293:
					UnlockAsset = (CtrRef<UnlockAssetBase>) p_Value;
					break;

				case 105828545:
					Modifiers = (RefArray<WeaponModifierBase>) p_Value;
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

				case 105828545:
					return Modifiers;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4135652293:
					return typeof(WeaponModifierData).GetProperty(nameof(UnlockAsset));

				case 105828545:
					return typeof(WeaponModifierData).GetProperty(nameof(Modifiers));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
