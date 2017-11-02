using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon.Common.Utility
{
    public class UtilityHelper
    {
        public static void CopyValues(object source, object destination)
        {
            if (source == null || destination == null)
            {
                return;
            }

            PropertyInfo[] sourceProperties = source.GetType().GetProperties();

            foreach (PropertyInfo prop in sourceProperties)
            {
                PropertyInfo destinationProp = destination.GetType().GetProperty(prop.Name, BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance);
                if (destinationProp != null)
                {
                    destinationProp.SetValue(destination, prop.GetValue(source, null), null);
                }
            }
        }
    }
}
