﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public static class Serialize
    {
        /// <summary>
        /// путь сохранения данных
        /// </summary>
        private static string _path = @"..\..\Data\";

        /// <summary>
        /// Проверяет, существует ли файл.
        /// </summary>
        /// <param name="nameFile"></param>
        /// <returns></returns>
        public static bool IsFile(string nameFile)
        {
            return File.Exists(_path + nameFile);
        }

        /// <summary>
        /// Сохраняет объекты из списка в формате JSON.
        /// </summary>
        /// <typeparam name="T">Тип объекта.</typeparam>
        /// <param name="nameFile">Имя файла для сохранения.</param>
        /// <param name="listObjects">Список объектов.</param>
        public static void SaveToFile(string nameFile, object obj)
        {
            using (StreamWriter writer = new StreamWriter(_path + nameFile))
            {
                writer.Write(JsonConvert.SerializeObject(obj));
            }
        }

        /// <summary>
        /// Загружает объекты в формате JSON и десериализует их в список.
        /// </summary>
        /// <typeparam name="T">Тип объекта.</typeparam>
        /// <param name="nameFile">Имя файла для загрузки объектов.</param>
        /// <returns></returns>
        public static List<User> LoadFromFile(string nameFile)
        {
            List<User> store;

            using (StreamReader reader = new StreamReader(_path + nameFile))
            {
                store = JsonConvert.DeserializeObject<List<User>>(reader.ReadToEnd());
            }

            return store;
        }
    }
}
