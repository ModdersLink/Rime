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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(40), ContainerClass]
	public class SimpleTransformNodeData : 
		AudioGraphNodeData
	{
		protected AudioGraphNodePort m_X = new AudioGraphNodePort();
		[ContainerField(8), MemberInfoFlag(41), ContainerFieldNameHash(177661)]
		public AudioGraphNodePort X { get { return m_X; } set { if (OnPropertyChanging("SimpleTransformNodeData." + nameof(X), this, m_X, value)) m_X = value; } } // 0x8 (8)
		
		protected AudioGraphNodePort m_Y = new AudioGraphNodePort();
		[ContainerField(16), MemberInfoFlag(41), ContainerFieldNameHash(177660)]
		public AudioGraphNodePort Y { get { return m_Y; } set { if (OnPropertyChanging("SimpleTransformNodeData." + nameof(Y), this, m_Y, value)) m_Y = value; } } // 0x10 (16)
		
		protected AudioGraphNodePort m_Z = new AudioGraphNodePort();
		[ContainerField(24), MemberInfoFlag(41), ContainerFieldNameHash(177663)]
		public AudioGraphNodePort Z { get { return m_Z; } set { if (OnPropertyChanging("SimpleTransformNodeData." + nameof(Z), this, m_Z, value)) m_Z = value; } } // 0x18 (24)
		
		protected SimpleTransformOperation m_Operation = new SimpleTransformOperation();
		[ContainerField(32), MemberInfoFlag(137), ContainerFieldNameHash(2346271248)]
		public SimpleTransformOperation Operation { get { return m_Operation; } set { if (OnPropertyChanging("SimpleTransformNodeData." + nameof(Operation), this, m_Operation, value)) m_Operation = value; } } // 0x20 (32)
		
		protected AngleUnit m_AngleUnit = new AngleUnit();
		[ContainerField(36), MemberInfoFlag(137), ContainerFieldNameHash(1824187906)]
		public AngleUnit AngleUnit { get { return m_AngleUnit; } set { if (OnPropertyChanging("SimpleTransformNodeData." + nameof(AngleUnit), this, m_AngleUnit, value)) m_AngleUnit = value; } } // 0x24 (36)
		
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
