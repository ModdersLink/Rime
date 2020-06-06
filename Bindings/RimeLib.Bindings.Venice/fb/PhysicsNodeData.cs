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
	public class PhysicsNodeData : 
		AudioGraphNodeData
	{
		[ContainerField(8)]
		public AudioGraphNodePort Distance { get; set; } = new AudioGraphNodePort(); // 0x8 (8)
		
		[ContainerField(16)]
		public AudioGraphNodePort Velocity { get; set; } = new AudioGraphNodePort(); // 0x10 (16)
		
		[ContainerField(24)]
		public AudioGraphNodePort RelativeVelocity { get; set; } = new AudioGraphNodePort(); // 0x18 (24)
		
		[ContainerField(32)]
		public AudioGraphNodePort Azimuth { get; set; } = new AudioGraphNodePort(); // 0x20 (32)
		
		[ContainerField(40)]
		public AudioGraphNodePort ElevationAngle { get; set; } = new AudioGraphNodePort(); // 0x28 (40)
		
		[ContainerField(48)]
		public RefArray<PhysicsEntry> Entries { get; set; } = new RefArray<PhysicsEntry>(); // 0x30 (48)
		
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
