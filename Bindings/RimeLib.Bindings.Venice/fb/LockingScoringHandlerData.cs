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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(12), ContainerClass]
	public class LockingScoringHandlerData : 
		ScoringHandlerData
	{
		protected float m_HotVehicleTimeout = new float();
		[ContainerField(8), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1202160117)]
		public float HotVehicleTimeout { get { return m_HotVehicleTimeout; } set { if (OnPropertyChanging("LockingScoringHandlerData." + nameof(HotVehicleTimeout), this, m_HotVehicleTimeout, value)) m_HotVehicleTimeout = value; } } // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1202160117:
					HotVehicleTimeout = (float) p_Value;
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
				case 1202160117:
					return HotVehicleTimeout;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1202160117:
					return typeof(LockingScoringHandlerData).GetProperty(nameof(HotVehicleTimeout));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
