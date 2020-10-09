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
    }
    private void btnClearError_Click(object sender, EventArgs e)
    {
      textbox_Result.Text = "0";
    }

    private void numKeyDown(object sender, KeyEventArgs e)
    {
      Button button = (Button)sender;
      switch (textbox_Result.Text)
      {
        case ".":
          btnDecimal.PerformClick();
          break;
        case "0":
          btn0.PerformClick();
          break;
        case "1":
          btn1.PerformClick();
          break;
        case "2":
          //textbox_Result.Text = "2";
          btn2.PerformClick();
          break;
        case "3":
          btn3.PerformClick();
          break;
        case "4":
          btn4.PerformClick();
          break;
        case "5":
          btn5.PerformClick();
          break;
        case "6":
          btn6.PerformClick();
          break;
        case "7":
          btn7.PerformClick();
          break;
        case "8":
          btn8.PerformClick();
          break;
        case "9":
          btn9.PerformClick();
          break;
        case "+":
          btnAddtion.PerformClick();
          break;
        case "-":
          btnSubtraction.PerformClick();
          break;
        case "*":
          btnMultiplication.PerformClick();
          break;
        case "/":
          btnDivision.PerformClick();
          break;
        case "=":
          btnEquals.PerformClick();
          break;
        default:
          break;
      }
    }

    private void Form1_KeyDown(object sender, KeyEventArgs e)
    {
      /*if (e.KeyCode == Keys.Escape)
      {
        this.Close();
      }*/
    }
  }
}
