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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(36), ContainerClass]
	public class FollowEnvelopeNodeData : 
		AudioGraphNodeData
	{
		protected AudioGraphNodePort m_X = new AudioGraphNodePort();
		[ContainerField(8), MemberInfoFlag(41), ContainerFieldNameHash(177661)]
		public AudioGraphNodePort X { get { return m_X; } set { if (OnPropertyChanging("FollowEnvelopeNodeData." + nameof(X), this, m_X, value)) m_X = value; } } // 0x8 (8)
		
		protected AudioGraphNodePort m_Y = new AudioGraphNodePort();
		[ContainerField(16), MemberInfoFlag(41), ContainerFieldNameHash(177660)]
		public AudioGraphNodePort Y { get { return m_Y; } set { if (OnPropertyChanging("FollowEnvelopeNodeData." + nameof(Y), this, m_Y, value)) m_Y = value; } } // 0x10 (16)
		
		protected float m_Base = new float();
		[ContainerField(24), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2088806864)]
		public float Base { get { return m_Base; } set { if (OnPropertyChanging("FollowEnvelopeNodeData." + nameof(Base), this, m_Base, value)) m_Base = value; } } // 0x18 (24)
		
		protected float m_Scale = new float();
		[ContainerField(28), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(231223453)]
		public float Scale { get { return m_Scale; } set { if (OnPropertyChanging("FollowEnvelopeNodeData." + nameof(Scale), this, m_Scale, value)) m_Scale = value; } } // 0x1C (28)
		
		protected float m_Pivot = new float();
		[ContainerField(32), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(232602033)]
		public float Pivot { get { return m_Pivot; } set { if (OnPropertyChanging("FollowEnvelopeNodeData." + nameof(Pivot), this, m_Pivot, value)) m_Pivot = value; } } // 0x20 (32)
		
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
