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
	[ContainerType(16), MemberInfoFlag(53), ContainerSize(176), ContainerClass]
	public class JammingComponentData : 
		ComponentData
	{
		protected SmokeJammingData m_SmokeJamming = new SmokeJammingData();
		[ContainerField(96), MemberInfoFlag(41), ContainerFieldNameHash(1348728305)]
		public SmokeJammingData SmokeJamming { get { return m_SmokeJamming; } set { if (OnPropertyChanging("JammingComponentData." + nameof(SmokeJamming), this, m_SmokeJamming, value)) m_SmokeJamming = value; } } // 0x60 (96)
		
		protected AirMissileJammingData m_AirMissileJamming = new AirMissileJammingData();
		[ContainerField(116), MemberInfoFlag(41), ContainerFieldNameHash(3537349392)]
		public AirMissileJammingData AirMissileJamming { get { return m_AirMissileJamming; } set { if (OnPropertyChanging("JammingComponentData." + nameof(AirMissileJamming), this, m_AirMissileJamming, value)) m_AirMissileJamming = value; } } // 0x74 (116)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1348728305:
					SmokeJamming = (SmokeJammingData) p_Value;
					break;

				case 3537349392:
					AirMissileJamming = (AirMissileJammingData) p_Value;
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
				case 1348728305:
					return SmokeJamming;

				case 3537349392:
					return AirMissileJamming;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1348728305:
					return typeof(JammingComponentData).GetProperty(nameof(SmokeJamming));

				case 3537349392:
					return typeof(JammingComponentData).GetProperty(nameof(AirMissileJamming));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
