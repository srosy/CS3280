using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = "E:/School/Fall 2020/CS3280/CS3280/Learning Activities/FileOperation/FileTest/";

            #region FileStream
            // filestream read, reads bytes of data
            var byteList = new List<byte>();
            try
            {
                using (var fileStreamReader = new FileStream(path + "FileStreamBLAH.txt", FileMode.Open))
                {
                    int _byte;

                    while ((_byte = fileStreamReader.ReadByte()) > 0)
                    {
                        byteList.Add((byte)_byte);
                    }
                }

                // filestream write, writes bytes of data
                using (var fileStreamWriter = new FileStream(path + "FileStream1.txt", FileMode.Open))
                {
                    fileStreamWriter.Write(byteList.ToArray(), 0, byteList.Count - 1);
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.FileName);
            }
            catch (System.Security.SecurityException ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.PermissionState);
                Console.WriteLine(ex.PermissionType);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.ParamName);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // using blocks close objects automatically even on thrown exceptions
            }
            #endregion

            #region StreamReader/StreamWriter
            // stream read, reads characters stored as int
            var streamList = new List<int>();
            int _char;
            using (var streamReader = new StreamReader(path + "StreamReaderWriter.txt"))
            {
                while ((_char = streamReader.Read()) > 0)
                {
                    streamList.Add(_char);
                }
            }

            // stream write, writes characters
            using (var streamWriter = new StreamWriter(path + "StreamReaderWriter1.txt"))
            {
                streamWriter.Write(streamList.Select(x => (char)x).ToArray()); // takes whole char array
                //also able to write char by char in foreach
            }
            #endregion

            #region StreamReader/StreamWriter + Text
            // stream read, reads lines stored as string
            var lines = new List<string>();
            string nextLine;
            using (var textReader = new StreamReader(path + "TextReaderWriter.txt"))
            {
                while (!string.IsNullOrEmpty(nextLine = textReader.ReadLine()))
                {
                    lines.Add(nextLine);
                }
            }

            // stream write, writes lines 
            using (var textWriter = new StreamWriter(path + "TextReaderWriter1.txt"))
            {
                lines.ForEach(x => textWriter.WriteLine(x));
            }
            #endregion
        }
    }
}
