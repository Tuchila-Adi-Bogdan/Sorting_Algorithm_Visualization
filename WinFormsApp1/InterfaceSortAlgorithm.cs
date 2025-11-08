using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithm_Visualizer
{
    internal interface InterfaceSortAlgorithm
    {
        string AlgorithmName { get; }
        List<SortStep> GenerateSortSteps(int[] array);
    }
}
