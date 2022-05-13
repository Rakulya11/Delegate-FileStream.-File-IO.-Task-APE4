using System;
using System.IO;
using System.Text;

namespace PracticeFileStream
{
    internal class Program
    {
        #region FileWriteMethod
        public static void FileWrite()
        {
            string fileRoad = @"C:\Users\Hideo Kojima\source\repos\FileStream\textWrite.txt";
            FileStream fs = new FileStream(fileRoad, FileMode.Append, FileAccess.Write);

            StreamWriter streamWriter = new StreamWriter(fs);
            streamWriter.WriteLine("First: Hello");
            streamWriter.WriteLine("Second: World");

            streamWriter.Flush();
            streamWriter.Close();
            fs.Close();
        }
        #endregion

        #region FileReadMethod
        public static void FileRead()
        {
            string fileRoad = @"C:\Users\Hideo Kojima\source\repos\FileStream\textWrite.txt";
            FileStream fs = new FileStream(fileRoad, FileMode.Open, FileAccess.Read);

            StreamReader streamReader = new StreamReader(fs);

            string text = streamReader.ReadLine();
            while (text != null)
            {
                Console.WriteLine(text);
                text = streamReader.ReadLine();
            }
        }
        #endregion
        static void Main(string[] args)
        {
            FileWrite();
            FileRead();

            #region FileStreams
            //FileStream stream = new FileStream("MyFile.txt", FileMode.Create, FileAccess.Write);
            //StreamWriter streamWriter = new StreamWriter(stream);

            //streamWriter.WriteLine("This is a text");
            //streamWriter.WriteLine("This is a other text");
            //streamWriter.Close();
            //stream.Close();

            //-----------------------

            ////FileStream fs = new FileStream("MyNewFile.txt", FileMode.CreateNew, FileAccess.Write, FileShare.None);
            //FileStream fs = new FileStream("MyNewFile.txt", FileMode.Create, FileAccess.Write, FileShare.None);

            //byte[] textData = Encoding.UTF8.GetBytes("Some texts to byte.");

            ////fs.Write(textData, 0, textData.Length);
            //fs.Write(textData, 0, 4);

            //fs.Close();

            //-----------------------

            //using (FileStream fs = new FileStream("MyFsFile.txt", FileMode.Create, FileAccess.Write))
            //using (StreamWriter streamWriter = new StreamWriter(fs))
            //{
            //    streamWriter.WriteLine("Salam ALeykum");
            //    streamWriter.WriteLine("ALeykum Salam");
            //}

            //-----------------------

            //using (FileStream fs = File.Create("MyNewFsFile.txt"))
            //using (StreamWriter streamWriter = new StreamWriter(fs, Encoding.UTF8))
            //{
            //    streamWriter.WriteLine("Salam Aleykum");

            //}
            //Console.ReadKey();

            //-----------------------

            //using (FileStream fs = File.Create("MyFsFileWithByte.txt"))
            //{
            //    byte [] data = Encoding.UTF8.GetBytes("Hello World!");
            //    fs.Write(data, 0, data.Length);
            //    //for (int i = 0; i < data.Length; i++)
            //    //{
            //    //    fs.WriteByte(data[i]);
            //    //}
            //}


            //FileStream with StreamReader:

            //FileStream stream = new FileStream("MyNewFsFile.txt", FileMode.Open, FileAccess.Read);
            //StreamReader reader = new StreamReader(stream, Encoding.UTF8);

            //string line;

            ////while ((line = reader.ReadLine()) != null) 
            //while (reader.Peek() > 0)
            //{
            //    line = reader.ReadLine();
            //    Console.WriteLine(line);
            //}
            #endregion
        }
    }
}
