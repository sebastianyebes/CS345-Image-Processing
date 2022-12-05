using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessor.Behaviours
{
    public interface IImageProcessor
    {
        void process(Bitmap loaded);
    }
}
