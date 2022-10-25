using static System.Net.Mime.MediaTypeNames;

namespace Pw_Lab3
{
    public partial class Form1 : Form
    {
        public static string Tytu速ext, Autortext;
        public static int IDtext;
        public static string csv,csv2;

        public Form1()
        {
            InitializeComponent();
            IDtext = 1;
            Tytu速ext = "";
            Autortext = "";
            csv = "";
            csv2 = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
            dataGridView1.Rows.Add(Tytu速ext,Autortext,IDtext);
            csv = csv + Tytu速ext + ","+ Autortext + "," + IDtext.ToString()+ System.Environment.NewLine;
            IDtext++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            File.WriteAllTextAsync("Zapisanyplik.csv", csv);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader(@"C:\Users\mikol\source\repos\Pw-Lab3\bin\Debug\net6.0-windows\Zapisanyplik.csv"))
            {
                String str;
                String[] array;
                while((str = sr.ReadLine()) != null && str !="")
                {
                    csv2 = csv2 + str; 
                    array=str.Split(',');
                    Tytu速ext = array[0];
                    Autortext = array[1];
                    IDtext = Int32.Parse(array[2]);
                    dataGridView1.Rows.Add(Tytu速ext, Autortext, IDtext);
                }                               
            }
            
            
        }
    }
}