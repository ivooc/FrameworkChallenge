using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Net;


namespace FrameworkChallenge
{
    public static class Utils
    {
        public static string GetJson(string url)
        {
            string json;
            using (WebClient wc = new WebClient())
            {
                json = wc.DownloadString($@"{url}");
            }
            return json;
        }

        public static List<T> JsonToList<T>(string json)
        {
            return JsonConvert.DeserializeObject<List<T>>(json);
        }

        public static DataTable JsonListToDataTable<T>(this IList<T> data)
        {
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;
        }

    }
}
