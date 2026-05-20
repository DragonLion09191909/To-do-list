using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace To_do_list
{
    internal class JsonSaver
    {
        
        private static string _save="save.json";

        public static void Save(List<TodoList> list)
        {
            string json;
            json = JsonSerializer.Serialize(list);
            File.WriteAllText(_save, json);

        }
        public static List<TodoList> Load()
        {
            if (File.Exists(_save))
            {
                string jsonFromFile = File.ReadAllText(_save);
                return JsonSerializer.Deserialize<List<TodoList>>(jsonFromFile) ?? new List<TodoList>();
            }

            return new List<TodoList>();

        }  
    }
}
