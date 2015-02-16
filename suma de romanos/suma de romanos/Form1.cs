using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace suma_de_romanos
{
    public partial class Form1 : Form
    {
        int arabicValue1 = 0, arabicValue2 = 0, arabicSum = 0;
        String romanAnswerValue;

        public Form1()
        {
            InitializeComponent();
        }

        private bool isNumber(String inputText)
        {
            try
            {
                decimal newDecimal = Convert.ToDecimal(inputText);
                return true;
            }
            catch 
            {
                return false;
            }
        }

        private bool isInteger(int inputValue, string inputText)
        {
            try
            {
                inputValue = Convert.ToInt16(inputText);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if ((isNumber(arabicNumber2.Text)) && (isNumber(arabicNumber2.Text)))
            {
                if (!(isInteger(arabicValue1, arabicNumber1.Text)) || !(isInteger(arabicValue2, arabicNumber2.Text)))
                    showMessageAndRestart("No ingrese números con decimales");
                else {
                    arabicValue1 = Convert.ToInt16(arabicNumber1.Text);
                    arabicValue2 = Convert.ToInt16(arabicNumber2.Text);
                    arabicSum = arabicValue1 + arabicValue2;
                    if (arabicSum > 0 && arabicSum < 4000)
                    {
                        romanAnswerValue = convertToRomanNumber(arabicSum);
                        romanAnswer.Text = romanAnswerValue;
                        arabicAnswer.Text = Convert.ToString(arabicSum);
                    }
                    else
                        showMessageAndRestart("La respuesta debe estar entre 1 y 3999");                
                }
            }
            else
                showMessageAndRestart("Solo se pueden ingresar números");
        }

        public void showMessageAndRestart(String message)
        {
            MessageBox.Show(message, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            resetElements();
        }
        
        public void resetElements()
        {
            arabicNumber1.Text = "";
            arabicNumber2.Text = "";
            romanAnswer.Text = "(Respuesta en romanos)";
            arabicAnswer.Text = "(Respuesta en arábigos)";      
        }

        public String convertToRomanNumber(int arabicNumber)
        {
            String[] unitArray = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
            String[] tenArray = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            String[] hundredArray = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            String[] thousandUnitArray = { "", "M", "MM", "MMM"};
            int thousandUnit = arabicNumber / 1000;
            int hundred = (arabicNumber % 1000) / 100;
            int ten = ((arabicNumber % 1000) % 100) / 10;
            int unit = (((arabicNumber % 1000) % 100) % 10);
            if (arabicNumber >= 1000)
                return thousandUnitArray[thousandUnit] + hundredArray[hundred] + tenArray[ten] + unitArray[unit];
            else if (arabicNumber >= 100)
                return hundredArray[hundred] + tenArray[ten] + unitArray[unit];
            else if (arabicNumber >= 10)
                return tenArray[ten] + unitArray[unit];
            else
                return unitArray[unit];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            resetElements();
        }

        private void arabicNumber1_TextChanged(object sender, EventArgs e) { }

        private void arabicNumber2_TextChanged(object sender, EventArgs e) { }

        private void arabicAnswer_Click(object sender, EventArgs e) { }
    }
}