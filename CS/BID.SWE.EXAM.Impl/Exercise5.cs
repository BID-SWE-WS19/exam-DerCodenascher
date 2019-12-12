using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using BID.SWE1.Exam.Interfaces;

namespace BID.SWE.EXAM.Impl
{
    public class Exercise5 : IExercise5
    {
       
        public object Method1(string str, int i)
        {
            List<string> list = new List<string>();
            Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            sock.Connect(str, i);
            using StreamReader reader = new StreamReader(new NetworkStream(sock));
            string retstr = string.Empty;
            while (!string.IsNullOrEmpty(retstr = reader.ReadLine())) {
                list.Add(retstr);
                retstr = string.Empty;
            }
            return list;
        }
    }
}