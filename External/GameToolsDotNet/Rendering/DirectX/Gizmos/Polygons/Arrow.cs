using GameToolsDotNet.Rendering.DirectX.Misc;
using GameToolsDotNet.Extensions;
using SharpDX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameToolsDotNet.Rendering.DirectX.Shaders;

namespace GameToolsDotNet.Rendering.DirectX.Gizmos.Polygons
{
    public class Arrow : Polygon, IPickableObject
    {
        private float arrowHeight;
        public float Height { get { return this.arrowHeight; } set { if (this.arrowHeight != value) { this.arrowHeight = value; this.IsDirty = true; } } }

        private Color4 color = new Color4(0xFF00FF00);
        public Color4 Color { get { return this.color; } set { if (this.color != value) { this.color = value; this.IsDirty = true; } } }

        // Vertex array for quick access for hit tests.
        private WireframeShader.Vertex[] vertices = new WireframeShader.Vertex[4];

        public Arrow(float height, Vector3 position, Quaternion rotation)
            : base(4, 8, position, rotation)
        {
            // Initialize fields.
            this.arrowHeight = height;
        }

        public override void BuildMesh(VertexStreamSplice<WireframeShader.Vertex> vertexBuffer, VertexStreamSplice<ushort> indexBuffer)
        {
            // Build the vertex buffer.
            vertexBuffer[0] = this.vertices[0] = new WireframeShader.Vertex(new Vector4(0f, 0f, -(this.arrowHeight / 2f), 1f), this.color);
            vertexBuffer[1] = this.vertices[1] = new WireframeShader.Vertex(new Vector4(-(this.arrowHeight / 2f), 0f, this.arrowHeight / 2f, 1f), this.color);
            vertexBuffer[2] = this.vertices[2] = new WireframeShader.Vertex(new Vector4(0f, 0f, this.arrowHeight / 5.0f, 1f), this.color);
            vertexBuffer[3] = this.vertices[3] = new WireframeShader.Vertex(new Vector4(this.arrowHeight / 2f, 0f, this.arrowHeight / 2f, 1f), this.color);

            // Check the draw style and handle accordingly.
            if (this.Style == PolygonDrawStyle.Outline)
            {
                // Set the number of vertices and indices being used.
                this.VertexCount = 4;
                this.IndexCount = 8;

                // Set primitive topology.
                this.PrimitiveTopology = SharpDX.Direct3D.PrimitiveTopology.LineList;

                // Build the index buffer.
                for (int i = 0; i < 4; i++)
                {
                    indexBuffer[(i * 2)] = (ushort)i;
                    indexBuffer[(i * 2) + 1] = (ushort)(i + 1);
                }

                // Correct the last index.
                indexBuffer[7] = 0;
            }
            else
            {
                // Set the number of vertices and indices being used.
                this.VertexCount = 4;
                this.IndexCount = 6;

                // Set primitive topology.
                this.PrimitiveTopology = SharpDX.Direct3D.PrimitiveTopology.TriangleList;

                // Build the index buffer.
                indexBuffer[0] = 0;
                indexBuffer[1] = 1;
                indexBuffer[2] = 2;

                indexBuffer[3] = 0;
                indexBuffer[4] = 2;
                indexBuffer[5] = 3;
            }

            // Flag that we are no longer dirty.
            this.IsDirty = false;
        }

        #region IPickableObject

        public bool DoPickingTest(RenderManager manager, Ray pickingRay, object context, out float distance, out object pickedObjectContext)
        {
            // Invert the arrow transformation so we can transform the picking ray to local space.
            Matrix arrowTransform = this.TransformationMatrix;
            arrowTransform.Invert();

            // Transform the picking ray to be in local space.
            Ray newPickingRay = new Ray(Vector3.TransformCoordinate(pickingRay.Position, arrowTransform), Vector3.TransformNormal(pickingRay.Direction, arrowTransform));
            newPickingRay.Direction.Normalize();

            Vector3 v0 = this.vertices[0].Position.ToVector3();
            Vector3 v1 = this.vertices[1].Position.ToVector3();
            Vector3 v2 = this.vertices[2].Position.ToVector3();
            Vector3 v3 = this.vertices[3].Position.ToVector3();

            // Perform hit detection with both triangles for the arrow.
            Vector3 intersectionPoint = Vector3.Zero;
            bool hitTest = newPickingRay.Intersects(ref v0, ref v1, ref v2, out intersectionPoint) || newPickingRay.Intersects(ref v0, ref v3, ref v2, out intersectionPoint);

            // If we had a hit set the distance to the arrow.
            if (hitTest == true)
                distance = this.Position.Z;
            else
                distance = float.MaxValue;

            // Return the hit test result.
            pickedObjectContext = intersectionPoint;
            return hitTest;
        }

        public void SelectObject(RenderManager manager, object context)
        {

        }

        public bool DeselectObject(RenderManager manager, object context)
        {
            return true;
        }

        public bool HandleInput(RenderManager manager)
        {
            return false;
        }

        #endregion

        public bool GetPointOfIntersection(RenderManager manager, Ray pickingRay, out Vector3 intersectionPoint)
        {
            /*
            // Invert the arrow transformation so we can transform the picking ray to local space.
            Matrix arrowTransform = this.TransformationMatrix;
            arrowTransform.Invert();

            // Transform the picking ray to be in local space.
            Ray newPickingRay = new Ray(Vector3.TransformCoordinate(pickingRay.Position, arrowTransform), Vector3.TransformNormal(pickingRay.Direction, arrowTransform));
            newPickingRay.Direction.Normalize();

            // Create a plane from the arrow vertices and check for an intersection.
            Plane arrowPlane = new Plane(this.vertices[0].Position, this.vertices[1].Position, this.vertices[3].Position);
            return newPickingRay.Intersects(ref arrowPlane, out intersectionPoint);
            */

            // Transform the vertices using the arrow's transformation matrix.
            Vector3 v1 = Vector3.Transform(this.vertices[0].Position.ToVector3(), this.TransformationMatrix).ToVector3();
            Vector3 v2 = Vector3.Transform(this.vertices[1].Position.ToVector3(), this.TransformationMatrix).ToVector3();
            Vector3 v3 = Vector3.Transform(this.vertices[2].Position.ToVector3(), this.TransformationMatrix).ToVector3();

            // Create a plane from the arrow vertices and check for an intersection.
            SharpDX.Plane arrowPlane = new SharpDX.Plane(v1, v2, v3);
            return pickingRay.Intersects(ref arrowPlane, out intersectionPoint);
        }
    }
}
