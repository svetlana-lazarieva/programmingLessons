using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;


namespace Project2
{
    public partial class ConfigForm : Form
    {
        SingleUserConfig config;
        UserForm userForm;

        public ConfigForm(UserForm userForm)
        {
            this.userForm = userForm;
            config = userForm.singleUserConfig;
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveConfig();
        }
        /// <summary>
        /// Сохранить настройки
        /// </summary>
        private void SaveConfig()
        {
            var dir = Path.GetDirectoryName(UserForm.ConfigFilePath);
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            int currentUserId = AppState.CurrentUser.Id;
            Config.UserSettings[currentUserId] = config;
            string json = JsonConvert.SerializeObject(Config.UserSettings);
            File.WriteAllText(UserForm.ConfigFilePath, json);
        }

        private void buttonBackColor_Click(object sender, EventArgs e)
        {
            BackColorSettings();
        }
        /// <summary>
        /// Настройки цвета фона
        /// </summary>
        private void BackColorSettings()
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                buttonBackColor.BackColor = colorDialog1.Color;
                userForm.BackColor = buttonBackColor.BackColor;

                config.BackColor.Name = userForm.BackColor.Name;
                config.BackColor.R = userForm.BackColor.R;
                config.BackColor.G = userForm.BackColor.G;
                config.BackColor.B = userForm.BackColor.B;
            }
        }

        private void buttonFontColor_Click(object sender, EventArgs e)
        {
            FontColorSettings();
        }

        /// <summary>
        /// Настройка цвет текста
        /// </summary>
        private void FontColorSettings()
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                buttonFontColor.BackColor = colorDialog1.Color;
                userForm.ForeColor = buttonFontColor.BackColor;

                config.FontColor.Name = userForm.ForeColor.Name;
                config.FontColor.R = userForm.ForeColor.R;
                config.FontColor.G = userForm.ForeColor.G;
                config.FontColor.B = userForm.ForeColor.B;
            }
        }

        

        private void textBoxFont_Click(object sender, EventArgs e)
        {
            FontSettings();
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
                userForm.Font = font1;
                string fontSise = Math.Round(fontDialog1.Font.Size).ToString();
                string fontStyle = fontDialog1.Font.Style.ToString();
                string font = fontDialog1.Font.Name.ToString();
                textBoxFont.Text = $"{font}, {fontStyle}, {fontSise}";

                config.MyFont.Name = font1.Name;
                config.MyFont.EmSize = font1.Size;
                config.MyFont.Style = font1.Style;
            }
        }

        /// <summary>
        ///  Обновляет компоненты на форме
        /// </summary>
        private void UpdateComponents(SingleUserConfig config)
        {
            // Цвет фона
            buttonBackColor.BackColor = Color.FromArgb(config.BackColor.R,
                                                       config.BackColor.G,
                                                       config.BackColor.B);
            // Цвет текста
            buttonFontColor.BackColor = Color.FromArgb(config.FontColor.R,
                                                       config.FontColor.G,
                                                       config.FontColor.B);
            // Шрифт
           // var FontFamily = new FontFamily(config.MyFont.Name);
            textBoxFont.Text = $"{config.MyFont.Name}, " +
                               $"{config.MyFont.Style}, " +
                               $"{config.MyFont.EmSize}";
        }
    }
}
