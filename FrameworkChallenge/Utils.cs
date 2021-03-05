using FrameworkChallenge.Models;
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
        public static DataTable GetJsonToDataTable<T>(string url, out string mensagemErro) where T : BasePost
        {
            string json = string.Empty;
            mensagemErro = string.Empty;
            using (WebClient wc = new WebClient())
            {
                try
                {
                    json = wc.DownloadString($@"{url}");
                }
                catch (Exception e)
                {
                    mensagemErro = $"{e.GetType().Name}: {e.Message}";
                    return new DataTable();
                }
            }
            List<T> jsonList = JsonConvert.DeserializeObject<List<T>>(json);
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in jsonList)
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
