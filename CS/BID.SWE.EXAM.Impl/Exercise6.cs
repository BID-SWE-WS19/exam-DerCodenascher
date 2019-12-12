using System;
using System.Data.SqlClient;
using BID.SWE1.Exam.Interfaces;

namespace BID.SWE.EXAM.Impl
{
    public class Exercise6 : IExercise6
    {
        public object Method1()
        {
            SqlCommand command = new SqlCommand(@"INSERT INTO TestAbgaben(Tag,Monat,Jahr,Stunde,Minute,Name) VALUES(@param1,@param2,@param3,@param4,@param5,@param6)");
            command.Parameters.AddWithValue("@param1", 12);
            command.Parameters.AddWithValue("@param2", 12);
            command.Parameters.AddWithValue("@param3", 2019);
            command.Parameters.AddWithValue("@param4", 17);
            command.Parameters.AddWithValue("@param5", 15);
            command.Parameters.AddWithValue("@param6", "Philipp Lakheshar");
            return command;
        }
    }
}