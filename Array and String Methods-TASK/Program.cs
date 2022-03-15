using System;

namespace Array_and_String_Methods_TASK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = "bu taski methodla yazmalisiz";
            string newSentence = sentence;

            string sen = sentence.Replace("bu taski methodla yazmalisiz", "Bu Taski Methodla Yazmalisiz");
            
            Console.WriteLine(sen);
        }
    }
}
