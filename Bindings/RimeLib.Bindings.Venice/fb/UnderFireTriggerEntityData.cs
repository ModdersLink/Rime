///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class UnderFireTriggerEntityData : 
		TriggerEntityData
	{
		[ContainerField(112), LayoutImmutable, Blittable]
		public float Radius { get; set; } // 0x70 (112)
		
		[ContainerField(116), LayoutImmutable, Blittable]
		public float CoolDownTime { get; set; } // 0x74 (116)
		
		[ContainerField(120)]
		public CtrRef<MaterialContainerPair> TriggerOnMaterialOnly { get; set; } = new CtrRef<MaterialContainerPair>(); // 0x78 (120)
		
		[ContainerField(124)]
		public AreaTriggerInclude TriggeredBy { get; set; } = new AreaTriggerInclude(); // 0x7C (124)
		
		[ContainerField(128), LayoutImmutable, Blittable]
		public bool DisableIfTrackEntityIsLost { get; set; } // 0x80 (128)
		
		[ContainerField(129), LayoutImmutable, Blittable]
		public bool RandomYaw { get; set; } // 0x81 (129)
		
		[ContainerField(130), LayoutImmutable, Blittable]
		public bool IndicateHit { get; set; } // 0x82 (130)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3298407133:
					Radius = (float) p_Value;
					break;

				case 282296301:
					CoolDownTime = (float) p_Value;
					break;

				case 3821487555:
					TriggerOnMaterialOnly = (CtrRef<MaterialContainerPair>) p_Value;
					break;

				case 1020865575:
					TriggeredBy = (AreaTriggerInclude) Enum.ToObject(typeof(AreaTriggerInclude), p_Value);
					break;

				case 1061491348:
					DisableIfTrackEntityIsLost = (bool) p_Value;
					break;

				case 1799468081:
					RandomYaw = (bool) p_Value;
					break;

				case 1494915465:
					IndicateHit = (bool) p_Value;
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
				case 3298407133:
					return Radius;

				case 282296301:
					return CoolDownTime;

				case 3821487555:
					return TriggerOnMaterialOnly;

				case 1020865575:
					return TriggeredBy;

				case 1061491348:
					return DisableIfTrackEntityIsLost;

				case 1799468081:
					return RandomYaw;

				case 1494915465:
					return IndicateHit;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3298407133:
					return typeof(UnderFireTriggerEntityData).GetProperty(nameof(Radius));

				case 282296301:
					return typeof(UnderFireTriggerEntityData).GetProperty(nameof(CoolDownTime));

				case 3821487555:
					return typeof(UnderFireTriggerEntityData).GetProperty(nameof(TriggerOnMaterialOnly));

				case 1020865575:
					return typeof(UnderFireTriggerEntityData).GetProperty(nameof(TriggeredBy));

				case 1061491348:
					return typeof(UnderFireTriggerEntityData).GetProperty(nameof(DisableIfTrackEntityIsLost));

				case 1799468081:
					return typeof(UnderFireTriggerEntityData).GetProperty(nameof(RandomYaw));

				case 1494915465:
					return typeof(UnderFireTriggerEntityData).GetProperty(nameof(IndicateHit));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
