using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITPCA_Project1
{
    public partial class E : Form
    {
        private List<Campus> everycampus;
        private int provincePosition = 0;
        private List<string> provinces;
       


        public E()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e) //source microsoft
        {
            everycampus = new List<Campus>();
            everycampus.Add(new Campus() { name = "Claremont", location = "Cape Town", province = "Western Cape" });
            everycampus.Add(new Campus() { name = "Tyger Valley", location = "Cape Town", province = "Western Cape" });
            everycampus.Add(new Campus() { name = "Potchefstroom", location = "Potchefstroom", province = "Northen Cape" });
            everycampus.Add(new Campus() { name = "Nelson Mandela Bay", location = "Port Elizabeth", province = "Eastern Cape" });
            everycampus.Add(new Campus() { name = "East London", location = "Port Elizabeth", province = "Eastern Cape" });
            everycampus.Add(new Campus() { name = "Bloemfontein", location = "Bloemfontein", province = "Free State" });
            everycampus.Add(new Campus() { name = "Umhlanga", location = "Durban", province = "KZN" });
            everycampus.Add(new Campus() { name = "Nelspruit", location = "Mbombela", province = "Mpumalanga" });
            everycampus.Add(new Campus() { name = "Midrand", location = "Midrand", province = "Gauteng" });
            everycampus.Add(new Campus() { name = "Vanderbijlpark", location = "Vanderbijlpark", province = "Gauteng" });
            everycampus.Add(new Campus() { name = "Pretoria", location = "Pretoria", province = "Gauteng" });

            comboBox1.DataSource = everycampus.Select(p => p.province).Distinct().ToList();

            timer1.Interval = 30000;     //setting time interval to 30 secs
            timer1.Enabled = true;
            timer1.Start();


        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string chooseProvince = comboBox1.SelectedItem.ToString();
            List<Campus> campusProvince = everycampus.Where(p => p.province == chooseProvince).ToList();

            /*
             * Original solution
             * string chooseProvince = comboBox1.SelectedItem.ToString();
           List<Campus> clearCampus = everycampus.Where(p  => p.province == chooseProvince).ToList();

           listBox1.DataSource = clearCampus;
           listBox1.DisplayMember = "name"; // displays the names of the campuses in the list
          */

            listBox1.DataSource = campusProvince;
            listBox1.DisplayMember = "name";
          
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            provinces = everycampus.Select(p => p.province).Distinct().ToList();

            if (provincePosition >= provinces.Count)
            {
                provincePosition = 0;
            }

            comboBox1.SelectedItem = provinces[provincePosition];
            List<Campus> campusProvince = everycampus.Where(p => p.province == provinces[provincePosition]).ToList();
            listBox1.DataSource = campusProvince;
            listBox1.DisplayMember = "Name";
            provincePosition++;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) //source microsoft
        {
            //Northern Cape Campuses https://www.eduvos.com/campuses/potchefstroom-campus/
            try
            {
                OpenLink1();
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }

        }

   
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //North  West Campuses https://www.eduvos.com/campuses/potchefstroom-campus/
            try
            {
                OpenLink2();
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Western Cape Campuses https://www.eduvos.com/campuses/cape-town-claremont-campus/
            try
            {
                OpenLink3();
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Free State Campus https://www.eduvos.com/campuses/bloemfontein-campus/
            try
            {
                OpenLink4();
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }

        }

     

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Eastern Cape Campus https://www.eduvos.com/campuses/nelson-mandela-bay-port-elizabeth-campus/
            try
            {
                OpenLink5();
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Gauteng Campuses https://www.eduvos.com/campuses/vanderbijlpark-campus/
            try
            {
                OpenLink6();
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //KZN Campus https://www.eduvos.com/campuses/durban/
            try
            {
                OpenLink7();
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Mpumalanga Campuses https://www.eduvos.com/campuses/mbombela-nelspruit-campus/
            try
            {
                OpenLink8();
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }

        private void OpenLink1()
        {
            // Change the color of the link text by setting LinkVisited
            // to true.
            linkLabel1.LinkVisited = true;
            //Call the Process.Start method to open the default browser
            //with a URL:
            System.Diagnostics.Process.Start("https://www.eduvos.com/campuses/cape-town-claremont-campus/");
        }
        private void OpenLink2()
        {
            // Change the color of the link text by setting LinkVisited
            // to true.
            linkLabel2.LinkVisited = true;
            //Call the Process.Start method to open the default browser
            //with a URL:
            System.Diagnostics.Process.Start("https://www.eduvos.com/campuses/potchefstroom-campus/");
        }

        private void OpenLink3()
        {
            // Change the color of the link text by setting LinkVisited
            // to true.
            linkLabel3.LinkVisited = true;
            //Call the Process.Start method to open the default browser
            //with a URL:
            System.Diagnostics.Process.Start("https://www.eduvos.com/campuses/cape-town-claremont-campus/");
        }

        private void OpenLink4()
        {
            // Change the color of the link text by setting LinkVisited
            // to true.
            linkLabel4.LinkVisited = true;
            //Call the Process.Start method to open the default browser
            //with a URL:
            System.Diagnostics.Process.Start("https://www.eduvos.com/campuses/bloemfontein-campus/");
        }

        private void OpenLink5()
        {
            // Change the color of the link text by setting LinkVisited
            // to true.
            linkLabel5.LinkVisited = true;
            //Call the Process.Start method to open the default browser
            //with a URL:
            System.Diagnostics.Process.Start("https://www.eduvos.com/campuses/nelson-mandela-bay-port-elizabeth-campus/");
        }

        private void OpenLink6()
        {
            // Change the color of the link text by setting LinkVisited
            // to true.
            linkLabel6.LinkVisited = true;
            //Call the Process.Start method to open the default browser
            //with a URL:
            System.Diagnostics.Process.Start("https://www.eduvos.com/campuses/vanderbijlpark-campus/");
        }

        private void OpenLink7()
        {
            // Change the color of the link text by setting LinkVisited
            // to true.
            linkLabel7.LinkVisited = true;
            //Call the Process.Start method to open the default browser
            //with a URL:
            System.Diagnostics.Process.Start("https://www.eduvos.com/campuses/durban/");
        }

        private void OpenLink8()
        {
            // Change the color of the link text by setting LinkVisited
            // to true.
            linkLabel8.LinkVisited = true;
            //Call the Process.Start method to open the default browser
            //with a URL:
            System.Diagnostics.Process.Start("https://www.eduvos.com/campuses/durban/");
        }
    }
}
