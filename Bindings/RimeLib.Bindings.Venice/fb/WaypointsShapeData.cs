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
	public class WaypointsShapeData : 
		VectorShapeData
	{
		protected RefArray<WaypointData> m_Waypoints = new RefArray<WaypointData>();
		[ContainerField(28), ContainerFieldNameHash(1635609973)]
		public RefArray<WaypointData> Waypoints { get { return m_Waypoints; } set { if (OnPropertyChanging("WaypointsShapeData." + nameof(Waypoints), this, m_Waypoints, value)) m_Waypoints = value; } } // 0x1C (28)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1635609973:
					Waypoints = (RefArray<WaypointData>) p_Value;
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
				case 1635609973:
					return Waypoints;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1635609973:
					return typeof(WaypointsShapeData).GetProperty(nameof(Waypoints));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
