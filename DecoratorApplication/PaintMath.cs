using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorApplication
{
    public class Areas
    {
        //Why use floats when we can use areas!
        //(Or instances of the area class...)
        //(Which uses floats...)

        public float Width { get; set; }
        public float Height { get; set; }
        public float Area { get; set; }

        public Areas(float width, float height)
        {
            this.Width = width;
            this.Height = height;
            this.Area = width * height;
        }
    }

    public class PaintMath
    {
        public PaintMath()
        {
            OpenAreas = new List<Areas>();
            WallAreas = new List<Areas>();
        }

        public List<Areas> OpenAreas { get; set; }
        public List<Areas> WallAreas { get; set; }

        public void AddWall(float width, float height)
        {
            this.WallAreas.Add(new Areas(width, height));
        }

        public void AddOpening(float width, float height)
        {
            this.OpenAreas.Add(new Areas(width,height));
        }

        public void RemoveWall()
        {
            try
            {
                this.WallAreas.Remove(this.WallAreas.Last());
            }
            catch { }
        }

        public void RemoveOpening()
        {
            try
            {
                this.OpenAreas.Remove(this.OpenAreas.Last());
            }
            catch { }
        }

        public float GetTotalArea()
        {
            //Go through all of the class instances in the list, recording the areas and adding them up.

            float totalWallArea = 0;
            foreach(Areas Wall in WallAreas)
            {
                totalWallArea = totalWallArea + Wall.Area;
            }

            float totalOpenArea = 0;
            foreach (Areas Opening in OpenAreas)
            {
                totalOpenArea = totalOpenArea + Opening.Area;
            }

            return totalWallArea - totalOpenArea;
        }
    }
}
