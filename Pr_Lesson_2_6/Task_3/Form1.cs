using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Используя Visual Studio, создайте проект по шаблону Windows Forms Application. 
/// Создайте программу-рефлектор, которая позволит получить информацию о сборке и 
/// входящих в ее состав типах. Для основы можно использовать программу-рефлектор из урока
/// </summary>
namespace Task_3
{
    public partial class Form1 : Form
    {
        Assembly assembly = null;

        Dictionary<TreeNode, Type> typeDictionary = new Dictionary<TreeNode, Type>();
        Dictionary<TreeNode, MethodInfo> methodInfoDictionary = new Dictionary<TreeNode, MethodInfo>();

        public Form1()
        {
            InitializeComponent();
            CreateTree("D:\\ProgrammingLessons\\Repo\\programmingLessons\\Pr_Lesson_2_6\\" +
                       "TemperstureConverterLibrary\\bin\\Debug\\netstandard2.0\\TemperstureConverterLibrary.dll");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Закрыть приложение
        /// </summary>
        private void closeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Открыть файл
        /// </summary>
        /// <param name="e">Путь к файлу</param>
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;                
                try
                {
                    assembly = Assembly.LoadFile(path);
                    textBox1.Text += $"СБОРКА {path} - УСПЕШНО ЗАГРУЖЕНА \n\n";
                }
                catch (FileNotFoundException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void CreateTree(string path)
        {
            assembly = Assembly.LoadFile(path);

            TreeNode tovarNode = new TreeNode($"Сборка: {path}");
            Type[] types = assembly.GetTypes();
            int i = 0;
            foreach (Type type in types)
            {
                TreeNode nodeType = new TreeNode(type.Name.ToString());
                tovarNode.Nodes.Add(nodeType);
                typeDictionary[nodeType] = type;

                MethodInfo[] methods = type.GetMethods();
                foreach (MethodInfo method in methods)
                {
                    TreeNode nodeMethod = new TreeNode(method.ToString());
                    tovarNode.Nodes[i].Nodes.Add(nodeMethod);
                    methodInfoDictionary[nodeMethod] = method;
             
                }
                i++;
            }
            // Раскрытие не только узла, но и всех его дочерних подузлов
            tovarNode.ExpandAll();
            treeView1.Nodes.Add(tovarNode);
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var treeNode = e.Node as TreeNode;
            textBox1.Text = string.Empty;

            if (methodInfoDictionary.ContainsKey(treeNode))
            {
                textBox1.Text = string.Empty;
                MethodInfo info = methodInfoDictionary[treeNode];
                textBox1.Text = $"Имя: {info.Name}" + Environment.NewLine +
                                $"Параметры: {info.GetParameters()}" + Environment.NewLine +
                                $"Возвращаемый тип: {info.ReturnType}";                
            }
            else if (typeDictionary.ContainsKey(treeNode))
            {                
                textBox1.Text = string.Empty;
                string s = string.Empty;
                Type type = typeDictionary[treeNode];
                s += type.AssemblyQualifiedName + Environment.NewLine;

                ConstructorInfo[] constructorsInfo = type.GetConstructors();
                foreach (var constructorInfo in constructorsInfo)
                {
                    s += $"Конструктор: {constructorsInfo}" + Environment.NewLine;
                }

                textBox1.Text = s;

            }
        }
    }
}
