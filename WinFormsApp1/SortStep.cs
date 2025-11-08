using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithm_Visualizer
{
    public enum SortStepType
    {
        Compare, Swap
    }
    internal class SortStep
    {
        public SortStepType StepType { get; set; }
        public int IndexA { get; set; }
        public int IndexB { get; set; }
        public int ValueA { get; set; }
        public int ValueB { get; set; }

        public SortStep(SortStepType type, int indexA, int indexB, int valueA, int valueB)
        {
            StepType = type;
            IndexA = indexA;
            IndexB = indexB;
            ValueA = valueA;
            ValueB = valueB;
        }
    }
}
