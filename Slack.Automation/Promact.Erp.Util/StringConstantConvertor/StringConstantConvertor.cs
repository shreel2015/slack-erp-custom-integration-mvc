using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Promact.Erp.DomainModel.ApplicationClass;
using Promact.Erp.DomainModel.DataRepository;
using Promact.Erp.Util.StringConstants;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promact.Erp.Util.StringConstantConvertor
{
    public class StringConstantConvertor : IStringConstantConvertor
    {
        #region Private Variables
        private readonly string stringConstantJsonFilePath;
        private readonly string stringConstantCSFilePath;
        private readonly IStringConstantRepository _stringConsant;
        #endregion

        #region Constructor
        public StringConstantConvertor(IStringConstantRepository stringConstant)
        {
            stringConstantJsonFilePath = "F:\\Siddhartha\\slack-automation\\slack-erp-custom-integration-mvc\\Slack.Automation\\Promact.Erp.Util\\StringConstants\\StringConstants.json";
            stringConstantCSFilePath = "F:\\Siddhartha\\slack-automation\\slack-erp-custom-integration-mvc\\Slack.Automation\\Promact.Erp.Util\\StringConstants\\StringConstantRepository.cs";
            _stringConsant = stringConstant;
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// Method to start file watcher
        /// </summary>
        /// <param name="path">Path of the directory</param>
        public void CreateFileWatcher(string path)
        {
            // Create a new FileSystemWatcher and set its properties.
            FileSystemWatcher watcher = new FileSystemWatcher();
            watcher.Path = path;
            // Watch for changes in LastAccess and LastWrite times, and the renaming of files or directories.
            watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite | NotifyFilters.FileName | NotifyFilters.DirectoryName;
            // Only watch text files.
            watcher.Filter = "StringConstants.json";
            // Add event handlers.
            watcher.Changed += new FileSystemEventHandler(Convertor);
            // Begin watching.
            watcher.EnableRaisingEvents = true;
        }

        /// <summary>
        /// Method to create .json file of StringConstantRepository.cs
        /// </summary>
        public void OnInit()
        {
            StringConstantJsonAC stringConstantJson = new StringConstantJsonAC();
            stringConstantJson.User = new Dictionary<string, string>();
            stringConstantJson.Leave = new Dictionary<string, string>();
            stringConstantJson.TaskMail = new Dictionary<string, string>();
            stringConstantJson.Scrum = new Dictionary<string, string>();
            stringConstantJson.CommonString = new Dictionary<string, string>();
            var stringConstant = new StringConstantRepository();
            foreach (var item in stringConstant.GetType().GetProperties())
            {
                var variableName = item.Name;
                var userFlag = variableName.Contains("User");
                var scrumFlag = variableName.Contains("Scrum");
                var taskFlag = variableName.Contains("Task");
                var leaveFlag = variableName.Contains("Leave");
                if (userFlag)
                {
                    stringConstantJson.User.Add(item.Name, item.GetValue(stringConstant).ToString());
                }
                else if (leaveFlag)
                {
                    stringConstantJson.Leave.Add(item.Name, item.GetValue(stringConstant).ToString());
                }
                else if (taskFlag)
                {
                    stringConstantJson.TaskMail.Add(item.Name, item.GetValue(stringConstant).ToString());
                }
                else if (scrumFlag)
                {
                    stringConstantJson.Scrum.Add(item.Name, item.GetValue(stringConstant).ToString());
                }
                else
                    stringConstantJson.CommonString.Add(item.Name, item.GetValue(stringConstant).ToString());
            }
            var json = JsonConvert.SerializeObject(stringConstantJson);
            File.WriteAllText(stringConstantJsonFilePath, json);
        }
        #endregion

        #region Private Method
        /// <summary>
        /// Method used to update data of StringConstantRepository.cs
        /// </summary>
        /// <param name="source">object</param>
        /// <param name="e">FileSystemEventArgs</param>
        private void Convertor(object source, FileSystemEventArgs e)
        {
            try
            {
                //string json = File.ReadAllText(stringConstantJsonFilePath);
                //dynamic jsonObj = JsonConvert.DeserializeObject(json);
                //jsonObj["Bots"][0]["Password"] = "new password";
                //string output = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Formatting.Indented);
                //File.WriteAllText(stringConstantJsonFilePath, output);
                var value = _stringConsant.EmailSubject;
                var newValues = ListofStringConstant(stringConstantJsonFilePath);
                var oldStringConstant = new StringConstantRepository();
                var input = File.ReadAllText(stringConstantCSFilePath);

                //using (StreamWriter createFile = new StreamWriter(stringConstantCSFilePath))
                //{
                    foreach (var item in oldStringConstant.GetType().GetProperties())
                    {
                        var newResult = newValues.FirstOrDefault(x => x.Key == item.Name).Value;
                        var oldResult = item.GetValue(oldStringConstant).ToString();
                        var result = item.CanWrite;
                        if (result)
                        {
                            item.SetValue(oldStringConstant, newResult);
                        }
                    }
                //    createFile.Write(oldStringConstant.EmailSubject);
                //    //var objectType = oldStringConstant.GetType().
                //    //createFile.Write();
                //    createFile.WriteLine();
                //    createFile.Close();
                //}
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Method used to read the data from .json file and return a list of variables with key
        /// </summary>
        /// <param name="path">Path of the file to be read</param>
        /// <returns>list of variables</returns>
        private Dictionary<string, string> ListofStringConstant(string path)
        {
            Dictionary<string, string> stringConstant = new Dictionary<string, string>();
            using (StreamReader read = File.OpenText(path))
            {
                StringConstantJsonAC jsonStringConstant = new StringConstantJsonAC();
                string json = read.ReadToEnd();
                jsonStringConstant = JsonConvert.DeserializeObject<StringConstantJsonAC>(json);
                read.Close();
                File.OpenText(path).Close();
                read.Dispose();
                stringConstant = jsonStringConstant.CommonString;
                foreach (var item in jsonStringConstant.Leave)
                {
                    stringConstant.Add(item.Key, item.Value);
                }
                foreach (var item in jsonStringConstant.TaskMail)
                {
                    stringConstant.Add(item.Key, item.Value);
                }
                foreach (var item in jsonStringConstant.Scrum)
                {
                    stringConstant.Add(item.Key, item.Value);
                }
                foreach (var item in jsonStringConstant.User)
                {
                    stringConstant.Add(item.Key, item.Value);
                }
            }
            return stringConstant;
        }
        #endregion
    }
}

