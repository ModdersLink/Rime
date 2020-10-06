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
	[ContainerType(16), MemberInfoFlag(53), ContainerSize(112), ContainerClass]
	public class GameSplineEntityData : 
		GameEntityData
	{
		protected GameSplineType m_SplineType = new GameSplineType();
		[ContainerField(96), MemberInfoFlag(137), ContainerFieldNameHash(3992327344)]
		public GameSplineType SplineType { get { return m_SplineType; } set { if (OnPropertyChanging("GameSplineEntityData." + nameof(SplineType), this, m_SplineType, value)) m_SplineType = value; } } // 0x60 (96)
		
		protected List<Vec3> m_LocalPoints = new List<Vec3>();
		[ContainerField(100), MemberInfoFlag(65), ContainerFieldNameHash(168850167), ContainerArray]
		public List<Vec3> LocalPoints { get { return m_LocalPoints; } set { if (OnPropertyChanging("GameSplineEntityData." + nameof(LocalPoints), this, m_LocalPoints, value)) m_LocalPoints = value; } } // 0x64 (100)
		
		protected List<Vec3> m_Normals = new List<Vec3>();
		[ContainerField(104), MemberInfoFlag(65), ContainerFieldNameHash(3102907301), ContainerArray]
		public List<Vec3> Normals { get { return m_Normals; } set { if (OnPropertyChanging("GameSplineEntityData." + nameof(Normals), this, m_Normals, value)) m_Normals = value; } } // 0x68 (104)
		
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
