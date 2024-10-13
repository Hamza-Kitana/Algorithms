namespace Algo22.Models
{
    public class SortAlgorithm
    {
         public int count {  get; set; }

        public int[] Insertion(int[] x , out int count2)
        {

            int[] y = x; count++;

            
            for (int i = 1; i < y.Length; ++i)
            {
                int key = y[i]; count++;
                int j = i - 1; count++;


                while (j >= 0 && y[j] > key)
                {
                    y[j + 1] = y[j]; count++;
                    j = j - 1; count++;
                }

                y[j + 1] = key; count++;
            }
            count = count + y.Length;

            int sum = 0;
            for(int i = 0;i<y.Length; ++i)
                sum = sum + i;

            count = count +sum ;
            count++;
            count2 = count; 
            return y;
        }


        public int[] Heap(int[] x , out int count2)
        {
            int[] y = x; count++;


            int n = y.Length; count++;

            int q = 1;
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                q++;
                Heapify(y, n, i); count++;
            }
            count = count +q;
            int p = 1;
            for (int i = n - 1; i > 0; i--)
            {
                p++;
                int temp = y[0]; count++;
                y[0] = y[i]; count++;
                y[i] = temp; count++;
                Heapify(y, i, 0); count++;
            }
            count = count + p;
            count++;
            count2 = count;
            return y;

        }


        public void Heapify(int[] arr, int n, int i)
        {
            int largest = i; count++;
            int left = 2 * i + 1; count++;
            int right = 2 * i + 2; count++;


            if (left < n && arr[left] > arr[largest])
            {
                largest = left; count++;
            }
            
            if (right < n && arr[right] > arr[largest])
            {
                largest = right; count++;
            }
           

            if (largest != i)
            {
                int swap = arr[i]; count++;
                arr[i] = arr[largest]; count++;
                arr[largest] = swap; count++;

                Heapify(arr, n, largest); count++;
            }
        }

        public int[] Counting(int[] x , out int count2)
        {
           
            int[] y = x; count++;
            int n = y.Length; count++;


            int max = y[0]; count++;
            int w = 0;
            for (int i = 1; i < n; i++)
            {
                w++;
                if (y[i] > max)
                {
                    max = y[i]; count++;
                }
            }
            count = count+w;

            int[] counte = new int[max + 1]; count++;


            for (int i = 0; i < n; i++)
            {
                counte[y[i]]++; count++;
            }


            int index = 0; count++;
            for (int i = 0; i <= max; i++)
            {
                count++;
                while (counte[i] > 0)
                {
                    count++;
                    y[index] = i; count++;
                    index++; count++;
                    counte[i]--; count++;
                }
            }
            count++;
            count2 = count; 
            return y;
        }




        public int[] Tag(int[] x)
        {

            Dictionary<int, List<int>> tags = new Dictionary<int, List<int>>();

            for (int i = 0; i < x.Length; i++)
            {
                int element = x[i];

                if (!tags.ContainsKey(element))
                {
                    tags[element] = new List<int>();
                }

                tags[element].Add(i);
            }


            List<KeyValuePair<int, List<int>>> sortedTags = new List<KeyValuePair<int, List<int>>>(tags);
            sortedTags.Sort((x, y) => x.Key.CompareTo(y.Key));


            int[] sortedArray = new int[x.Length];

            int index = 0;

            foreach (KeyValuePair<int, List<int>> tag in sortedTags)
            {
                foreach (int position in tag.Value)
                {
                    sortedArray[index++] = position;
                }
            }

            return sortedArray;
        }



        public int[] Comb(int[] array)
        {
            int gap = array.Length / 2;
            bool swapped = true;

            while (gap > 1 || swapped)
            {
                gap /= 2;
                swapped = false;

                for (int i = 0; i < array.Length - gap; i++)
                {
                    if (array[i] > array[i + gap])
                    {
                        int temp = array[i];
                        array[i] = array[i + gap];
                        array[i + gap] = temp;
                        swapped = true;
                    }
                }
            }

            return array;
        }


        public int[] Pancake(int[] array)
        {
            for (int i = array.Length - 1; i >= 1; i--)
            {
                int maxIndex = FindMaxIndex(array, i);
                Flip(array, maxIndex);
                Flip(array, i);
            }

            return array;
        }

        private static int FindMaxIndex(int[] array, int end)
        {
            int maxIndex = 0;
            int maxValue = array[0];

            for (int i = 1; i <= end; i++)
            {
                if (array[i] > maxValue)
                {
                    maxIndex = i;
                    maxValue = array[i];
                }
            }

            return maxIndex;
        }

        private static void Flip(int[] array, int end)
        {
            int temp;

            for (int i = 0; i <= end / 2; i++)
            {
                temp = array[i];
                array[i] = array[end - i];
                array[end - i] = temp;
            }
        }



        private static void StoogeSort(int[] array, int start, int end)
        {
            if (end - start <= 1)
            {
                return;
            }

            int mid = (start + end) / 2;

            if (array[end] < array[start])
            {
                Swap(array, start, end);
            }

            if (end - start > 2 && array[mid] < array[start])
            {
                Swap(array, start, mid);
            }

            StoogeSort(array, start, mid);
            StoogeSort(array, mid + 1, end);
            StoogeSort(array, start, mid);
        }

        private static void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        public int[] Stooge(int[] array)
        {
            StoogeSort(array, 0, array.Length - 1);
            return array;
        }





        public int[] Gnome(int[] array)
        {
            int index = 1;
            while (index < array.Length)
            {
                if (array[index] >= array[index - 1])
                {
                    index++;
                }
                else
                {
                    int temp = array[index];
                    int i = index - 1;

                    while (i >= 0 && array[i] > temp)
                    {
                        array[i + 1] = array[i];
                        i--;
                    }

                    array[i + 1] = temp;
                    index = 1;
                }
            }

            return array;
        }





        private static void BitonicMerge(int[] array, int low, int high, bool isAscending)
        {
            if (high - low <= 1)
            {
                return;
            }

            int mid = (low + high) / 2;
            BitonicMerge(array, low, mid, true);
            BitonicMerge(array, mid, high, false);

            if (isAscending)
            {
                for (int i = low; i < mid; i++)
                {
                    if (array[i] > array[mid])
                    {
                        Swape(array, i, mid + i);
                    }
                }
            }
            else
            {
                for (int i = mid + 1; i < high; i++)
                {
                    if (array[i] < array[mid - 1 + i])
                    {
                        Swape(array, i, mid - 1 + i);
                    }
                }
            }
        }

        private static void Swape(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        public int[] Bitonic(int[] array)
        {
            BitonicMerge(array, 0, array.Length, true);
            return array;
        }



        public int[] Pigeonhole(int[] array)
        {
            int min = array[0];
            int max = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
                else if (array[i] > max)
                {
                    max = array[i];
                }
            }

            int[] pigeonholes = new int[max - min + 1];

            for (int i = 0; i < array.Length; i++)
            {
                pigeonholes[array[i] - min]++;
            }

            int[] sortedArray = new int[array.Length];
            int index = 0;

            for (int i = 0; i < pigeonholes.Length; i++)
            {
                for (int j = 0; j < pigeonholes[i]; j++)
                {
                    sortedArray[index++] = i + min;
                }
            }

            return sortedArray;
        }



        public int[] Cocktail(int[] array)
        {
            bool swapped = true;
            int start = 0;
            int end = array.Length - 1;

            while (swapped)
            {
                swapped = false;


                for (int i = start; i < end; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        swapped = true;
                    }
                }

                end--;

                if (!swapped)
                {
                    break;
                }

                swapped = false;

                // Right-to-left pass
                for (int i = end - 1; i >= start; i--)
                {
                    if (array[i] > array[i + 1])
                    {
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        swapped = true;
                    }
                }

                start++;
            }

            return array;
        }



        public int[] Radix(int[] x)
        {
            int[] y = x;
            int max = GetMax(y);
            for (int exp = 1; max / exp > 0; exp *= 10)
            {
                CountingSort(y, exp);
            }
            return y;
        }

        static void CountingSort(int[] arr, int exp)
        {
            int n = arr.Length;
            int[] output = new int[n];
            int[] count = new int[10];


            for (int i = 0; i < n; i++)
            {
                count[(arr[i] / exp) % 10]++;
            }


            for (int i = 1; i < 10; i++)
            {
                count[i] += count[i - 1];
            }


            for (int i = n - 1; i >= 0; i--)
            {
                output[count[(arr[i] / exp) % 10] - 1] = arr[i];
                count[(arr[i] / exp) % 10]--;
            }


            for (int i = 0; i < n; i++)
            {
                arr[i] = output[i];
            }
        }

        static int GetMax(int[] arr)
        {
            int max = arr[0];
            foreach (int element in arr)
            {
                if (element > max)
                {
                    max = element;
                }
            }
            return max;
        }



        public int[] Selection(int[] x)
        {
            int[] y = x;

            int n = y.Length;

            for (int i = 0; i < n - 1; i++)
            {

                int minIndex = i;


                for (int j = i + 1; j < n; j++)
                {
                    if (y[j] < y[minIndex])
                    {
                        minIndex = j;
                    }
                }


                if (minIndex != i)
                {
                    int temp = y[i];
                    y[i] = y[minIndex];
                    y[minIndex] = temp;
                }
            }
            return y;
        }

        public int[] Bubble(int[] x)
        {
            int[] y = x;


            for (int i = 0; i < y.Length; i++)
            {
                for (int j = 0; j < y.Length - 1; j++)
                {
                    if (y[j] > y[j + 1])
                    {
                        int temp = y[j];
                        y[j] = y[j + 1];
                        y[j + 1] = temp;
                    }
                }
            }
            return y;
        }




        public int[] Merge(int[] x)
        {
            int[] y = x;
            MergeSort(y, 0, y.Length - 1);

            return y;
        }

        static void MergeSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;
                MergeSort(arr, left, middle);
                MergeSort(arr, middle + 1, right);
                Merge(arr, left, middle, right);
            }
        }

        static void Merge(int[] arr, int left, int middle, int right)
        {
            int n1 = middle - left + 1;
            int n2 = right - middle;

            int[] leftArray = new int[n1];
            int[] rightArray = new int[n2];

            for (int i = 0; i < n1; i++)
            {
                leftArray[i] = arr[left + i];
            }
            for (int j = 0; j < n2; j++)
            {
                rightArray[j] = arr[middle + 1 + j];
            }

            int iLeft = 0, iRight = 0, k = left;
            while (iLeft < n1 && iRight < n2)
            {
                if (leftArray[iLeft] <= rightArray[iRight])
                {
                    arr[k] = leftArray[iLeft];
                    iLeft++;
                }
                else
                {
                    arr[k] = rightArray[iRight];
                    iRight++;
                }
                k++;
            }

            while (iLeft < n1)
            {
                arr[k] = leftArray[iLeft];
                iLeft++;
                k++;
            }
            while (iRight < n2)
            {
                arr[k] = rightArray[iRight];
                iRight++;
                k++;
            }
        }

        public int[] Cycle(int[] x)
        {
            int[] y = x;
            int n = y.Length;

            for (int start = 0; start <= n - 2; start++)
            {
                int item = y[start];
                int pos = start;

                for (int i = start + 1; i < n; i++)
                {
                    if (y[i] < item)
                        pos++;
                }

                if (pos == start)
                    continue;

                while (item == y[pos])
                    pos++;

                int temp = y[pos];
                y[pos] = item;
                item = temp;

                while (pos != start)
                {
                    pos = start;
                    for (int i = start + 1; i < n; i++)
                    {
                        if (y[i] < item)
                            pos++;
                    }

                    while (item == y[pos])
                        pos++;

                    temp = y[pos];
                    y[pos] = item;
                    item = temp;
                }
            }

            return y;
        }



        public int[] Quick(int[] x)
        {
            int[] y = x;
            QuickSort(y, 0, y.Length - 1);

            return y;
        }
        static void QuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = Partition(arr, low, high);
                QuickSort(arr, low, pivotIndex - 1);
                QuickSort(arr, pivotIndex + 1, high);
            }
        }

        static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (arr[j] <= pivot)
                {
                    i++;
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            int tempPivot = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = tempPivot;

            return i + 1;
        }


        public int[] Shell(int[] array)
        {
            int gap = array.Length / 2;
            bool swapped = true;

            while (gap > 1 || swapped)
            {
                gap /= 2;
                swapped = false;

                for (int i = 0; i < array.Length - gap; i++)
                {
                    if (array[i] > array[i + gap])
                    {
                        int temp = array[i];
                        array[i] = array[i + gap];
                        array[i + gap] = temp;
                        swapped = true;
                    }
                }
            }

            return array;
        }



        public int[] Sleep(int[] array)
        {

            Thread[] threads = new Thread[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                Thread thread = new Thread(() => {
                    Thread.Sleep(array[i]);
                });

                thread.Start();
                threads[i] = thread;
            }

            for (int i = 0; i < array.Length; i++)
            {
                threads[i].Join();
            }


            Array.Sort(array);
            return array;
        }

        public int[] Bucket(int[] arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            int[] buckets = new int[max + 1];
            for (int i = 0; i < arr.Length; i++)
            {
                buckets[arr[i]]++;
            }

            int index = 0;
            for (int i = 0; i <= max; i++)
            {
                for (int j = 0; j < buckets[i]; j++)
                {
                    arr[index++] = i;
                }
            }

            return arr;
        }
    }
}
