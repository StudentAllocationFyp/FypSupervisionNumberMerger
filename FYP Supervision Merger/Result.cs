using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FYP_Supervision_Merger
{
    public class Result
    {
        public string Name { get; set; }
        public int TotalFyp = 0;
        public int Sem1 = 0;
        public int Sem2 = 0;
        public int FileId = -1;
        public bool IsMerged = false;
    }
}
