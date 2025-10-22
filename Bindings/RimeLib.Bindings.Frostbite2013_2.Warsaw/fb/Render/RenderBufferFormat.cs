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


namespace fb.Render;

[ContainerType(1, 4)]
public enum RenderBufferFormat : int
{
	RenderBufferFormat_Unknown = 0,
	RenderBufferFormat_Float1 = 1,
	RenderBufferFormat_Float2 = 2,
	RenderBufferFormat_Float3 = 3,
	RenderBufferFormat_Float4 = 4,
	RenderBufferFormat_Half1 = 5,
	RenderBufferFormat_Half2 = 6,
	RenderBufferFormat_Half4 = 7,
	RenderBufferFormat_Int1 = 8,
	RenderBufferFormat_Int2 = 9,
	RenderBufferFormat_Int3 = 10,
	RenderBufferFormat_Int4 = 11,
	RenderBufferFormat_UInt1 = 12,
	RenderBufferFormat_UInt2 = 13,
	RenderBufferFormat_UInt3 = 14,
	RenderBufferFormat_UInt4 = 15,
	RenderBufferFormat_UInt16_1 = 16,
	RenderBufferFormat_UInt16_2 = 17,
	RenderBufferFormat_UInt16_4 = 18,
}

