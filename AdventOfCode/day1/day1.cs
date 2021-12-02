using System;
using System.Collections.Generic;
using adventOfCode;

namespace AdventOfCode.day1
{
    public static class day1
    {
        public static void oneDataCounter()
        {
            List<int> _numberList = OneDataList.DataList();
            var increments = 0;
            
            for (var i = 1; i < _numberList.Count; i++)
            {
                if (_numberList[i] > _numberList[i - 1])
                {
                    increments += 1;
                } 
            }

            Console.WriteLine(increments);
        }
        
        public static void threeDataCounter()
        {
            List<int> _numberList = ThreeDataList.DataList();
            var increments = 0;
            
            for (var i = 0; i < _numberList.Count - 3; i++)
            {
                var firstSum = _numberList[i] + _numberList[i + 1] + _numberList[i + 2];
                var secondSum = _numberList[i + 1] + _numberList[i + 2] + _numberList[i + 3];
                if (firstSum < secondSum)
                {
                    increments += 1;
                }
            }

            Console.WriteLine(increments);
        }
    }
}