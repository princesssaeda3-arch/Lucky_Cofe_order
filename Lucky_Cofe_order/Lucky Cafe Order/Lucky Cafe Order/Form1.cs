using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lucky_Cafe_Order
{
    public partial class Form1 : Form
    {
        Random rand = new Random();

        double totalPrice;
        string luckyMessage;

        public Form1()
        {
            InitializeComponent();

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox_drink_Enter(object sender, EventArgs e)
        {

        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkStudent_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbncofee_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Please enter customer name.");
                return;
            }

            int quantity;

            try
            {
                quantity = int.Parse(txtQuantity.Text);

                if (quantity < 1)
                {
                    MessageBox.Show("Enter quantity greater than 0.");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Please enter a valid quantity.");
                return;
            }

            double price = 0;
            string drink = "";

            if (rbTea.Checked == true)
            {
                price = 1;
                drink = "Tea";
            }
            else
            {
                if (rbncofee.Checked == true)
                {
                    price = 2;
                    drink = "Coffee";
                }
                else
                {
                    if (rbtnJuice.Checked == true)
                    {
                        price = 3;
                        drink = "Juice";
                    }
                    else
                    {
                        MessageBox.Show("Please select a drink.");
                        return;
                    }
                }
            }

            listbx_Order.Items.Clear();

            bool prize = false;

            for (int i = 1; i <= quantity; i++)
            {
                int luckyNumber = rand.Next(1, 51);

                if (luckyNumber == 7 || luckyNumber == 17)
                {
                    prize = true;
                }

                string order = i + ") " + txtName.Text;
                order = order + " - " + drink;
                order = order + " - Lucky: " + luckyNumber;
                order = order + " - $" + price.ToString("0.00");

                listbx_Order.Items.Add(order);
            }

          
            totalPrice = price * quantity;
            double totalBeforeDiscount = totalPrice;
            double discount = 0;

            if (chkStudent.Checked == true)
            {
                discount = totalPrice * 10 / 100;
            }

            totalPrice = totalPrice - discount;

            if (prize == true)
            {
                luckyMessage = "You got a Free Cookie!";
            }
            else
            {
                luckyMessage = "No prize this time.";
            }

            if (chkStudent.Checked == true)
            {
                listbx_Order.Items.Add("");
                listbx_Order.Items.Add("Member Discount: 10%");
                listbx_Order.Items.Add("Total Before Discount: $" + totalBeforeDiscount.ToString("0.00"));
                listbx_Order.Items.Add("Total After Discount: $" + totalPrice.ToString("0.00"));
            }


            listbx_Order.Items.Add("Lucky Message: " + luckyMessage);

            lblResult.Text = "Total Price: $" +
                totalPrice.ToString("0.00") +
                "\n" + luckyMessage;
        }

        private void btn_save_file_Click(object sender, EventArgs e)
        {
            if (listbx_Order.Items.Count == 0)
            {
                MessageBox.Show("No order to save.");
            }
            else
            {
                StreamWriter writer = File.AppendText("orders.txt");

                for (int i = 0; i < listbx_Order.Items.Count; i++)
                {
                    writer.WriteLine(listbx_Order.Items[i]);
                }

                writer.WriteLine("Total Price: $" + totalPrice);
                writer.WriteLine("----------------------");

                writer.Close();


                MessageBox.Show("Order saved.");
            }
        }

        private void btn_load_file_Click(object sender, EventArgs e)
        {
            if (File.Exists("orders.txt") == false)
            {
                MessageBox.Show("No file found.");
            }
            else
            {
                listbx_Order.Items.Clear();

                StreamReader reader = File.OpenText("orders.txt");

                while (reader.EndOfStream == false)
                {
                    string line = reader.ReadLine();
                    listbx_Order.Items.Add(line);
                }

                reader.Close();
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtQuantity.Clear();

            listbx_Order.Items.Clear();

            lblResult.Text = "";

            chkStudent.Checked = false;

            rbTea.Checked = false;
            rbncofee.Checked = false;
            rbtnJuice.Checked = false;

            totalPrice = 0;
            luckyMessage = "";

        }

        private void listbx_Order_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rbTea_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private void rbtnJuice_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
