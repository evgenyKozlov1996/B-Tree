using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_Tree
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] hardcodedNumbersArray = new int[] { 14, 1, 5, 2, 4, 6, 8, 10, 15, 17 };
            List<int> increasedArray = new List<int>();

            Node treeNode = null;

            for (int numberIndex = 0; numberIndex < hardcodedNumbersArray.Length; numberIndex++)
            {
                AddNode(hardcodedNumbersArray[numberIndex], ref treeNode);
            }

            Console.ReadLine();
        }

        public static void AddNode(int number, ref Node treeNode)
        {
            if (treeNode == null)
            {
                treeNode = new Node() { Weight = number };
                return;
            }
            if (number > treeNode.Weight)
            {
                AddNode(number, ref treeNode.Right);
            }
            else
            {
                AddNode(number, ref treeNode.Left);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="treeNode"></param>
        /// <param name="increasedArray">List which should contains all numbers from tree ordered by asc</param>
        public static void GetIncreasedArray(Node treeNode, ref List<int> increasedArray)
        {
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="treeNode"></param>
        /// <returns>Should return Max value in tree</returns>
        public static int GetMaxValue(Node treeNode)
        {
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="treeNode"></param>
        /// <returns>Should return Max value in tree</returns>
        public static int GetMinValue(Node treeNode)
        {
            
        }
    }
}
