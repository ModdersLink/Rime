using System;
using System.Collections.Generic;
using System.Text;

namespace MeshExtractor.glTF
{
    public class glTFOrthographicCamera : glTFCamera
    {
        protected float m_XMag;
        protected float m_YMag;
        protected float m_ZFar;
        protected float m_ZNear;

        public glTFOrthographicCamera()
        {
            m_CameraType = CameraType.Orthographic;
        }
    }
}
