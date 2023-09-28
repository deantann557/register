using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace register
{
    public partial class Form1 : Form
    {
        //global variables
        double manaBomb = 35.25;
        double numofManabomb;
        double toxinBomb = 30.50;
        double numofToxinBomb;
        double thermalBomb = 28.99;
        double numofThermalBomb;
        double Tax = 0.13;
        double subTotal;
        double taxAmount;
        double totalCost;
        double tendered;
        double change;
        int number = 0;
       
       

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

        private void calculateTotal_Click(object sender, EventArgs e)
        {
            numofManabomb = Convert.ToDouble(manaText.Text);
            numofToxinBomb = Convert.ToDouble(toxinText.Text);
            numofThermalBomb = Convert.ToDouble(thermalText.Text);
            subTotal = manaBomb * numofManabomb + toxinBomb * numofToxinBomb + thermalBomb * numofThermalBomb;

            subtotalLabel.Text += subTotal.ToString("C");
            taxAmount = subTotal * Tax;
            taxLabel.Text += taxAmount.ToString("C");
            totalCost = taxAmount + subTotal;
            totalLabel.Text += totalCost.ToString("C");
        }

        private void calculateChange_Click(object sender, EventArgs e)
        {
            tendered = Convert.ToDouble(tenderedText.Text);
            change = tendered - totalCost;
            changeLabel.Text += change.ToString("C");

        }

        private void printReceipt_Click(object sender, EventArgs e)
        {
           
            numofManabomb = Convert.ToDouble(manaText.Text);
            numofToxinBomb = Convert.ToDouble(toxinText.Text);
            numofThermalBomb = Convert.ToDouble(thermalText.Text);
            Receipt.Text = "\n                                      Bomb.Co";

            Receipt.Text += "\n\n Order Number" + number++;
            
            Receipt.Text += "\n\nManaBomb x" + manaText.Text + "                                 ^" + manaBomb;
            Receipt.Text += "\n\nToxinBomb x" + toxinText.Text + "                                 ^" + toxinBomb;
            Receipt.Text += "\n\nThermalBomb x" + thermalText.Text + "                               ^" + thermalBomb;

            Receipt.Text += "\n\n\n SubTotal     " + subTotal.ToString("C");
            Receipt.Text += "\n\n Tax          " + taxAmount.ToString("C");
            Receipt.Text += "\n\n Total          " + totalCost.ToString("C");
            Receipt.Text += "\n\n Amount Tendered         " + tendered.ToString("C");
            Receipt.Text += "\n\n Change            " + change.ToString ("C");
            Receipt.Text += "\n\n Have an Explosive day!";
        }
    }
}
