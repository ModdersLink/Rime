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
	public class WarpAnimationBinding : FrostbiteContainer
	{
		[ContainerField(Name: "ConnectJointGroup", Offset: 0, NameHash: 3144089970, Flags: 41)]
		public AntRef ConnectJointGroup { get; set; } = new AntRef(); // 0x0 (0)
		
		[ContainerField(Name: "ConnectJointWeight", Offset: 4, NameHash: 1293270221, Flags: 41)]
		public AntRef ConnectJointWeight { get; set; } = new AntRef(); // 0x4 (4)
		
		[ContainerField(Name: "EnableAlign", Offset: 8, NameHash: 637937353, Flags: 41)]
		public AntRef EnableAlign { get; set; } = new AntRef(); // 0x8 (8)
		
		[ContainerField(Name: "DisableCulling", Offset: 12, NameHash: 900615207, Flags: 41)]
		public AntRef DisableCulling { get; set; } = new AntRef(); // 0xC (12)
		
		[ContainerField(Name: "TranslationYWarpTolerance", Offset: 16, NameHash: 544117098, Flags: 41)]
		public AntRef TranslationYWarpTolerance { get; set; } = new AntRef(); // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3144089970:
					ConnectJointGroup = (AntRef) p_Value;
					break;

				case 1293270221:
					ConnectJointWeight = (AntRef) p_Value;
					break;

				case 637937353:
					EnableAlign = (AntRef) p_Value;
					break;

				case 900615207:
					DisableCulling = (AntRef) p_Value;
					break;

				case 544117098:
					TranslationYWarpTolerance = (AntRef) p_Value;
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
				case 3144089970:
					return ConnectJointGroup;

				case 1293270221:
					return ConnectJointWeight;

				case 637937353:
					return EnableAlign;

				case 900615207:
					return DisableCulling;

				case 544117098:
					return TranslationYWarpTolerance;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3144089970:
					return typeof(WarpAnimationBinding).GetProperty(nameof(ConnectJointGroup));

				case 1293270221:
					return typeof(WarpAnimationBinding).GetProperty(nameof(ConnectJointWeight));

				case 637937353:
					return typeof(WarpAnimationBinding).GetProperty(nameof(EnableAlign));

				case 900615207:
					return typeof(WarpAnimationBinding).GetProperty(nameof(DisableCulling));

				case 544117098:
					return typeof(WarpAnimationBinding).GetProperty(nameof(TranslationYWarpTolerance));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
