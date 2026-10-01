using System;
using System.Collections.Generic;
using System.Text;

using System.Collections;

namespace session_10.Services
{
    public static class ArrayListReverser
    {
        public static void Reverse(ArrayList list)
        {
            int left = 0;
            int right = list.Count - 1;

            while (left < right)
            {
                object temp = list[left]!;

                list[left] = list[right];
                list[right] = temp;

                left++;
                right--;
            }
        }
    }
}
