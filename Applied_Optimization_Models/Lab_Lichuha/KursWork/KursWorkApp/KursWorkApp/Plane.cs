using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursWorkApp
{
    public class Plane
    {
        public Plane()
        {
            Sections = new List<Section>();
        }
        public List<Section> Sections { get; set; }
    }
}
