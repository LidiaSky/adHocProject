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
        public Vertex CreateObst()
        {
            var r = random.NextDouble() * 2.0;
            var phi = random.NextDouble() * 2.0 * Math.PI;
            
            
                return new Vertex2D(r * Math.Cos(phi), r * Math.Sin(phi), 2);
            
        }
        public Vertex CreateVertex(double radius, Vertex obst)
        {
           
                    while (true)
                    {
                        var r = random.NextDouble() * RadiusMax;
                        var phi = random.NextDouble() * 2.0 * Math.PI;
                        Vertex2D created = new Vertex2D(r * Math.Cos(phi), r * Math.Sin(phi), radius);
                        if (created.NotLiesIn(obst)) return created;
                    }
                
            }

        public NetworkGenerator(double radiusMax, int count)
        {
            RadiusMax = radiusMax;
            vertices = new Vertex[count];
        }

        public int[][] Generate()
        {
            double radiusMin = 1;
            double radiusMax = 1;
            int count = vertices.Count();
            Vertex obst = CreateObst();
            for (int i = 0; i < count; i++)
            {
                double radius = 1; // random.NextDouble() * (radiusMax - radiusMin) + radiusMin;
                vertices[i] = CreateVertex(radius, obst);
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
