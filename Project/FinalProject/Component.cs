
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FinalProject
{
    public class Component
    {
        const int OffsetY = 18;
        readonly Size LabelSize = new Size(38, 15);
        readonly Size RichTextBoxSize = new Size(147, 100);

        // Событие
        public event Action<Component> ComponentClicked;


        private Point _position;
        public Label Label { get; set; }
        public RichTextBox RichTextBox { get; set; }
        public Form Form { get; set; }
        public ComponentDataPerDay DataPerDay { get; set; }
      
        public Component(Form form)
        {
            Form = form;

            Label = new Label();
            Label.Size = LabelSize;
            Form.Controls.Add(Label);
            Label.AutoSize = true;
            Label.TextChanged += OnLabelChanged;

            RichTextBox = new RichTextBox();
            RichTextBox.ReadOnly = true;
            RichTextBox.Size = RichTextBoxSize;
            RichTextBox.Click += OnRichTextBoxClick;
            RichTextBox.TextChanged += OnRichTextBoxTextChanged;
            Form.Controls.Add(RichTextBox);

            DataPerDay = new ComponentDataPerDay();
        }

        private void OnLabelChanged(object sender, EventArgs e)
        {
            if (sender is Label)
            {
                Label label = sender as Label;
                DataPerDay.LabelData = label.Text;
            }
        }

        private void OnRichTextBoxTextChanged(object sender, EventArgs e)
        {
            if (sender is RichTextBox)
            {
                RichTextBox richTextBox = sender as RichTextBox;
                DataPerDay.RichTextBoxData = richTextBox.Text;
            }
        }

        private void OnRichTextBoxClick(object sender, EventArgs e)
        {
            // Вызиваем событие
            if (ComponentClicked != null)
            {
                ComponentClicked.Invoke(this);
            }
            
        }

        public Point Position 
        {
            get => _position;
            set
            {
                _position = value;
                Label.Location = value; 
                RichTextBox.Location = new Point(_position.X, _position.Y + OffsetY);
            }
        }

        public void SetComponentData(ComponentDataPerDay data)
        {
            DataPerDay = data;
            Label.Text = data.LabelData;
            RichTextBox.Text = data.RichTextBoxData;
        }

    }
}
