using System;

namespace CAFindTheDuplicateNumber
{
    class Program
    {
      static void Main(string[] args)
      {
        int[] nums =new int[] {1,3,4,2,2};
        int result = FindDuplicate(nums);
        Console.WriteLine(result.ToString());
      }

        public static int FindDuplicate(int[] nums) 
        {    
             int slowPointer=0;
             int fastPointer= 0;
        
        while(true)
        {            
          slowPointer = nums[slowPointer];
          fastPointer= nums[nums[fastPointer]];

            if(slowPointer == fastPointer)
              break;
        }
        
        int slowPointer2=0;

        while(true)
        {
          slowPointer = nums[slowPointer];
          slowPointer2 = nums[slowPointer2];

            if(slowPointer == slowPointer2)            
               return slowPointer;
                      
        }
        }
    }

    
}