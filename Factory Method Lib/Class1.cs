using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace Factory_Method_Lib
{
    namespace FactoryMethodLib
    {
        public interface ITestButton
        {
            Control CreateButton();
        }

        public class StandardButtonFactory : ITestButton
        {
            public Control CreateButton()
            {
                Button button = new Button();
                button.Text = "Standard Button";
                button.Size = new System.Drawing.Size(150, 50);
                return button;
            }
        }

        // Конкретна фабрика для RadioButton
        public class RadioButtonFactory : ITestButton
        {
            public Control CreateButton()
            {
                RadioButton radioButton = new RadioButton();
                radioButton.Text = "Radio Button";
                radioButton.Size = new System.Drawing.Size(150, 50);
                return radioButton;
            }
        }

        public class CheckBoxButtonFactory : ITestButton
        {
            public Control CreateButton()
            {
                CheckBox checkBox = new CheckBox();
                checkBox.Text = "Check Box";
                checkBox.Size = new System.Drawing.Size(150, 50);
                return checkBox;
            }
        }
    }

}
