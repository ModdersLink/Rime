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
	[ContainerType(4, 32)]
	public partial class ScreenshotInfo :
		EbxSerializable
	{
		[ObservableProperty]
		[property: ContainerField(0), LayoutImmutable, JsonProperty(Order = 0)]
		private string _Name = string.Empty;
		
		[ObservableProperty]
		[property: ContainerField(4), LayoutImmutable, Blittable, JsonProperty(Order = 4)]
		private uint _CropImageY1;
		
		[ObservableProperty]
		[property: ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		private uint _CropImageX1;
		
		[ObservableProperty]
		[property: ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		private uint _CropImageX2;
		
		[ObservableProperty]
		[property: ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private uint _CropImageY2;
		
		[ObservableProperty]
		[property: ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		private uint _ResizeOutputImageHeight;
		
		[ObservableProperty]
		[property: ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		private uint _ResizeOutputImageWidth;
		
		[ObservableProperty]
		[property: ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		private bool _ResizeOutputImage;
		
		[ObservableProperty]
		[property: ContainerField(29), LayoutImmutable, Blittable, JsonProperty(Order = 29)]
		private bool _CropImage;
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteString(Name));
			p_Writer.Write(CropImageY1);
			p_Writer.Write(CropImageX1);
			p_Writer.Write(CropImageX2);
			p_Writer.Write(CropImageY2);
			p_Writer.Write(ResizeOutputImageHeight);
			p_Writer.Write(ResizeOutputImageWidth);
			p_Writer.Write(ResizeOutputImage);
			p_Writer.Write(CropImage);
			p_Writer.WriteNullBytes(2);
		}
	}
}
