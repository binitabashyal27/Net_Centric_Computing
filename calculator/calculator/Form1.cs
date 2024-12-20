using System;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            button1.Click += button1_Click;
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                double num1 = double.Parse(textBox1.Text);
                double num2 = double.Parse(textBox2.Text);

               
                string operation = comboBox1.SelectedItem.ToString();
                double result = 0;

                
                switch (operation)
                {
                    case "Add":
                        result = num1 + num2;
                        break;
                    case "Subtract":
                        result = num1 - num2;
                        break;
                    case "Multiply":
                        result = num1 * num2;
                        break;
                    case "Divide":
                        // Handle division by zero
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                        }
                        else
                        {
                            MessageBox.Show("Cannot divide by zero!");
                            return; 
                        }
                        break;
                    default:
                        MessageBox.Show("Please select a valid operation.");
                        return;
                }

                
                textBox3.Text = result.ToString();
            }
            catch (FormatException)
            {
               
                MessageBox.Show("Please enter valid numbers in both input fields.");
            }
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            
            comboBox1.Items.Add("Add");
            comboBox1.Items.Add("Subtract");
            comboBox1.Items.Add("Multiply");
            comboBox1.Items.Add("Divide");

            
            comboBox1.SelectedIndex = 0;
        }
    }
}
