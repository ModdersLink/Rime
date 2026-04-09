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
	[ContainerType(4, 28)]
	public partial class MouseInputActionData :
		AxesInputActionData
	{
		[ObservableProperty]
		[property: ContainerField(20), JsonProperty(Order = 20)]
		private InputDeviceMouseButtons _Button = new();

		[ObservableProperty]
		[property: ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		private bool _SimulateJoystickAxis;

		[ObservableProperty]
		[property: ContainerField(25), LayoutImmutable, Blittable, JsonProperty(Order = 25)]
		private bool _RememberExcessInput;

		[ObservableProperty]
		[property: ContainerField(26), LayoutImmutable, Blittable, JsonProperty(Order = 26)]
		private bool _ScaleScrollWheelAxisInput;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) Button);
			p_Writer.Write(SimulateJoystickAxis);
			p_Writer.Write(RememberExcessInput);
			p_Writer.Write(ScaleScrollWheelAxisInput);
			p_Writer.WriteNullBytes(1);
		}
	}
}
