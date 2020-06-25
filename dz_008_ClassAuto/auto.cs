using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_008_ClassAuto
{
    public class auto
    {
        public int Int { get; set; }
        public double Double { get; set; }
        public string String { get; set; }
        public int Current { get; set; }

        public auto(int conferInt)
        {
            Current = 0;
            Int = conferInt;
        }
        public auto(double conferDouble)
        {
            Current = 1;
            Double = conferDouble;
        }
        public auto(string conferString)
        {
            Current = 2;
            String = conferString;
        }
        public auto()
        { }

        // explicit conversion
        public static explicit operator int(auto auto)
        {
            int tmp = 0;
            switch (auto.Current)
            {
                case 0:
                    tmp = auto.Int;
                    break;
                case 1:
                    tmp = (int)auto.Double;
                    break;
                case 2:
                    int.TryParse(auto.String, out tmp);
                    break;
            }
            return tmp;
        }

        public static explicit operator string(auto auto)
        {
            string tmp = null;
            switch (auto.Current)
            {
                case 0:
                    tmp = auto.Int.ToString();
                    break;
                case 1:
                    tmp = auto.Double.ToString();
                    break;
                case 2:
                    tmp = auto.String;
                    break;
            }
            return tmp;
        }

        public static explicit operator double(auto auto)
        {
            double tmp = 0;
            switch (auto.Current)
            {
                case 0:
                    tmp = auto.Int;
                    break;
                case 1:
                    tmp = auto.Double;
                    break;
                case 2:
                    double.TryParse(auto.String, out tmp);
                    break;
            }
            return tmp;
        }

        public static explicit operator auto(int number)
        {
            auto tmp = new auto(number)
            {
                Current = 0
            };
            return tmp;
        }

        public static explicit operator auto(double number)
        {
            auto tmp = new auto(number)
            {
                Current = 1
            };
            return tmp;
        }

        public static explicit operator auto(string str)
        {
            auto tmp = new auto(str)
            {
                Current = 2
            };
            return tmp;
        }
        // 
        public override string ToString()
        {
            switch (Current)
            {
                case 0:
                    return $"{Int}";
                case 1:
                    return $"{Double}";
                case 2:
                    return $"{String}";
            }
            return $"";
        }
        public override bool Equals(object obj)
        {
            return Current.Equals((obj as auto)?.Current);
        }
        public override int GetHashCode()
        {
            return Current.GetHashCode();
        }
        // overload comparisons
        public static bool operator ==(auto l, auto r)
        {
            bool check = false;
            if (l.Current == r.Current)
            {
                switch (l.Current)
                {
                    case 0:
                        check = l.Int == r.Int;
                        break;
                    case 1:
                        check = l.Double == r.Double;
                        break;
                    case 2:
                        check = l.String == r.String;
                        break;
                }
            }
            return check;
        }
        public static bool operator !=(auto l, auto r)
        {
            return !(l == r);
        }
        public static bool operator >(auto l, auto r)
        {
            bool check = false;
            if (l.Current == r.Current)
            {
                switch (l.Current)
                {
                    case 0:
                        check = l.Int > r.Int;
                        break;
                    case 1:
                        check = l.Double > r.Double;
                        break;
                    case 2:
                        Console.WriteLine("Operaotor '>' can not be applied to operands of 'string' and 'string'");
                        throw new FormatException();
                }
            }
            return check;
        }
        public static bool operator <(auto l, auto r)
        {
            bool check = false;
            if (l.Current == r.Current)
            {
                switch (l.Current)
                {
                    case 0:
                        check = l.Int < r.Int;
                        break;
                    case 1:
                        check = l.Double < r.Double;
                        break;
                    case 2:
                        Console.WriteLine("Operaotor '<' can not be applied to operands of 'string' and 'string'");
                        throw new FormatException();
                }
            }
            return check;
        }
        public static bool operator >=(auto l, auto r)
        {
            bool check = false;
            if (l.Current == r.Current)
            {
                switch (l.Current)
                {
                    case 0:
                        check = l.Int >= r.Int;
                        break;
                    case 1:
                        check = l.Double >= r.Double;
                        break;
                    case 2:
                        Console.WriteLine("Operaotor '>=' can not be applied to operands of 'string' and 'string'");
                        throw new FormatException();
                }
            }
            return check;
        }
        public static bool operator <=(auto l, auto r)
        {
            bool check = false;
            if (l.Current == r.Current)
            {
                switch (l.Current)
                {
                    case 0:
                        check = l.Int <= r.Int;
                        break;
                    case 1:
                        check = l.Double <= r.Double;
                        break;
                    case 2:
                        Console.WriteLine("Operaotor '<=' can not be applied to operands of 'string' and 'string'");
                        throw new FormatException();
                }
            }
            return check;
        }

        // addition overload
        public static auto operator +(auto l, auto r)
        {
            auto tmp = null;
            switch (l.Current)
            {
                case 0:
                    tmp = l + (int)r;
                    break;
                case 1:
                    tmp = l + (double)r;
                    break;
                case 2:
                    tmp = l + (string)r;
                    break;
            }
            return tmp;
        }
        public static auto operator +(auto l, int r)
        {
            auto tmp = null;
            switch (l.Current)
            {
                case 0:
                    tmp = new auto(l.Int + r);
                    break;
                case 1:
                    tmp = new auto(l.Double + r);
                    break;
                case 2:
                    tmp = new auto(l.String + r);
                    break;
            }
            return tmp;
        }
        public static auto operator +(auto l, double r)
        {
            auto tmp = null;
            switch (l.Current)
            {
                case 0:
                    tmp = new auto(l.Int + (int)r);
                    break;
                case 1:
                    tmp = new auto(l.Double + r);
                    break;
                case 2:
                    tmp = new auto(l.String + r);
                    break;
            }
            return tmp;
        }
        public static auto operator +(auto l, string r)
        {
            auto tmp = null;
            switch (l.Current)
            {
                case 0:
                    int.TryParse(r, out int result);
                    tmp = new auto(l.Int + result);
                    break;
                case 1:
                    double.TryParse(r, out double result1);
                    tmp = new auto(l.Double + result1);
                    break;
                case 2:
                    tmp = new auto(l.String + r);
                    break;
            }
            return tmp;
        }

        // subtraction operators
        public static auto operator -(auto l, auto r)
        {
            auto tmp = null;
            switch (l.Current)
            {
                case 0:
                    tmp = l - (int)r;
                    break;
                case 1:
                    tmp = l - (double)r;
                    break;
                case 2:
                    Console.WriteLine("Operaotor '-' can not be applied to operands of 'string' and 'string'");
                    throw new FormatException();
            }
            return tmp;
        }
        public static auto operator -(auto l, int r)
        {
            auto tmp = null;
            switch (l.Current)
            {
                case 0:
                    tmp = new auto(l.Int - r);
                    break;
                case 1:
                    tmp = new auto(l.Double - r);
                    break;
                case 2:
                    Console.WriteLine("Operaotor '-' can not be applied to operands of 'string' and 'int'");
                    throw new FormatException();
            }
            return tmp;
        }
        public static auto operator -(auto l, double r)
        {
            auto tmp = null;
            switch (l.Current)
            {
                case 0:
                    tmp = new auto(l.Int - (int)r);
                    break;
                case 1:
                    tmp = new auto(l.Double - r);
                    break;
                case 2:
                    Console.WriteLine("Operaotor '-' can not be applied to operands of 'string' and 'double'");
                    throw new FormatException();
            }
            return tmp;
        }
        public static auto operator -(auto l, string r)
        {
            auto tmp = null;
            switch (l.Current)
            {
                case 0:
                    int.TryParse(r, out int num);
                    tmp = new auto(l.Int - num);
                    break;
                case 1:
                    double.TryParse(r, out double num1);
                    tmp = new auto(l.Double - num1);
                    break;
                case 2:
                    Console.WriteLine("Operaotor '-' can not be applied to operands of 'string' and 'string'");
                    throw new FormatException();
            }
            return tmp;
        }

        // operator *
        public static auto operator *(auto l,auto r)
        {
            auto tmp = null;
            switch (l.Current)
            {
                case 0:
                    tmp = l * (int)r;
                    break;
                case 1:
                    tmp = l * (double)r;
                    break;
                case 2:
                    if (r.Current == 2)
                    {
                        string tmpStr = null;
                        for (int i = 0; i < l.String.Length; i++)
                        {
                            if (r.String.Contains(l.String[i]))
                                tmpStr += l.String[i];
                        }
                        tmp = new auto(tmpStr);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Operaotor '*' can not be applied to operands of 'string' and 'some type'");
                        throw new FormatException();
                    }
            }
            return tmp;
        }
        public static auto operator *(auto l, int r)
        {
            auto tmp = null;
            switch (l.Current)
            {
                case 0:
                    tmp = new auto(l.Int * r);
                    break;
                case 1:
                    tmp = new auto(l.Double * r);
                    break;
                case 2:
                    Console.WriteLine("Operaotor '*' can not be applied to operands of 'string' and 'int'");
                    throw new FormatException();
            }
            return tmp;
        }
        public static auto operator *(auto l, double r)
        {
            auto tmp = null;
            switch (l.Current)
            {
                case 0:
                    tmp = new auto(l.Int * (int)r);
                    break;
                case 1:
                    tmp = new auto(l.Double * r);
                    break;
                case 2:
                    Console.WriteLine("Operaotor '*' can not be applied to operands of 'string' and 'double'");
                    throw new FormatException();
            }
            return tmp;
        }
        public static auto operator *(auto l, string r)
        {
            auto tmp = null;
            switch (l.Current)
            {
                case 0:
                    int.TryParse(r, out int result);
                    tmp = new auto(l.Int * result);
                    break;
                case 1:
                    double.TryParse(r, out double result1);
                    tmp = new auto(l.Double * result1);
                    break;
                case 2:
                    string tmpStr = null;
                    for (int i = 0; i < l.String.Length; i++)
                    {
                        if (r.Contains(l.String[i]))
                            tmpStr += l.String[i];
                    }
                    tmp = new auto(tmpStr);
                    break;
            }
            return tmp;
        }

        // operator /
        public static auto operator /(auto l, auto r)
        {
            auto tmp = null;
            switch (l.Current)
            {
                case 0:
                    tmp = l / (int)r;
                    break;
                case 1:
                    tmp = l / (double)r;
                    break;
                case 2:
                    if (r.Current == 2)
                    {
                        string tmpStr = null;
                        for (int i = 0; i < l.String.Length; i++)
                        {
                            if (!(r.String.Contains(l.String[i])))
                                tmpStr += l.String[i];
                        }
                        tmp = new auto(tmpStr);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Operaotor '/' can not be applied to operands of 'string' and 'some type'");
                        throw new FormatException();
                    }
            }
            return tmp;
        }
        public static auto operator /(auto l, int r)
        {
            auto tmp = null;
            switch (l.Current)
            {
                case 0:
                    tmp = new auto(l.Int / r);
                    break;
                case 1:
                    tmp = new auto(l.Double / r);
                    break;
                case 2:
                    Console.WriteLine("Operaotor '/' can not be applied to operands of 'string' and 'int'");
                    throw new FormatException();
            }
            return tmp;
        }
        public static auto operator /(auto l, double r)
        {
            auto tmp = null;
            switch (l.Current)
            {
                case 0:
                    tmp = new auto(l.Int / (int)r);
                    break;
                case 1:
                    tmp = new auto(l.Double / r);
                    break;
                case 2:
                    Console.WriteLine("Operaotor '/' can not be applied to operands of 'string' and 'double'");
                    throw new FormatException();
            }
            return tmp;
        }
        public static auto operator /(auto l, string r)
        {
            auto tmp = null;
            switch (l.Current)
            {
                case 0:
                    int.TryParse(r, out int result);
                    tmp = new auto(l.Int / result);
                    break;
                case 1:
                    double.TryParse(r, out double result1);
                    tmp = new auto(l.Double / result1);
                    break;
                case 2:
                    string tmpStr = null;
                    for (int i = 0; i < l.String.Length; i++)
                    {
                        if (!(r.Contains(l.String[i])))
                            tmpStr += l.String[i];
                    }
                    tmp = new auto(tmpStr);
                    break;
            }
            return tmp;
        }
    }
}
