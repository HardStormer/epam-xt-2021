using System;

namespace CUSTOM_STRING
{
    class I_String
    {
        private char[] I_Array;
        private int I_Length;
        public I_String()
        {
            I_Length = 0;
            I_Array = new char[0];
        }
        public I_String(params char[] array)
        {
            I_Length = array.Length;
            I_Array = new char[I_Length];
            for (int i = 0; i < I_Length; ++i)
            {
                I_Array[i] = array[i];
            }
        }
        public I_String(int length, char symbol)
        {
            I_Length = length;
            I_Array = new char[I_Length];
            for (int i = 0; i < I_Length; ++i)
            {
                I_Array[i] = symbol;
            }
        }
        public I_String(string str)
        {
            I_Length = str.Length;
            I_Array = new char[I_Length];
            for (int i = 0; i < I_Length; ++i)
            {
                I_Array[i] = str[i];
            }
        }
        public I_String(int length)
        {
            I_Length = length;
            I_Array = new char[I_Length];
        }
        public bool Compare(I_String b)
        {
            I_String a = new I_String(this.I_Array);
            if (a == b)
            {
                for (int i = 0; i < I_Length;)
                {
                    if (this[i] != b[i])
                        return false;
                    else
                        ++i;
                }
                return true;
            }
            else
                return false;
        }
        public int Find(char symbol)
        {
            int num = -1;
            for (int i = 0; i < I_Length; ++i)
                if (this[i] == symbol)
                    num = i;
            return num;
        }
        public int Find_First(char symbol)
        {
            int num = -1;
            bool find = false;
            for (int i = 0; i < I_Length; ++i)
                if (this[i] == symbol && !find)
                {
                    num = i;
                    find = true;
                }
            return num;
        }
        public I_String Concatenation(I_String b)
        {
            I_String new_str = new I_String(this.I_Length + b.I_Length);
            for (int i = 0; i < this.I_Length; ++i)
                new_str[i] = this[i];
            for (int i = this.I_Length; i < new_str.I_Length; ++i)
                new_str[i] = b[i - this.I_Length];
            return new_str;
        }
        public void Output()
        {
            for (int i = 0; i < I_Length; ++i)
                Console.Write(I_Array[i]);
            Console.WriteLine();
        }
        public char this[int index]
        {
            get
            {
                return I_Array[index];
            }
            set
            {
                I_Array[index] = value;
            }
        }
        public static bool operator ==(I_String a, I_String b)
        {
            if (a.I_Length == b.I_Length)
                return true;
            else return false;
        }
        public static bool operator !=(I_String a, I_String b)
        {
            if (a.I_Length == b.I_Length)
                return false;
            else return true;
        }
        public static I_String operator +(I_String a, I_String b)
        {
            I_String new_str = new I_String(a.I_Length + b.I_Length);
            for (int i = 0; i < a.I_Length; ++i)
                new_str[i] = a[i];
            for (int i = a.I_Length; i < new_str.I_Length; ++i)
                new_str[i] = b[i - a.I_Length];
            return new_str;
        }
        public static I_String operator +(I_String a, char[] array)
        {
            I_String new_str = new I_String(a.I_Length + array.Length);
            for (int i = 0; i < a.I_Length; ++i)
                new_str[i] = a[i];
            for (int i = a.I_Length; i < new_str.I_Length; ++i)
                new_str[i] = array[i - a.I_Length];
            return new_str;
        }
        public static I_String operator +(I_String a, string str)
        {
            I_String new_str = new I_String(a.I_Length + str.Length);
            for (int i = 0; i < a.I_Length; ++i)
                new_str[i] = a[i];
            for (int i = a.I_Length; i < new_str.I_Length; ++i)
                new_str[i] = str[i - a.I_Length];
            return new_str;
        }
        public static I_String operator +(I_String a, char symbol)
        {
            I_String new_str = new I_String(a.I_Length + 1);
            for (int i = 0; i < a.I_Length; ++i)
                new_str[i] = a[i];
            new_str[a.I_Length] = symbol;
            return new_str;
        }

        public static implicit operator string(I_String a)
        {
            string result = "";
            for (int i = 0; i < a.I_Length; ++i)
                result += a[i];
            return result;
        }
        public static explicit operator I_String(string a)
        {
            I_String result = new I_String(a.Length);
            for (int i = 0; i < a.Length; ++i)
                result[i] = a[i];
            return result;
        }
    }
}
