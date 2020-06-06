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
	public class ClimbLadderComponentData : 
		ComponentData
	{
		[ContainerField(96), LayoutImmutable, Blittable]
		public int ClimbPhase { get; set; } // 0x60 (96)
		
		[ContainerField(100), LayoutImmutable, Blittable]
		public int ConnectPhase { get; set; } // 0x64 (100)
		
		[ContainerField(104), LayoutImmutable, Blittable]
		public float ConnectJointDisplacement { get; set; } // 0x68 (104)
		
		[ContainerField(108)]
		public ClimbLadderBinding Binding { get; set; } = new ClimbLadderBinding(); // 0x6C (108)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2435927203:
					ClimbPhase = (int) p_Value;
					break;

				case 990855988:
					ConnectPhase = (int) p_Value;
					break;

				case 1469536954:
					ConnectJointDisplacement = (float) p_Value;
					break;

				case 2590060228:
					Binding = (ClimbLadderBinding) p_Value;
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
				case 2435927203:
					return ClimbPhase;

				case 990855988:
					return ConnectPhase;

				case 1469536954:
					return ConnectJointDisplacement;

				case 2590060228:
					return Binding;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2435927203:
					return typeof(ClimbLadderComponentData).GetProperty(nameof(ClimbPhase));

				case 990855988:
					return typeof(ClimbLadderComponentData).GetProperty(nameof(ConnectPhase));

				case 1469536954:
					return typeof(ClimbLadderComponentData).GetProperty(nameof(ConnectJointDisplacement));

				case 2590060228:
					return typeof(ClimbLadderComponentData).GetProperty(nameof(Binding));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
