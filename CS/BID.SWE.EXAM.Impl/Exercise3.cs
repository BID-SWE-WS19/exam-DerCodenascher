using System;
using BID.SWE1.Exam.Impl;
using BID.SWE1.Exam.Interfaces;

namespace BID.SWE.EXAM.Impl
{
    public class myclass3 : Map {
        public override int AddNewCells(int count) {
            return count;
        }

        public override string GetMapName() {
            return "BID-Map";
        }

        public override float GetMapSize(float amount) {
            return amount * amount;
        }
    }

    public abstract class Bewegung {
        public abstract string Position();
        public abstract string Move(int x);
    }

    public class Springen : Bewegung {
        public override string Move(int x) {
            return string.Empty;
        }

        public override string Position() {
            return string.Empty;
        }
    }

    public class Laufen : Bewegung {
        public override string Move(int x) {
            return string.Empty;
        }

        public override string Position() {
            return string.Empty;
        }
    }

    public class Exercise3 : IExercise3
    {
        public object Method1()
        {
            return new myclass3();
        }

        public object Method2()
        {
            Bewegung[] bewarr = new Bewegung[2];
            bewarr[0] = new Springen();
            bewarr[1] = new Laufen();
            return bewarr;
        }

    }
}