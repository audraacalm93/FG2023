using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace FINISHGOOD
{
    public partial class Form1 : Form
    {
        SqlConnection Connection;
        double val = 0;
        public Form1()
        {
            InitializeComponent();
            Connection = new SqlConnection(@"Server=tcp:finishgood-server.database.windows.net,1433;Initial Catalog=FINISHGOOD_DB;Persist Security Info=False;User ID=azima;Password=Jima2003;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            FillComboBox();
        }
       
// ============================================================================================== Button SUBMIT Sesuai dengan Loading Plan =====================================================================================================================================================
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.Open();

                if (int.TryParse(textBox1.Text, out int qty1) &&
                    int.TryParse(textBox2.Text, out int qty2) &&
                    int.TryParse(textBox3.Text, out int qty3) &&
                    int.TryParse(textBox4.Text, out int qty4) &&
                    int.TryParse(textBox5.Text, out int qty5))
                {
                    // Memasukkan data baru ke dalam tabel
                    SqlCommand cmd1 = new SqlCommand("INSERT INTO LDPLAN_TB(ID_LDPLAN, MODEL_NAME, QTY) VALUES(@ID_LDPLAN1, @MODEL_NAME1, @QTY1)", Connection);
                    cmd1.Parameters.AddWithValue("@ID_LDPLAN1", ("LD" + "-" + "1" + "-" + comboBox1.Text + "-" + DateTime.Now.ToString("MMyyyyHHmmss")));
                    cmd1.Parameters.AddWithValue("@MODEL_NAME1", comboBox1.Text);
                    cmd1.Parameters.AddWithValue("@QTY1", qty1);

                    SqlCommand cmd2 = new SqlCommand("INSERT INTO LDPLAN_TB(ID_LDPLAN, MODEL_NAME, QTY) VALUES(@ID_LDPLAN2, @MODEL_NAME2, @QTY2)", Connection);
                    cmd2.Parameters.AddWithValue("@ID_LDPLAN2", ("LD" + "-" + "1" + "-" + comboBox2.Text + "-" + DateTime.Now.ToString("MMyyyyHHmmss")));
                    cmd2.Parameters.AddWithValue("@MODEL_NAME2", comboBox2.Text);
                    cmd2.Parameters.AddWithValue("@QTY2", qty2);

                    SqlCommand cmd3 = new SqlCommand("INSERT INTO LDPLAN_TB(ID_LDPLAN, MODEL_NAME, QTY) VALUES(@ID_LDPLAN3, @MODEL_NAME3, @QTY3)", Connection);
                    cmd3.Parameters.AddWithValue("@ID_LDPLAN3", ("LD" + "-" + "1" + "-" + comboBox3.Text + "-" + DateTime.Now.ToString("MMyyyyHHmmss")));
                    cmd3.Parameters.AddWithValue("@MODEL_NAME3", comboBox3.Text);
                    cmd3.Parameters.AddWithValue("@QTY3", qty3);

                    SqlCommand cmd4 = new SqlCommand("INSERT INTO LDPLAN_TB(ID_LDPLAN, MODEL_NAME, QTY) VALUES(@ID_LDPLAN4, @MODEL_NAME4, @QTY4)", Connection);
                    cmd4.Parameters.AddWithValue("@ID_LDPLAN4", ("LD" + "-" + "1" + "-" + comboBox4.Text + "-" + DateTime.Now.ToString("MMyyyyHHmmss")));
                    cmd4.Parameters.AddWithValue("@MODEL_NAME4", comboBox4.Text);
                    cmd4.Parameters.AddWithValue("@QTY4", qty4);

                    SqlCommand cmd5 = new SqlCommand("INSERT INTO LDPLAN_TB(ID_LDPLAN, MODEL_NAME, QTY) VALUES(@ID_LDPLAN5, @MODEL_NAME5, @QTY5)", Connection);
                    cmd5.Parameters.AddWithValue("@ID_LDPLAN5", ("LD" + "-" + "1" + "-" + comboBox5.Text + "-" + DateTime.Now.ToString("MMyyyyHHmmss")));
                    cmd5.Parameters.AddWithValue("@MODEL_NAME5", comboBox5.Text);
                    cmd5.Parameters.AddWithValue("@QTY5", qty5);

                    cmd1.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                    cmd3.ExecuteNonQuery();
                    cmd4.ExecuteNonQuery();
                    cmd5.ExecuteNonQuery();

                    MessageBox.Show("Succesfully Saved");
                    comboBox1.Text = ""; textBox1.Text = "";
					comboBox2.Text = ""; textBox2.Text = "";
					comboBox3.Text = ""; textBox3.Text = "";
					comboBox4.Text = ""; textBox4.Text = "";
					comboBox5.Text = ""; textBox5.Text = "";
				}
                else
                {
                    MessageBox.Show("Tolong Masukkan inputan Angka Pada kolom Qty");
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            Connection.Close();
            Console.ReadLine();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.Open();

                if (int.TryParse(textBox6.Text, out int qty6) &&
                    int.TryParse(textBox7.Text, out int qty7) &&
                    int.TryParse(textBox8.Text, out int qty8) &&
                    int.TryParse(textBox9.Text, out int qty9) &&
                    int.TryParse(textBox10.Text, out int qty10))
                {
                    // Memasukkan data baru ke dalam tabel
                    SqlCommand cmd1 = new SqlCommand("INSERT INTO LDPLAN_TB(ID_LDPLAN, MODEL_NAME, QTY) VALUES(@ID_LDPLAN1, @MODEL_NAME1, @QTY1)", Connection);
                    cmd1.Parameters.AddWithValue("@ID_LDPLAN1", ("LD" + "-" + "2" + "-" + comboBox6.Text + "-" + DateTime.Now.ToString("MMyyyyHHmmss")));
                    cmd1.Parameters.AddWithValue("@MODEL_NAME1", comboBox6.Text);
                    cmd1.Parameters.AddWithValue("@QTY1", qty6);

                    SqlCommand cmd2 = new SqlCommand("INSERT INTO LDPLAN_TB(ID_LDPLAN, MODEL_NAME, QTY) VALUES(@ID_LDPLAN2, @MODEL_NAME2, @QTY2)", Connection);
                    cmd2.Parameters.AddWithValue("@ID_LDPLAN2", ("LD" + "-" + "2" + "-" + comboBox7.Text + "-" + DateTime.Now.ToString("MMyyyyHHmmss")));
                    cmd2.Parameters.AddWithValue("@MODEL_NAME2", comboBox7.Text);
                    cmd2.Parameters.AddWithValue("@QTY2", qty7);

                    SqlCommand cmd3 = new SqlCommand("INSERT INTO LDPLAN_TB(ID_LDPLAN, MODEL_NAME, QTY) VALUES(@ID_LDPLAN3, @MODEL_NAME3, @QTY3)", Connection);
                    cmd3.Parameters.AddWithValue("@ID_LDPLAN3", ("LD" + "-" + "2" + "-" + comboBox8.Text + "-" + DateTime.Now.ToString("MMyyyyHHmmss")));
                    cmd3.Parameters.AddWithValue("@MODEL_NAME3", comboBox8.Text);
                    cmd3.Parameters.AddWithValue("@QTY3", qty8);

                    SqlCommand cmd4 = new SqlCommand("INSERT INTO LDPLAN_TB(ID_LDPLAN, MODEL_NAME, QTY) VALUES(@ID_LDPLAN4, @MODEL_NAME4, @QTY4)", Connection);
                    cmd4.Parameters.AddWithValue("@ID_LDPLAN4", ("LD" + "-" + "2" + "-" + comboBox9.Text + "-" + DateTime.Now.ToString("MMyyyyHHmmss")));
                    cmd4.Parameters.AddWithValue("@MODEL_NAME4", comboBox9.Text);
                    cmd4.Parameters.AddWithValue("@QTY4", qty9);

                    SqlCommand cmd5 = new SqlCommand("INSERT INTO LDPLAN_TB(ID_LDPLAN, MODEL_NAME, QTY) VALUES(@ID_LDPLAN5, @MODEL_NAME5, @QTY5)", Connection);
                    cmd5.Parameters.AddWithValue("@ID_LDPLAN5", ("LD" + "-" + "2" + "-" + comboBox10.Text + "-" + DateTime.Now.ToString("MMyyyyHHmmss")));
                    cmd5.Parameters.AddWithValue("@MODEL_NAME5", comboBox10.Text);
                    cmd5.Parameters.AddWithValue("@QTY5", qty10);

                    cmd1.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                    cmd3.ExecuteNonQuery();
                    cmd4.ExecuteNonQuery();
                    cmd5.ExecuteNonQuery();

                    MessageBox.Show("Succesfully Saved");
                }
                else
                {
                    MessageBox.Show("Tolong Masukkan inputan Angka Pada kolom Qty");
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            Connection.Close();
            Console.ReadLine();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.Open();

                if (int.TryParse(textBox11.Text, out int qty11) &&
                    int.TryParse(textBox12.Text, out int qty12) &&
                    int.TryParse(textBox13.Text, out int qty13) &&
                    int.TryParse(textBox14.Text, out int qty14) &&
                    int.TryParse(textBox15.Text, out int qty15))
                {
                    // Memasukkan data baru ke dalam tabel
                    SqlCommand cmd1 = new SqlCommand("INSERT INTO LDPLAN_TB(ID_LDPLAN, MODEL_NAME, QTY) VALUES(@ID_LDPLAN1, @MODEL_NAME1, @QTY1)", Connection);
                    cmd1.Parameters.AddWithValue("@ID_LDPLAN1", ("LD" + "-" + "3" + "-" + comboBox11.Text + "-" + DateTime.Now.ToString("MMyyyyHHmmss")));
                    cmd1.Parameters.AddWithValue("@MODEL_NAME1", comboBox11.Text);
                    cmd1.Parameters.AddWithValue("@QTY1", qty11);

                    SqlCommand cmd2 = new SqlCommand("INSERT INTO LDPLAN_TB(ID_LDPLAN, MODEL_NAME, QTY) VALUES(@ID_LDPLAN2, @MODEL_NAME2, @QTY2)", Connection);
                    cmd2.Parameters.AddWithValue("@ID_LDPLAN2", ("LD" + "-" + "3" + "-" + comboBox12.Text + "-" + DateTime.Now.ToString("MMyyyyHHmmss")));
                    cmd2.Parameters.AddWithValue("@MODEL_NAME2", comboBox12.Text);
                    cmd2.Parameters.AddWithValue("@QTY2", qty12);

                    SqlCommand cmd3 = new SqlCommand("INSERT INTO LDPLAN_TB(ID_LDPLAN, MODEL_NAME, QTY) VALUES(@ID_LDPLAN3, @MODEL_NAME3, @QTY3)", Connection);
                    cmd3.Parameters.AddWithValue("@ID_LDPLAN3", ("LD" + "-" + "3" + "-" + comboBox13.Text + "-" + DateTime.Now.ToString("MMyyyyHHmmss")));
                    cmd3.Parameters.AddWithValue("@MODEL_NAME3", comboBox13.Text);
                    cmd3.Parameters.AddWithValue("@QTY3", qty13);

                    SqlCommand cmd4 = new SqlCommand("INSERT INTO LDPLAN_TB(ID_LDPLAN, MODEL_NAME, QTY) VALUES(@ID_LDPLAN4, @MODEL_NAME4, @QTY4)", Connection);
                    cmd4.Parameters.AddWithValue("@ID_LDPLAN4", ("LD" + "-" + "3" + "-" + comboBox14.Text + "-" + DateTime.Now.ToString("MMyyyyHHmmss")));
                    cmd4.Parameters.AddWithValue("@MODEL_NAME4", comboBox14.Text);
                    cmd4.Parameters.AddWithValue("@QTY4", qty14);

                    SqlCommand cmd5 = new SqlCommand("INSERT INTO LDPLAN_TB(ID_LDPLAN, MODEL_NAME, QTY) VALUES(@ID_LDPLAN5, @MODEL_NAME5, @QTY5)", Connection);
                    cmd5.Parameters.AddWithValue("@ID_LDPLAN5", ("LD" + "-" + "3" + "-" + comboBox15.Text + "-" + DateTime.Now.ToString("MMyyyyHHmmss")));
                    cmd5.Parameters.AddWithValue("@MODEL_NAME5", comboBox15.Text);
                    cmd5.Parameters.AddWithValue("@QTY5", qty15);

                    cmd1.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                    cmd3.ExecuteNonQuery();
                    cmd4.ExecuteNonQuery();
                    cmd5.ExecuteNonQuery();

                    MessageBox.Show("Succesfully Saved");
                }
                else
                {
                    MessageBox.Show("Tolong Masukkan inputan Angka Pada kolom Qty");
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            Connection.Close();
            Console.ReadLine();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.Open();

                if (int.TryParse(textBox16.Text, out int qty16) &&
                    int.TryParse(textBox17.Text, out int qty17) &&
                    int.TryParse(textBox18.Text, out int qty18) &&
                    int.TryParse(textBox19.Text, out int qty19) &&
                    int.TryParse(textBox20.Text, out int qty20))
                {
                    // Memasukkan data baru ke dalam tabel
                    SqlCommand cmd1 = new SqlCommand("INSERT INTO LDPLAN_TB(ID_LDPLAN, MODEL_NAME, QTY) VALUES(@ID_LDPLAN1, @MODEL_NAME1, @QTY1)", Connection);
                    cmd1.Parameters.AddWithValue("@ID_LDPLAN1", ("LD" + "-" + "4" + "-" + comboBox16.Text + "-" + DateTime.Now.ToString("MMyyyyHHmmss")));
                    cmd1.Parameters.AddWithValue("@MODEL_NAME1", comboBox16.Text);
                    cmd1.Parameters.AddWithValue("@QTY1", qty16);

                    SqlCommand cmd2 = new SqlCommand("INSERT INTO LDPLAN_TB(ID_LDPLAN, MODEL_NAME, QTY) VALUES(@ID_LDPLAN2, @MODEL_NAME2, @QTY2)", Connection);
                    cmd2.Parameters.AddWithValue("@ID_LDPLAN2", ("LD" + "-" + "4" + "-" + comboBox17.Text + "-" + DateTime.Now.ToString("MMyyyyHHmmss")));
                    cmd2.Parameters.AddWithValue("@MODEL_NAME2", comboBox17.Text);
                    cmd2.Parameters.AddWithValue("@QTY2", qty17);

                    SqlCommand cmd3 = new SqlCommand("INSERT INTO LDPLAN_TB(ID_LDPLAN, MODEL_NAME, QTY) VALUES(@ID_LDPLAN3, @MODEL_NAME3, @QTY3)", Connection);
                    cmd3.Parameters.AddWithValue("@ID_LDPLAN3", ("LD" + "-" + "4" + "-" + comboBox18.Text + "-" + DateTime.Now.ToString("MMyyyyHHmmss")));
                    cmd3.Parameters.AddWithValue("@MODEL_NAME3", comboBox18.Text);
                    cmd3.Parameters.AddWithValue("@QTY3", qty18);

                    SqlCommand cmd4 = new SqlCommand("INSERT INTO LDPLAN_TB(ID_LDPLAN, MODEL_NAME, QTY) VALUES(@ID_LDPLAN4, @MODEL_NAME4, @QTY4)", Connection);
                    cmd4.Parameters.AddWithValue("@ID_LDPLAN4", ("LD" + "-" + "4" + "-" + comboBox19.Text + "-" + DateTime.Now.ToString("MMyyyyHHmmss")));
                    cmd4.Parameters.AddWithValue("@MODEL_NAME4", comboBox19.Text);
                    cmd4.Parameters.AddWithValue("@QTY4", qty19);

                    SqlCommand cmd5 = new SqlCommand("INSERT INTO LDPLAN_TB(ID_LDPLAN, MODEL_NAME, QTY) VALUES(@ID_LDPLAN5, @MODEL_NAME5, @QTY5)", Connection);
                    cmd5.Parameters.AddWithValue("@ID_LDPLAN5", ("LD" + "-" + "4" + "-" + comboBox20.Text + "-" + DateTime.Now.ToString("MMyyyyHHmmss")));
                    cmd5.Parameters.AddWithValue("@MODEL_NAME5", comboBox20.Text);
                    cmd5.Parameters.AddWithValue("@QTY5", qty20);

                    cmd1.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                    cmd3.ExecuteNonQuery();
                    cmd4.ExecuteNonQuery();
                    cmd5.ExecuteNonQuery();

                    MessageBox.Show("Succesfully Saved");
                }
                else
                {
                    MessageBox.Show("Tolong Masukkan inputan Angka Pada kolom Qty");
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            Connection.Close();
            Console.ReadLine();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.Open();

                if (int.TryParse(textBox21.Text, out int qty21) &&
                    int.TryParse(textBox22.Text, out int qty22) &&
                    int.TryParse(textBox23.Text, out int qty23) &&
                    int.TryParse(textBox24.Text, out int qty24) &&
                    int.TryParse(textBox25.Text, out int qty25))
                {
                    // Memasukkan data baru ke dalam tabel
                    SqlCommand cmd1 = new SqlCommand("INSERT INTO LDPLAN_TB(ID_LDPLAN, MODEL_NAME, QTY) VALUES(@ID_LDPLAN1, @MODEL_NAME1, @QTY1)", Connection);
                    cmd1.Parameters.AddWithValue("@ID_LDPLAN1", ("LD" + "-" + "5" + "-" + comboBox21.Text + "-" + DateTime.Now.ToString("MMyyyyHHmmss")));
                    cmd1.Parameters.AddWithValue("@MODEL_NAME1", comboBox21.Text);
                    cmd1.Parameters.AddWithValue("@QTY1", qty21);

                    SqlCommand cmd2 = new SqlCommand("INSERT INTO LDPLAN_TB(ID_LDPLAN, MODEL_NAME, QTY) VALUES(@ID_LDPLAN2, @MODEL_NAME2, @QTY2)", Connection);
                    cmd2.Parameters.AddWithValue("@ID_LDPLAN2", ("LD" + "-" + "5" + "-" + comboBox22.Text + "-" + DateTime.Now.ToString("MMyyyyHHmmss")));
                    cmd2.Parameters.AddWithValue("@MODEL_NAME2", comboBox22.Text);
                    cmd2.Parameters.AddWithValue("@QTY2", qty22);

                    SqlCommand cmd3 = new SqlCommand("INSERT INTO LDPLAN_TB(ID_LDPLAN, MODEL_NAME, QTY) VALUES(@ID_LDPLAN3, @MODEL_NAME3, @QTY3)", Connection);
                    cmd3.Parameters.AddWithValue("@ID_LDPLAN3", ("LD" + "-" + "5" + "-" + comboBox23.Text + "-" + DateTime.Now.ToString("MMyyyyHHmmss")));
                    cmd3.Parameters.AddWithValue("@MODEL_NAME3", comboBox23.Text);
                    cmd3.Parameters.AddWithValue("@QTY3", qty23);

                    SqlCommand cmd4 = new SqlCommand("INSERT INTO LDPLAN_TB(ID_LDPLAN, MODEL_NAME, QTY) VALUES(@ID_LDPLAN4, @MODEL_NAME4, @QTY4)", Connection);
                    cmd4.Parameters.AddWithValue("@ID_LDPLAN4", ("LD" + "-" + "5" + "-" + comboBox24.Text + "-" + DateTime.Now.ToString("MMyyyyHHmmss")));
                    cmd4.Parameters.AddWithValue("@MODEL_NAME4", comboBox24.Text);
                    cmd4.Parameters.AddWithValue("@QTY4", qty24);

                    SqlCommand cmd5 = new SqlCommand("INSERT INTO LDPLAN_TB(ID_LDPLAN, MODEL_NAME, QTY) VALUES(@ID_LDPLAN5, @MODEL_NAME5, @QTY5)", Connection);
                    cmd5.Parameters.AddWithValue("@ID_LDPLAN5", ("LD" + "-" + "5" + "-" + comboBox25.Text + "-" + DateTime.Now.ToString("MMyyyyHHmmss")));
                    cmd5.Parameters.AddWithValue("@MODEL_NAME5", comboBox25.Text);
                    cmd5.Parameters.AddWithValue("@QTY5", qty25);

                    cmd1.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                    cmd3.ExecuteNonQuery();
                    cmd4.ExecuteNonQuery();
                    cmd5.ExecuteNonQuery();

                    MessageBox.Show("Succesfully Saved");
                }
                else
                {
                    MessageBox.Show("Tolong Masukkan inputan Angka Pada kolom Qty");
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            Connection.Close();
            Console.ReadLine();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.Open();

                if (int.TryParse(textBox26.Text, out int qty26) &&
                    int.TryParse(textBox27.Text, out int qty27) &&
                    int.TryParse(textBox28.Text, out int qty28) &&
                    int.TryParse(textBox29.Text, out int qty29) &&
                    int.TryParse(textBox30.Text, out int qty30))
                {
                    // Memasukkan data baru ke dalam tabel
                    SqlCommand cmd1 = new SqlCommand("INSERT INTO LDPLAN_TB(ID_LDPLAN, MODEL_NAME, QTY) VALUES(@ID_LDPLAN1, @MODEL_NAME1, @QTY1)", Connection);
                    cmd1.Parameters.AddWithValue("@ID_LDPLAN1", ("LD" + "-" + "6" + "-" + comboBox26.Text + "-" + DateTime.Now.ToString("MMyyyyHHmmss")));
                    cmd1.Parameters.AddWithValue("@MODEL_NAME1", comboBox26.Text);
                    cmd1.Parameters.AddWithValue("@QTY1", qty26);

                    SqlCommand cmd2 = new SqlCommand("INSERT INTO LDPLAN_TB(ID_LDPLAN, MODEL_NAME, QTY) VALUES(@ID_LDPLAN2, @MODEL_NAME2, @QTY2)", Connection);
                    cmd2.Parameters.AddWithValue("@ID_LDPLAN2", ("LD" + "-" + "6" + "-" + comboBox27.Text + "-" + DateTime.Now.ToString("MMyyyyHHmmss")));
                    cmd2.Parameters.AddWithValue("@MODEL_NAME2", comboBox27.Text);
                    cmd2.Parameters.AddWithValue("@QTY2", qty27);

                    SqlCommand cmd3 = new SqlCommand("INSERT INTO LDPLAN_TB(ID_LDPLAN, MODEL_NAME, QTY) VALUES(@ID_LDPLAN3, @MODEL_NAME3, @QTY3)", Connection);
                    cmd3.Parameters.AddWithValue("@ID_LDPLAN3", ("LD" + "-" + "6" + "-" + comboBox28.Text + "-" + DateTime.Now.ToString("MMyyyyHHmmss")));
                    cmd3.Parameters.AddWithValue("@MODEL_NAME3", comboBox28.Text);
                    cmd3.Parameters.AddWithValue("@QTY3", qty28);

                    SqlCommand cmd4 = new SqlCommand("INSERT INTO LDPLAN_TB(ID_LDPLAN, MODEL_NAME, QTY) VALUES(@ID_LDPLAN4, @MODEL_NAME4, @QTY4)", Connection);
                    cmd4.Parameters.AddWithValue("@ID_LDPLAN4", ("LD" + "-" + "6" + "-" + comboBox29.Text + "-" + DateTime.Now.ToString("MMyyyyHHmmss")));
                    cmd4.Parameters.AddWithValue("@MODEL_NAME4", comboBox29.Text);
                    cmd4.Parameters.AddWithValue("@QTY4", qty29);

                    SqlCommand cmd5 = new SqlCommand("INSERT INTO LDPLAN_TB(ID_LDPLAN, MODEL_NAME, QTY) VALUES(@ID_LDPLAN5, @MODEL_NAME5, @QTY5)", Connection);
                    cmd5.Parameters.AddWithValue("@ID_LDPLAN5", ("LD" + "-" + "6" + "-" + comboBox30.Text + "-" + DateTime.Now.ToString("MMyyyyHHmmss")));
                    cmd5.Parameters.AddWithValue("@MODEL_NAME5", comboBox30.Text);
                    cmd5.Parameters.AddWithValue("@QTY5", qty30);

                    cmd1.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                    cmd3.ExecuteNonQuery();
                    cmd4.ExecuteNonQuery();
                    cmd5.ExecuteNonQuery();

                    MessageBox.Show("Succesfully Saved");
                }
                else
                {
                    MessageBox.Show("Tolong Masukkan inputan Angka Pada kolom Qty");
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            Connection.Close();
            Console.ReadLine();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.Open();

                if (int.TryParse(textBox31.Text, out int qty31) &&
                    int.TryParse(textBox32.Text, out int qty32) &&
                    int.TryParse(textBox33.Text, out int qty33) &&
                    int.TryParse(textBox34.Text, out int qty34) &&
                    int.TryParse(textBox35.Text, out int qty35))
                {
                    // Memasukkan data baru ke dalam tabel
                    SqlCommand cmd1 = new SqlCommand("INSERT INTO LDPLAN_TB(ID_LDPLAN, MODEL_NAME, QTY) VALUES(@ID_LDPLAN1, @MODEL_NAME1, @QTY1)", Connection);
                    cmd1.Parameters.AddWithValue("@ID_LDPLAN1", ("LD" + "-" + "7" + "-" + comboBox31.Text + "-" + DateTime.Now.ToString("MMyyyyHHmmss")));
                    cmd1.Parameters.AddWithValue("@MODEL_NAME1", comboBox31.Text);
                    cmd1.Parameters.AddWithValue("@QTY1", qty31);

                    SqlCommand cmd2 = new SqlCommand("INSERT INTO LDPLAN_TB(ID_LDPLAN, MODEL_NAME, QTY) VALUES(@ID_LDPLAN2, @MODEL_NAME2, @QTY2)", Connection);
                    cmd2.Parameters.AddWithValue("@ID_LDPLAN2", ("LD" + "-" + "7" + "-" + comboBox32.Text + "-" + DateTime.Now.ToString("MMyyyyHHmmss")));
                    cmd2.Parameters.AddWithValue("@MODEL_NAME2", comboBox32.Text);
                    cmd2.Parameters.AddWithValue("@QTY2", qty32);

                    SqlCommand cmd3 = new SqlCommand("INSERT INTO LDPLAN_TB(ID_LDPLAN, MODEL_NAME, QTY) VALUES(@ID_LDPLAN3, @MODEL_NAME3, @QTY3)", Connection);
                    cmd3.Parameters.AddWithValue("@ID_LDPLAN3", ("LD" + "-" + "7" + "-" + comboBox33.Text + "-" + DateTime.Now.ToString("MMyyyyHHmmss")));
                    cmd3.Parameters.AddWithValue("@MODEL_NAME3", comboBox33.Text);
                    cmd3.Parameters.AddWithValue("@QTY3", qty33);

                    SqlCommand cmd4 = new SqlCommand("INSERT INTO LDPLAN_TB(ID_LDPLAN, MODEL_NAME, QTY) VALUES(@ID_LDPLAN4, @MODEL_NAME4, @QTY4)", Connection);
                    cmd4.Parameters.AddWithValue("@ID_LDPLAN4", ("LD" + "-" + "7" + "-" + comboBox34.Text + "-" + DateTime.Now.ToString("MMyyyyHHmmss")));
                    cmd4.Parameters.AddWithValue("@MODEL_NAME4", comboBox34.Text);
                    cmd4.Parameters.AddWithValue("@QTY4", qty34);

                    SqlCommand cmd5 = new SqlCommand("INSERT INTO LDPLAN_TB(ID_LDPLAN, MODEL_NAME, QTY) VALUES(@ID_LDPLAN5, @MODEL_NAME5, @QTY5)", Connection);
                    cmd5.Parameters.AddWithValue("@ID_LDPLAN5", ("LD" + "-" + "7" + "-" + comboBox35.Text + "-" + DateTime.Now.ToString("MMyyyyHHmmss")));
                    cmd5.Parameters.AddWithValue("@MODEL_NAME5", comboBox35.Text);
                    cmd5.Parameters.AddWithValue("@QTY5", qty35);

                    cmd1.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                    cmd3.ExecuteNonQuery();
                    cmd4.ExecuteNonQuery();
                    cmd5.ExecuteNonQuery();

                    MessageBox.Show("Succesfully Saved");
                }
                else
                {
                    MessageBox.Show("Tolong Masukkan inputan Angka Pada kolom Qty");
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            Connection.Close();
            Console.ReadLine();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.Open();

                if (int.TryParse(textBox36.Text, out int qty36) &&
                    int.TryParse(textBox37.Text, out int qty37) &&
                    int.TryParse(textBox38.Text, out int qty38) &&
                    int.TryParse(textBox39.Text, out int qty39) &&
                    int.TryParse(textBox40.Text, out int qty40))
                {
                    // Memasukkan data baru ke dalam tabel
                    SqlCommand cmd1 = new SqlCommand("INSERT INTO LDPLAN_TB(ID_LDPLAN, MODEL_NAME, QTY) VALUES(@ID_LDPLAN1, @MODEL_NAME1, @QTY1)", Connection);
                    cmd1.Parameters.AddWithValue("@ID_LDPLAN1", ("LD" + "-" + "8" + "-" + comboBox36.Text + "-" + DateTime.Now.ToString("MMyyyyHHmmss")));
                    cmd1.Parameters.AddWithValue("@MODEL_NAME1", comboBox36.Text);
                    cmd1.Parameters.AddWithValue("@QTY1", qty36);

                    SqlCommand cmd2 = new SqlCommand("INSERT INTO LDPLAN_TB(ID_LDPLAN, MODEL_NAME, QTY) VALUES(@ID_LDPLAN2, @MODEL_NAME2, @QTY2)", Connection);
                    cmd2.Parameters.AddWithValue("@ID_LDPLAN2", ("LD" + "-" + "8" + "-" + comboBox37.Text + "-" + DateTime.Now.ToString("MMyyyyHHmmss")));
                    cmd2.Parameters.AddWithValue("@MODEL_NAME2", comboBox37.Text);
                    cmd2.Parameters.AddWithValue("@QTY2", qty37);

                    SqlCommand cmd3 = new SqlCommand("INSERT INTO LDPLAN_TB(ID_LDPLAN, MODEL_NAME, QTY) VALUES(@ID_LDPLAN3, @MODEL_NAME3, @QTY3)", Connection);
                    cmd3.Parameters.AddWithValue("@ID_LDPLAN3", ("LD" + "-" + "8" + "-" + comboBox38.Text + "-" + DateTime.Now.ToString("MMyyyyHHmmss")));
                    cmd3.Parameters.AddWithValue("@MODEL_NAME3", comboBox38.Text);
                    cmd3.Parameters.AddWithValue("@QTY3", qty38);

                    SqlCommand cmd4 = new SqlCommand("INSERT INTO LDPLAN_TB(ID_LDPLAN, MODEL_NAME, QTY) VALUES(@ID_LDPLAN4, @MODEL_NAME4, @QTY4)", Connection);
                    cmd4.Parameters.AddWithValue("@ID_LDPLAN4", ("LD" + "-" + "8" + "-" + comboBox39.Text + "-" + DateTime.Now.ToString("MMyyyyHHmmss")));
                    cmd4.Parameters.AddWithValue("@MODEL_NAME4", comboBox39.Text);
                    cmd4.Parameters.AddWithValue("@QTY4", qty39);

                    SqlCommand cmd5 = new SqlCommand("INSERT INTO LDPLAN_TB(ID_LDPLAN, MODEL_NAME, QTY) VALUES(@ID_LDPLAN5, @MODEL_NAME5, @QTY5)", Connection);
                    cmd5.Parameters.AddWithValue("@ID_LDPLAN5", ("LD" + "-" + "8" + "-" + comboBox40.Text + "-" + DateTime.Now.ToString("MMyyyyHHmmss")));
                    cmd5.Parameters.AddWithValue("@MODEL_NAME5", comboBox40.Text);
                    cmd5.Parameters.AddWithValue("@QTY5", qty40);

                    cmd1.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                    cmd3.ExecuteNonQuery();
                    cmd4.ExecuteNonQuery();
                    cmd5.ExecuteNonQuery();

                    MessageBox.Show("Succesfully Saved");
                }
                else
                {
                    MessageBox.Show("Tolong Masukkan inputan Angka Pada kolom Qty");
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            Connection.Close();
            Console.ReadLine();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.Open();

                if (int.TryParse(textBox41.Text, out int qty41) &&
                    int.TryParse(textBox42.Text, out int qty42) &&
                    int.TryParse(textBox43.Text, out int qty43) &&
                    int.TryParse(textBox44.Text, out int qty44) &&
                    int.TryParse(textBox45.Text, out int qty45))
                {
                    // Memasukkan data baru ke dalam tabel
                    SqlCommand cmd1 = new SqlCommand("INSERT INTO LDPLAN_TB(ID_LDPLAN, MODEL_NAME, QTY) VALUES(@ID_LDPLAN1, @MODEL_NAME1, @QTY1)", Connection);
                    cmd1.Parameters.AddWithValue("@ID_LDPLAN1", ("LD" + "-" + "9" + "-" + comboBox41.Text + "-" + DateTime.Now.ToString("MMyyyyHHmmss")));
                    cmd1.Parameters.AddWithValue("@MODEL_NAME1", comboBox41.Text);
                    cmd1.Parameters.AddWithValue("@QTY1", qty41);

                    SqlCommand cmd2 = new SqlCommand("INSERT INTO LDPLAN_TB(ID_LDPLAN, MODEL_NAME, QTY) VALUES(@ID_LDPLAN2, @MODEL_NAME2, @QTY2)", Connection);
                    cmd2.Parameters.AddWithValue("@ID_LDPLAN2", ("LD" + "-" + "9" + "-" + comboBox42.Text + "-" + DateTime.Now.ToString("MMyyyyHHmmss")));
                    cmd2.Parameters.AddWithValue("@MODEL_NAME2", comboBox42.Text);
                    cmd2.Parameters.AddWithValue("@QTY2", qty42);

                    SqlCommand cmd3 = new SqlCommand("INSERT INTO LDPLAN_TB(ID_LDPLAN, MODEL_NAME, QTY) VALUES(@ID_LDPLAN3, @MODEL_NAME3, @QTY3)", Connection);
                    cmd3.Parameters.AddWithValue("@ID_LDPLAN3", ("LD" + "-" + "9" + "-" + comboBox43.Text + "-" + DateTime.Now.ToString("MMyyyyHHmmss")));
                    cmd3.Parameters.AddWithValue("@MODEL_NAME3", comboBox43.Text);
                    cmd3.Parameters.AddWithValue("@QTY3", qty43);

                    SqlCommand cmd4 = new SqlCommand("INSERT INTO LDPLAN_TB(ID_LDPLAN, MODEL_NAME, QTY) VALUES(@ID_LDPLAN4, @MODEL_NAME4, @QTY4)", Connection);
                    cmd4.Parameters.AddWithValue("@ID_LDPLAN4", ("LD" + "-" + "9" + "-" + comboBox44.Text + "-" + DateTime.Now.ToString("MMyyyyHHmmss")));
                    cmd4.Parameters.AddWithValue("@MODEL_NAME4", comboBox44.Text);
                    cmd4.Parameters.AddWithValue("@QTY4", qty44);

                    SqlCommand cmd5 = new SqlCommand("INSERT INTO LDPLAN_TB(ID_LDPLAN, MODEL_NAME, QTY) VALUES(@ID_LDPLAN5, @MODEL_NAME5, @QTY5)", Connection);
                    cmd5.Parameters.AddWithValue("@ID_LDPLAN5", ("LD" + "-" + "9" + "-" + comboBox45.Text + "-" + DateTime.Now.ToString("MMyyyyHHmmss")));
                    cmd5.Parameters.AddWithValue("@MODEL_NAME5", comboBox45.Text);
                    cmd5.Parameters.AddWithValue("@QTY5", qty45);

                    cmd1.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                    cmd3.ExecuteNonQuery();
                    cmd4.ExecuteNonQuery();
                    cmd5.ExecuteNonQuery();

                    MessageBox.Show("Succesfully Saved");
                }
                else
                {
                    MessageBox.Show("Tolong Masukkan inputan Angka Pada kolom Qty");
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            Connection.Close();
            Console.ReadLine();
        }
        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.Open();

                if (int.TryParse(textBox46.Text, out int qty46) &&
                    int.TryParse(textBox47.Text, out int qty47) &&
                    int.TryParse(textBox48.Text, out int qty48) &&
                    int.TryParse(textBox49.Text, out int qty49) &&
                    int.TryParse(textBox50.Text, out int qty50))
                {
                    // Memasukkan data baru ke dalam tabel
                    SqlCommand cmd1 = new SqlCommand("INSERT INTO LDPLAN_TB(ID_LDPLAN, MODEL_NAME, QTY) VALUES(@ID_LDPLAN1, @MODEL_NAME1, @QTY1)", Connection);
                    cmd1.Parameters.AddWithValue("@ID_LDPLAN1", ("LD" + "-" + "10" + "-" + comboBox46.Text + "-" + DateTime.Now.ToString("MMyyyyHHmmss")));
                    cmd1.Parameters.AddWithValue("@MODEL_NAME1", comboBox46.Text);
                    cmd1.Parameters.AddWithValue("@QTY1", qty46);

                    SqlCommand cmd2 = new SqlCommand("INSERT INTO LDPLAN_TB(ID_LDPLAN, MODEL_NAME, QTY) VALUES(@ID_LDPLAN2, @MODEL_NAME2, @QTY2)", Connection);
                    cmd2.Parameters.AddWithValue("@ID_LDPLAN2", ("LD" + "-" + "10" + "-" + comboBox47.Text + "-" + DateTime.Now.ToString("MMyyyyHHmmss")));
                    cmd2.Parameters.AddWithValue("@MODEL_NAME2", comboBox47.Text);
                    cmd2.Parameters.AddWithValue("@QTY2", qty47);

                    SqlCommand cmd3 = new SqlCommand("INSERT INTO LDPLAN_TB(ID_LDPLAN, MODEL_NAME, QTY) VALUES(@ID_LDPLAN3, @MODEL_NAME3, @QTY3)", Connection);
                    cmd3.Parameters.AddWithValue("@ID_LDPLAN3", ("LD" + "-" + "10" + "-" + comboBox48.Text + "-" + DateTime.Now.ToString("MMyyyyHHmmss")));
                    cmd3.Parameters.AddWithValue("@MODEL_NAME3", comboBox48.Text);
                    cmd3.Parameters.AddWithValue("@QTY3", qty48);

                    SqlCommand cmd4 = new SqlCommand("INSERT INTO LDPLAN_TB(ID_LDPLAN, MODEL_NAME, QTY) VALUES(@ID_LDPLAN4, @MODEL_NAME4, @QTY4)", Connection);
                    cmd4.Parameters.AddWithValue("@ID_LDPLAN4", ("LD" + "-" + "10" + "-" + comboBox49.Text + "-" + DateTime.Now.ToString("MMyyyyHHmmss")));
                    cmd4.Parameters.AddWithValue("@MODEL_NAME4", comboBox49.Text);
                    cmd4.Parameters.AddWithValue("@QTY4", qty49);

                    SqlCommand cmd5 = new SqlCommand("INSERT INTO LDPLAN_TB(ID_LDPLAN, MODEL_NAME, QTY) VALUES(@ID_LDPLAN5, @MODEL_NAME5, @QTY5)", Connection);
                    cmd5.Parameters.AddWithValue("@ID_LDPLAN5", ("LD" + "-" + "10" + "-" + comboBox50.Text + "-" + DateTime.Now.ToString("MMyyyyHHmmss")));
                    cmd5.Parameters.AddWithValue("@MODEL_NAME5", comboBox50.Text);
                    cmd5.Parameters.AddWithValue("@QTY5", qty50);

                    cmd1.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                    cmd3.ExecuteNonQuery();
                    cmd4.ExecuteNonQuery();
                    cmd5.ExecuteNonQuery();

                    MessageBox.Show("Succesfully Saved");
                }
                else
                {
                    MessageBox.Show("Tolong Masukkan inputan Angka Pada kolom Qty");
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            Connection.Close();
            Console.ReadLine();
        }
        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.Open();

                if (int.TryParse(textBox51.Text, out int qty51) &&
                    int.TryParse(textBox52.Text, out int qty52) &&
                    int.TryParse(textBox53.Text, out int qty53) &&
                    int.TryParse(textBox54.Text, out int qty54) &&
                    int.TryParse(textBox55.Text, out int qty55))
                {
                    // Memasukkan data baru ke dalam tabel
                    SqlCommand cmd1 = new SqlCommand("INSERT INTO LDPLAN_TB(ID_LDPLAN, MODEL_NAME, QTY) VALUES(@ID_LDPLAN1, @MODEL_NAME1, @QTY1)", Connection);
                    cmd1.Parameters.AddWithValue("@ID_LDPLAN1", ("LD" + "-" + "11" + "-" + comboBox51.Text + "-" + DateTime.Now.ToString("MMyyyyHHmmss")));
                    cmd1.Parameters.AddWithValue("@MODEL_NAME1", comboBox51.Text);
                    cmd1.Parameters.AddWithValue("@QTY1", qty51);

                    SqlCommand cmd2 = new SqlCommand("INSERT INTO LDPLAN_TB(ID_LDPLAN, MODEL_NAME, QTY) VALUES(@ID_LDPLAN2, @MODEL_NAME2, @QTY2)", Connection);
                    cmd2.Parameters.AddWithValue("@ID_LDPLAN2", ("LD" + "-" + "11" + "-" + comboBox52.Text + "-" + DateTime.Now.ToString("MMyyyyHHmmss")));
                    cmd2.Parameters.AddWithValue("@MODEL_NAME2", comboBox52.Text);
                    cmd2.Parameters.AddWithValue("@QTY2", qty52);

                    SqlCommand cmd3 = new SqlCommand("INSERT INTO LDPLAN_TB(ID_LDPLAN, MODEL_NAME, QTY) VALUES(@ID_LDPLAN3, @MODEL_NAME3, @QTY3)", Connection);
                    cmd3.Parameters.AddWithValue("@ID_LDPLAN3", ("LD" + "-" + "11" + "-" + comboBox53.Text + "-" + DateTime.Now.ToString("MMyyyyHHmmss")));
                    cmd3.Parameters.AddWithValue("@MODEL_NAME3", comboBox53.Text);
                    cmd3.Parameters.AddWithValue("@QTY3", qty53);

                    SqlCommand cmd4 = new SqlCommand("INSERT INTO LDPLAN_TB(ID_LDPLAN, MODEL_NAME, QTY) VALUES(@ID_LDPLAN4, @MODEL_NAME4, @QTY4)", Connection);
                    cmd4.Parameters.AddWithValue("@ID_LDPLAN4", ("LD" + "-" + "11" + "-" + comboBox54.Text + "-" + DateTime.Now.ToString("MMyyyyHHmmss")));
                    cmd4.Parameters.AddWithValue("@MODEL_NAME4", comboBox54.Text);
                    cmd4.Parameters.AddWithValue("@QTY4", qty54);

                    SqlCommand cmd5 = new SqlCommand("INSERT INTO LDPLAN_TB(ID_LDPLAN, MODEL_NAME, QTY) VALUES(@ID_LDPLAN5, @MODEL_NAME5, @QTY5)", Connection);
                    cmd5.Parameters.AddWithValue("@ID_LDPLAN5", ("LD" + "-" + "11" + "-" + comboBox55.Text + "-" + DateTime.Now.ToString("MMyyyyHHmmss")));
                    cmd5.Parameters.AddWithValue("@MODEL_NAME5", comboBox55.Text);
                    cmd5.Parameters.AddWithValue("@QTY5", qty55);

                    cmd1.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                    cmd3.ExecuteNonQuery();
                    cmd4.ExecuteNonQuery();
                    cmd5.ExecuteNonQuery();

                    MessageBox.Show("Succesfully Saved");
                }
                else
                {
                    MessageBox.Show("Tolong Masukkan inputan Angka Pada kolom Qty");
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            Connection.Close();
            Console.ReadLine();
        }
        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.Open();

                if (int.TryParse(textBox56.Text, out int qty56) &&
                    int.TryParse(textBox57.Text, out int qty57) &&
                    int.TryParse(textBox58.Text, out int qty58) &&
                    int.TryParse(textBox59.Text, out int qty59) &&
                    int.TryParse(textBox60.Text, out int qty60))
                {
                    // Memasukkan data baru ke dalam tabel
                    SqlCommand cmd1 = new SqlCommand("INSERT INTO LDPLAN_TB(ID_LDPLAN, MODEL_NAME, QTY) VALUES(@ID_LDPLAN1, @MODEL_NAME1, @QTY1)", Connection);
                    cmd1.Parameters.AddWithValue("@ID_LDPLAN1", ("LD" + "-" + "12" + "-" + comboBox56.Text + "-" + DateTime.Now.ToString("MMyyyyHHmmss")));
                    cmd1.Parameters.AddWithValue("@MODEL_NAME1", comboBox56.Text);
                    cmd1.Parameters.AddWithValue("@QTY1", qty56);

                    SqlCommand cmd2 = new SqlCommand("INSERT INTO LDPLAN_TB(ID_LDPLAN, MODEL_NAME, QTY) VALUES(@ID_LDPLAN2, @MODEL_NAME2, @QTY2)", Connection);
                    cmd2.Parameters.AddWithValue("@ID_LDPLAN2", ("LD" + "-" + "12" + "-" + comboBox57.Text + "-" + DateTime.Now.ToString("MMyyyyHHmmss")));
                    cmd2.Parameters.AddWithValue("@MODEL_NAME2", comboBox57.Text);
                    cmd2.Parameters.AddWithValue("@QTY2", qty57);

                    SqlCommand cmd3 = new SqlCommand("INSERT INTO LDPLAN_TB(ID_LDPLAN, MODEL_NAME, QTY) VALUES(@ID_LDPLAN3, @MODEL_NAME3, @QTY3)", Connection);
                    cmd3.Parameters.AddWithValue("@ID_LDPLAN3", ("LD" + "-" + "12" + "-" + comboBox58.Text + "-" + DateTime.Now.ToString("MMyyyyHHmmss")));
                    cmd3.Parameters.AddWithValue("@MODEL_NAME3", comboBox58.Text);
                    cmd3.Parameters.AddWithValue("@QTY3", qty58);

                    SqlCommand cmd4 = new SqlCommand("INSERT INTO LDPLAN_TB(ID_LDPLAN, MODEL_NAME, QTY) VALUES(@ID_LDPLAN4, @MODEL_NAME4, @QTY4)", Connection);
                    cmd4.Parameters.AddWithValue("@ID_LDPLAN4", ("LD" + "-" + "12" + "-" + comboBox59.Text + "-" + DateTime.Now.ToString("MMyyyyHHmmss")));
                    cmd4.Parameters.AddWithValue("@MODEL_NAME4", comboBox59.Text);
                    cmd4.Parameters.AddWithValue("@QTY4", qty59);

                    SqlCommand cmd5 = new SqlCommand("INSERT INTO LDPLAN_TB(ID_LDPLAN, MODEL_NAME, QTY) VALUES(@ID_LDPLAN5, @MODEL_NAME5, @QTY5)", Connection);
                    cmd5.Parameters.AddWithValue("@ID_LDPLAN5", ("LD" + "-" + "12" + "-" + comboBox60.Text + "-" + DateTime.Now.ToString("MMyyyyHHmmss")));
                    cmd5.Parameters.AddWithValue("@MODEL_NAME5", comboBox60.Text);
                    cmd5.Parameters.AddWithValue("@QTY5", qty60);

                    cmd1.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                    cmd3.ExecuteNonQuery();
                    cmd4.ExecuteNonQuery();
                    cmd5.ExecuteNonQuery();

                    MessageBox.Show("Succesfully Saved");
                }
                else
                {
                    MessageBox.Show("Tolong Masukkan inputan Angka Pada kolom Qty");
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            Connection.Close();
            Console.ReadLine();
        }
        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.Open();

                if (int.TryParse(textBox61.Text, out int qty61) &&
                    int.TryParse(textBox62.Text, out int qty62) &&
                    int.TryParse(textBox63.Text, out int qty63) &&
                    int.TryParse(textBox64.Text, out int qty64) &&
                    int.TryParse(textBox65.Text, out int qty65))
                {
                    // Memasukkan data baru ke dalam tabel
                    SqlCommand cmd1 = new SqlCommand("INSERT INTO LDPLAN_TB(ID_LDPLAN, MODEL_NAME, QTY) VALUES(@ID_LDPLAN1, @MODEL_NAME1, @QTY1)", Connection);
                    cmd1.Parameters.AddWithValue("@ID_LDPLAN1", ("LD" + "-" + "13" + "-" + comboBox61.Text + "-" + DateTime.Now.ToString("MMyyyyHHmmss")));
                    cmd1.Parameters.AddWithValue("@MODEL_NAME1", comboBox61.Text);
                    cmd1.Parameters.AddWithValue("@QTY1", qty61);

                    SqlCommand cmd2 = new SqlCommand("INSERT INTO LDPLAN_TB(ID_LDPLAN, MODEL_NAME, QTY) VALUES(@ID_LDPLAN2, @MODEL_NAME2, @QTY2)", Connection);
                    cmd2.Parameters.AddWithValue("@ID_LDPLAN2", ("LD" + "-" + "13" + "-" + comboBox62.Text + "-" + DateTime.Now.ToString("MMyyyyHHmmss")));
                    cmd2.Parameters.AddWithValue("@MODEL_NAME2", comboBox62.Text);
                    cmd2.Parameters.AddWithValue("@QTY2", qty62);

                    SqlCommand cmd3 = new SqlCommand("INSERT INTO LDPLAN_TB(ID_LDPLAN, MODEL_NAME, QTY) VALUES(@ID_LDPLAN3, @MODEL_NAME3, @QTY3)", Connection);
                    cmd3.Parameters.AddWithValue("@ID_LDPLAN3", ("LD" + "-" + "13" + "-" + comboBox63.Text + "-" + DateTime.Now.ToString("MMyyyyHHmmss")));
                    cmd3.Parameters.AddWithValue("@MODEL_NAME3", comboBox63.Text);
                    cmd3.Parameters.AddWithValue("@QTY3", qty63);

                    SqlCommand cmd4 = new SqlCommand("INSERT INTO LDPLAN_TB(ID_LDPLAN, MODEL_NAME, QTY) VALUES(@ID_LDPLAN4, @MODEL_NAME4, @QTY4)", Connection);
                    cmd4.Parameters.AddWithValue("@ID_LDPLAN4", ("LD" + "-" + "13" + "-" + comboBox64.Text + "-" + DateTime.Now.ToString("MMyyyyHHmmss")));
                    cmd4.Parameters.AddWithValue("@MODEL_NAME4", comboBox64.Text);
                    cmd4.Parameters.AddWithValue("@QTY4", qty64);

                    SqlCommand cmd5 = new SqlCommand("INSERT INTO LDPLAN_TB(ID_LDPLAN, MODEL_NAME, QTY) VALUES(@ID_LDPLAN5, @MODEL_NAME5, @QTY5)", Connection);
                    cmd5.Parameters.AddWithValue("@ID_LDPLAN5", ("LD" + "-" + "13" + "-" + comboBox65.Text + "-" + DateTime.Now.ToString("MMyyyyHHmmss")));
                    cmd5.Parameters.AddWithValue("@MODEL_NAME5", comboBox65.Text);
                    cmd5.Parameters.AddWithValue("@QTY5", qty65);

                    cmd1.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                    cmd3.ExecuteNonQuery();
                    cmd4.ExecuteNonQuery();
                    cmd5.ExecuteNonQuery();

                    MessageBox.Show("Succesfully Saved");
                }
                else
                {
                    MessageBox.Show("Tolong Masukkan inputan Angka Pada kolom Qty");
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            Connection.Close();
            Console.ReadLine();
        }
        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.Open();

                if (int.TryParse(textBox66.Text, out int qty66) &&
                    int.TryParse(textBox67.Text, out int qty67) &&
                    int.TryParse(textBox68.Text, out int qty68) &&
                    int.TryParse(textBox69.Text, out int qty69) &&
                    int.TryParse(textBox70.Text, out int qty70))
                {
                    // Memasukkan data baru ke dalam tabel
                    SqlCommand cmd1 = new SqlCommand("INSERT INTO LDPLAN_TB(ID_LDPLAN, MODEL_NAME, QTY) VALUES(@ID_LDPLAN1, @MODEL_NAME1, @QTY1)", Connection);
                    cmd1.Parameters.AddWithValue("@ID_LDPLAN1", ("LD" + "-" + "14" + "-" + comboBox66.Text + "-" + DateTime.Now.ToString("MMyyyyHHmmss")));
                    cmd1.Parameters.AddWithValue("@MODEL_NAME1", comboBox66.Text);
                    cmd1.Parameters.AddWithValue("@QTY1", qty66);

                    SqlCommand cmd2 = new SqlCommand("INSERT INTO LDPLAN_TB(ID_LDPLAN, MODEL_NAME, QTY) VALUES(@ID_LDPLAN2, @MODEL_NAME2, @QTY2)", Connection);
                    cmd2.Parameters.AddWithValue("@ID_LDPLAN2", ("LD" + "-" + "14" + "-" + comboBox67.Text + "-" + DateTime.Now.ToString("MMyyyyHHmmss")));
                    cmd2.Parameters.AddWithValue("@MODEL_NAME2", comboBox67.Text);
                    cmd2.Parameters.AddWithValue("@QTY2", qty67);

                    SqlCommand cmd3 = new SqlCommand("INSERT INTO LDPLAN_TB(ID_LDPLAN, MODEL_NAME, QTY) VALUES(@ID_LDPLAN3, @MODEL_NAME3, @QTY3)", Connection);
                    cmd3.Parameters.AddWithValue("@ID_LDPLAN3", ("LD" + "-" + "14" + "-" + comboBox68.Text + "-" + DateTime.Now.ToString("MMyyyyHHmmss")));
                    cmd3.Parameters.AddWithValue("@MODEL_NAME3", comboBox68.Text);
                    cmd3.Parameters.AddWithValue("@QTY3", qty68);

                    SqlCommand cmd4 = new SqlCommand("INSERT INTO LDPLAN_TB(ID_LDPLAN, MODEL_NAME, QTY) VALUES(@ID_LDPLAN4, @MODEL_NAME4, @QTY4)", Connection);
                    cmd4.Parameters.AddWithValue("@ID_LDPLAN4", ("LD" + "-" + "14" + "-" + comboBox69.Text + "-" + DateTime.Now.ToString("MMyyyyHHmmss")));
                    cmd4.Parameters.AddWithValue("@MODEL_NAME4", comboBox69.Text);
                    cmd4.Parameters.AddWithValue("@QTY4", qty69);

                    SqlCommand cmd5 = new SqlCommand("INSERT INTO LDPLAN_TB(ID_LDPLAN, MODEL_NAME, QTY) VALUES(@ID_LDPLAN5, @MODEL_NAME5, @QTY5)", Connection);
                    cmd5.Parameters.AddWithValue("@ID_LDPLAN5", ("LD" + "-" + "14" + "-" + comboBox70.Text + "-" + DateTime.Now.ToString("MMyyyyHHmmss")));
                    cmd5.Parameters.AddWithValue("@MODEL_NAME5", comboBox70.Text);
                    cmd5.Parameters.AddWithValue("@QTY5", qty70);

                    cmd1.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                    cmd3.ExecuteNonQuery();
                    cmd4.ExecuteNonQuery();
                    cmd5.ExecuteNonQuery();

                    MessageBox.Show("Succesfully Saved");
                }
                else
                {
                    MessageBox.Show("Tolong Masukkan inputan Angka Pada kolom Qty");
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            Connection.Close();
            Console.ReadLine();
        }
        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.Open();

                if (int.TryParse(textBox71.Text, out int qty71) &&
                    int.TryParse(textBox72.Text, out int qty72) &&
                    int.TryParse(textBox73.Text, out int qty73) &&
                    int.TryParse(textBox74.Text, out int qty74) &&
                    int.TryParse(textBox75.Text, out int qty75))
                {
                    // Memasukkan data baru ke dalam tabel
                    SqlCommand cmd1 = new SqlCommand("INSERT INTO LDPLAN_TB(ID_LDPLAN, MODEL_NAME, QTY) VALUES(@ID_LDPLAN1, @MODEL_NAME1, @QTY1)", Connection);
                    cmd1.Parameters.AddWithValue("@ID_LDPLAN1", ("LD" + "-" + "15" + "-" + comboBox71.Text + "-" + DateTime.Now.ToString("MMyyyyHHmmss")));
                    cmd1.Parameters.AddWithValue("@MODEL_NAME1", comboBox71.Text);
                    cmd1.Parameters.AddWithValue("@QTY1", qty71);

                    SqlCommand cmd2 = new SqlCommand("INSERT INTO LDPLAN_TB(ID_LDPLAN, MODEL_NAME, QTY) VALUES(@ID_LDPLAN2, @MODEL_NAME2, @QTY2)", Connection);
                    cmd2.Parameters.AddWithValue("@ID_LDPLAN2", ("LD" + "-" + "15" + "-" + comboBox72.Text + "-" + DateTime.Now.ToString("MMyyyyHHmmss")));
                    cmd2.Parameters.AddWithValue("@MODEL_NAME2", comboBox72.Text);
                    cmd2.Parameters.AddWithValue("@QTY2", qty72);

                    SqlCommand cmd3 = new SqlCommand("INSERT INTO LDPLAN_TB(ID_LDPLAN, MODEL_NAME, QTY) VALUES(@ID_LDPLAN3, @MODEL_NAME3, @QTY3)", Connection);
                    cmd3.Parameters.AddWithValue("@ID_LDPLAN3", ("LD" + "-" + "15" + "-" + comboBox73.Text + "-" + DateTime.Now.ToString("MMyyyyHHmmss")));
                    cmd3.Parameters.AddWithValue("@MODEL_NAME3", comboBox73.Text);
                    cmd3.Parameters.AddWithValue("@QTY3", qty73);

                    SqlCommand cmd4 = new SqlCommand("INSERT INTO LDPLAN_TB(ID_LDPLAN, MODEL_NAME, QTY) VALUES(@ID_LDPLAN4, @MODEL_NAME4, @QTY4)", Connection);
                    cmd4.Parameters.AddWithValue("@ID_LDPLAN4", ("LD" + "-" + "15" + "-" + comboBox74.Text + "-" + DateTime.Now.ToString("MMyyyyHHmmss")));
                    cmd4.Parameters.AddWithValue("@MODEL_NAME4", comboBox74.Text);
                    cmd4.Parameters.AddWithValue("@QTY4", qty74);

                    SqlCommand cmd5 = new SqlCommand("INSERT INTO LDPLAN_TB(ID_LDPLAN, MODEL_NAME, QTY) VALUES(@ID_LDPLAN5, @MODEL_NAME5, @QTY5)", Connection);
                    cmd5.Parameters.AddWithValue("@ID_LDPLAN5", ("LD" + "-" + "15" + "-" + comboBox75.Text + "-" + DateTime.Now.ToString("MMyyyyHHmmss")));
                    cmd5.Parameters.AddWithValue("@MODEL_NAME5", comboBox75.Text);
                    cmd5.Parameters.AddWithValue("@QTY5", qty75);

                    cmd1.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                    cmd3.ExecuteNonQuery();
                    cmd4.ExecuteNonQuery();
                    cmd5.ExecuteNonQuery();

                    MessageBox.Show("Succesfully Saved");
                }
                else
                {
                    MessageBox.Show("Tolong Masukkan inputan Angka Pada kolom Qty");
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            Connection.Close();
            Console.ReadLine();
        }
// ============================================================================================== Button SUBMIT Sesuai dengan Loading Plan =====================================================================================================================================================

// ========================================================================================================== Dropdown Value ===================================================================================================================================================================
        private void FillComboBox()
        {
            string connectionString = @"Server=tcp:finishgood-server.database.windows.net,1433;Initial Catalog=FINISHGOOD_DB;Persist Security Info=False;User ID=azima;Password=Jima2003;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            // Ganti NamaServer dan NamaDatabase dengan nilai yang sesuai.

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT MODEL_NAME FROM MODEL_TB";
                // Ganti NamaKolom dengan nama kolom yang ingin Anda tampilkan di ComboBox.
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        comboBox1.Items.Add(reader["MODEL_NAME"].ToString());
                        comboBox2.Items.Add(reader["MODEL_NAME"].ToString());
                        comboBox3.Items.Add(reader["MODEL_NAME"].ToString());
                        comboBox4.Items.Add(reader["MODEL_NAME"].ToString());
                        comboBox5.Items.Add(reader["MODEL_NAME"].ToString());
                        comboBox6.Items.Add(reader["MODEL_NAME"].ToString());
                        comboBox7.Items.Add(reader["MODEL_NAME"].ToString());
                        comboBox8.Items.Add(reader["MODEL_NAME"].ToString());
                        comboBox9.Items.Add(reader["MODEL_NAME"].ToString());
                        comboBox10.Items.Add(reader["MODEL_NAME"].ToString());
                        comboBox11.Items.Add(reader["MODEL_NAME"].ToString());
                        comboBox12.Items.Add(reader["MODEL_NAME"].ToString());
                        comboBox13.Items.Add(reader["MODEL_NAME"].ToString());
                        comboBox14.Items.Add(reader["MODEL_NAME"].ToString());
                        comboBox15.Items.Add(reader["MODEL_NAME"].ToString());
                        comboBox16.Items.Add(reader["MODEL_NAME"].ToString());
                        comboBox17.Items.Add(reader["MODEL_NAME"].ToString());
                        comboBox18.Items.Add(reader["MODEL_NAME"].ToString());
                        comboBox19.Items.Add(reader["MODEL_NAME"].ToString());
                        comboBox20.Items.Add(reader["MODEL_NAME"].ToString());
                        comboBox21.Items.Add(reader["MODEL_NAME"].ToString());
                        comboBox22.Items.Add(reader["MODEL_NAME"].ToString());
                        comboBox23.Items.Add(reader["MODEL_NAME"].ToString());
                        comboBox24.Items.Add(reader["MODEL_NAME"].ToString());
                        comboBox25.Items.Add(reader["MODEL_NAME"].ToString());
                        comboBox26.Items.Add(reader["MODEL_NAME"].ToString());
                        comboBox27.Items.Add(reader["MODEL_NAME"].ToString());
                        comboBox28.Items.Add(reader["MODEL_NAME"].ToString());
                        comboBox29.Items.Add(reader["MODEL_NAME"].ToString());
                        comboBox30.Items.Add(reader["MODEL_NAME"].ToString());
                        comboBox31.Items.Add(reader["MODEL_NAME"].ToString());
                        comboBox32.Items.Add(reader["MODEL_NAME"].ToString());
                        comboBox33.Items.Add(reader["MODEL_NAME"].ToString());
                        comboBox34.Items.Add(reader["MODEL_NAME"].ToString());
                        comboBox35.Items.Add(reader["MODEL_NAME"].ToString());
                        comboBox36.Items.Add(reader["MODEL_NAME"].ToString());
                        comboBox37.Items.Add(reader["MODEL_NAME"].ToString());
                        comboBox38.Items.Add(reader["MODEL_NAME"].ToString());
                        comboBox39.Items.Add(reader["MODEL_NAME"].ToString());
                        comboBox40.Items.Add(reader["MODEL_NAME"].ToString());
                        comboBox41.Items.Add(reader["MODEL_NAME"].ToString());
                        comboBox42.Items.Add(reader["MODEL_NAME"].ToString());
                        comboBox43.Items.Add(reader["MODEL_NAME"].ToString());
                        comboBox44.Items.Add(reader["MODEL_NAME"].ToString());
                        comboBox45.Items.Add(reader["MODEL_NAME"].ToString());
                        comboBox46.Items.Add(reader["MODEL_NAME"].ToString());
                        comboBox47.Items.Add(reader["MODEL_NAME"].ToString());
                        comboBox48.Items.Add(reader["MODEL_NAME"].ToString());
                        comboBox49.Items.Add(reader["MODEL_NAME"].ToString());
                        comboBox50.Items.Add(reader["MODEL_NAME"].ToString());
                        comboBox51.Items.Add(reader["MODEL_NAME"].ToString());
                        comboBox52.Items.Add(reader["MODEL_NAME"].ToString());
                        comboBox53.Items.Add(reader["MODEL_NAME"].ToString());
                        comboBox54.Items.Add(reader["MODEL_NAME"].ToString());
                        comboBox55.Items.Add(reader["MODEL_NAME"].ToString());
                        comboBox56.Items.Add(reader["MODEL_NAME"].ToString());
                        comboBox57.Items.Add(reader["MODEL_NAME"].ToString());
                        comboBox58.Items.Add(reader["MODEL_NAME"].ToString());
                        comboBox59.Items.Add(reader["MODEL_NAME"].ToString());
                        comboBox60.Items.Add(reader["MODEL_NAME"].ToString());
                        comboBox61.Items.Add(reader["MODEL_NAME"].ToString());
                        comboBox62.Items.Add(reader["MODEL_NAME"].ToString());
                        comboBox63.Items.Add(reader["MODEL_NAME"].ToString());
                        comboBox64.Items.Add(reader["MODEL_NAME"].ToString());
                        comboBox65.Items.Add(reader["MODEL_NAME"].ToString());
                        comboBox66.Items.Add(reader["MODEL_NAME"].ToString());
                        comboBox67.Items.Add(reader["MODEL_NAME"].ToString());
                        comboBox68.Items.Add(reader["MODEL_NAME"].ToString());
                        comboBox69.Items.Add(reader["MODEL_NAME"].ToString());
                        comboBox70.Items.Add(reader["MODEL_NAME"].ToString());
                        comboBox71.Items.Add(reader["MODEL_NAME"].ToString());
                        comboBox72.Items.Add(reader["MODEL_NAME"].ToString());
                        comboBox73.Items.Add(reader["MODEL_NAME"].ToString());
                        comboBox74.Items.Add(reader["MODEL_NAME"].ToString());
                        comboBox75.Items.Add(reader["MODEL_NAME"].ToString());
                    }

                    reader.Close();
                }
            }
        }
// ========================================================================================================== Dropdown Value ===================================================================================================================================================================

        private void fgcb()
        {
            //koneksi.Open();
            //SqlCommand cmd = new SqlCommand("Select count(ID) from [tblmod3]", koneksi);
            //int i = Convert.ToInt32(cmd.ExecuteScalar());
            //koneksi.Close();
            //i++;
            //labelID.Text = val + i.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //fgcb();
        }

        private void textBox74_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
