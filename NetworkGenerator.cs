using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adHoc
{
    public class NetworkGenerator
    {
        private static Random random = new Random();
        private Vertex[] vertices;
        private double RadiusMax;
        public Vertex CreateObst(double radius, bool is3D)
        {
            var r = random.NextDouble() * 2.0;
            var phi = random.NextDouble() * 2.0 * Math.PI;
            if (is3D)
            {
                var theta = random.NextDouble() * 2.0 * Math.PI;
                return new Vertex3D(r * Math.Sin(phi) * Math.Cos(theta), r * Math.Sin(phi) * Math.Sin(theta), r * Math.Cos(theta), radius);
            }
            else
            {
                return new Vertex2D(r * Math.Cos(phi), r * Math.Sin(phi), radius);
            }
        }
        public Vertex CreateVertex(double radius, Vertex obst, bool is3D)
        {
                if (is3D)
                {
                    while (true)
                    {
                        var r = random.NextDouble() * RadiusMax;
                        var phi = random.NextDouble() * 2.0 * Math.PI;
                        var theta = random.NextDouble() * 2.0 * Math.PI;
                        Vertex3D created = new Vertex3D(r * Math.Sin(phi) * Math.Cos(theta), r * Math.Sin(phi) * Math.Sin(theta), r * Math.Cos(theta), radius);
                        if (created.NotLiesIn(obst)) return created;
                    }
                }
                else
                {
                    while (true)
                    {
                        var r = random.NextDouble() * RadiusMax;
                        var phi = random.NextDouble() * 2.0 * Math.PI;
                        Vertex2D created = new Vertex2D(r * Math.Cos(phi), r * Math.Sin(phi), radius);
                        if (created.NotLiesIn(obst)) return created;
                    }
                }
            }

        public NetworkGenerator(double radiusMax, int count)
        {
            RadiusMax = radiusMax;
            vertices = new Vertex[count];
        }

        public int[][] Generate(double radiusMin, double radiusMax, bool is3D)
        {
            int count = vertices.Count();
            Vertex obst = CreateObst(2.0, is3D);
            for (int i = 0; i < count; i++)
            {
                double radius = random.NextDouble() * (radiusMax - radiusMin) + radiusMin;
                vertices[i] = CreateVertex(radius, obst, is3D);
            }
            var result = new int[count][];
            for (int i = 0; i < count; i++)
            {
                result[i] = new int[count];
                for (int j = 0; j < i; j++)
                {
                    result[i][j] = result[j][i] = (vertices[i].Intersects(vertices[j])&&obst.NotInterrupt(vertices[i],vertices[j])) ? 1 : 0; 
                }
            }
            return result;
        }
    }
}
