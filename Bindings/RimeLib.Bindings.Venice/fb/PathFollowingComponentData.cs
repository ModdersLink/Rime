///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Collections.Generic;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class PathFollowingComponentData : 
		ComponentData
	{
		[ContainerField(96), LayoutImmutable, Blittable]
		public float UpdatePathAtDistancePercent { get; set; } // 0x60 (96)
		
		[ContainerField(100), LayoutImmutable, Blittable]
		public uint PreferredPathfindingIndex { get; set; } // 0x64 (100)
		
		[ContainerField(104)]
		public List<uint> AlternatePathfindingIndices { get; set; } = new List<uint>(); // 0x68 (104)
		
		[ContainerField(108), LayoutImmutable, Blittable]
		public float MovementCorridorRadius { get; set; } // 0x6C (108)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 324611860:
					UpdatePathAtDistancePercent = (float) p_Value;
					break;

				case 233434614:
					PreferredPathfindingIndex = (uint) p_Value;
					break;

				case 1978090370:
					AlternatePathfindingIndices = (List<uint>) p_Value;
					break;

				case 1392343010:
					MovementCorridorRadius = (float) p_Value;
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
				case 324611860:
					return UpdatePathAtDistancePercent;

				case 233434614:
					return PreferredPathfindingIndex;

				case 1978090370:
					return AlternatePathfindingIndices;

				case 1392343010:
					return MovementCorridorRadius;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 324611860:
					return typeof(PathFollowingComponentData).GetProperty(nameof(UpdatePathAtDistancePercent));

				case 233434614:
					return typeof(PathFollowingComponentData).GetProperty(nameof(PreferredPathfindingIndex));

				case 1978090370:
					return typeof(PathFollowingComponentData).GetProperty(nameof(AlternatePathfindingIndices));

				case 1392343010:
					return typeof(PathFollowingComponentData).GetProperty(nameof(MovementCorridorRadius));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
