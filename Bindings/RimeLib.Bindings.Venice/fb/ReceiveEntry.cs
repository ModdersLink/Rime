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
	public class ReceiveEntry : 
		AudioGraphNodePortGroup
	{
		[ContainerField(8)]
		public AudioGraphNodePort Out { get; set; } = new AudioGraphNodePort(); // 0x8 (8)
		
		[ContainerField(16)]
		public CtrRef<AudioGraphParameter> Source { get; set; } = new CtrRef<AudioGraphParameter>(); // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float Parameter { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float SavedValue { get; set; } // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 193453899:
					Out = (AudioGraphNodePort) p_Value;
					break;

				case 3339738264:
					Source = (CtrRef<AudioGraphParameter>) p_Value;
					break;

				case 2964084716:
					Parameter = (float) p_Value;
					break;

				case 2552725931:
					SavedValue = (float) p_Value;
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
				case 193453899:
					return Out;

				case 3339738264:
					return Source;

				case 2964084716:
					return Parameter;

				case 2552725931:
					return SavedValue;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 193453899:
					return typeof(ReceiveEntry).GetProperty(nameof(Out));

				case 3339738264:
					return typeof(ReceiveEntry).GetProperty(nameof(Source));

				case 2964084716:
					return typeof(ReceiveEntry).GetProperty(nameof(Parameter));

				case 2552725931:
					return typeof(ReceiveEntry).GetProperty(nameof(SavedValue));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
