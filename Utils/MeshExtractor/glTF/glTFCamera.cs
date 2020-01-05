using System;
using System.Collections.Generic;
using System.Text;

namespace MeshExtractor.glTF
{
    public class glTFCamera
    {
        /// <summary>
        /// glTF only supports 2 camera types
        /// Perspective and Orthographic
        /// </summary>
        protected enum CameraType
        {
            /// <summary>
            /// Perspective camera
            /// </summary>
            Perspective,

            /// <summary>
            /// Orthographic camera
            /// </summary>
            Orthographic,

            /// <summary>
            /// Total cameras count
            /// </summary>
            Count
        }

        // The camera type
        protected CameraType m_CameraType;
    }
}
