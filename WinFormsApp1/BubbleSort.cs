using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithm_Visualizer
{
    internal class BubbleSort: InterfaceSortAlgorithm
    {
        public string AlgorithmName => "Bubble Sort";
        public List<SortStep> GenerateSortSteps(int[] array)
        {
            List<SortStep> steps = new List<SortStep>();
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    steps.Add(new SortStep(SortStepType.Compare, j, j + 1, array[j], array[j + 1]));
                    if (array[j] > array[j + 1])
                    {
                        steps.Add(new SortStep(SortStepType.Swap, j, j + 1, array[j], array[j + 1]));
                        MySwap.swap(ref array[j], ref array[j + 1]);
                    }
                }
            }
            return steps;
        }
    }
}
