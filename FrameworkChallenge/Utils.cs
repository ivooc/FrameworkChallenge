using FrameworkChallenge.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Net;
using System.Text;


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

        public static string GetFilter(string userId, string id, string title, string body, bool filterCompleted, bool completed)
        {
            StringBuilder filterBuilder = new StringBuilder();
            if (!string.IsNullOrEmpty(userId) && int.Parse(userId) > 0)
                filterBuilder.Append($"UserId = '{userId}' AND ");
            if (!string.IsNullOrEmpty(id) && int.Parse(id) > 0)
                filterBuilder.Append($"Id = '{id}' AND ");
            if (!string.IsNullOrWhiteSpace(title))
                filterBuilder.Append($"Title LIKE '%{title}%' AND ");
            if (!string.IsNullOrWhiteSpace(body))
                filterBuilder.Append($"Body LIKE '%{body}%' AND ");
            if (filterCompleted)
                filterBuilder.Append($"Completed = '{completed}'");
            string filter = filterBuilder.ToString();
            if (filter != string.Empty && filter.Substring(filter.Length - 5, 5) == " AND ")
                filter = filter.Remove(filter.Length - 5, 5);
            return filter;
        }
    }
}
