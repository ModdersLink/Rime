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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 20)]
	public class ChildStaticModelNetworkInfo : FrostbiteContainer
	{
		[ContainerField(Name: "NetworkRange", Offset: 0, NameHash: 1862047044, Flags: 41)]
		public IndexRange NetworkRange { get; set; } = new IndexRange(); // 0x0 (0)
		
		[ContainerField(Name: "ParentPartComponentIndex", Offset: 8, NameHash: 2200889407, Flags: 49421), LayoutImmutable, Blittable]
		public uint ParentPartComponentIndex { get; set; } // 0x8 (8)
		
		[ContainerField(Name: "ParentHealthStateIndex", Offset: 12, NameHash: 3385119660, Flags: 49421), LayoutImmutable, Blittable]
		public uint ParentHealthStateIndex { get; set; } // 0xC (12)
		
		[ContainerField(Name: "InstanceIndex", Offset: 16, NameHash: 521024402, Flags: 49421), LayoutImmutable, Blittable]
		public uint InstanceIndex { get; set; } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1862047044:
					NetworkRange = (IndexRange) p_Value;
					break;

				case 2200889407:
					ParentPartComponentIndex = (uint) p_Value;
					break;

				case 3385119660:
					ParentHealthStateIndex = (uint) p_Value;
					break;

				case 521024402:
					InstanceIndex = (uint) p_Value;
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
				case 1862047044:
					return NetworkRange;

				case 2200889407:
					return ParentPartComponentIndex;

				case 3385119660:
					return ParentHealthStateIndex;

				case 521024402:
					return InstanceIndex;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1862047044:
					return typeof(ChildStaticModelNetworkInfo).GetProperty(nameof(NetworkRange));

				case 2200889407:
					return typeof(ChildStaticModelNetworkInfo).GetProperty(nameof(ParentPartComponentIndex));

				case 3385119660:
					return typeof(ChildStaticModelNetworkInfo).GetProperty(nameof(ParentHealthStateIndex));

				case 521024402:
					return typeof(ChildStaticModelNetworkInfo).GetProperty(nameof(InstanceIndex));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
