#define CONFIG
using Microsoft.Win32;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Task_4
{
    public partial class Form1 : Form
    {
        Config config = new Config();
        //MyFont myFont = new MyFont();
        XmlSerializer formatter;

        public Form1()
        {
            InitializeComponent();
            formatter = new XmlSerializer(typeof(Config));
        }

        private void buttonBackColor_Click(object sender, EventArgs e)
        {
            BackColorSettings();
        }
       
        private void buttonFontColor_Click(object sender, EventArgs e)
        {
            FontColorSettings();
        }

        private void textBoxFont_Click(object sender, EventArgs e)
        {
            FontSettings();
        }

        /// <summary>
        /// Настройки цвета фона
        /// </summary>
        private void BackColorSettings()
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                buttonBackColor.BackColor = colorDialog1.Color;
                textBox1.BackColor = buttonBackColor.BackColor;

                config.BackColor.Name = textBox1.BackColor.Name;
                config.BackColor.R = textBox1.BackColor.R;
                config.BackColor.G = textBox1.BackColor.G;
                config.BackColor.B = textBox1.BackColor.B;
            }            
        }

        /// <summary>
        /// Настройка цвет текста
        /// </summary>
        private void FontColorSettings()
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                buttonFontColor.BackColor = colorDialog1.Color;
                textBox1.ForeColor = buttonFontColor.BackColor;

                config.FontColor.Name = textBox1.ForeColor.Name;
                config.FontColor.R = textBox1.ForeColor.R;
                config.FontColor.G = textBox1.ForeColor.G;
                config.FontColor.B = textBox1.ForeColor.B;
            }
        }

        /// <summary>
        /// Настройки шрифта
        /// </summary>
        private void FontSettings()
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                // Шрифт
                Font font1 = new Font(fontDialog1.Font.FontFamily, fontDialog1.Font.Size, fontDialog1.Font.Style);
                textBox1.Font = font1;
                string fontSise = Math.Round(fontDialog1.Font.Size).ToString();
                string fontStyle = fontDialog1.Font.Style.ToString();
                string font = fontDialog1.Font.Name.ToString();
                textBoxFont.Text = $"{font}, {fontStyle}, {fontSise}";

                config.MyFont.Name = font1.Name;
                config.MyFont.EmSize = font1.Size;
                config.MyFont.Style = font1.Style;
            } 
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
#if CONFIG
            SaveConfig();
#else
            SaveToRegistry();
#endif
        }

        /// <summary>
        /// Сохранить настройки
        /// </summary>
        private void SaveConfig()
        {            
            using (FileStream fs = new FileStream("Config.config", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, config);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
#if CONFIG
            LoadConfig();
#else
            LoadFromRegistry();
#endif
        }

        /// <summary>
        /// Загрузить настройки
        /// </summary>
        private void LoadConfig()
        {
            string filename = "Config.config";
            if (File.Exists(filename))
            {
                using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
                {
                    Config newConfig = (Config)formatter.Deserialize(fs);
                    UpdateComponents(newConfig);
                }
            }
        }

        /// <summary>
        /// Запись настроек в регистр
        /// </summary>
        private void SaveToRegistry()
        {
            RegistryKey key = Registry.CurrentUser;
            RegistryKey subKey = key.OpenSubKey("Software", true);
            RegistryKey subSubKey = subKey.CreateSubKey(@"MyConfig");

            // Цвет фона
            RegistryKey backColor = subSubKey.CreateSubKey(@"BackColor");
            backColor.SetValue("BackColor R", config.BackColor.R);
            backColor.SetValue("BackColor G", config.BackColor.G);
            backColor.SetValue("BackColor B", config.BackColor.B);

            // Цвет текста
            RegistryKey fontColor = subSubKey.CreateSubKey(@"FontColor");
            fontColor.SetValue("FontColor R", config.FontColor.R);
            fontColor.SetValue("FontColor G", config.FontColor.G);
            fontColor.SetValue("FontColor B", config.FontColor.B);

            // Шрифт
            RegistryKey font = subSubKey.CreateSubKey(@"Font");
            font.SetValue("FontName", config.MyFont.Name);
            font.SetValue("FontStyle", (int)config.MyFont.Style);
            font.SetValue("FontSize", config.MyFont.EmSize);

            subKey.Close();
            subSubKey.Close();
            backColor.Close();
            fontColor.Close();
            font.Close();
        }

        /// <summary>
        /// Загрузка настроек из регистра
        /// </summary>
        private void LoadFromRegistry()
        {
            RegistryKey key = Registry.CurrentUser;
            RegistryKey subKey = key.OpenSubKey(@"Software\MyConfig");

            try
            {
                // Цвет фона
                var regBackColor = subKey.OpenSubKey(@"BackColor");
                var colorR = regBackColor.GetValue("BackColor R");
                config.BackColor.R = byte.Parse((string)regBackColor.GetValue("BackColor R"));
                config.BackColor.G = byte.Parse((string)regBackColor.GetValue("BackColor G"));
                config.BackColor.B = byte.Parse((string)regBackColor.GetValue("BackColor B"));
                // Цвет текста
                var regFontColor = subKey.OpenSubKey(@"FontColor");
                config.FontColor.R = byte.Parse((string)regFontColor.GetValue(@"FontColor R"));
                config.FontColor.G = byte.Parse((string)regFontColor.GetValue(@"FontColor G"));
                config.FontColor.B = byte.Parse((string)regFontColor.GetValue(@"FontColor B"));
                // Шрифт
                config.MyFont.Name = subKey.OpenSubKey(@"Font").GetValue("FontName") as string;
                config.MyFont.Style = (FontStyle)subKey.OpenSubKey(@"Font").GetValue("FontStyle");
                config.MyFont.EmSize = float.Parse((string)subKey.OpenSubKey(@"Font").GetValue("FontSize"));

                UpdateComponents(config);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        /// <summary>
        ///  Обновляет компоненты на форме
        /// </summary>
        private void UpdateComponents(Config config)
        {
            // Цвет фона
            textBox1.BackColor = Color.FromArgb(config.BackColor.R,
                                                config.BackColor.G,
                                                config.BackColor.B);
            buttonBackColor.BackColor = textBox1.BackColor;
            // Цвет текста
            textBox1.ForeColor = Color.FromArgb(config.FontColor.R,
                                                config.FontColor.G,
                                                config.FontColor.B);
            buttonFontColor.BackColor = textBox1.ForeColor;
            // Шрифт
            var FontFamily = new FontFamily(config.MyFont.Name);
            textBox1.Font = new Font(FontFamily,
                                     config.MyFont.EmSize,
                                     config.MyFont.Style);
            textBoxFont.Text = $"{config.MyFont.Name}, " +
                               $"{config.MyFont.Style}, " +
                               $"{config.MyFont.EmSize}";
        }

    }
}
