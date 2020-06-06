///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class GameSplineEntityData : 
		GameEntityData
	{
		[ContainerField(96)]
		public GameSplineType SplineType { get; set; } = new GameSplineType(); // 0x60 (96)
		
		[ContainerField(100)]
		public List<Vec3> LocalPoints { get; set; } = new List<Vec3>(); // 0x64 (100)
		
		[ContainerField(104)]
		public List<Vec3> Normals { get; set; } = new List<Vec3>(); // 0x68 (104)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3992327344:
					SplineType = (GameSplineType) Enum.ToObject(typeof(GameSplineType), p_Value);
					break;

				case 168850167:
					LocalPoints = (List<Vec3>) p_Value;
					break;

				case 3102907301:
					Normals = (List<Vec3>) p_Value;
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
				case 3992327344:
					return SplineType;

				case 168850167:
					return LocalPoints;

				case 3102907301:
					return Normals;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3992327344:
					return typeof(GameSplineEntityData).GetProperty(nameof(SplineType));

				case 168850167:
					return typeof(GameSplineEntityData).GetProperty(nameof(LocalPoints));

				case 3102907301:
					return typeof(GameSplineEntityData).GetProperty(nameof(Normals));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
