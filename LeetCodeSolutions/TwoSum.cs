using System.Collections.Generic;

namespace LeetCodeSolutions
{
    public class TwoSumSolution
    {
        public int[] AnySum(int[] nums, int target)
        {
            var indices = new List<int>();
            int sum;
            bool isSolutionFound = false;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int k = 1; k < nums.Length; k++)
                {
                    sum = 0 + nums[i];
                    indices.Add(i);
                    for (int j = i + k; j < nums.Length; j++)
                    {
                        sum += nums[j];
                        indices.Add(j);
                        if (sum == target)
                        {
                            isSolutionFound = true;
                            break;
                        }
                        if (sum > target)
                        {
                            isSolutionFound = false;
                            sum = 0;
                            indices.Clear();
                            break;
                        }
                    }
                    if (isSolutionFound)
                        break;
                    else
                    {
                        indices.Clear();
                    }
                }
                if (isSolutionFound)
                    break;
                else
                {
                    sum = 0;
                    indices.Clear();
                }
            }

            return isSolutionFound ? indices.ToArray() : new int[] { };
        }

        public int[] TwoSum(int[] nums, int target)
        {
            var indices = new List<int>();
            int sum;
            bool isSolutionFound = false;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int k = 1; k < nums.Length; k++)
                {
                    sum = 0 + nums[i];
                    indices.Add(i);
                    for (int j = i + k; j < nums.Length; j++)
                    {
                        sum += nums[j];
                        indices.Add(j);
                        if (sum == target)
                        {
                            isSolutionFound = true;
                            break;
                        }
                        if (sum != target)
                        {
                            isSolutionFound = false;
                            sum = 0;
                            indices.Clear();
                            break;
                        }
                    }
                    if (isSolutionFound)
                        break;
                    else
                    {
                        indices.Clear();
                    }
                }
                if (isSolutionFound)
                    break;
                else
                {
                    sum = 0;
                    indices.Clear();
                }
            }

            return isSolutionFound ? indices.ToArray() : new int[] { };
        }

        public int SubarraySum(int[] nums, int k)
        {
            int sum = 0;
            int counter = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum = 0;
                for (int j = i; j < nums.Length; j++)
                {
                    sum += nums[j];
                    if (sum == k)
                    {
                        counter++;
                    }
                }
            }

            return counter;
        }
    }
}