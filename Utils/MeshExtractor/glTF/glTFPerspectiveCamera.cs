using System;
using System.Collections.Generic;
using System.Text;

namespace MeshExtractor.glTF
{
    public class glTFPerspectiveCamera : glTFCamera
    {
        protected float m_AspectRatio;
        protected float m_YFov;
        protected float m_ZFar;
        protected float m_ZNear;

        public glTFPerspectiveCamera()
        {
            m_CameraType = CameraType.Perspective;
        }
    }
}
