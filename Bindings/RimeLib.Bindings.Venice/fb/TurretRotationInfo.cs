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
	[ContainerType(4), MemberInfoFlag(41), ContainerSize(24), ContainerStruct]
	public class TurretRotationInfo : FrostbiteContainer
	{
		[ContainerField(0), MemberInfoFlag(137)]
		public RotationAxis RotationAxis { get; set; } = new RotationAxis(); // 0x0 (0)
		
		[ContainerField(4), MemberInfoFlag(137)]
		public RotationChannel Channel { get; set; } = new RotationChannel(); // 0x4 (4)
		
		[ContainerField(8), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float MaxRotation { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float MinRotation { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float PhaseOffset { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable, MemberInfoFlag(49325)]
		public bool NormalizeRotation { get; set; } // 0x14 (20)
		
		[ContainerField(21), LayoutImmutable, Blittable, MemberInfoFlag(49325)]
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
