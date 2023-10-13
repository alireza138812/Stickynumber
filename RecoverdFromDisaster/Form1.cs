using System.ComponentModel.Design.Serialization;
using System.Drawing.Text;
using System.Security.Cryptography.Pkcs;
using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;
using Microsoft.VisualBasic;
using System.Data.SQLite;
using System.Drawing;
using Microsoft.Data.Sqlite;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public int randnum;



        public Form1()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show("A game which is created by alireza138812 ,Select a range , than find the random number!, be update to date : github.com/alireza138812");

        }

        public void Form1_Load(object sender, EventArgs e)
        {

            textBox3.AppendText("Not Defind");



        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        public int input3;
        public void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string input1 = Interaction.InputBox("From 0 to :", "Range");
            int input2 = Convert.ToInt32(input1);

            int rnum = rnd.Next(1, input2);
            randnum = rnum;
            input3 = input2;
            textBox3.Clear();
            textBox3.AppendText(input3.ToString());




        }

        public static Random rnd = new Random();
        public static int A = 0;
        private void rerangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (input3 == 0)
            {
                MessageBox.Show("Define a range first , From Options -> Range");
            }
            else
            {
                int rnum = rnd.Next(1, input3);
                randnum = rnum;
            }

        }
        public void button2_Click(object sender, EventArgs e)
        {

            string cs = @"URI=file:records.db";
            using var connection = new SQLiteConnection(cs);
            connection.Open();
            using var command = new SQLiteCommand(connection);




            string nums = textBox1.Text;
            int num = Convert.ToInt32(nums);
            if (randnum == 0)
            {
                MessageBox.Show("Hey Please Define a Range first , From options -> Range");
            }
            else if (num > randnum)
            {
                MessageBox.Show("Your number is bigger");
                textBox2.AppendText("Your Number is bigger");
                A = A + 1;
            }
            else if (num < randnum)
            {
                MessageBox.Show("Your number is smaller");
                textBox2.AppendText("Your Number is Smaller");
                A = A + 1;


            }
            else if (num == randnum)
            {
                string B = A.ToString();
                MessageBox.Show(B, "You winned!  Score :");
                command.CommandText = @$"INSERT INTO record(rec) VALUES({A})";
                command.ExecuteNonQuery();
                //command.CommandText = $@"CREATE TABLE rec(id int , records int)";
                //command.ExecuteNonQuery();
                
            }

            
        
        }
        
    public void button4_Click(object sender, EventArgs e)
        {

        }

        public void button3_Click(object sender, EventArgs e)
        {

        }



        public void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A game by alireza138812 , Get latest version and help at : github.com/alireza138812 , StickyNumber");
        }

        private void cheatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (randnum == 0)
            {
                MessageBox.Show("Hehe , Define a Range first! from optios -> Range");
            }
            else
                MessageBox.Show(randnum.ToString(), "Cheater!");
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void userManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            string cs = @"URI=file:records.db";
            using var connection = new SQLiteConnection(cs);
            connection.Open();
            using var command = new SQLiteCommand(connection);
            command.CommandText = @"SELECT rec FROM record";
            command.ExecuteNonQuery();
            SQLiteDataReader reader = command.ExecuteReader();
            reader.Read();
            int A = reader.GetInt32(0);
            MessageBox.Show(A.ToString());
            




        }
    }
}