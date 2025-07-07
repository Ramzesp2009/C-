using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson
{
    internal class FunWithLocalFunctions
    {
        static int AddWrapper(int x, int y)
        {
            return Add();
            int Add()
            {
                return x + y;
            }
        }
        private static void Process(string?[] lines, string mark)
        {
            foreach (var line in lines)
            {
                if (IsValid(line))
                {
                    continue;
                }
            }

            bool IsValid([NotNullWhen(true)] string? line){
                {
                    return !string.IsNullOrEmpty(line) && line.Length >= mark.Length;
                }
            }
        }
        static int AddWrapperWithSideEffect(int x, int y)
        {
            // This local function has a side effect, it modifies the input parameters
            return Add();
            int Add()
            {
                x += 1;
                return x + y;
            }
        }
        static int AddWrapperWithStatic(int x, int y)
        {
            // This local function is static, it does not capture any variables from the outer scope
            return Add(x, y);
            static int Add(int x, int y)
            {
                return x + y;
            }
        }
    }
}
