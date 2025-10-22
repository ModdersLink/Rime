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


namespace fb.GameShared;

[ContainerType(1, 4)]
public enum UIScreenRenderingPass : int
{
	UIScreenRenderingPass_RenderTarget = 0,
	UIScreenRenderingPass_AboveFlash = 1,
	UIScreenRenderingPass_BelowFlash = 2,
	UIScreenRenderingPass_Dialog = 3,
}

