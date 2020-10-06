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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(32), ContainerClass]
	public class GameSplineData : 
		CustomSplineData
	{
		protected GameSplineType m_SplineType = new GameSplineType();
		[ContainerField(28), MemberInfoFlag(137), ContainerFieldNameHash(3992327344)]
		public GameSplineType SplineType { get { return m_SplineType; } set { if (OnPropertyChanging("GameSplineData." + nameof(SplineType), this, m_SplineType, value)) m_SplineType = value; } } // 0x1C (28)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3992327344:
					SplineType = (GameSplineType) Enum.ToObject(typeof(GameSplineType), p_Value);
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

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3992327344:
					return typeof(GameSplineData).GetProperty(nameof(SplineType));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
