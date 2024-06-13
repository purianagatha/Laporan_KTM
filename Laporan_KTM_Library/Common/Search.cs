using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laporan_KTM_Library.Common
{
    public static class Search<T> where T : IComparable<T>
    {
        public static int ByNim(List<T> list, T item)
        {
            int min = 0;
            int max = list.Count - 1;
            bool NotFound = true;

            while (min <= max)
            {
                int mid = (min + max) / 2;
                int comparisonResult = item.CompareTo(list[mid]);

                if (comparisonResult == 0)
                {
                    return mid;
                }
                else if (comparisonResult < 0)
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            Debug.Assert(NotFound, "Data tidak ada dalam list");
            return -1;
        }
    }
}
