using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DXNET.DirectWrite
{
    public partial class ColorGlyphRunEnumerator
    {
        public unsafe ColorGlyphRun CurrentRun
        {
            get
            {
                GetCurrentRun(out IntPtr ptr);
                var run = new ColorGlyphRun();
                run.__MarshalFrom(ref *((ColorGlyphRun.__Native*)ptr));
                return run;
            }
        }
    }
}
