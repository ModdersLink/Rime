///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Frostbite2_0.Ebx;
using CommunityToolkit.Mvvm.ComponentModel;

namespace fb
{
	[ContainerType(4, 44)]
	public partial class VisualVectorShapeData :
		VectorShapeData
	{
		[ObservableProperty]
		[property: ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		private float _ErrorTolerance;

		[ObservableProperty]
		[property: ContainerField(32), JsonProperty(Order = 32)]
		private CtrRef<SurfaceShaderBaseAsset> _Shader3d = new();

		[ObservableProperty]
		[property: ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		private uint _DrawOrderIndex;

		[ObservableProperty]
		[property: ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		private float _TessellationTriangleSize;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(ErrorTolerance);
			p_Writer.Write(p_EbxWriter.WriteImport(Shader3d));
			p_Writer.Write(DrawOrderIndex);
			p_Writer.Write(TessellationTriangleSize);
		}
	}
}
