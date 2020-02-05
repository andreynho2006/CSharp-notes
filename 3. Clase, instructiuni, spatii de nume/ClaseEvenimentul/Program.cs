using System;

namespace ClaseEvenimentul
{
    class Program
    {
        static void Main(string[] args)
        {
            Form1 form = new Form1();

        }
    }

    public delegate void EventHandler(object sender, System.EventArgs e);

    public class Button
    {
        public event EventHandler Click;
        public void Reset()
        {
            Click = null;
        }
    }

    public class Form1
    {
        public Button button1 = new Button();

        public Form1()
        {
            button1.Click += new EventHandler(Button1_Click);
        }

        void Button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Button1 was clicked!");
        }

        public void Disconect()
        {
            button1.Click -= new EventHandler(Button1_Click);
        }
    }
}
