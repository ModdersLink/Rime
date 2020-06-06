///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class SimpleTransformNodeData : 
		AudioGraphNodeData
	{
		[ContainerField(8)]
		public AudioGraphNodePort X { get; set; } = new AudioGraphNodePort(); // 0x8 (8)
		
		[ContainerField(16)]
		public AudioGraphNodePort Y { get; set; } = new AudioGraphNodePort(); // 0x10 (16)
		
		[ContainerField(24)]
		public AudioGraphNodePort Z { get; set; } = new AudioGraphNodePort(); // 0x18 (24)
		
		[ContainerField(32)]
		public SimpleTransformOperation Operation { get; set; } = new SimpleTransformOperation(); // 0x20 (32)
		
		[ContainerField(36)]
		public AngleUnit AngleUnit { get; set; } = new AngleUnit(); // 0x24 (36)
		
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

				case 177663:
					Z = (AudioGraphNodePort) p_Value;
					break;

				case 2346271248:
					Operation = (SimpleTransformOperation) Enum.ToObject(typeof(SimpleTransformOperation), p_Value);
					break;

				case 1824187906:
					AngleUnit = (AngleUnit) Enum.ToObject(typeof(AngleUnit), p_Value);
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

				case 177663:
					return Z;

				case 2346271248:
					return Operation;

				case 1824187906:
					return AngleUnit;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 177661:
					return typeof(SimpleTransformNodeData).GetProperty(nameof(X));

				case 177660:
					return typeof(SimpleTransformNodeData).GetProperty(nameof(Y));

				case 177663:
					return typeof(SimpleTransformNodeData).GetProperty(nameof(Z));

				case 2346271248:
					return typeof(SimpleTransformNodeData).GetProperty(nameof(Operation));

				case 1824187906:
					return typeof(SimpleTransformNodeData).GetProperty(nameof(AngleUnit));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
