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
	public class RichPresenceContextSetting : FrostbiteContainer
	{
		[ContainerField(Name: "Context", Offset: 0, NameHash: 3654325786, Flags: 53)]
		public CtrRef<RichPresenceContext> Context { get; set; } = new CtrRef<RichPresenceContext>(); // 0x0 (0)
		
		[ContainerField(Name: "Value", Offset: 4, NameHash: 225375086, Flags: 53)]
		public CtrRef<RichPresenceContextValue> Value { get; set; } = new CtrRef<RichPresenceContextValue>(); // 0x4 (4)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3654325786:
					Context = (CtrRef<RichPresenceContext>) p_Value;
					break;

				case 225375086:
					Value = (CtrRef<RichPresenceContextValue>) p_Value;
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
				case 3654325786:
					return Context;

				case 225375086:
					return Value;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3654325786:
					return typeof(RichPresenceContextSetting).GetProperty(nameof(Context));

				case 225375086:
					return typeof(RichPresenceContextSetting).GetProperty(nameof(Value));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
