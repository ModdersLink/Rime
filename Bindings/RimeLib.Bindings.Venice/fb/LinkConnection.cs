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
	[ContainerType(4)]
	public class LinkConnection : FrostbiteContainer
	{
		[ContainerField(0)]
		public CtrRef<DataContainer> Source { get; set; } = new CtrRef<DataContainer>(); // 0x0 (0)
		
		[ContainerField(4)]
		public CtrRef<DataContainer> Target { get; set; } = new CtrRef<DataContainer>(); // 0x4 (4)
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public int SourceFieldId { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public int TargetFieldId { get; set; } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3339738264:
					Source = (CtrRef<DataContainer>) p_Value;
					break;

				case 3215022804:
					Target = (CtrRef<DataContainer>) p_Value;
					break;

				case 4259496439:
					SourceFieldId = (int) p_Value;
					break;

				case 2227058747:
					TargetFieldId = (int) p_Value;
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
				case 3339738264:
					return Source;

				case 3215022804:
					return Target;

				case 4259496439:
					return SourceFieldId;

				case 2227058747:
					return TargetFieldId;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3339738264:
					return typeof(LinkConnection).GetProperty(nameof(Source));

				case 3215022804:
					return typeof(LinkConnection).GetProperty(nameof(Target));

				case 4259496439:
					return typeof(LinkConnection).GetProperty(nameof(SourceFieldId));

				case 2227058747:
					return typeof(LinkConnection).GetProperty(nameof(TargetFieldId));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
