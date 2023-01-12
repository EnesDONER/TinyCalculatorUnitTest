using System;

namespace TinyCalculator
{
    public class Calculator
    {
        char[] _operators = new char[] {'*','-','+','/'
        };
     
        public int Calculate(string input)
        {
            
            foreach(var o in _operators)
            {
                if (input.Contains(o.ToString()))
                {
                    string[] parts = input.Split(new char[] { o },StringSplitOptions.RemoveEmptyEntries);
                    int left = Convert.ToInt32(parts[0]);
                    int right = Convert.ToInt32(parts[1]);
                    if (o == '+')
                        return left + right;
                    if (o == '-')
                        return left - right;

                    if (o == '/')
                        return left / right;

                    if (o == '*')
                        return left * right;

                }
            }
        
           
            throw new InvalidOperationException();

        }
    }
}