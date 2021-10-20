using System;

namespace Open_Lab_04._02
{
    public class Doubler
    {
        char[] arr = new char[20];
        public string DoubleChar(string original)
        {
            int p = original.Length;
            int i = 0;
            original.ToCharArray();
            
            do
            {
                char c = original[i];
                arr[i] = (c);
                i++;
                char b = original[i];
                arr[i] = (b);
                i++;

            } while (i < p);
            string final = arr.ToString();
            return final;

        }
    }
}
