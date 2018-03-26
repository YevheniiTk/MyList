using StringExtantion;
using System;
using System.Collections.Generic;

namespace ListTest
{
    class Program
    {
        static void Main(string[] args)
        {
            TestAddFirstValue();

            TestAddFourValues();

            TestAddFifyhValues();

            TestCountFirstValue();

            TestCountFourValues();

            TestCountFifyhValues();

            TestRemove();

            TestRemoveAt();

            TestClear();

            TestIEnumetator();

            TestStringExtantions();

            TestContains();
        }

        private static void TestContains()
        {
            var list = new List.List();

            int from = 0;
            int to = 3;
            for (int i = from; i <= to; i++)
            {
                list.Add(i);
            }
            
            if(list.Contains(1) && !list.Contains(5))
            {
                Console.WriteLine(@"TestContains passed.");
            }
            else
            {
                Console.WriteLine(@"TestContains failf.");
            }
        }

        private static void TestAddFirstValue()
        {
            var list = new List.List();

            int value = 10;

            list.Add(value);

            if ((int)list[0] == value)
            {
                Console.WriteLine(@"TestAddFirstValue passed 
                                            for value {0}.", value);
            }
            else
            {
                Console.WriteLine(@"TestAddFirstValue failf. 
                                            Expected: {0}
                                            Actual: {1}.", value, (int)list[0]);
            }
        }

        private static void TestAddFourValues()
        {
            var list = new List.List();

            int from = 0;
            int to = 3;
            for (int i = from; i <= to; i++)
            {
                list.Add(i);
            }

            for (int i = from; i <= to; i++)
            {
                if ((int)list[i] == i)
                {
                    Console.WriteLine(@"TestAddFourValues passed 
                                            for value {0}.", i);
                }
                else
                {
                    Console.WriteLine(@"TestAddFourValues failf. 
                                            Expected: {0}
                                            Actual: {1}.", i, (int)list[i]);
                }
            }

        }

        private static void TestAddFifyhValues()
        {
            var list = new List.List();

            int from = 0;
            int to = 4;
            for (int i = from; i <= to; i++)
            {
                list.Add(i);
            }

            if ((int)list[to] == to)
            {
                Console.WriteLine(@"TestAddFifyhValues passed 
                                            for value {0}.", to);
            }
            else
            {
                Console.WriteLine(@"TestAddFifyhValues failf. 
                                            Expected: {0}
                                            Actual: {1}.", to, (int)list[0]);
            }
        }

        private static void TestCountFirstValue()
        {
            var list = new List.List();

            int expectedValue = 1;

            list.Add(10);

            if (list.Count == 1)
            {
                Console.WriteLine(@"TestCountFirstValue passed.");
            }
            else
            {
                Console.WriteLine(@"TestCountFirstValue failf. 
                                            Expected: {0}
                                            Actual: {1}.", expectedValue, list.Count);
            }
        }

        private static void TestCountFourValues()
        {
            var list = new List.List();

            int from = 0;
            int to = 3;
            for (int i = from; i <= to; i++)
            {
                list.Add(i);
            }

            int expectedResult = to + 1;
            if (list.Count == expectedResult)
            {
                Console.WriteLine(@"TestCountFourValues passed.");
            }
            else
            {
                Console.WriteLine(@"TestCountFourValues failf. 
                                            Expected: {0}
                                            Actual: {1}.", expectedResult, list.Count);
            }
        }

        private static void TestCountFifyhValues()
        {
            var list = new List.List();

            int from = 0;
            int to = 4;
            for (int i = from; i <= to; i++)
            {
                list.Add(i);
            }

            int expectedResult = to + 1;
            if (list.Count == expectedResult)
            {
                Console.WriteLine(@"TestCountFifyhValues passed.");
            }
            else
            {
                Console.WriteLine(@"TestCountFifyhValues failf. 
                                            Expected: {0}
                                            Actual: {1}.", expectedResult, list.Count);
            }
        }

        private static void TestRemove()
        {
            var list = new List.List();

            int from = 0;
            int to = 4;

            for (int i = from; i <= to; i++)
            {
                list.Add(i);
            }

            list.Remove(5);
            list.Remove(1);

            if (list.Count == 4)
            {
                Console.WriteLine(@"TestRemove passed.");
            }
            else
            {
                Console.WriteLine(@"TestRemove failf. 
                                            Expected: List count - {0}", list.Count);
            }

        }

        private static void TestRemoveAt()
        {
            var list = new List.List();

            int from = 0;
            int to = 4;

            for (int i = from; i <= to; i++)
            {
                list.Add(i);
            }

            list.RemoveAt(0);

            if (list.Count == 4)
            {
                Console.WriteLine(@"TestRemoveAt passed.");
            }
            else
            {
                Console.WriteLine(@"TestRemoveAt failf. 
                                            Expected: List count - {0}", list.Count);
            }
        }

        private static void TestClear()
        {
            var list = new List.List();

            int from = 0;
            int to = 8;

            for (int i = from; i <= to; i++)
            {
                list.Add(i);
            }

            list.Clear();

            if(list.Count == 0)
            {
                Console.WriteLine(@"TestClear passed.");
            }
            else
            {
                Console.WriteLine(@"TestClear failf. 
                                            Expected: List count - {0}", list.Count);
            }
        }

        private static void TestIEnumetator()
        {
            var list = new List.List();

            bool result = false;

            int from = 0;
            int to = 1;

            for (int i = from; i <= to; i++)
            {
                list.Add(i);
            }
            
            foreach (var i in list)
            {
                result = true;
            }

            if (result)
            {
                Console.WriteLine(@"TestIEnumetator passed.");
            }
            else
            {
                Console.WriteLine(@"TestIEnumetator failf.");
            }
        }

        private static void TestStringExtantions()
        {
            string test = "1jhhbj2kjjj3lh4d5";
            List.List list = test.GetListIntegers();

            foreach (var item in list)
            {
                if (item is int)
                {
                    Console.WriteLine(@"TestStringExtantions passed.");
                }
                else
                {
                    Console.WriteLine(@"TestRemove failf.");
                }
            }
        }
    }
}

