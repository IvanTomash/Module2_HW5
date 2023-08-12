using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Homework_2_5
{
    internal class FileService
    {
        public FileService() 
        {
             
        }
               
        public void CreateDirectory(string dirPath)
        {
            if (!Directory.Exists(dirPath))
            {
                Directory.CreateDirectory(dirPath);
            }           
        }

        public void DeleteOldestFileInDir(string dirPath)
        {
            string[] files = Directory.GetFiles(dirPath);
            if (files.Length > 3)
            {
                string oldestFile = files[0];
                for (int i = 1; i < files.Length; i++)
                {
                    if (File.GetCreationTime(Path.Combine(dirPath, oldestFile)) > File.GetCreationTime(Path.Combine(dirPath, files[i])))
                    {
                        oldestFile = files[i];
                    }
                }
                File.Delete(Path.Combine(dirPath, oldestFile));
            }
        }
       
        public void SaveToJson(object info, string name, string path)
        {
           string jsonPath = Path.Combine(path, $"{name}.json");
           string jsonInfo = JsonSerializer.Serialize(info);
           using (var writer = new StreamWriter(jsonPath))
           {
               writer.Write(jsonInfo);
           }     
           DeleteOldestFileInDir(path);
        }
    }
}
