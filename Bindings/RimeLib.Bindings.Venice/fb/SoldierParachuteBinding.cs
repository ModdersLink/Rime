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
	public class SoldierParachuteBinding : FrostbiteContainer
	{
		[ContainerField(0)]
		public AntRef Enabled { get; set; } = new AntRef(); // 0x0 (0)
		
		[ContainerField(4)]
		public AntRef SteerLeftRight { get; set; } = new AntRef(); // 0x4 (4)
		
		[ContainerField(8)]
		public AntRef AccelerateBrake { get; set; } = new AntRef(); // 0x8 (8)
		
		[ContainerField(12)]
		public AntRef Pitch { get; set; } = new AntRef(); // 0xC (12)
		
		[ContainerField(16)]
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
