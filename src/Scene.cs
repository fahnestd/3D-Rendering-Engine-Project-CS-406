using System;
using System.Collections.Generic;

namespace _3d_Rendering_Engine.src
{
    public class Scene(
        Camera camera
    )
    {
        public Camera Camera = camera;

        public List<Mesh> Meshes { get; } = [];

        public void AddMesh(Mesh mesh)
        {
            Meshes.Add(mesh);
        }

        public void RemoveMesh(Mesh mesh)
        {
            Meshes.Remove(mesh);
        }
    }

}