using System;

namespace Open_Lab_04._03
{
    public class StringTools
    {
        public string RemoveFirstLast(string original)
        {
            if (original.Length < 2)
            {
                return original;
            }
            else 
            {
                return original.Remove(original.Length - 1).Remove(0, 1);
            }
        }
    }
}
