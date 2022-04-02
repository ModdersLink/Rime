using GameToolsDotNet.Rendering.DirectX.Misc;
using GameToolsDotNet.Rendering.DirectX.Shaders;
using SharpDX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameToolsDotNet.Rendering.DirectX.Gizmos.Polygons
{
    public enum BoxLineStyle
    {
        Solid,
        CornersOnly
    }

    public class Box : Polygon, IPickableObject
    {
        private Vector3 minExtents;
        private Vector3 maxExtents;

        private float width = 0f;
        public float Width { get { return this.width; } set { if (value != this.width) { this.width = value; this.IsDirty = true; } } }

        private float height = 0f;
        public float Height { get { return this.height; } set { if (value != this.height) { this.height = value; this.IsDirty = true; } } }

        private float depth = 0f;
        public float Depth { get { return this.depth; } set { if (value != this.depth) { this.depth = value; this.IsDirty = true; } } }

        private float scale = 1f;
        public float Scale { get { return this.scale; } set { if (value != this.scale) { this.scale = value; this.IsDirty = true; } } }

        private BoxLineStyle lineStyle = BoxLineStyle.Solid;
        /// <summary>
        /// Style of the box outline when rendered in outline mode
        /// </summary>
        public BoxLineStyle LineStyle { get { return this.lineStyle; } set { this.lineStyle = value; this.IsDirty = true; } }

        private Color4 lineColor = new Color4(0xFF00FF00);
        public Color4 LineColor { get { return this.lineColor; } set { if (this.lineColor != value) { this.lineColor = value; this.IsDirty = true; } } }

        // Used to correct bounding boxes which are offset from (0, 0, 0).
        //private Vector3 basePosition = Vector3.Zero;

        public Box(Vector3 minExtents, Vector3 maxExtents, Vector3 position, Quaternion rotation, PolygonDrawStyle style = PolygonDrawStyle.Outline) 
            : base(32, 48, position, rotation)
        {
            // Initialize fields.
            this.minExtents = minExtents;
            this.maxExtents = maxExtents;
            this.width = Math.Abs(maxExtents.X - minExtents.X);
            this.height = Math.Abs(maxExtents.Y - minExtents.Y);
            this.depth = Math.Abs(maxExtents.Z - minExtents.Z);
            this.Style = style;

            // Calculate the center of the bounding box and use it as the base position.
            //this.basePosition = new Vector3(maxExtents.X - (this.width / 2f), maxExtents.Y - (this.height / 2f), maxExtents.Z - (this.depth / 2f));

            this.PrimitiveTopology = SharpDX.Direct3D.PrimitiveTopology.LineList;
        }

        public Box(float width, float height, float depth, Vector3 position, Quaternion rotation, PolygonDrawStyle style = PolygonDrawStyle.Outline)
            : base(32, 48, position, rotation)
        {
            // Initialize fields.
            this.maxExtents = new Vector3(width / 2f, height / 2f, depth / 2f);
            this.minExtents = this.maxExtents * -1f;
            this.width = width;
            this.height = height;
            this.depth = depth;
            this.Style = style;

            this.PrimitiveTopology = SharpDX.Direct3D.PrimitiveTopology.LineList;
        }

        public override void BuildMesh(VertexStreamSplice<WireframeShader.Vertex> vertexBuffer, VertexStreamSplice<ushort> indexBuffer)
        {
            // Scale the size of the bounding box.
            float scaledWidth = this.Width * this.Scale;
            float scaledHeight = this.Height * this.Scale;
            float scaledDepth = this.Depth * this.Scale;

            // Line length for corners should be 10 pixels long or the length of the shortest side.
            float smallestSideLength = Math.Min(scaledDepth, Math.Min(scaledHeight, scaledWidth));
            float cornerLength = Math.Min(15.0f, smallestSideLength);

            // Calculate the half-widths of the box.
            float halfWidth = scaledWidth / 2.0f;
            float halfHeight = scaledHeight / 2.0f;
            float halfDepth = scaledDepth / 2.0f;

            // Update the min/max extents.
            this.maxExtents = new Vector3(halfWidth, halfHeight, halfDepth);
            this.minExtents = this.maxExtents * -1f;

            // Check if we are rendering in solid or outline mode.
            if (this.Style == PolygonDrawStyle.Outline)
            {
                // Check if we are rendering only box corners or full lines.
                if (this.LineStyle == BoxLineStyle.CornersOnly)
                {
                    #region Corners Only

                    // Set number of vertices and indices being used.
                    this.VertexCount = 32;
                    this.IndexCount = 48;

                    // Top left front:
                    vertexBuffer[0] = new WireframeShader.Vertex(new Vector3(halfWidth, halfHeight, -halfDepth), this.LineColor);
                    vertexBuffer[1] = new WireframeShader.Vertex(new Vector3(halfWidth, halfHeight, -halfDepth + cornerLength), this.LineColor);
                    vertexBuffer[2] = new WireframeShader.Vertex(new Vector3(halfWidth, halfHeight - cornerLength, -halfDepth), this.LineColor);
                    vertexBuffer[3] = new WireframeShader.Vertex(new Vector3(halfWidth - cornerLength, halfHeight, -halfDepth), this.LineColor);

                    // Top Right front:
                    vertexBuffer[4] = new WireframeShader.Vertex(new Vector3(-halfWidth, halfHeight, -halfDepth), this.LineColor);
                    vertexBuffer[5] = new WireframeShader.Vertex(new Vector3(-halfWidth, halfHeight, -halfDepth + cornerLength), this.LineColor);
                    vertexBuffer[6] = new WireframeShader.Vertex(new Vector3(-halfWidth, halfHeight - cornerLength, -halfDepth), this.LineColor);
                    vertexBuffer[7] = new WireframeShader.Vertex(new Vector3(-halfWidth + cornerLength, halfHeight, -halfDepth), this.LineColor);

                    // Bottom left front:
                    vertexBuffer[8] = new WireframeShader.Vertex(new Vector3(halfWidth, -halfHeight, -halfDepth), this.LineColor);
                    vertexBuffer[9] = new WireframeShader.Vertex(new Vector3(halfWidth, -halfHeight, -halfDepth + cornerLength), this.LineColor);
                    vertexBuffer[10] = new WireframeShader.Vertex(new Vector3(halfWidth, -halfHeight + cornerLength, -halfDepth), this.LineColor);
                    vertexBuffer[11] = new WireframeShader.Vertex(new Vector3(halfWidth - cornerLength, -halfHeight, -halfDepth), this.LineColor);

                    // Bottom Right front:
                    vertexBuffer[12] = new WireframeShader.Vertex(new Vector3(-halfWidth, -halfHeight, -halfDepth), this.LineColor);
                    vertexBuffer[13] = new WireframeShader.Vertex(new Vector3(-halfWidth, -halfHeight, -halfDepth + cornerLength), this.LineColor);
                    vertexBuffer[14] = new WireframeShader.Vertex(new Vector3(-halfWidth, -halfHeight + cornerLength, -halfDepth), this.LineColor);
                    vertexBuffer[15] = new WireframeShader.Vertex(new Vector3(-halfWidth + cornerLength, -halfHeight, -halfDepth), this.LineColor);

                    // Top left back:
                    vertexBuffer[16] = new WireframeShader.Vertex(new Vector3(halfWidth, halfHeight, halfDepth), this.LineColor);
                    vertexBuffer[17] = new WireframeShader.Vertex(new Vector3(halfWidth, halfHeight, halfDepth - cornerLength), this.LineColor);
                    vertexBuffer[18] = new WireframeShader.Vertex(new Vector3(halfWidth, halfHeight - cornerLength, halfDepth), this.LineColor);
                    vertexBuffer[19] = new WireframeShader.Vertex(new Vector3(halfWidth - cornerLength, halfHeight, halfDepth), this.LineColor);

                    // Top Right back:
                    vertexBuffer[20] = new WireframeShader.Vertex(new Vector3(-halfWidth, halfHeight, halfDepth), this.LineColor);
                    vertexBuffer[21] = new WireframeShader.Vertex(new Vector3(-halfWidth, halfHeight, halfDepth - cornerLength), this.LineColor);
                    vertexBuffer[22] = new WireframeShader.Vertex(new Vector3(-halfWidth, halfHeight - cornerLength, halfDepth), this.LineColor);
                    vertexBuffer[23] = new WireframeShader.Vertex(new Vector3(-halfWidth + cornerLength, halfHeight, halfDepth), this.LineColor);

                    // Bottom left back:
                    vertexBuffer[24] = new WireframeShader.Vertex(new Vector3(halfWidth, -halfHeight, halfDepth), this.LineColor);
                    vertexBuffer[25] = new WireframeShader.Vertex(new Vector3(halfWidth, -halfHeight, halfDepth - cornerLength), this.LineColor);
                    vertexBuffer[26] = new WireframeShader.Vertex(new Vector3(halfWidth, -halfHeight + cornerLength, halfDepth), this.LineColor);
                    vertexBuffer[27] = new WireframeShader.Vertex(new Vector3(halfWidth - cornerLength, -halfHeight, halfDepth), this.LineColor);

                    // Bottom Right back:
                    vertexBuffer[28] = new WireframeShader.Vertex(new Vector3(-halfWidth, -halfHeight, halfDepth), this.LineColor);
                    vertexBuffer[29] = new WireframeShader.Vertex(new Vector3(-halfWidth, -halfHeight, halfDepth - cornerLength), this.LineColor);
                    vertexBuffer[30] = new WireframeShader.Vertex(new Vector3(-halfWidth, -halfHeight + cornerLength, halfDepth), this.LineColor);
                    vertexBuffer[31] = new WireframeShader.Vertex(new Vector3(-halfWidth + cornerLength, -halfHeight, halfDepth), this.LineColor);

                    int[] idx = new int[]
                    {
                        0, 1,
                        0, 2,
                        0, 3,

                        4, 5,
                        4, 6,
                        4, 7,

                        8, 9,
                        8, 10,
                        8, 11,

                        12, 13,
                        12, 14,
                        12, 15,

                        16, 17,
                        16, 18,
                        16, 19,

                        20, 21,
                        20, 22,
                        20, 23,

                        24, 25,
                        24, 26,
                        24, 27,

                        28, 29,
                        28, 30,
                        28, 31
                    };

                    // Setup the index buffer.
                    for (int i = 0; i < 48; i++)
                        indexBuffer[i] = (ushort)idx[i];

                    #endregion
                }
                else
                {
                    #region Solid

                    // Set number of vertices and indices being used.
                    this.VertexCount = 8;
                    this.IndexCount = 24;

                    // Build the vertex array from the bounding box info.
                    vertexBuffer[0] = new WireframeShader.Vertex(new Vector3(-halfWidth, -halfHeight, halfDepth), this.LineColor);     // BL-R
                    vertexBuffer[1] = new WireframeShader.Vertex(new Vector3(halfWidth, -halfHeight, halfDepth), this.LineColor);      // BR-R
                    vertexBuffer[2] = new WireframeShader.Vertex(new Vector3(halfWidth, -halfHeight, -halfDepth), this.LineColor);     // BR-F
                    vertexBuffer[3] = new WireframeShader.Vertex(new Vector3(-halfWidth, -halfHeight, -halfDepth), this.LineColor);    // BL-F

                    vertexBuffer[4] = new WireframeShader.Vertex(new Vector3(-halfWidth, halfHeight, halfDepth), this.LineColor);      // TL-R
                    vertexBuffer[5] = new WireframeShader.Vertex(new Vector3(halfWidth, halfHeight, halfDepth), this.LineColor);       // TR-R
                    vertexBuffer[6] = new WireframeShader.Vertex(new Vector3(halfWidth, halfHeight, -halfDepth), this.LineColor);      // TR-F
                    vertexBuffer[7] = new WireframeShader.Vertex(new Vector3(-halfWidth, halfHeight, -halfDepth), this.LineColor);     // TL-F

                    indexBuffer[0] = 0;
                    indexBuffer[1] = 1;
                    indexBuffer[2] = 1;
                    indexBuffer[3] = 2;
                    indexBuffer[4] = 2;
                    indexBuffer[5] = 3;
                    indexBuffer[6] = 3;
                    indexBuffer[7] = 0;

                    indexBuffer[8] = 4;
                    indexBuffer[9] = 5;
                    indexBuffer[10] = 5;
                    indexBuffer[11] = 6;
                    indexBuffer[12] = 6;
                    indexBuffer[13] = 7;
                    indexBuffer[14] = 7;
                    indexBuffer[15] = 4;

                    indexBuffer[16] = 0;
                    indexBuffer[17] = 4;
                    indexBuffer[18] = 1;
                    indexBuffer[19] = 5;
                    indexBuffer[20] = 2;
                    indexBuffer[21] = 6;
                    indexBuffer[22] = 3;
                    indexBuffer[23] = 7;

                    #endregion
                }

                // Set the primitive topology to line list.
                this.PrimitiveTopology = SharpDX.Direct3D.PrimitiveTopology.LineList;
            }
            else
            {
                #region Solid Shape

                // Set number of vertices and indices being used.
                this.VertexCount = 8;
                this.IndexCount = 36;

                // Build the vertex array from the bounding box info.
                vertexBuffer[0] = new WireframeShader.Vertex(new Vector3(-halfWidth, -halfHeight, halfDepth), this.LineColor);     // BL-R
                vertexBuffer[1] = new WireframeShader.Vertex(new Vector3(halfWidth, -halfHeight, halfDepth), this.LineColor);      // BR-R
                vertexBuffer[2] = new WireframeShader.Vertex(new Vector3(halfWidth, -halfHeight, -halfDepth), this.LineColor);     // BR-F
                vertexBuffer[3] = new WireframeShader.Vertex(new Vector3(-halfWidth, -halfHeight, -halfDepth), this.LineColor);    // BL-F

                vertexBuffer[4] = new WireframeShader.Vertex(new Vector3(-halfWidth, halfHeight, halfDepth), this.LineColor);      // TL-R
                vertexBuffer[5] = new WireframeShader.Vertex(new Vector3(halfWidth, halfHeight, halfDepth), this.LineColor);       // TR-R
                vertexBuffer[6] = new WireframeShader.Vertex(new Vector3(halfWidth, halfHeight, -halfDepth), this.LineColor);      // TR-F
                vertexBuffer[7] = new WireframeShader.Vertex(new Vector3(-halfWidth, halfHeight, -halfDepth), this.LineColor);     // TL-F

                indexBuffer[0] = 0;
                indexBuffer[1] = 4;
                indexBuffer[2] = 7;
                indexBuffer[3] = 7;
                indexBuffer[4] = 3;
                indexBuffer[5] = 0;

                indexBuffer[6] = 7;
                indexBuffer[7] = 6;
                indexBuffer[8] = 2;
                indexBuffer[9] = 3;
                indexBuffer[10] = 7;
                indexBuffer[11] = 2;

                indexBuffer[12] = 6;
                indexBuffer[13] = 5;
                indexBuffer[14] = 1;
                indexBuffer[15] = 2;
                indexBuffer[16] = 6;
                indexBuffer[17] = 1;

                indexBuffer[18] = 5;
                indexBuffer[19] = 4;
                indexBuffer[20] = 0;
                indexBuffer[21] = 1;
                indexBuffer[22] = 5;
                indexBuffer[23] = 0;

                indexBuffer[24] = 0;
                indexBuffer[25] = 3;
                indexBuffer[26] = 2;
                indexBuffer[27] = 2;
                indexBuffer[28] = 1;
                indexBuffer[29] = 0;

                indexBuffer[30] = 6;
                indexBuffer[31] = 7;
                indexBuffer[32] = 4;
                indexBuffer[33] = 4;
                indexBuffer[34] = 5;
                indexBuffer[35] = 6;

                #endregion

                // Set the primitive topology to triangle list.
                this.PrimitiveTopology = SharpDX.Direct3D.PrimitiveTopology.TriangleList;
            }

            // Flag that we are no longer dirty.
            this.IsDirty = false;
        }

        #region IPickableObject

        public bool DoPickingTest(RenderManager manager, Ray pickingRay, object context, out float distance, out object pickedObjectContext)
        {
            pickedObjectContext = null;

            // Invert the transformation matrix so we can transform the picking ray to local space.
            Matrix boxTransform = this.TransformationMatrix;
            boxTransform.Invert();

            // Transform the picking ray into local space.
            Ray newPickingRay = new Ray(Vector3.TransformCoordinate(pickingRay.Position, boxTransform), Vector3.TransformNormal(pickingRay.Direction, boxTransform));
            newPickingRay.Direction.Normalize();

            // Check if the picking ray intersects the bounding box.
            SharpDX.BoundingBox box = new SharpDX.BoundingBox(this.minExtents, this.maxExtents);
            bool hitResult = newPickingRay.Intersects(ref box, out distance);

            // Calculate the point of intersection based on the hit result.
            if (hitResult == true)
                pickedObjectContext = newPickingRay.Position + (distance * newPickingRay.Direction) + this.Position;
            else
                pickedObjectContext = Vector3.Zero;

            return hitResult;
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
    }
}
