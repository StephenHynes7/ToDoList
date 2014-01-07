using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
namespace ToDoList
{
    public partial class Form1 : Form
    {
        private List<String> toDoTasks = new List<string>();
        private List<String> finishedTasks = new List<string>();
        public Form1()
        {
            InitializeComponent();
            loadFromFile();
            ToDoTasks.DataSource = toDoTasks;
            FinishedTasks.DataSource = finishedTasks;
        }

        private void loadFromFile()
        {
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) +  @"\ToDoTasks.txt";
            try
            {
                if (File.Exists(filePath))
                {
                    String json;
                    using (StreamReader sr = new StreamReader(filePath))
                    {
                        json = sr.ReadToEnd();
                    }
                    FormData loadedData = JsonConvert.DeserializeObject<FormData>(json);
                    toDoTasks = loadedData.toDoTasks;
                    finishedTasks = loadedData.finishedTasks;
                }
               
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void AddTask_Click(object sender, EventArgs e)
        {
            if(Input.Text.Length > 0){
                String task = DateTime.Now + " " + Input.Text;
                toDoTasks.Add(task);
                ToDoTasks.DataSource = null;
                ToDoTasks.DataSource = toDoTasks;
            }
            
        }

        private void FinishedBtn_Click(object sender, EventArgs e)
        {
            if (ToDoTasks.SelectedIndex >= 0)
            {          
                finishedTasks.Add(toDoTasks[ToDoTasks.SelectedIndex]);
                toDoTasks.RemoveAt(ToDoTasks.SelectedIndex);
                ToDoTasks.DataSource = null;
                ToDoTasks.DataSource = toDoTasks;
                FinishedTasks.DataSource = null;
                FinishedTasks.DataSource = finishedTasks;
            }
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            if (ToDoTasks.SelectedIndex >= 0)
            {
                toDoTasks.RemoveAt(ToDoTasks.SelectedIndex);
                ToDoTasks.DataSource = null;
                ToDoTasks.DataSource = toDoTasks;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormData formData = new FormData(toDoTasks, finishedTasks);
            String jsonData = JsonConvert.SerializeObject(formData);
            saveToFile(jsonData);
        }

        private void saveToFile(String jsonData)
        {
            string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            StringBuilder sb = new StringBuilder();


            using (StreamWriter outfile = new StreamWriter(mydocpath + @"\ToDoTasks.txt"))
            {
                outfile.Write(jsonData);
            }
        }
    }

    public class FormData
    {

        [JsonProperty(Order = 0)]
        public List<String> finishedTasks { get; set; }
        [JsonProperty(Order = 1)]
        public List<String> toDoTasks { get; set; }

        public FormData(List<String> toDoTasks, List<String> finishedTasks)
        {
            this.toDoTasks = toDoTasks; 
            this.finishedTasks = finishedTasks;
        }
    }
}
