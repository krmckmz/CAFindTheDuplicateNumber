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
            if(nums[slowPointer] == nums[nums[fastPointer]])
              break;

              slowPointer++;
              fastPointer+=2;
        }
        
        int slowPointer2=0;

        while(true)
        {
            slowPointer--;
            slowPointer2++;

            if(nums[slowPointer] == nums[slowPointer2])            
               return nums[slowPointer];
                      
        }
        }
    }

    
}