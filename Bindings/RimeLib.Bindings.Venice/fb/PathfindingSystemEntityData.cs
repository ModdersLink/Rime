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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(16), ContainerClass]
	public class PathfindingSystemEntityData : 
		EntityData
	{
		protected List<uint> m_PathfindingTypesOnLevel = new List<uint>();
		[ContainerField(12), MemberInfoFlag(65), ContainerFieldNameHash(2264269169), ContainerArray]
		public List<uint> PathfindingTypesOnLevel { get { return m_PathfindingTypesOnLevel; } set { if (OnPropertyChanging("PathfindingSystemEntityData." + nameof(PathfindingTypesOnLevel), this, m_PathfindingTypesOnLevel, value)) m_PathfindingTypesOnLevel = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2264269169:
					PathfindingTypesOnLevel = (List<uint>) p_Value;
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
				case 2264269169:
					return PathfindingTypesOnLevel;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2264269169:
					return typeof(PathfindingSystemEntityData).GetProperty(nameof(PathfindingTypesOnLevel));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
