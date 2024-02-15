// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine(FindMedianSortedArrays(new int[2] {1,3}, new int[1]{2}));

Console.WriteLine(FindMedianSortedArrays(new int[2] {1,3}, new int[2]{2,4}));

    double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        var lista = new List<int>(nums1);
        lista.AddRange(nums2);
        lista.Sort();
        if(lista.Count % 2 == 1){
            return lista[(lista.Count/2)];
        }

        return (lista[(lista.Count/2)-1] + lista[(lista.Count/2)])/2d;
    }
