using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Ежедневник
{
    public class Notes
    {
        public int Id;
        public string Name;
        public string Description;
        public int Day;
        public int Month;
        public int Year;
        public static List<Notes> MyNotes = new List<Notes>();
    }
}
