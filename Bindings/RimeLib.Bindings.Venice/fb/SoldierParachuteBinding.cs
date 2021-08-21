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
	public class SoldierParachuteBinding : FrostbiteContainer
	{
		[ContainerField(Name: "Enabled", Offset: 0, NameHash: 2662400, Flags: 41)]
		public AntRef Enabled { get; set; } = new AntRef(); // 0x0 (0)
		
		[ContainerField(Name: "SteerLeftRight", Offset: 4, NameHash: 1723505707, Flags: 41)]
		public AntRef SteerLeftRight { get; set; } = new AntRef(); // 0x4 (4)
		
		[ContainerField(Name: "AccelerateBrake", Offset: 8, NameHash: 3628539477, Flags: 41)]
		public AntRef AccelerateBrake { get; set; } = new AntRef(); // 0x8 (8)
		
		[ContainerField(Name: "Pitch", Offset: 12, NameHash: 232604323, Flags: 41)]
		public AntRef Pitch { get; set; } = new AntRef(); // 0xC (12)
		
		[ContainerField(Name: "Roll", Offset: 16, NameHash: 2089387576, Flags: 41)]
		public AntRef Roll { get; set; } = new AntRef(); // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2662400:
					Enabled = (AntRef) p_Value;
					break;

				case 1723505707:
					SteerLeftRight = (AntRef) p_Value;
					break;

				case 3628539477:
					AccelerateBrake = (AntRef) p_Value;
					break;

				case 232604323:
					Pitch = (AntRef) p_Value;
					break;

				case 2089387576:
					Roll = (AntRef) p_Value;
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
				case 2662400:
					return Enabled;

				case 1723505707:
					return SteerLeftRight;

				case 3628539477:
					return AccelerateBrake;

				case 232604323:
					return Pitch;

				case 2089387576:
					return Roll;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2662400:
					return typeof(SoldierParachuteBinding).GetProperty(nameof(Enabled));

				case 1723505707:
					return typeof(SoldierParachuteBinding).GetProperty(nameof(SteerLeftRight));

				case 3628539477:
					return typeof(SoldierParachuteBinding).GetProperty(nameof(AccelerateBrake));

				case 232604323:
					return typeof(SoldierParachuteBinding).GetProperty(nameof(Pitch));

				case 2089387576:
					return typeof(SoldierParachuteBinding).GetProperty(nameof(Roll));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
