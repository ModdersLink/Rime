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
	public class PhysicsEntry : 
		AudioGraphNodePortGroup
	{
		[ContainerField(8)]
		public AudioGraphNodePort Distance { get; set; } = new AudioGraphNodePort(); // 0x8 (8)
		
		[ContainerField(16)]
		public AudioGraphNodePort Azimuth { get; set; } = new AudioGraphNodePort(); // 0x10 (16)
		
		[ContainerField(24)]
		public AudioGraphNodePort ElevationAngle { get; set; } = new AudioGraphNodePort(); // 0x18 (24)
		
		[ContainerField(32)]
		public CtrRef<OutputNodeData> Output { get; set; } = new CtrRef<OutputNodeData>(); // 0x20 (32)
		
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
