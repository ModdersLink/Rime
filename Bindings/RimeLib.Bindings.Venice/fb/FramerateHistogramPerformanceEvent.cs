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
	[ContainerType(8)]
	public class FramerateHistogramPerformanceEvent : 
		MetricEvent
	{
		protected float m_SpikeAverage = new float();
		[ContainerField(16), LayoutImmutable, Blittable, ContainerFieldNameHash(4281755330)]
		public float SpikeAverage { get { return m_SpikeAverage; } set { if (OnPropertyChanging("FramerateHistogramPerformanceEvent." + nameof(SpikeAverage), this, m_SpikeAverage, value)) m_SpikeAverage = value; } } // 0x10 (16)
		
		protected float m_Below5 = new float();
		[ContainerField(20), LayoutImmutable, Blittable, ContainerFieldNameHash(2668044995)]
		public float Below5 { get { return m_Below5; } set { if (OnPropertyChanging("FramerateHistogramPerformanceEvent." + nameof(Below5), this, m_Below5, value)) m_Below5 = value; } } // 0x14 (20)
		
		protected float m_Below10 = new float();
		[ContainerField(24), LayoutImmutable, Blittable, ContainerFieldNameHash(2146139031)]
		public float Below10 { get { return m_Below10; } set { if (OnPropertyChanging("FramerateHistogramPerformanceEvent." + nameof(Below10), this, m_Below10, value)) m_Below10 = value; } } // 0x18 (24)
		
		protected float m_Below15 = new float();
		[ContainerField(28), LayoutImmutable, Blittable, ContainerFieldNameHash(2146139026)]
		public float Below15 { get { return m_Below15; } set { if (OnPropertyChanging("FramerateHistogramPerformanceEvent." + nameof(Below15), this, m_Below15, value)) m_Below15 = value; } } // 0x1C (28)
		
		protected float m_Below20 = new float();
		[ContainerField(32), LayoutImmutable, Blittable, ContainerFieldNameHash(2146138996)]
		public float Below20 { get { return m_Below20; } set { if (OnPropertyChanging("FramerateHistogramPerformanceEvent." + nameof(Below20), this, m_Below20, value)) m_Below20 = value; } } // 0x20 (32)
		
		protected float m_Below25 = new float();
		[ContainerField(36), LayoutImmutable, Blittable, ContainerFieldNameHash(2146138993)]
		public float Below25 { get { return m_Below25; } set { if (OnPropertyChanging("FramerateHistogramPerformanceEvent." + nameof(Below25), this, m_Below25, value)) m_Below25 = value; } } // 0x24 (36)
		
		protected float m_Below30 = new float();
		[ContainerField(40), LayoutImmutable, Blittable, ContainerFieldNameHash(2146138965)]
		public float Below30 { get { return m_Below30; } set { if (OnPropertyChanging("FramerateHistogramPerformanceEvent." + nameof(Below30), this, m_Below30, value)) m_Below30 = value; } } // 0x28 (40)
		
		protected float m_Below60 = new float();
		[ContainerField(44), LayoutImmutable, Blittable, ContainerFieldNameHash(2146138864)]
		public float Below60 { get { return m_Below60; } set { if (OnPropertyChanging("FramerateHistogramPerformanceEvent." + nameof(Below60), this, m_Below60, value)) m_Below60 = value; } } // 0x2C (44)
		
		protected float m_Above60 = new float();
		[ContainerField(48), LayoutImmutable, Blittable, ContainerFieldNameHash(402579644)]
		public float Above60 { get { return m_Above60; } set { if (OnPropertyChanging("FramerateHistogramPerformanceEvent." + nameof(Above60), this, m_Above60, value)) m_Above60 = value; } } // 0x30 (48)
		
		protected GUID m_PerformanceLink = new GUID();
		[ContainerField(52), LayoutImmutable, Blittable, ContainerFieldNameHash(3478312829)]
		public GUID PerformanceLink { get { return m_PerformanceLink; } set { if (OnPropertyChanging("FramerateHistogramPerformanceEvent." + nameof(PerformanceLink), this, m_PerformanceLink, value)) m_PerformanceLink = value; } } // 0x34 (52)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4281755330:
					SpikeAverage = (float) p_Value;
					break;

				case 2668044995:
					Below5 = (float) p_Value;
					break;

				case 2146139031:
					Below10 = (float) p_Value;
					break;

				case 2146139026:
					Below15 = (float) p_Value;
					break;

				case 2146138996:
					Below20 = (float) p_Value;
					break;

				case 2146138993:
					Below25 = (float) p_Value;
					break;

				case 2146138965:
					Below30 = (float) p_Value;
					break;

				case 2146138864:
					Below60 = (float) p_Value;
					break;

				case 402579644:
					Above60 = (float) p_Value;
					break;

				case 3478312829:
					PerformanceLink = (GUID) p_Value;
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
				case 4281755330:
					return SpikeAverage;

				case 2668044995:
					return Below5;

				case 2146139031:
					return Below10;

				case 2146139026:
					return Below15;

				case 2146138996:
					return Below20;

				case 2146138993:
					return Below25;

				case 2146138965:
					return Below30;

				case 2146138864:
					return Below60;

				case 402579644:
					return Above60;

				case 3478312829:
					return PerformanceLink;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4281755330:
					return typeof(FramerateHistogramPerformanceEvent).GetProperty(nameof(SpikeAverage));

				case 2668044995:
					return typeof(FramerateHistogramPerformanceEvent).GetProperty(nameof(Below5));

				case 2146139031:
					return typeof(FramerateHistogramPerformanceEvent).GetProperty(nameof(Below10));

				case 2146139026:
					return typeof(FramerateHistogramPerformanceEvent).GetProperty(nameof(Below15));

				case 2146138996:
					return typeof(FramerateHistogramPerformanceEvent).GetProperty(nameof(Below20));

				case 2146138993:
					return typeof(FramerateHistogramPerformanceEvent).GetProperty(nameof(Below25));

				case 2146138965:
					return typeof(FramerateHistogramPerformanceEvent).GetProperty(nameof(Below30));

				case 2146138864:
					return typeof(FramerateHistogramPerformanceEvent).GetProperty(nameof(Below60));

				case 402579644:
					return typeof(FramerateHistogramPerformanceEvent).GetProperty(nameof(Above60));

				case 3478312829:
					return typeof(FramerateHistogramPerformanceEvent).GetProperty(nameof(PerformanceLink));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
