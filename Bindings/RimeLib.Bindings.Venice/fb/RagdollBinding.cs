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
	public class RagdollBinding : FrostbiteContainer
	{
		[ContainerField(Name: "RagdollOnBack", Offset: 0, NameHash: 2489942928, Flags: 41)]
		public AntRef RagdollOnBack { get; set; } = new AntRef(); // 0x0 (0)
		
		[ContainerField(Name: "RagdollBlend", Offset: 4, NameHash: 4115440603, Flags: 41)]
		public AntRef RagdollBlend { get; set; } = new AntRef(); // 0x4 (4)
		
		[ContainerField(Name: "RagdollForceBlendDisabled", Offset: 8, NameHash: 1434101654, Flags: 41)]
		public AntRef RagdollForceBlendDisabled { get; set; } = new AntRef(); // 0x8 (8)
		
		[ContainerField(Name: "RagdollActiveTime", Offset: 12, NameHash: 3250948099, Flags: 41)]
		public AntRef RagdollActiveTime { get; set; } = new AntRef(); // 0xC (12)
		
		[ContainerField(Name: "RagdollFullyBlendedIn", Offset: 16, NameHash: 2375624599, Flags: 41)]
		public AntRef RagdollFullyBlendedIn { get; set; } = new AntRef(); // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2489942928:
					RagdollOnBack = (AntRef) p_Value;
					break;

				case 4115440603:
					RagdollBlend = (AntRef) p_Value;
					break;

				case 1434101654:
					RagdollForceBlendDisabled = (AntRef) p_Value;
					break;

				case 3250948099:
					RagdollActiveTime = (AntRef) p_Value;
					break;

				case 2375624599:
					RagdollFullyBlendedIn = (AntRef) p_Value;
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
				case 2489942928:
					return RagdollOnBack;

				case 4115440603:
					return RagdollBlend;

				case 1434101654:
					return RagdollForceBlendDisabled;

				case 3250948099:
					return RagdollActiveTime;

				case 2375624599:
					return RagdollFullyBlendedIn;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2489942928:
					return typeof(RagdollBinding).GetProperty(nameof(RagdollOnBack));

				case 4115440603:
					return typeof(RagdollBinding).GetProperty(nameof(RagdollBlend));

				case 1434101654:
					return typeof(RagdollBinding).GetProperty(nameof(RagdollForceBlendDisabled));

				case 3250948099:
					return typeof(RagdollBinding).GetProperty(nameof(RagdollActiveTime));

				case 2375624599:
					return typeof(RagdollBinding).GetProperty(nameof(RagdollFullyBlendedIn));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
