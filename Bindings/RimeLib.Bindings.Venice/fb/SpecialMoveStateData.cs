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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 60)]
	public class SpecialMoveStateData : FrostbiteContainer
	{
		[ContainerField(Name: "MinHeightScale", Offset: 0, NameHash: 1954093224, Flags: 49469), LayoutImmutable, Blittable]
		public float MinHeightScale { get; set; } // 0x0 (0)
		
		[ContainerField(Name: "OptimumDistanceFromObject", Offset: 4, NameHash: 994268946, Flags: 49469), LayoutImmutable, Blittable]
		public float OptimumDistanceFromObject { get; set; } // 0x4 (4)
		
		[ContainerField(Name: "OptimumHeightOfObject", Offset: 8, NameHash: 885491089, Flags: 49469), LayoutImmutable, Blittable]
		public float OptimumHeightOfObject { get; set; } // 0x8 (8)
		
		[ContainerField(Name: "OptimumLengthOfObject", Offset: 12, NameHash: 2467815538, Flags: 49469), LayoutImmutable, Blittable]
		public float OptimumLengthOfObject { get; set; } // 0xC (12)
		
		[ContainerField(Name: "MaxDistanceScale", Offset: 16, NameHash: 301144810, Flags: 49469), LayoutImmutable, Blittable]
		public float MaxDistanceScale { get; set; } // 0x10 (16)
		
		[ContainerField(Name: "MinDistanceScale", Offset: 20, NameHash: 1135265332, Flags: 49469), LayoutImmutable, Blittable]
		public float MinDistanceScale { get; set; } // 0x14 (20)
		
		[ContainerField(Name: "MaxHeightScale", Offset: 24, NameHash: 3932743542, Flags: 49469), LayoutImmutable, Blittable]
		public float MaxHeightScale { get; set; } // 0x18 (24)
		
		[ContainerField(Name: "MotionPoints", Offset: 28, NameHash: 1211724068, Flags: 65)]
		public List<SpecialMoveInterpolatedPoint> MotionPoints { get; set; } = new List<SpecialMoveInterpolatedPoint>(); // 0x1C (28)
		
		[ContainerField(Name: "MaxObjectLengthScale", Offset: 32, NameHash: 842198496, Flags: 49469), LayoutImmutable, Blittable]
		public float MaxObjectLengthScale { get; set; } // 0x20 (32)
		
		[ContainerField(Name: "MinObjectLengthScale", Offset: 36, NameHash: 746779070, Flags: 49469), LayoutImmutable, Blittable]
		public float MinObjectLengthScale { get; set; } // 0x24 (36)
		
		[ContainerField(Name: "ExitAnimationDrivenStateVelocity", Offset: 40, NameHash: 926295825, Flags: 49469), LayoutImmutable, Blittable]
		public float ExitAnimationDrivenStateVelocity { get; set; } // 0x28 (40)
		
		[ContainerField(Name: "ResetPose", Offset: 44, NameHash: 1918089849, Flags: 137)]
		public SpecialMovesPoseType ResetPose { get; set; } = new SpecialMovesPoseType(); // 0x2C (44)
		
		[ContainerField(Name: "OverridePose", Offset: 48, NameHash: 4159539896, Flags: 137)]
		public SpecialMovesPoseType OverridePose { get; set; } = new SpecialMovesPoseType(); // 0x30 (48)
		
		[ContainerField(Name: "GravityPoints", Offset: 52, NameHash: 1228375932, Flags: 65)]
		public List<SpecialMoveInterpolatedPoint> GravityPoints { get; set; } = new List<SpecialMoveInterpolatedPoint>(); // 0x34 (52)
		
		[ContainerField(Name: "KeepInitialSoldierDirection", Offset: 56, NameHash: 3901116463, Flags: 49325), LayoutImmutable, Blittable]
		public bool KeepInitialSoldierDirection { get; set; } // 0x38 (56)
		
		[ContainerField(Name: "ScaleWithDistanceToObject", Offset: 57, NameHash: 2442340306, Flags: 49325), LayoutImmutable, Blittable]
		public bool ScaleWithDistanceToObject { get; set; } // 0x39 (57)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1954093224:
					MinHeightScale = (float) p_Value;
					break;

				case 994268946:
					OptimumDistanceFromObject = (float) p_Value;
					break;

				case 885491089:
					OptimumHeightOfObject = (float) p_Value;
					break;

				case 2467815538:
					OptimumLengthOfObject = (float) p_Value;
					break;

				case 301144810:
					MaxDistanceScale = (float) p_Value;
					break;

				case 1135265332:
					MinDistanceScale = (float) p_Value;
					break;

				case 3932743542:
					MaxHeightScale = (float) p_Value;
					break;

				case 1211724068:
					MotionPoints = (List<SpecialMoveInterpolatedPoint>) p_Value;
					break;

				case 842198496:
					MaxObjectLengthScale = (float) p_Value;
					break;

				case 746779070:
					MinObjectLengthScale = (float) p_Value;
					break;

				case 926295825:
					ExitAnimationDrivenStateVelocity = (float) p_Value;
					break;

				case 1918089849:
						ResetPose = (SpecialMovesPoseType) Enum.ToObject(typeof(SpecialMovesPoseType), p_Value);
					break;

				case 4159539896:
						OverridePose = (SpecialMovesPoseType) Enum.ToObject(typeof(SpecialMovesPoseType), p_Value);
					break;

				case 1228375932:
					GravityPoints = (List<SpecialMoveInterpolatedPoint>) p_Value;
					break;

				case 3901116463:
					KeepInitialSoldierDirection = (bool) p_Value;
					break;

				case 2442340306:
					ScaleWithDistanceToObject = (bool) p_Value;
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
				case 1954093224:
					return MinHeightScale;

				case 994268946:
					return OptimumDistanceFromObject;

				case 885491089:
					return OptimumHeightOfObject;

				case 2467815538:
					return OptimumLengthOfObject;

				case 301144810:
					return MaxDistanceScale;

				case 1135265332:
					return MinDistanceScale;

				case 3932743542:
					return MaxHeightScale;

				case 1211724068:
					return MotionPoints;

				case 842198496:
					return MaxObjectLengthScale;

				case 746779070:
					return MinObjectLengthScale;

				case 926295825:
					return ExitAnimationDrivenStateVelocity;

				case 1918089849:
					return ResetPose;

				case 4159539896:
					return OverridePose;

				case 1228375932:
					return GravityPoints;

				case 3901116463:
					return KeepInitialSoldierDirection;

				case 2442340306:
					return ScaleWithDistanceToObject;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1954093224:
					return typeof(SpecialMoveStateData).GetProperty(nameof(MinHeightScale));

				case 994268946:
					return typeof(SpecialMoveStateData).GetProperty(nameof(OptimumDistanceFromObject));

				case 885491089:
					return typeof(SpecialMoveStateData).GetProperty(nameof(OptimumHeightOfObject));

				case 2467815538:
					return typeof(SpecialMoveStateData).GetProperty(nameof(OptimumLengthOfObject));

				case 301144810:
					return typeof(SpecialMoveStateData).GetProperty(nameof(MaxDistanceScale));

				case 1135265332:
					return typeof(SpecialMoveStateData).GetProperty(nameof(MinDistanceScale));

				case 3932743542:
					return typeof(SpecialMoveStateData).GetProperty(nameof(MaxHeightScale));

				case 1211724068:
					return typeof(SpecialMoveStateData).GetProperty(nameof(MotionPoints));

				case 842198496:
					return typeof(SpecialMoveStateData).GetProperty(nameof(MaxObjectLengthScale));

				case 746779070:
					return typeof(SpecialMoveStateData).GetProperty(nameof(MinObjectLengthScale));

				case 926295825:
					return typeof(SpecialMoveStateData).GetProperty(nameof(ExitAnimationDrivenStateVelocity));

				case 1918089849:
					return typeof(SpecialMoveStateData).GetProperty(nameof(ResetPose));

				case 4159539896:
					return typeof(SpecialMoveStateData).GetProperty(nameof(OverridePose));

				case 1228375932:
					return typeof(SpecialMoveStateData).GetProperty(nameof(GravityPoints));

				case 3901116463:
					return typeof(SpecialMoveStateData).GetProperty(nameof(KeepInitialSoldierDirection));

				case 2442340306:
					return typeof(SpecialMoveStateData).GetProperty(nameof(ScaleWithDistanceToObject));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
