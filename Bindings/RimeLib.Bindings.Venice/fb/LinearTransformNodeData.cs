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
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 4,  Flags: 53, Size: 40)]
	public class LinearTransformNodeData : 
		AudioGraphNodeData
	{
		protected AudioGraphNodePort m_X = new AudioGraphNodePort();
		[ContainerField(Name: "X", Offset: 8, NameHash: 177661, Flags: 41)]
		public AudioGraphNodePort X { get { return m_X; } set { if (OnPropertyChanging("LinearTransformNodeData." + nameof(X), this, m_X, value)) m_X = value; } } // 0x8 (8)
		
		protected AudioGraphNodePort m_K = new AudioGraphNodePort();
		[ContainerField(Name: "K", Offset: 16, NameHash: 177646, Flags: 41)]
		public AudioGraphNodePort K { get { return m_K; } set { if (OnPropertyChanging("LinearTransformNodeData." + nameof(K), this, m_K, value)) m_K = value; } } // 0x10 (16)
		
		protected AudioGraphNodePort m_M = new AudioGraphNodePort();
		[ContainerField(Name: "M", Offset: 24, NameHash: 177640, Flags: 41)]
		public AudioGraphNodePort M { get { return m_M; } set { if (OnPropertyChanging("LinearTransformNodeData." + nameof(M), this, m_M, value)) m_M = value; } } // 0x18 (24)
		
		protected AudioGraphNodePort m_Y = new AudioGraphNodePort();
		[ContainerField(Name: "Y", Offset: 32, NameHash: 177660, Flags: 41)]
		public AudioGraphNodePort Y { get { return m_Y; } set { if (OnPropertyChanging("LinearTransformNodeData." + nameof(Y), this, m_Y, value)) m_Y = value; } } // 0x20 (32)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 177661:
					X = (AudioGraphNodePort) p_Value;
					break;

				case 177646:
					K = (AudioGraphNodePort) p_Value;
					break;

				case 177640:
					M = (AudioGraphNodePort) p_Value;
					break;

				case 177660:
					Y = (AudioGraphNodePort) p_Value;
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

				case 177646:
					return K;

				case 177640:
					return M;

				case 177660:
					return Y;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 177661:
					return typeof(LinearTransformNodeData).GetProperty(nameof(X));

				case 177646:
					return typeof(LinearTransformNodeData).GetProperty(nameof(K));

				case 177640:
					return typeof(LinearTransformNodeData).GetProperty(nameof(M));

				case 177660:
					return typeof(LinearTransformNodeData).GetProperty(nameof(Y));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
