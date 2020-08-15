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
	[ContainerType(4)]
	public class PhysicsEntry : 
		AudioGraphNodePortGroup
	{
		protected AudioGraphNodePort m_Distance = new AudioGraphNodePort();
		[ContainerField(8), ContainerFieldNameHash(408560070)]
		public AudioGraphNodePort Distance { get { return m_Distance; } set { if (OnPropertyChanging("PhysicsEntry." + nameof(Distance), this, m_Distance, value)) m_Distance = value; } } // 0x8 (8)
		
		protected AudioGraphNodePort m_Azimuth = new AudioGraphNodePort();
		[ContainerField(16), ContainerFieldNameHash(1333813715)]
		public AudioGraphNodePort Azimuth { get { return m_Azimuth; } set { if (OnPropertyChanging("PhysicsEntry." + nameof(Azimuth), this, m_Azimuth, value)) m_Azimuth = value; } } // 0x10 (16)
		
		protected AudioGraphNodePort m_ElevationAngle = new AudioGraphNodePort();
		[ContainerField(24), ContainerFieldNameHash(891204419)]
		public AudioGraphNodePort ElevationAngle { get { return m_ElevationAngle; } set { if (OnPropertyChanging("PhysicsEntry." + nameof(ElevationAngle), this, m_ElevationAngle, value)) m_ElevationAngle = value; } } // 0x18 (24)
		
		protected CtrRef<OutputNodeData> m_Output = new CtrRef<OutputNodeData>();
		[ContainerField(32), ContainerFieldNameHash(2895736442)]
		public CtrRef<OutputNodeData> Output { get { return m_Output; } set { if (OnPropertyChanging("PhysicsEntry." + nameof(Output), this, m_Output, value)) m_Output = value; } } // 0x20 (32)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 408560070:
					Distance = (AudioGraphNodePort) p_Value;
					break;

				case 1333813715:
					Azimuth = (AudioGraphNodePort) p_Value;
					break;

				case 891204419:
					ElevationAngle = (AudioGraphNodePort) p_Value;
					break;

				case 2895736442:
					Output = (CtrRef<OutputNodeData>) p_Value;
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
				case 408560070:
					return Distance;

				case 1333813715:
					return Azimuth;

				case 891204419:
					return ElevationAngle;

				case 2895736442:
					return Output;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 408560070:
					return typeof(PhysicsEntry).GetProperty(nameof(Distance));

				case 1333813715:
					return typeof(PhysicsEntry).GetProperty(nameof(Azimuth));

				case 891204419:
					return typeof(PhysicsEntry).GetProperty(nameof(ElevationAngle));

				case 2895736442:
					return typeof(PhysicsEntry).GetProperty(nameof(Output));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
