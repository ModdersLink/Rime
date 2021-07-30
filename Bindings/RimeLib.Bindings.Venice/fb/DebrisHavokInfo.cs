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
	public class DebrisHavokInfo : FrostbiteContainer
	{
		[ContainerField(Name: "HavokAsset", Offset: 0, NameHash: 2342641198, Flags: 53)]
		public CtrRef<HavokAsset> HavokAsset { get; set; } = new CtrRef<HavokAsset>(); // 0x0 (0)
		
		[ContainerField(Name: "ReserveCount", Offset: 4, NameHash: 1845599910, Flags: 49405), LayoutImmutable, Blittable]
		public int ReserveCount { get; set; } // 0x4 (4)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2342641198:
					HavokAsset = (CtrRef<HavokAsset>) p_Value;
					break;

				case 1845599910:
					ReserveCount = (int) p_Value;
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
				case 2342641198:
					return HavokAsset;

				case 1845599910:
					return ReserveCount;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2342641198:
					return typeof(DebrisHavokInfo).GetProperty(nameof(HavokAsset));

				case 1845599910:
					return typeof(DebrisHavokInfo).GetProperty(nameof(ReserveCount));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
