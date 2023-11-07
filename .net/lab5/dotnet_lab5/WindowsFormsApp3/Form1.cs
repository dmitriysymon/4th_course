using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Reflection;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void SerializeXML(Rhombus rh)
        {
            XmlSerializer xml = new XmlSerializer(typeof(Rhombus));
            using (FileStream fs = new FileStream("Rhombus.xml", FileMode.OpenOrCreate))
            {
                xml.Serialize(fs, rh);
            }
        }
        private void SerializeBinary(Rhombus rh)
        {
            BinaryFormatter bn = new BinaryFormatter();
            using (FileStream fs = new FileStream("Rhombus1.dat", FileMode.OpenOrCreate))
            {
                bn.Serialize(fs, rh);
            }
        }

        private void serialize_Click(object sender, EventArgs e)
        {
            Rhombus rh = new Rhombus(int.Parse(r_textBox.Text), int.Parse(b_textBox.Text));
            SerializeXML(rh);
            SerializeBinary(rh);
        }
        private Rhombus DeserializeXML()
        {
            XmlSerializer xml = new XmlSerializer(typeof(Rhombus));
            using (FileStream fs = new FileStream("Rhombus.xml", FileMode.OpenOrCreate))
            {
                return (Rhombus)xml.Deserialize(fs);
            }
        }
        private Rhombus DeserializeBinary()
        {
            BinaryFormatter bn = new BinaryFormatter();
            using (FileStream fs = new FileStream("Rhombus1.dat", FileMode.OpenOrCreate))
            {
                return (Rhombus)bn.Deserialize(fs);
            }
        }

        private void deserealize_button_Click(object sender, EventArgs e)
        {
            Rhombus rh = DeserializeXML();
            rh = DeserializeBinary();
            r_textBox.Text = rh.a.ToString();
            b_textBox.Text = rh.b.ToString();
        }
        private void reflec_button_Click(object sender, EventArgs e)
        {
            Type t = typeof(Rhombus);
            MethodInfo[] x = t.GetMethods();
            foreach (MethodInfo m in x)
            {
                reflec_textbox.Text += m.ToString() + Environment.NewLine;

            }
            MemberInfo[] x2 = t.GetMembers();
            foreach (MemberInfo m in x2)
            {
                reflec_textbox.Text += m.ToString() + Environment.NewLine;
            }
        }

        private void draw_btn_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.Clear(this.BackColor);

            int centerX = 550;
            int centerY = this.ClientSize.Height / 2;

            Point[] RhombusPoints = new Point[]
            {
            new Point(centerX, centerY - 75),
            new Point(centerX + 50, centerY),
            new Point(centerX, centerY + 75),
            new Point(centerX - 50, centerY)
            };

            g.FillPolygon(Brushes.Gray, RhombusPoints);
            g.DrawPolygon(Pens.Black, RhombusPoints);
        }
    }
}
