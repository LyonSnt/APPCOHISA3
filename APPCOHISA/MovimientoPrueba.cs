using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APPCOHISA
{
    public partial class MovimientoPrueba : Form
    {
        public MovimientoPrueba()
        {
            InitializeComponent();
        }

        private void lstMovimiento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnMovimiento_Click(object sender, EventArgs e)
        {
            string s1 = "Este ese la varia s1 ";
            string s2 = "esta es la variable s2";



            // Concatenate s1 and s2. This actually creates a new
            // string object and stores it in s1, releasing the
            // reference to the original object.

          //  s1 += s2;   //es lo mismo
            string  so = s1 + s2;

            // txtMovimiento.Text = Convert.ToString(result);

            txtMovimiento.Text = so;

            

            //  System.Console.WriteLine(s1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int counter = 0;
            string line;
            string palabra;

            Stack miPila = new Stack();
            miPila.Push("hola");
            miPila.Push("buenos");
            miPila.Push("días");

            // Read the file and display it line by line.  
           StreamReader file = new StreamReader(@"E:\test.txt");
         //   while ((line = file.ReadLine()) != null)
          //  {
                miPila.Push(file);
              

                for (byte i = 0; i < miPila.Count; i++)
                {
                    palabra = (string)miPila.Pop();
                    Console.WriteLine(palabra);
                    // textBox2.Text = palabra;
                    lstMovimiento.Items.Add(palabra);
                }
              //  Console.WriteLine(line);

                // textBox1.Text += line;
               // textBox1.Text += line;
                //lstMovimiento.Items.Add(line);
                //counter++;

               // textbox.Text = array[0] + "\r\n" + variable;
           // }

           // file.Close();
          //Console.WriteLine("Tiene {0} lineas.", counter);
            //textBox2.Text = "Tiene: "+ Convert.ToString(counter) + " lineas";
            // Suspend the screen.  
          //  Console.ReadLine();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string palabra;

            Stack miPila = new Stack();
            miPila.Push("hola");
            miPila.Push("buenos");
            miPila.Push("días");

            for (byte i = 0; i < 3; i++)
            {
                palabra = (string)miPila.Pop();
                Console.WriteLine(palabra);
               // textBox2.Text = palabra;
                lstMovimiento.Items.Add(palabra);
            }

            //  Console.ReadKey();

            string s = "for break 10.14";
          //  StreamReader file = new StreamReader(@"E:\test.txt");
            for (int i = 0; i < s.Length; i++)
                Console.WriteLine(s[i]);



        }

        private void button3_Click(object sender, EventArgs e)
        {

            string line;
            StreamReader r = new StreamReader(@"E:\test.txt");
            line = r.ReadToEnd();
            for (int i = 0; i < line.Length; i++)
            {
                tablamovi.Rows.Add(line[i]);

                lstMovimiento.Items.Add(line[i]);

            }



            r.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StreamReader fichero;
            string linea;

            fichero = File.OpenText(@"E:\test.txt");
            linea = fichero.ReadToEnd();
            for (int i = 0; i < linea.Length; i++)
            {
                 lstMovimiento.Items.Add(linea[i]);
                tablamovi.Rows.Add(linea[i]);
            }
           // fichero.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //DataTable dt = new DataTable();
            string m = txtMovimiento.Text;

            tablamovi.Rows.Add(m);
//tablamovi.DataSource = dt.Rows.Add(m);
            // this.tablamovi.DataSource = m;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (StreamReader reader = new StreamReader(@"E:\test.txt"))
            {
                while (true)
                {
                    string line = reader.ReadToEnd();
                    if (line == null)
                    {
                        break;
                    }
                    Console.WriteLine(line); // Use line.
                    tablamovi.Rows.Add(line);
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
           StreamReader file = new StreamReader(@"E:\test.txt");
            string[] columnnames = file.ReadLine().Split(' ');
            DataTable dt = new DataTable();
            foreach (string c in columnnames)
            {
                dt.Columns.Add(c);
            }
            string newline;
            while ((newline = file.ReadLine()) != null)
            {
                DataRow dr = dt.NewRow();
                string[] values = newline.Split(' ');
                for (int i = 0; i < values.Length; i++)
                {
                    dr[i] = values[i];
                }
                dt.Rows.Add(dr);
            }
            file.Close();
            dataGridView1.DataSource = dt;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // declara tu string
            string s = "hello";

            // utilizamos un hastable para almazenar los singulos
            // char que forman nuestra string

            Hashtable chars = new Hashtable();

            // por todos los char que estan en string....

            foreach (char c in s)
            {
                // si no estan en nuestra base de datos lo añadimo con valor 1

                if (!chars.Contains(c)) chars.Add(c, 1);
                else
                {

                    // si ya existe en nuestra base de datos,
                    // leemos el valor actual y lo incrementamos...

                    int p = (int)chars[c];
                    chars[c] = ++p;
                }
            }

            // visualizamos el resultado
            foreach (char c in chars.Keys)
            {
                Console.WriteLine("chart {0}\t{1}", c, chars[c]);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string bin = "100011";
           bin = bin.Substring(bin.Length - 4, 4);
           Console.WriteLine(bin);

            
        }

        private void button10_Click(object sender, EventArgs e)
        {

            string line;
            StreamReader r = new StreamReader(@"E:\test.txt");
            line = r.ReadToEnd();
            var chars = line.ToCharArray();
            int ctr;
           // for (int count = 1; count < chars.Length; count++)
            
                for (ctr = 0; ctr < chars.Length; ctr++)
                    tablamovi.Rows.Add(ctr, chars[ctr], ctr+1);
            
            r.Close();
        }
    }
}
