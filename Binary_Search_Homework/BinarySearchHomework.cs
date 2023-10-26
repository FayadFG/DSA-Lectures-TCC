using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Homework // don't edit this line!!!
{
    public class BinarySearchHomework // don't edit this line!!!
    {
        public static int TernarySearch(int[] myArray, int key, int start, int end) // don't edit this line!!!
                                                                                    // يمكنك تجاهل برمترات البداية والنهاية إذا لا تريد استخدام الطريقة العودية 
                                                                                    // لكن لاتقوم بحذفهم أو التعديل عليهم هنا تحت اي ظرف!!!
                                                                                    // من الممكن تمرير قيمة 0 لتجاهلهم
        {
            //TODO: write code for the ternary search algorithm and return the index of the element
            if (end >= start)
            {
                int midValue1 = start + (end - start) / 3;
                int Valuemid2 = end - (end - start) / 3;

                if (myArray[midValue1] == key)
                    return midValue1;

                if (myArray[Valuemid2] == key)
                    return Valuemid2;

                if (key < myArray[midValue1])
                    return TernarySearch(myArray, key, start, midValue1 - 1);

                else if (key > myArray[Valuemid2])
                    return TernarySearch(myArray, key, Valuemid2 + 1, end);

                else
                    return TernarySearch(myArray, key, midValue1 + 1, Valuemid2 - 1);
            }
            return -1;
        }

        public static int BinarySearchForCalculatingRepeated
            (int[] arr, int key, bool is_first, int start, int end) // don't edit this line!!!
                                                                    // يمكنك تجاهل برمترات البداية والنهاية إذا لا تريد استخدام الطريقة العودية 
                                                                    // لكن لاتقوم بحذفهم أو التعديل عليهم هنا تحت اي ظرف!!!
                                                                    // من الممكن تمرير قيمة 0 لتجاهلهم
        {
            //TODO: this methods is for getting the first accurence of the key and the last accurance

            int returnValue = -1;

            while (start <= end)
            {
                int mid = start + (end - start) / 2;

                if (arr[mid] == key)
                {
                    returnValue = mid;

                    if (is_first)
                        end = mid - 1;

                    else
                        start = mid + 1;
                }
                else if (arr[mid] < key)
                    start = mid + 1;

                else
                    end = mid - 1;

                if (!is_first && mid == arr.Length - 1)
                    break;
            }
            return returnValue;
        }

        public static int GetRepeatCount(int[] arr, int key) // don't edit this line!!!
        {
            //TODO: write code to calculate the repeat count of a spacific element
            // make sure to use the previous method in this method

            int firstIndex = BinarySearchForCalculatingRepeated(arr, key, true, 0, arr.Length);
            int lastIndex = BinarySearchForCalculatingRepeated(arr, key, false, 0, arr.Length);


            if (firstIndex == -1 || lastIndex == -1)
                return 0;

            int count = 0;
            for (int i = firstIndex; i <= lastIndex; i++)
                if (key == arr[i])
                    count++;

            if (count > 0)
                return count;
            else
                return 0;
        }
    }
}
