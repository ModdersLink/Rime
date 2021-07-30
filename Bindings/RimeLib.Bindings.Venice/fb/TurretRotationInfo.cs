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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 24)]
	public class TurretRotationInfo : FrostbiteContainer
	{
		[ContainerField(Name: "RotationAxis", Offset: 0, NameHash: 3148542130, Flags: 137)]
		public RotationAxis RotationAxis { get; set; } = new RotationAxis(); // 0x0 (0)
		
		[ContainerField(Name: "Channel", Offset: 4, NameHash: 4082709062, Flags: 137)]
		public RotationChannel Channel { get; set; } = new RotationChannel(); // 0x4 (4)
		
		[ContainerField(Name: "MaxRotation", Offset: 8, NameHash: 1608547717, Flags: 49469), LayoutImmutable, Blittable]
		public float MaxRotation { get; set; } // 0x8 (8)
		
		[ContainerField(Name: "MinRotation", Offset: 12, NameHash: 3781648795, Flags: 49469), LayoutImmutable, Blittable]
		public float MinRotation { get; set; } // 0xC (12)
		
		[ContainerField(Name: "PhaseOffset", Offset: 16, NameHash: 3780505959, Flags: 49469), LayoutImmutable, Blittable]
		public float PhaseOffset { get; set; } // 0x10 (16)
		
		[ContainerField(Name: "NormalizeRotation", Offset: 20, NameHash: 1190235636, Flags: 49325), LayoutImmutable, Blittable]
		public bool NormalizeRotation { get; set; } // 0x14 (20)
		
		[ContainerField(Name: "InvertRotation", Offset: 21, NameHash: 1002888771, Flags: 49325), LayoutImmutable, Blittable]
		public bool InvertRotation { get; set; } // 0x15 (21)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3148542130:
						RotationAxis = (RotationAxis) Enum.ToObject(typeof(RotationAxis), p_Value);
					break;

				case 4082709062:
						Channel = (RotationChannel) Enum.ToObject(typeof(RotationChannel), p_Value);
					break;

				case 1608547717:
					MaxRotation = (float) p_Value;
					break;

				case 3781648795:
					MinRotation = (float) p_Value;
					break;

				case 3780505959:
					PhaseOffset = (float) p_Value;
					break;

				case 1190235636:
					NormalizeRotation = (bool) p_Value;
					break;

				case 1002888771:
					InvertRotation = (bool) p_Value;
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
				case 3148542130:
					return RotationAxis;

				case 4082709062:
					return Channel;

				case 1608547717:
					return MaxRotation;

				case 3781648795:
					return MinRotation;

				case 3780505959:
					return PhaseOffset;

				case 1190235636:
					return NormalizeRotation;

				case 1002888771:
					return InvertRotation;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3148542130:
					return typeof(TurretRotationInfo).GetProperty(nameof(RotationAxis));

				case 4082709062:
					return typeof(TurretRotationInfo).GetProperty(nameof(Channel));

				case 1608547717:
					return typeof(TurretRotationInfo).GetProperty(nameof(MaxRotation));

				case 3781648795:
					return typeof(TurretRotationInfo).GetProperty(nameof(MinRotation));

				case 3780505959:
					return typeof(TurretRotationInfo).GetProperty(nameof(PhaseOffset));

				case 1190235636:
					return typeof(TurretRotationInfo).GetProperty(nameof(NormalizeRotation));

				case 1002888771:
					return typeof(TurretRotationInfo).GetProperty(nameof(InvertRotation));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
