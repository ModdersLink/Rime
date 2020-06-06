///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class ArmamentData : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public int ThreatLength { get; set; } // 0x8 (8)
		
		[ContainerField(12)]
		public CtrRef<TurretData> TurretData { get; set; } = new CtrRef<TurretData>(); // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public bool IsAntiAircraft { get; set; } // 0x10 (16)
		
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
