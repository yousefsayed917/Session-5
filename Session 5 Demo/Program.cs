namespace Session_5_Demo
{
    #region Enum
    //enum Gender
    //{
    //    Male, Female
    //}
    #endregion
    internal class Program
    {
        #region Passing By Out
        static void SumMul(int x, int y, out int sum, out int mul)
        {
            sum = x+y;
            mul = x*y;
        }
        #endregion
        #region Function - Params
        static int SumArray(int y, int x = 9,params int[] arr)
        {
            int sum = 0;
            if (arr != null)
            {
                foreach (int item in arr)
                {
                    sum += item;
                }
            }
            return sum;
        }
        #endregion
        #region ExceptionHandling And Protective Code
        static void DoSomeCode()
        {
            try
            {
                int x, y, z;
                Console.WriteLine("enter x");
                x = int.Parse(Console.ReadLine()!);
                Console.WriteLine("enter y");
                y = int.Parse(Console.ReadLine()!);
                z = x / y;
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }
        static void DoSomeProtectiveCode()
        {
            int x, y, z;
            do
            {
                Console.WriteLine("enter x");
            } while (!int.TryParse(Console.ReadLine()!, out x));
            do
            {
                Console.WriteLine("enter y");
            } while (!int.TryParse(Console.ReadLine()!, out y) || y == 0);
            z = x / y;
        }
        #endregion
        static void Main(string[] args)
        {
            #region Array method
            //int[] arr = { 1, 4, 1, 3, 6, 5, 7, 2 };
            //int[] arr1 = { 1, 2, 3 };
            //int[] arr2 = new int[5];
            #region Class Member Method {Static Method}
            //Array.Sort(arr); //order by asec
            //foreach (int item in arr)
            //    Console.WriteLine(item);
            //Console.WriteLine("----------");
            //Array.Copy(arr1, arr2, 3);
            //foreach (int item in arr2)
            //    Console.WriteLine(item);
            //Console.WriteLine("----------");
            //Array.Clear(arr2);
            //foreach (int item in arr2)
            //    Console.WriteLine(item);
            //Console.WriteLine("----------");
            //Array.ConstrainedCopy(arr1, 0, arr2, 0, 3);
            //foreach (int item in arr2)
            //    Console.WriteLine(item);
            //int[] arr3 = (int[])Array.CreateInstance(typeof(int), 7);//int arr3=new int[7]
            //int[,,] arr4 = (int[,,])Array.CreateInstance(typeof(int), 2, 3, 2);//Create 3D array
            #endregion
            #region Object Member Method
            //arr1.CopyTo(arr2, 0);
            //arr2.SetValue(7, 4);
            //Console.WriteLine(arr2[4]);
            #endregion

            #endregion
            #region Passing By Out
            //SumMul(5, 4, out int sum, out int mul);
            //Console.WriteLine(sum);
            //Console.WriteLine(mul);

            #endregion
            #region Function - Params
            //int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            //int sum=SumArray(1, 2, 3, 4, 5, 6, 7);
            //Console.WriteLine(sum);
            #endregion
            #region ExceptionHandling And Protective 
            //System Exception
            //1- Format Exception
            //2- Index Out Of Range Exception
            //3- Null Reference Exception
            //4- Invalid Operation Exception
            //Arithmetic Exception
            //1- Divided By Zero Exception
            //Application Exception
            //DoSomeCode();
            //DoSomeProtectiveCode();
            #endregion
            #region Enum
            //Gender MyGender = Gender.Male;
            //if (MyGender == Gender.Male)
            //    Console.WriteLine(":)");
            //MyGender = (Gender)1; //= Female
            #endregion
            #region Struct
            //Point p1;
            //p1.x = 7;
            //p1.y = 6;
            //p1 = new Point(4,5);
            //Console.WriteLine(p1.x);
            //Console.WriteLine(p1.y);
            #endregion
        }
    }
}
