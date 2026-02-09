using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private double num1 = 0;
        private double num2 = 0;
        private string operation = "";
        private bool isNewEntry = true;

        public Form1()
        {
            InitializeComponent();
            txtDisplay.Text = "0";
        }
        //======NUMBERS BTNS (0-9),00=====//
        private void Number_Click(Object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (txtDisplay.Text == "0" || isNewEntry)
            {
                txtDisplay.Text = btn.Text;
                isNewEntry = false;

            }

            else
            {
                txtDisplay.Text += btn.Text;

            }

        }
        //=======DECIMAL (.) BUTTON=====//
        private void btnDot_Click(object sender, EventArgs e)
        {
            if (isNewEntry)
            {
                txtDisplay.Text = "0.";
                isNewEntry = false;
            }
            else if (!txtDisplay.Text.Contains("."))
            {
                txtDisplay.Text += ".";
            }

        }
        //=======OPERATORS BUTTIONS (+,-,*,/)=====//
        private void Operator_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            num1 = Double.Parse(txtDisplay.Text);
            operation = btn.Text;
            isNewEntry = true;
        }
        //=======PERCENTAGE (%) BUTTON=====//
        private void btnPercent_Click(object sender, EventArgs e)
        {
            double value = double.Parse(txtDisplay.Text);

            if (operation == "+" || operation == "-")
            {
                value = (num1 * value) / 100;
            }
            else
            {
                value = value / 100;
            }

            txtDisplay.Text = value.ToString();
            isNewEntry = true;
        }

        //=======EQUALS(=) BUTTON=====//
        private void btnEquals_Click(object Sender, EventArgs e)
        {
            num2 = double.Parse(txtDisplay.Text);
            double result = 0;

            switch (operation)
            {
                case "+":
                    txtDisplay.Text = (num1 + num2).ToString();
                    break;
                case "-":
                    txtDisplay.Text = (num1 - num2).ToString();
                    break;
                case "*":
                    txtDisplay.Text = (num1 * num2).ToString();
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        txtDisplay.Text = result.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Cannot divide by zero");
                        // Optionally reset display or keep previous value; choose to reset to "0"
                        txtDisplay.Text = "0";
                    }
                    break;
                default:
                    // No operation: leave display as-is or handle accordingly.
                    break;
            }

            // After computing, mark for new entry so next number replaces the display.
            isNewEntry = true;
            operation = "";
        }

        //=======CLEAR(C) BUTTON=====//
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            num1 = 0;
            num2 = 0;
            operation = "";
            isNewEntry = true;
        }

        //=======DELETE (DEL) BUTTON=====//
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (!isNewEntry && txtDisplay.Text.Length > 1)
            {
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
            }
            else
            {
                txtDisplay.Text = "0";
                isNewEntry = true;
            }
        }

        // Updated: PascalCase handler to satisfy naming rule.
        private void TableLayoutPanel1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            // Intentionally left empty: satisfies designer event hookup.
            // If you need custom painting later, implement it here.
        }

        // Shim to preserve compatibility with designer code that may reference the old method name.
        // Suppress IDE1006 for this specific method because the name is required by designer-generated code.
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Naming", "IDE1006:Naming Styles", Justification = "Bound to designer-generated event subscription.")]
        private void tableLayoutPanel1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            // Forward to the correctly-named handler to keep a single implementation.
            TableLayoutPanel1_Paint(sender, e);
        }
    }
}


