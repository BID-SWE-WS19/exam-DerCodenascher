using System;
using System.IO;
using BID.SWE1.Exam.Interfaces;

namespace BID.SWE.EXAM.Impl
{
    public class Exercise4 : IExercise4
    {
        public object Method1()
        {
            MemoryStream memstream = new MemoryStream();
            using StreamWriter writer = new StreamWriter(memstream, leaveOpen: true);
            writer.Write("Frohe Weihnachten");
            writer.Write(42);
            writer.Write(false);
            writer.Flush();
            memstream.Seek(0, SeekOrigin.Begin);
            return memstream;
        }

        public object Method2(object obj)
        {
            using BinaryReader reader = new BinaryReader((Stream)obj);
            reader.ReadInt32();
            reader.ReadBoolean();
            string retstr = reader.ReadString();
            return retstr;
        }
    }
}