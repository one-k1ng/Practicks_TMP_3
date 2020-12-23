using System;


namespace Practicks_TMP_2
{
    class Vertex
    {
        public int Number { get; set; }
        public Vertex (int number)
        {
            Number = number;
        }

        public override string ToString()
        {
            return Number.ToString();
        }

    }
}
