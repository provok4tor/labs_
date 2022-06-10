using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using InputString;


namespace Lab4.Main
{
    public partial class Form1 : Form
    {
        Assembly Models;
        IEnumerable<Type> types;

        Type currentType;
        object currentObject;

        MethodInfo currentMethod;
        object[] methodParameters;

        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load_1(object sender, EventArgs e)
        {
            Models = Assembly.Load("Lab4.Models");
            types = Models.GetTypes()
                .Where(type => type.GetInterface("Ship") != null && !type.IsAbstract);
            selectTypeComboBox.Items.AddRange(types.Select(type => type.Name).ToArray());
        }

        void FillMethodsComboBox()
        {
            selectMethodComboBox.Items.Clear();
            IEnumerable<string> objectMethods = (new object()).GetType()
                .GetMethods().Select(method => method.Name);
            selectMethodComboBox.Items.AddRange(currentType.GetMethods()
                .Where(method => !objectMethods.Contains(method.Name) &&
                method.Name.Substring(0, 4) != "get_" &&
                method.Name.Substring(0, 4) != "set_")
                .Select(method => method.Name).ToArray());
        }

        private void selectTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentType = types.First(type => type.Name == selectTypeComboBox.SelectedItem.ToString());
            currentObject = null;
            FillMethodsComboBox();
            createObjectButton.Enabled = true;
            selectMethodComboBox.Enabled = true;
            inputParametersButton.Enabled = false;
            startMethodButton.Enabled = false;
            PropertiesListBox.Items.Clear();
        }

        private void selectMethodComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentMethod = currentType.GetMethods()
                .First(method => method.Name == selectMethodComboBox.SelectedItem.ToString());
            startMethodButton.Enabled = false;

            if (currentMethod.GetParameters().Length == 0)
            {
                inputParametersButton.Enabled = false;
                startMethodButton.Enabled = currentObject != null;
            }
            else
                inputParametersButton.Enabled = true;
            methodParameters = null;
            ParametersListBox.Items.Clear();

            foreach (var item in currentMethod.GetParameters())
            {
                ParametersListBox.Items.Add(item.Name);
            }
        }

        object InputObject(Type type)
        {
            MessageBox.Show($"input {type.Name} object");

            object newObject = Activator.CreateInstance(type);

            foreach (var item in type.GetProperties())
            {
                if (item.PropertyType == typeof(bool))
                    item.SetValue(newObject, InputBool(item.Name + "?"));
                else
                    item.SetValue(newObject, InputNumber("input " + item.Name, item.PropertyType.Name));
            }

            return newObject;
        }

        void ShowObjectProperties()
        {
            PropertiesListBox.Items.Clear();

            foreach (var item in currentType.GetProperties())
            {
                PropertiesListBox.Items.Add(item.Name + ": " + item.GetValue(currentObject));
            }
        }

        bool InputBool(string message)
        {
            return MessageBox.Show(message, "input answer", MessageBoxButtons.YesNo) == DialogResult.Yes;
        }

        private void inputParametersButton_Click(object sender, EventArgs e)
        {
            if (currentMethod.GetParameters()[0].ParameterType.Name == "Ship")
                methodParameters = new object[1] { InputObject(currentType) };
            else if (currentMethod.GetParameters().Length != 0)
                methodParameters = currentMethod.GetParameters()
                    .Select(param => (param.ParameterType == typeof(bool)
                    ? InputBool(param.Name + "?")
                    : InputNumber("input " + param.Name, param.ParameterType.Name)))
                    .ToArray();

            if (currentObject != null)
                startMethodButton.Enabled = true;
        }

        object InputNumber(string message, string numberType)
        {
            IStringValidator validator;
            if (numberType == typeof(double).Name)
                validator = new NotNegativeDoubleValidator();
            else
                validator = new NotNegativeIntValidator();
            InputStringDialog inputNumber = new InputStringDialog(validator, message);
            if (inputNumber.ShowDialog() == DialogResult.OK)
            {
                if (numberType == typeof(double).Name)
                    return Double.Parse(inputNumber.Value);
                else
                    return Int32.Parse(inputNumber.Value);
            }
            return 0;
        }

        private void startMethodButton_Click(object sender, EventArgs e)
        {
            if (currentMethod.ReturnType == typeof(void))
            {
                currentMethod.Invoke(currentObject, methodParameters);
                MessageBox.Show("Метод выполнен");
            }
            else
                MessageBox.Show(currentMethod.Invoke(currentObject, methodParameters).ToString());

            ShowObjectProperties();
        }

        private void createObjectButton_Click(object sender, EventArgs e)
        {
            currentObject = InputObject(currentType);

            if (currentMethod?.GetParameters().Length == 0)
                startMethodButton.Enabled = true;

            ShowObjectProperties();
        }

    }
}
