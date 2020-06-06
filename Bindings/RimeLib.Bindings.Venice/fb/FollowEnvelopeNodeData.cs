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
	public class FollowEnvelopeNodeData : 
		AudioGraphNodeData
	{
		[ContainerField(8)]
		public AudioGraphNodePort X { get; set; } = new AudioGraphNodePort(); // 0x8 (8)
		
		[ContainerField(16)]
		public AudioGraphNodePort Y { get; set; } = new AudioGraphNodePort(); // 0x10 (16)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float Base { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public float Scale { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public float Pivot { get; set; } // 0x20 (32)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 177661:
					X = (AudioGraphNodePort) p_Value;
					break;

				case 177660:
					Y = (AudioGraphNodePort) p_Value;
					break;

				case 2088806864:
					Base = (float) p_Value;
					break;

				case 231223453:
					Scale = (float) p_Value;
					break;

				case 232602033:
					Pivot = (float) p_Value;
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
				case 177661:
					return X;

				case 177660:
					return Y;

				case 2088806864:
					return Base;

				case 231223453:
					return Scale;

				case 232602033:
					return Pivot;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 177661:
					return typeof(FollowEnvelopeNodeData).GetProperty(nameof(X));

				case 177660:
					return typeof(FollowEnvelopeNodeData).GetProperty(nameof(Y));

				case 2088806864:
					return typeof(FollowEnvelopeNodeData).GetProperty(nameof(Base));

				case 231223453:
					return typeof(FollowEnvelopeNodeData).GetProperty(nameof(Scale));

				case 232602033:
					return typeof(FollowEnvelopeNodeData).GetProperty(nameof(Pivot));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
