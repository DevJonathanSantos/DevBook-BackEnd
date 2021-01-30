using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;

namespace DevBook.Domain.Extensions
{
    public static class CollectionExtension
    {

        public static DataTable ToDataTable<T>(this IList<T> data)
        {
            PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            for (int i = 0; i < props.Count; i++)
            {
                PropertyDescriptor prop = props[i];

                if (prop.PropertyType.ToString().Contains("System.Nullable"))
                {
                    var tipo = prop.PropertyType.ToString().Replace("System.Nullable`1[", "").Replace("]", "");

                    table.Columns.Add(new DataColumn(prop.Name, System.Type.GetType(tipo)) { AllowDBNull = true });
                }
                else
                {
                    table.Columns.Add(new DataColumn(prop.Name, prop.PropertyType) { AllowDBNull = true });
                }

            }
            object[] values = new object[props.Count];
            foreach (T item in data)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    if (props[i].GetValue(item) != null && props[i].GetValue(item).Equals(DateTime.MinValue))
                    {
                        values[i] = DBNull.Value;
                    }
                    else
                    {
                        values[i] = props[i].GetValue(item);
                    }

                }
                table.Rows.Add(values);
            }
            return table;
        }


    }
}
