using System;
using System.Drawing;
using System.Windows.Forms;
using Factory_Method_Lib.FactoryMethodLib;

namespace Factory_method
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ITestButton standardButtonFactory = new StandardButtonFactory();
            AddButton(standardButtonFactory, new Point(50, 50));

            ITestButton radioButtonFactory = new RadioButtonFactory();
            AddButton(radioButtonFactory, new Point(50, 120));

            ITestButton checkBoxFactory = new CheckBoxButtonFactory();
            AddButton(checkBoxFactory, new Point(50, 190));
        }

        private void AddButton(ITestButton buttonFactory, Point location)
        {
            Control control = buttonFactory.CreateButton();
            control.Location = location;
            this.Controls.Add(control);
        }
    }
}


