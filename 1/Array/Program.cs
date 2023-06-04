
static void Main(string[] args)
{

    int[] arr = new int[3];

    arr[0] = 1;
    arr[1] = 2;
    arr[2] = 3;


    int[,] matrix = new int[3, 3];
    matrix[0, 0] = 1;
    matrix[0, 1] = 2;
    matrix[1, 0] = 3;
    matrix[1, 1] = 4;
    matrix[2, 0] = 5;
    matrix[2, 1] = 6 ;
    matrix[3, 0] = 7;
    matrix[3, 1] = 8;
    matrix[3, 2] = 9;


    int[][] jaggedArray = new int[3][];
    jaggedArray[0] = new int[] { 1, 2, 3 };
    jaggedArray[1] = new int[] { 4, 5 };
    jaggedArray[2] = new int[] { 6, 7, 8, 9 };

    int element = jaggedArray[0][1];



    string[] names = { "ahmed", "sara", "hamad "  ,
       "mosaab" , "Ziana" , "sultan" , "mohamed"};

    string FirstName = names[0];
    Console.WriteLine(FirstName);
}