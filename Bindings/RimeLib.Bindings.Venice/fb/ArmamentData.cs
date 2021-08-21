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
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 4,  Flags: 53, Size: 20)]
	public class ArmamentData : 
		DataContainer
	{
		protected int m_ThreatLength = new int();
		[ContainerField(Name: "ThreatLength", Offset: 8, NameHash: 2704429479, Flags: 49405), LayoutImmutable, Blittable]
		public int ThreatLength { get { return m_ThreatLength; } set { if (OnPropertyChanging("ArmamentData." + nameof(ThreatLength), this, m_ThreatLength, value)) m_ThreatLength = value; } } // 0x8 (8)
		
		protected CtrRef<TurretData> m_TurretData = new CtrRef<TurretData>();
		[ContainerField(Name: "TurretData", Offset: 12, NameHash: 1721999205, Flags: 53)]
		public CtrRef<TurretData> TurretData { get { return m_TurretData; } set { if (OnPropertyChanging("ArmamentData." + nameof(TurretData), this, m_TurretData, value)) m_TurretData = value; } } // 0xC (12)
		
		protected bool m_IsAntiAircraft = new bool();
		[ContainerField(Name: "IsAntiAircraft", Offset: 16, NameHash: 1061521109, Flags: 49325), LayoutImmutable, Blittable]
		public bool IsAntiAircraft { get { return m_IsAntiAircraft; } set { if (OnPropertyChanging("ArmamentData." + nameof(IsAntiAircraft), this, m_IsAntiAircraft, value)) m_IsAntiAircraft = value; } } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2704429479:
					ThreatLength = (int) p_Value;
					break;

				case 1721999205:
					TurretData = (CtrRef<TurretData>) p_Value;
					break;

				case 1061521109:
					IsAntiAircraft = (bool) p_Value;
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
				case 2704429479:
					return ThreatLength;

				case 1721999205:
					return TurretData;

				case 1061521109:
					return IsAntiAircraft;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2704429479:
					return typeof(ArmamentData).GetProperty(nameof(ThreatLength));

				case 1721999205:
					return typeof(ArmamentData).GetProperty(nameof(TurretData));

				case 1061521109:
					return typeof(ArmamentData).GetProperty(nameof(IsAntiAircraft));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
