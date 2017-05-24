using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringKata
{    
    public static class Extensions
    {
        public static string GetDescription(this Enum enumValue)
        {
            FieldInfo fi = enumValue.GetType().GetField(enumValue.ToString());

            if (fi != null)
            {
                object[] attrs = fi.GetCustomAttributes(typeof(DescriptionAttribute), true);
                if (attrs.Length > 0)
                    return ((DescriptionAttribute)attrs[0]).Description;
            }

            return String.Empty;
        }

        public static T GetEnum<T>(this int val) where T : struct
        {
            T result = default(T);
            if (Enum.IsDefined(typeof(T), val) && Enum.TryParse(val.ToString(), out result))
            {

            }

            return result;
        }

    }
}
