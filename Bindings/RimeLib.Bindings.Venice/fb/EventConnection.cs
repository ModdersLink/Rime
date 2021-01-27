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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 20)]
	public class EventConnection : FrostbiteContainer
	{
		[ContainerField(Name: "Source", Offset: 0, NameHash: 3339738264, Flags: 53)]
		public CtrRef<DataContainer> Source { get; set; } = new CtrRef<DataContainer>(); // 0x0 (0)
		
		[ContainerField(Name: "Target", Offset: 4, NameHash: 3215022804, Flags: 53)]
		public CtrRef<DataContainer> Target { get; set; } = new CtrRef<DataContainer>(); // 0x4 (4)
		
		[ContainerField(Name: "SourceEvent", Offset: 8, NameHash: 3000664532, Flags: 41)]
		public EventSpec SourceEvent { get; set; } = new EventSpec(); // 0x8 (8)
		
		[ContainerField(Name: "TargetEvent", Offset: 12, NameHash: 2254399000, Flags: 41)]
		public EventSpec TargetEvent { get; set; } = new EventSpec(); // 0xC (12)
		
		[ContainerField(Name: "TargetType", Offset: 16, NameHash: 328114796, Flags: 137)]
		public EventConnectionTargetType TargetType { get; set; } = new EventConnectionTargetType(); // 0x10 (16)
		
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

				case 3000664532:
					SourceEvent = (EventSpec) p_Value;
					break;

				case 2254399000:
					TargetEvent = (EventSpec) p_Value;
					break;

				case 328114796:
						TargetType = (EventConnectionTargetType) Enum.ToObject(typeof(EventConnectionTargetType), p_Value);
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

				case 3000664532:
					return SourceEvent;

				case 2254399000:
					return TargetEvent;

				case 328114796:
					return TargetType;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3339738264:
					return typeof(EventConnection).GetProperty(nameof(Source));

				case 3215022804:
					return typeof(EventConnection).GetProperty(nameof(Target));

				case 3000664532:
					return typeof(EventConnection).GetProperty(nameof(SourceEvent));

				case 2254399000:
					return typeof(EventConnection).GetProperty(nameof(TargetEvent));

				case 328114796:
					return typeof(EventConnection).GetProperty(nameof(TargetType));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
