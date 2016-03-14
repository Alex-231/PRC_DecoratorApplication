using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorApplication
{
    public class PaintMath
    {
        public PaintMath()
        {
            WallAreas = new List<float>();
            OpenAreas = new List<float>();
        }


        //Public Access
        public List<float> WallAreas;
        public List<float> OpenAreas;

        //Private Set
        /*
        //Creating identical private data for a public property is not a good thing to do.
        //However due to a bug with VS 2010's compiler, not doing this would result in an overflow.
        private List<float> wallareas;
        public List<float> WallAreas { get { return wallareas; } private set { wallareas = value; } }
        private List<float> openareas;
        public List<float> OpenAreas { get { return openareas; } private set { openareas = value; } }
        */

        //public List<float> WallAreas { get { return WallAreas; } set { WallAreas = value; } }

        public float PaintArea = 0;

        //I would like to use doubles but they aren't so friendly.
        //public double paintPrice = 0;
        //public double undercoatPrice = 0;

        public float paintPrice = 0;
        public float undercoatPrice = 0;

        public string paintType;

        public void AddWall(float width, float height)
        {
            this.WallAreas.Add(width * height);
        }

        public void AddOpening(float width, float height)
        {
            this.OpenAreas.Add(width * height);
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
                this.OpenAreas.Remove(this.WallAreas.Last());
            }
            catch { }
        }

        public float GetTotalArea()
        {
            return (WallAreas.Sum() - OpenAreas.Sum());
        }
    }
}
