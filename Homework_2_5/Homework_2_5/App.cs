using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Homework_2_5
{
    internal class App
    {
        public App() 
        {        
        }

        public void Run()
        {
            Actions actions = new Actions();
            Random rand = new Random(); 
            for (int i = 0; i < 100; i++) 
            {
                try
                {
                    switch (rand.Next(1, 4))
                    {
                        case 1:
                            actions.FirstMethod();
                            break;
                        case 2:
                            actions.SecondMethod();
                            break;
                        case 3:
                            actions.ThirdMethod();
                            break;
                    }
                }
                catch(BusinessException be)
                {
                    Logger.Instance.LogInfo(LogTypes.Warning, "Action got this custom Exception: " + be.Message);
                }
                catch (Exception e)
                {
                    Logger.Instance.LogInfo(LogTypes.Error, "Action failed by reason: " + e.Message);
                }                
            }

            string dirPath = Path.Combine(@"D:\my projects\A level\Module2_HW5\Homework_2_5", "Json Files");
            FileService fileService = new FileService();
            fileService.CreateDirectory(dirPath);
            DateTime now = DateTime.Now;
            fileService.SaveToJson(Logger.Instance, $"{now.ToString("MM-dd-yyyy-hh-mm-ss")}.json", dirPath);            
        }
    }
}
