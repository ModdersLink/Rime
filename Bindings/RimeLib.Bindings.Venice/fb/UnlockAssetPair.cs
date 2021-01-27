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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 8)]
	public class UnlockAssetPair : FrostbiteContainer
	{
		[ContainerField(Name: "Second", Offset: 0, NameHash: 3337441269, Flags: 53)]
		public CtrRef<UnlockAssetBase> Second { get; set; } = new CtrRef<UnlockAssetBase>(); // 0x0 (0)
		
		[ContainerField(Name: "Result", Offset: 4, NameHash: 3293273164, Flags: 53)]
		public CtrRef<UnlockAssetBase> Result { get; set; } = new CtrRef<UnlockAssetBase>(); // 0x4 (4)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3337441269:
					Second = (CtrRef<UnlockAssetBase>) p_Value;
					break;

				case 3293273164:
					Result = (CtrRef<UnlockAssetBase>) p_Value;
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
				case 3337441269:
					return Second;

				case 3293273164:
					return Result;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3337441269:
					return typeof(UnlockAssetPair).GetProperty(nameof(Second));

				case 3293273164:
					return typeof(UnlockAssetPair).GetProperty(nameof(Result));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
