/*
 * TextureType
 * Created by: kiwidog
 * With help from: MSDN
 * Copyright (c) kiwidoggie productions 2005-2014
 * Explicit Permission Given to D. Gintalas for use
 * Source, or any product using this class not to be sold or redistributed without direct written permission
*/

namespace RimeLib.Texture.Frostbite
{
    /// <summary>
    /// Texture type
    /// </summary>
    public enum TextureType : uint
    {
        /// <summary>
        /// 2D texture
        /// </summary>
        TextureType_2D = 0x0,

        /// <summary>
        /// Cube texture
        /// </summary>
        TextureType_Cube = 0x1,

        /// <summary>
        /// 3D texture
        /// </summary>
        TextureType_3D = 0x2,

        /// <summary>
        /// 2D texture array
        /// </summary>
        TextureType_2DArray = 0x3,

        /// <summary>
        /// 1D texture array
        /// </summary>
        TextureType_1DArray = 0x4,

        /// <summary>
        /// 1D texture
        /// </summary>
        TextureType_1D = 0x5,
    }
}
