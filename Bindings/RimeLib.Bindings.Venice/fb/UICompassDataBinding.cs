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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 88)]
	public class UICompassDataBinding : 
		UIDataBinding
	{
		protected UIDataSourceInfo m_Heading = new UIDataSourceInfo();
		[ContainerField(Name: "Heading", Offset: 8, NameHash: 2009143629, Flags: 41)]
		public UIDataSourceInfo Heading { get { return m_Heading; } set { if (OnPropertyChanging("UICompassDataBinding." + nameof(Heading), this, m_Heading, value)) m_Heading = value; } } // 0x8 (8)
		
		protected UIDataSourceInfo m_Objectives = new UIDataSourceInfo();
		[ContainerField(Name: "Objectives", Offset: 24, NameHash: 2766624249, Flags: 41)]
		public UIDataSourceInfo Objectives { get { return m_Objectives; } set { if (OnPropertyChanging("UICompassDataBinding." + nameof(Objectives), this, m_Objectives, value)) m_Objectives = value; } } // 0x18 (24)
		
		protected UIDataSourceInfo m_Visibility = new UIDataSourceInfo();
		[ContainerField(Name: "Visibility", Offset: 40, NameHash: 1708270083, Flags: 41)]
		public UIDataSourceInfo Visibility { get { return m_Visibility; } set { if (OnPropertyChanging("UICompassDataBinding." + nameof(Visibility), this, m_Visibility, value)) m_Visibility = value; } } // 0x28 (40)
		
		protected UIDataSourceInfo m_ShowAirRadar = new UIDataSourceInfo();
		[ContainerField(Name: "ShowAirRadar", Offset: 56, NameHash: 1704705368, Flags: 41)]
		public UIDataSourceInfo ShowAirRadar { get { return m_ShowAirRadar; } set { if (OnPropertyChanging("UICompassDataBinding." + nameof(ShowAirRadar), this, m_ShowAirRadar, value)) m_ShowAirRadar = value; } } // 0x38 (56)
		
		protected UIDataSourceInfo m_RadarSweepDegree = new UIDataSourceInfo();
		[ContainerField(Name: "RadarSweepDegree", Offset: 72, NameHash: 2148740705, Flags: 41)]
		public UIDataSourceInfo RadarSweepDegree { get { return m_RadarSweepDegree; } set { if (OnPropertyChanging("UICompassDataBinding." + nameof(RadarSweepDegree), this, m_RadarSweepDegree, value)) m_RadarSweepDegree = value; } } // 0x48 (72)
		
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
