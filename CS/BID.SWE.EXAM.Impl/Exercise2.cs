using System;
using BID.SWE1.Exam.Interfaces;

namespace BID.SWE.EXAM.Impl
{
    public class myclass2 : Cell {
        public override int Grow() {
            _size *= 2;
            return _size;
        }

        public bool IsAlive(int Neighbours) {
            if ((Neighbours % 2) == 0) { 
                return true;
            }
            return false;
        }

    }

    public class Exercise2 : IExercise2
    {
        public object Method1()
        {
            throw new NotImplementedException();
        }

        public int Method2()
        {
            myclass2 mycl = new myclass2();
            return mycl.Grow();
        }

        public bool Method3(int o1)
        {
            myclass2 mycl = new myclass2();
            return mycl.IsAlive(o1);
        }
    }
}