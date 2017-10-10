using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            Stack<int> st1 = new Stack<int>();
            st1.Push(nums[0]); 
            Stack<int> st2 = new Stack<int>();
            for (int i = 1; i < nums.Count; ++i)
            {
                if (st1.Peek() == nums[i])
                {
                    st1.Push(nums[i]);
                }
                else
                {
                    if (st2.Count == 0 || st2.Peek() == nums[i])
                    {
                        st2.Push(nums[i]);
                        if (st1.Count < st2.Count)
                        {
                            st1.Clear();
                            int currNum = st2.Peek();
                            for (int j = 0; j < st2.Count; ++j)
                            {
                                st1.Push(currNum);
                            }
                            st2.Clear();
                        }
                    }
                    else
                    {
                        st2.Clear();
                        st2.Push(nums[i]);
                    }
                }
            }
            Console.WriteLine(string.Join(" ", st1));
        }
    }
}
