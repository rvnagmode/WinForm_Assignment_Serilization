using System;
using System.IO;
using System.Windows.Forms;
using System.Text.Json;
using System.Text;
using System.Xml.Serialization;

namespace WinForm_Assignment_Serilization
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Product p = new Product();
                FileStream fs = new FileStream(@"D:\ProductJson.json", FileMode.Open, FileAccess.Read);
                p = JsonSerializer.Deserialize<Product>(fs);
                txtpcode.Text = p.Pcode.ToString();
                txtpname.Text = p.Pname;
                txtprice.Text = p.Price.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnBinaryWrite_Click(object sender, EventArgs e)
        {

        }

        private void btnJsonWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Product p = new Product();
                p.Pcode = Convert.ToInt32(txtpcode.Text);
                p.Pname = txtpname.Text;
                p.Price = Convert.ToInt32(txtprice.Text);
                FileStream fs = new FileStream(@"D:\ProductJson.json", FileMode.Create, FileAccess.Write);
                JsonSerializer.Serialize(fs, p);
                fs.Close();
                MessageBox.Show("file added");
            } 
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXmlWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Product p = new Product();
                p.Pcode = Convert.ToInt32(txtpcode.Text);
                p.Pname = txtpname.Text;
                p.Price = Convert.ToInt32(txtprice.Text);
                FileStream fs = new FileStream(@"D:\ProductXml.xml", FileMode.Create, FileAccess.Write);
                XmlSerializer xml = new XmlSerializer(typeof(Product));
                xml.Serialize(fs, p);
                fs.Close();
                MessageBox.Show("file added");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXmlRead_Click(object sender, EventArgs e)
        {
            try
            {
                Product p = new Product();
                FileStream fs = new FileStream(@"D:\\ProductXml.xml", FileMode.Open, FileAccess.Read);
                XmlSerializer xml = new XmlSerializer(typeof(Product));
                p=(Product)xml.Deserialize(fs);
                txtpcode.Text = p.Pcode.ToString();
                txtpname.Text = p.Pname;
                txtprice.Text = p.Price.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
