using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorPractice
{
  public partial class Form1 : Form
  {
    double resultValue = 0;
    string operationPerformed = "";
    bool isOperationPerformed = false;
    public Form1()
    {
      InitializeComponent();
    }
    private void Form1_Load(object sender, EventArgs e)
    {
      btnEquals.Focus();
    }
    private void button_Click(object sender, EventArgs e)
    {
      if ((textbox_Result.Text == "0") || (isOperationPerformed))
        textbox_Result.Clear();
      isOperationPerformed = false;
      Button button = (Button)sender;
      if (button.Text == ".")
      {
        if (!textbox_Result.Text.Contains("."))
          textbox_Result.Text = textbox_Result.Text + button.Text;
      }
      else
        textbox_Result.Text = textbox_Result.Text + button.Text;
    }
    private void operatiorClick(object sender, EventArgs e)
    {
      Button button = (Button)sender;

      if (resultValue != 0)
      {
        btnEquals.PerformClick();
        operationPerformed = button.Text;
        labelCurrentOperation.Text = resultValue + " " + operationPerformed;
        isOperationPerformed = true;
      }
      else
      {
        operationPerformed = button.Text;
        resultValue = Double.Parse(textbox_Result.Text);
        labelCurrentOperation.Text = resultValue + " " + operationPerformed;
        isOperationPerformed = true;
      }
    }
    private void equalsClick(object sender, EventArgs e)
    {
      switch (operationPerformed)
      {
        case "+":
          textbox_Result.Text = (resultValue + Double.Parse(textbox_Result.Text)).ToString();
          break;
        case "-":
          textbox_Result.Text = (resultValue - Double.Parse(textbox_Result.Text)).ToString();
          break;
        case "*":
          textbox_Result.Text = (resultValue * Double.Parse(textbox_Result.Text)).ToString();
          break;
        case "/":
          textbox_Result.Text = (resultValue / Double.Parse(textbox_Result.Text)).ToString();
          break;
        default:
          break;
      }
      resultValue = double.Parse(textbox_Result.Text);
      labelCurrentOperation.Text = "";
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
      textbox_Result.Text = "0";
      resultValue = 0;
      labelCurrentOperation.Text = "";
    }
    private void btnClearError_Click(object sender, EventArgs e)
    {
      textbox_Result.Text = "0";
      labelCurrentOperation.Text = "";
    }

    private void Form1_KeyDown(object sender, KeyEventArgs e)
    {
      switch (e.KeyCode)
      {
        case Keys.Decimal:
          btnDecimal.PerformClick();
          break;
        case Keys.NumPad0:
          btn0.PerformClick();
          break;
        case Keys.NumPad1:
          btn1.PerformClick();
          break;
        case Keys.NumPad2:
          btn2.PerformClick();
          break;
        case Keys.NumPad3:
          btn3.PerformClick();
          break;
        case Keys.NumPad4:
          btn4.PerformClick();
          break;
        case Keys.NumPad5:
          btn5.PerformClick();
          break;
        case Keys.NumPad6:
          btn6.PerformClick();
          break;
        case Keys.NumPad7:
          btn7.PerformClick();
          break;
        case Keys.NumPad8:
          btn8.PerformClick();
          break;
        case Keys.NumPad9:
          btn9.PerformClick();
          break;
        case Keys.Add:
          btnAddtion.PerformClick();
          break;
        case Keys.Subtract:
          btnSubtraction.PerformClick();
          break;
        case Keys.Multiply:
          btnMultiplication.PerformClick();
          break;
        case Keys.Divide:
          btnDivision.PerformClick();
          break;
        case Keys.Return:
          btnEquals.PerformClick();
          break;
        default:
          break;
      }
    }

    private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
    {
      MessageBox.Show(e.KeyCode.ToString());
    }

    private void Form1_KeyPress(object sender, KeyPressEventArgs e)
    {
      MessageBox.Show(e.KeyChar.ToString());
    }
  }
}
