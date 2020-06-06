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
	public class UICompassDataBinding : 
		UIDataBinding
	{
		[ContainerField(8)]
		public UIDataSourceInfo Heading { get; set; } = new UIDataSourceInfo(); // 0x8 (8)
		
		[ContainerField(24)]
		public UIDataSourceInfo Objectives { get; set; } = new UIDataSourceInfo(); // 0x18 (24)
		
		[ContainerField(40)]
		public UIDataSourceInfo Visibility { get; set; } = new UIDataSourceInfo(); // 0x28 (40)
		
		[ContainerField(56)]
		public UIDataSourceInfo ShowAirRadar { get; set; } = new UIDataSourceInfo(); // 0x38 (56)
		
		[ContainerField(72)]
		public UIDataSourceInfo RadarSweepDegree { get; set; } = new UIDataSourceInfo(); // 0x48 (72)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2009143629:
					Heading = (UIDataSourceInfo) p_Value;
					break;

				case 2766624249:
					Objectives = (UIDataSourceInfo) p_Value;
					break;

				case 1708270083:
					Visibility = (UIDataSourceInfo) p_Value;
					break;

				case 1704705368:
					ShowAirRadar = (UIDataSourceInfo) p_Value;
					break;

				case 2148740705:
					RadarSweepDegree = (UIDataSourceInfo) p_Value;
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
				case 2009143629:
					return Heading;

				case 2766624249:
					return Objectives;

				case 1708270083:
					return Visibility;

				case 1704705368:
					return ShowAirRadar;

				case 2148740705:
					return RadarSweepDegree;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2009143629:
					return typeof(UICompassDataBinding).GetProperty(nameof(Heading));

				case 2766624249:
					return typeof(UICompassDataBinding).GetProperty(nameof(Objectives));

				case 1708270083:
					return typeof(UICompassDataBinding).GetProperty(nameof(Visibility));

				case 1704705368:
					return typeof(UICompassDataBinding).GetProperty(nameof(ShowAirRadar));

				case 2148740705:
					return typeof(UICompassDataBinding).GetProperty(nameof(RadarSweepDegree));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
