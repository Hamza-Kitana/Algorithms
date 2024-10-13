namespace Algo22.Models
{
    public class Details
    {
        public int SizeArray { get; set; }
        public bool RandomOrNot { get; set; }
        public int[] Array { get; set; }
        public int[] Array2 { get; set; }
        public double Time { get; set; }
        public  long MemoryUsed { get; set; }
        public string sorted {  get; set; }
        public Sort sort { get; set; }
        public int N { get; set; }

        public SortAlgorithm algorithm = new SortAlgorithm();

       
        public int[] box = new int[20];  
       
       


        public static int[] HamzaSort(int[] Array)
        {

            int MaxNumber = 0;
            int ZeroRepeat = 0;

            // هذا الوب ماذا يفعل :
            //1- يقوم بمعرفة اعلى رقم في المصفوفة  
            //2-  ويقوم بمعرفة كم صفر  في  المصفوفة 
            for (int i = 0; i < Array.Length; i++)
            {
                MaxNumber = Math.Max(Array[i], MaxNumber);
                if (Array[i] == 0)
                    ZeroRepeat = ZeroRepeat + 1;
            }

            // نقوم بانشاء مصفوفة بحجم اعلى رقم
            int[] IndexArray = new int[MaxNumber + 1];

            //نقوم بتعبئة هذه المصفوفة من حيث ان الرقم الموجود بالمصفوفة الاصلية يكون موقع الرقم ذاته
            for (int i = 0; i < Array.Length; i++)
            {
                if (IndexArray[Array[i]] == 0)
                    IndexArray[Array[i]] = Array[i];
            }

            //ننشء مصفوفة اخرى بنفس السعه للمصفوفة الاصلية    
            int[] FinalArray = new int[Array.Length];

            //نذهب الى تكرارات الصفر و نقوم باضافتهم على المصفوفة الجديدة 
            for (int i = 0; i <= ZeroRepeat; i++)
                FinalArray[i] = 0;

            //ثم نبدأ الوب من بعد موقع اخر صفر تم اضافته و نقوم بالبحث 
            //عن الارقام الموجودة في المصفوفة التي حجمها اعلى رقم في المصفوفة الاصلية
            for (int i = 0; i < IndexArray.Length; i++)
            {
                if (IndexArray[i] != 0)
                {
                    FinalArray[ZeroRepeat] = IndexArray[i];
                    ZeroRepeat = ZeroRepeat + 1;
                }
            }

            return FinalArray;
        }

        


    }
}
