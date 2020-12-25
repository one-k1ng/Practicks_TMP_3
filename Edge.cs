using System;

namespace Practicks_TMP_2
{
    class Edge
    {
        public int startNode { get; }
        public int finishNode { get; }
        public Edge (int newStart, int newFinish)
        {
            startNode = newStart;
            finishNode = newFinish;
        }

    }
}
