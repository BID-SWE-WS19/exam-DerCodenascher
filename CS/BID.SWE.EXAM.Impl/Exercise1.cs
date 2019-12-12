using System;
using BID.SWE1.Exam.Interfaces;

namespace BID.SWE.EXAM.Impl
{
    public class myclass1 : ICellPrinter {
        public string PrintPostion(int x, int y) {
            return "Cell is on Position X:" + x + " Y:"+ y;
        }

        public string PrintState(bool alive, DateTime date, string color) {
            string retstr = "Cell " + color + " born on " + date.ToString("dd.MM.yyyy") + " is ";
            if (alive) {
                retstr += "alive";
            } else {
                retstr += "not alive";
            }
            return retstr;
        }
    }

    public class Exercise1 : IExercise1
    {
        public object Method1()
        {
            return new myclass1();
        }
    }
}
