﻿using BusinessLayer.Models;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;

namespace BusinessLayer
{
    public static class Utility
    {

        /// <summary>
        /// Generic method that serializes an object.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <param name="filename"></param>
        public static void Serialize<T>(T obj, string filePath)
        {
            using (var ms = File.OpenWrite(filePath))
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(ms, obj);
                ms.Flush();
            }
        }

        /// <summary>
        /// Deserializes a generic object
        /// </summary>
        /// <param name="filename"></param>
        public static T Deserialize<T>(string filename)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream fs = File.Open(filename, FileMode.Open);

            var obj = formatter.Deserialize(fs);
            fs.Flush();
            fs.Close();
            fs.Dispose();
            return (T)obj;
        }

        public static int SaveLibraryItem(LibraryItem li, [Optional] int cloneCount)
        {
            if (li == null) return 0;

            var numRowsUpdated = 0;
            if (cloneCount > 1)
            {
                for (int i = 0; i < cloneCount; i++)
                {
                    numRowsUpdated += SaveLibraryItem(li);
                }
            }
            else
            {
                numRowsUpdated += SaveLibraryItem(li);
            }

            return numRowsUpdated; // success > 0
        }

        private static int SaveLibraryItem(LibraryItem libraryItem)
        {
            DataLayer.Utility.LibraryItemAdapter.Fill(DataLayer.Utility.LibraryItems);
            var li = DataLayer.Utility.LibraryItems.NewLibraryItemsRow();
            li.Type = libraryItem.Type;
            li.Title = libraryItem.Title;
            li.Genre = libraryItem.Genre;
            li.Location = libraryItem.Location;
            li.ISBN = libraryItem.ISBN;
            li.Edition = libraryItem.Edition;
            li.WebUrl = libraryItem.WebUrl;
            li.NumArticles = libraryItem.NumArticles;
            li.Advertisers = libraryItem.Advertisers;
            li.Publisher = libraryItem.Publisher;
            li.Author = libraryItem.Author;
            li.VolumeNum = libraryItem.VolumeNum;
            li.ISSN = libraryItem.ISSN;

            return DataLayer.Utility.SaveLibraryItem(li) ? 1 : 0;
        }
    }
}
