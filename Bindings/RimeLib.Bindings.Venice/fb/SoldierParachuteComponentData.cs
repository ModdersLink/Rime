///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class SoldierParachuteComponentData : 
		ComponentData
	{
		[ContainerField(96)]
		public SoldierParachuteBinding Binding { get; set; } = new SoldierParachuteBinding(); // 0x60 (96)
		
		[ContainerField(116)]
		public AimingConstraintsData AimingConstraints { get; set; } = new AimingConstraintsData(); // 0x74 (116)
		
		[ContainerField(132), LayoutImmutable, Blittable]
		public float UndeployTime { get; set; } // 0x84 (132)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2590060228:
					Binding = (SoldierParachuteBinding) p_Value;
					break;

				case 1523178198:
					AimingConstraints = (AimingConstraintsData) p_Value;
					break;

				case 1689758176:
					UndeployTime = (float) p_Value;
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
				case 2590060228:
					return Binding;

				case 1523178198:
					return AimingConstraints;

				case 1689758176:
					return UndeployTime;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2590060228:
					return typeof(SoldierParachuteComponentData).GetProperty(nameof(Binding));

				case 1523178198:
					return typeof(SoldierParachuteComponentData).GetProperty(nameof(AimingConstraints));

				case 1689758176:
					return typeof(SoldierParachuteComponentData).GetProperty(nameof(UndeployTime));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
