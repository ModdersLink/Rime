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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 52)]
	public class PhysicsNodeData : 
		AudioGraphNodeData
	{
		protected AudioGraphNodePort m_Distance = new AudioGraphNodePort();
		[ContainerField(Name: "Distance", Offset: 8, NameHash: 408560070, Flags: 41)]
		public AudioGraphNodePort Distance { get { return m_Distance; } set { if (OnPropertyChanging("PhysicsNodeData." + nameof(Distance), this, m_Distance, value)) m_Distance = value; } } // 0x8 (8)
		
		protected AudioGraphNodePort m_Velocity = new AudioGraphNodePort();
		[ContainerField(Name: "Velocity", Offset: 16, NameHash: 3860766482, Flags: 41)]
		public AudioGraphNodePort Velocity { get { return m_Velocity; } set { if (OnPropertyChanging("PhysicsNodeData." + nameof(Velocity), this, m_Velocity, value)) m_Velocity = value; } } // 0x10 (16)
		
		protected AudioGraphNodePort m_RelativeVelocity = new AudioGraphNodePort();
		[ContainerField(Name: "RelativeVelocity", Offset: 24, NameHash: 866456998, Flags: 41)]
		public AudioGraphNodePort RelativeVelocity { get { return m_RelativeVelocity; } set { if (OnPropertyChanging("PhysicsNodeData." + nameof(RelativeVelocity), this, m_RelativeVelocity, value)) m_RelativeVelocity = value; } } // 0x18 (24)
		
		protected AudioGraphNodePort m_Azimuth = new AudioGraphNodePort();
		[ContainerField(Name: "Azimuth", Offset: 32, NameHash: 1333813715, Flags: 41)]
		public AudioGraphNodePort Azimuth { get { return m_Azimuth; } set { if (OnPropertyChanging("PhysicsNodeData." + nameof(Azimuth), this, m_Azimuth, value)) m_Azimuth = value; } } // 0x20 (32)
		
		protected AudioGraphNodePort m_ElevationAngle = new AudioGraphNodePort();
		[ContainerField(Name: "ElevationAngle", Offset: 40, NameHash: 891204419, Flags: 41)]
		public AudioGraphNodePort ElevationAngle { get { return m_ElevationAngle; } set { if (OnPropertyChanging("PhysicsNodeData." + nameof(ElevationAngle), this, m_ElevationAngle, value)) m_ElevationAngle = value; } } // 0x28 (40)
		
		protected RefArray<PhysicsEntry> m_Entries = new RefArray<PhysicsEntry>();
		[ContainerField(Name: "Entries", Offset: 48, NameHash: 8238103, Flags: 65)]
		public RefArray<PhysicsEntry> Entries { get { return m_Entries; } set { if (OnPropertyChanging("PhysicsNodeData." + nameof(Entries), this, m_Entries, value)) m_Entries = value; } } // 0x30 (48)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 408560070:
					Distance = (AudioGraphNodePort) p_Value;
					break;

				case 3860766482:
					Velocity = (AudioGraphNodePort) p_Value;
					break;

				case 866456998:
					RelativeVelocity = (AudioGraphNodePort) p_Value;
					break;

				case 1333813715:
					Azimuth = (AudioGraphNodePort) p_Value;
					break;

				case 891204419:
					ElevationAngle = (AudioGraphNodePort) p_Value;
					break;

				case 8238103:
					Entries = (RefArray<PhysicsEntry>) p_Value;
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

				case 3860766482:
					return Velocity;

				case 866456998:
					return RelativeVelocity;

				case 1333813715:
					return Azimuth;

				case 891204419:
					return ElevationAngle;

				case 8238103:
					return Entries;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 408560070:
					return typeof(PhysicsNodeData).GetProperty(nameof(Distance));

				case 3860766482:
					return typeof(PhysicsNodeData).GetProperty(nameof(Velocity));

				case 866456998:
					return typeof(PhysicsNodeData).GetProperty(nameof(RelativeVelocity));

				case 1333813715:
					return typeof(PhysicsNodeData).GetProperty(nameof(Azimuth));

				case 891204419:
					return typeof(PhysicsNodeData).GetProperty(nameof(ElevationAngle));

				case 8238103:
					return typeof(PhysicsNodeData).GetProperty(nameof(Entries));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
