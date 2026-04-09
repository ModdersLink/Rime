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
	[ContainerType(16, 176)]
	public partial class PropertyDebugEntityData :
		EntityData
	{
		[ObservableProperty]
		[property: ContainerField(16), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private Vec3 _Vec3Value = new();

		[ObservableProperty]
		[property: ContainerField(32), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		private Vec3 _TextColor = new();

		[ObservableProperty]
		[property: ContainerField(48), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		private Vec2 _ScreenPosition = new();

		[ObservableProperty]
		[property: ContainerField(64), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		private LinearTransform _TransformValue = new();

		[ObservableProperty]
		[property: ContainerField(128), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		private Vec2 _Vec2Value = new();

		[ObservableProperty]
		[property: ContainerField(136), LayoutImmutable, JsonProperty(Order = 136)]
		private string _ValuePrefix = string.Empty;

		[ObservableProperty]
		[property: ContainerField(140), JsonProperty(Order = 140)]
		private Realm _Realm = new();

		[ObservableProperty]
		[property: ContainerField(144), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
		private float _FloatValue;

		[ObservableProperty]
		[property: ContainerField(148), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
		private int _IntValue;

		[ObservableProperty]
		[property: ContainerField(152), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
		private float _TextScale;

		[ObservableProperty]
		[property: ContainerField(156), LayoutImmutable, JsonProperty(Order = 156)]
		private string _StringValue = string.Empty;

		[ObservableProperty]
		[property: ContainerField(160), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
		private bool _DefaultVisible;

		[ObservableProperty]
		[property: ContainerField(161), LayoutImmutable, Blittable, JsonProperty(Order = 161)]
		private bool _BoolValue;

		[ObservableProperty]
		[property: ContainerField(162), LayoutImmutable, Blittable, JsonProperty(Order = 162)]
		private bool _Multiline;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(4);
			Vec3Value.Serialize(p_Writer, p_EbxWriter);
			TextColor.Serialize(p_Writer, p_EbxWriter);
			ScreenPosition.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(8);
			TransformValue.Serialize(p_Writer, p_EbxWriter);
			Vec2Value.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteString(ValuePrefix));
			p_Writer.Write((int) Realm);
			p_Writer.Write(FloatValue);
			p_Writer.Write(IntValue);
			p_Writer.Write(TextScale);
			p_Writer.Write(p_EbxWriter.WriteString(StringValue));
			p_Writer.Write(DefaultVisible);
			p_Writer.Write(BoolValue);
			p_Writer.Write(Multiline);
			p_Writer.WriteNullBytes(13);
		}
	}
}
