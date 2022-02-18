using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 

namespace culc
{
    public partial class Form1 : Form
    {
        int left = 0;
        int right = 0;
        int opr = 1;
        int oprc = 1;
        int ans = 0;
        int opcid = 0;
        int endcode = 0;
        public Form1()
        {
            InitializeComponent();
            
        }
        public void textgoleft()
        {
            textBox1.Text = String.Format("{0:d}", left);
        }
        public void textgoright()
        {
            textBox1.Text = String.Format("{0:d}", right);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            switch (opr)
            {
                case 1:
                    switch (oprc)
                    {
                        case 1:
                            left += 1;
                            textgoleft();
                            break;
                        case 2:
                            left += 10;
                            textgoleft();
                            break;
                        case 3:
                            left += 100;
                            textgoleft();
                            break;
                        case 4:
                            left += 1000;
                            textgoleft();
                            break;
                        case 5:
                            left += 10000;
                            textgoleft();
                            break;
                    }
                    break;
                case 2:
                    switch (oprc)
                    {
                        case 1:
                            right += 1;
                            textgoright();
                            break;
                        case 2:
                            right += 10;
                            textgoright();
                            break;
                        case 3:
                            right += 100;
                            textgoright();
                            break;
                        case 4:
                            right += 1000;
                            textgoright();
                            break;
                        case 5:
                            right += 10000;
                            textgoright();
                            break;
                    }
                    break;
                    
            }
            oprc++;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            switch (opcid) 
            {
                case 1:
                    ans = left + right;
                    break;
                case 2:
                    ans = left - right;
                    break;
                case 3:
                    ans = left * right;
                    break;
                case 4:
                    ans = left / right;
                    break;
                    
            }
            textBox1.Text = String.Format("{0:d}", ans);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            switch (opr)
            {
                case 1:
                    switch (oprc)
                    {
                        case 1:
                            left += 2;
                            textgoleft();
                            break;
                        case 2:
                            left += 20;
                            textgoleft();
                            break;
                        case 3:
                            left += 200;
                            textgoleft();
                            break;
                        case 4:
                            left += 2000;
                            textgoleft();
                            break;
                        case 5:
                            left += 20000;
                            textgoleft();
                            break;
                    }
                    break;
                case 2:
                    switch (oprc)
                    {
                        case 1:
                            right += 2;
                            textgoright();
                            break;
                        case 2:
                            right += 20;
                            textgoright();
                            break;
                        case 3:
                            right += 200;
                            textgoright();
                            break;
                        case 4:
                            right += 2000;
                            textgoright();
                            break;
                        case 5:
                            right += 20000;
                            textgoright();
                            break;
                    }
                    break;
            }
            oprc++;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            switch (opr)
            {
                case 1:
                    switch (oprc)
                    {
                        case 1:
                            left += 3;
                            textgoleft();
                            break;
                        case 2:
                            left += 30;
                            textgoleft();
                            break;
                        case 3:
                            left += 300;
                            textgoleft();
                            break;
                        case 4:
                            left += 3000;
                            textgoleft();
                            break;
                        case 5:
                            left += 30000;
                            textgoleft();
                            break;
                    }
                    break;
                case 2:
                    switch (oprc)
                    {
                        case 1:
                            right += 3;
                            textgoright();
                            break;
                        case 2:
                            right += 30;
                            textgoright();
                            break;
                        case 3:
                            right += 300;
                            textgoright();
                            break;
                        case 4:
                            right += 3000;
                            textgoright();
                            break;
                        case 5:
                            right += 30000;
                            textgoright();
                            break;
                    }
                    break;
            }
            oprc++;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            switch (opr)
            {
                case 1:
                    switch (oprc)
                    {
                        case 1:
                            left += 4;
                            textgoleft();
                            break;
                        case 2:
                            left += 40;
                            textgoleft();
                            break;
                        case 3:
                            left += 400;
                            textgoleft();
                            break;
                        case 4:
                            left += 4000;
                            textgoleft();
                            break;
                        case 5:
                            left += 40000;
                            textgoleft();
                            break;
                    }
                    break;
                case 2:
                    switch (oprc)
                    {
                        case 1:
                            right += 4;
                            textgoright();
                            break;
                        case 2:
                            right += 40;
                            textgoright();
                            break;
                        case 3:
                            right += 400;
                            textgoright();
                            break;
                        case 4:
                            right += 4000;
                            textgoright();
                            break;
                        case 5:
                            right += 40000;
                            textgoright();
                            break;
                    }
                    break;
            }
            oprc++;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            switch (opr)
            {
                case 1:
                    switch (oprc)
                    {
                        case 1:
                            left += 5;
                            textgoleft();
                            break;
                        case 2:
                            left += 50;
                            textgoleft();
                            break;
                        case 3:
                            left += 500;
                            textgoleft();
                            break;
                        case 4:
                            left += 5000;
                            textgoleft();
                            break;
                        case 5:
                            left += 50000;
                            textgoleft();
                            break;
                    }
                    break;
                case 2:
                    switch (oprc)
                    {
                        case 1:
                            right += 5;
                            textgoright();
                            break;
                        case 2:
                            right += 50;
                            textgoright();
                            break;
                        case 3:
                            right += 500;
                            textgoright();
                            break;
                        case 4:
                            right += 5000;
                            textgoright();
                            break;
                        case 5:
                            right += 50000;
                            textgoright();
                            break;
                    }
                    break;
            }
            oprc++;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            switch (opr)
            {
                case 1:
                    switch (oprc)
                    {
                        case 1:
                            left += 6;
                            textgoleft();
                            break;
                        case 2:
                            left += 60;
                            textgoleft();
                            break;
                        case 3:
                            left += 600;
                            textgoleft();
                            break;
                        case 4:
                            left += 6000;
                            textgoleft();
                            break;
                        case 5:
                            left += 60000;
                            textgoleft();
                            break;
                    }
                    break;
                case 2:
                    switch (oprc)
                    {
                        case 1:
                            right += 6;
                            textgoright();
                            break;
                        case 2:
                            right += 60;
                            textgoright();
                            break;
                        case 3:
                            right += 600;
                            textgoright();
                            break;
                        case 4:
                            right += 6000;
                            textgoright();
                            break;
                        case 5:
                            right += 60000;
                            textgoright();
                            break;
                            
                    }
                    break;
            }
            oprc++;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            switch (opr)
            {
                case 1:
                    switch (oprc)
                    {
                        case 1:
                            left += 7;
                            textgoleft();
                            break;
                        case 2:
                            left += 70;
                            textgoleft();
                            break;
                        case 3:
                            left += 700;
                            textgoleft();
                            break;
                        case 4:
                            left += 7000;
                            textgoleft();
                            break;
                        case 5:
                            left += 70000;
                            textgoleft();
                            break;
                    }
                    break;
                case 2:
                    switch (oprc)
                    {
                        case 1:
                            right += 7;
                            textgoright();
                            break;
                        case 2:
                            right += 70;
                            textgoright();
                            break;
                        case 3:
                            right += 700;
                            textgoright();
                            break;
                        case 4:
                            right += 7000;
                            textgoright();
                            break;
                        case 5:
                            right += 70000;
                            textgoright();
                            break;
                    }
                    break;
            }
            oprc++;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            switch (opr)
            {
                case 1:
                    switch (oprc)
                    {
                        case 1:
                            left += 8;
                            textgoleft();
                            break;
                        case 2:
                            left += 80;
                            textgoleft();
                            break;
                        case 3:
                            left += 800;
                            textgoleft();
                            break;
                        case 4:
                            left += 8000;
                            textgoleft();
                            break;
                        case 5:
                            left += 80000;
                            textgoleft();
                            break;
                    }
                    break;
                case 2:
                    switch (oprc)
                    {
                        case 1:
                            right += 8;
                            textgoright();
                            break;
                        case 2:
                            right += 80;
                            textgoright();
                            break;
                        case 3:
                            right += 800;
                            textgoright();
                            break;
                        case 4:
                            right += 8000;
                            textgoright();
                            break;
                        case 5:
                            right += 80000;
                            textgoright();
                            break;
                    }
                    break;
            }
            oprc++;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            switch (opr)
            {
                case 1:
                    switch (oprc)
                    {
                        case 1:
                            left += 9;
                            textgoleft();
                            break;
                        case 2:
                            left += 90;
                            textgoleft();
                            break;
                        case 3:
                            left += 900;
                            textgoleft();
                            break;
                        case 4:
                            left += 9000;
                            textgoleft();
                            break;
                        case 5:
                            left += 90000;
                            textgoleft();
                            break;
                    }
                    break;
                case 2:
                    switch (oprc)
                    {
                        case 1:
                            right += 9;
                            textgoright();
                            break;
                        case 2:
                            right += 90;
                            textgoright();
                            break;
                        case 3:
                            right += 900;
                            textgoright();
                            break;
                        case 4:
                            right += 9000;
                            textgoright();
                            break;
                        case 5:
                            right += 90000;
                            textgoright();
                            break;
                    }
                    break;
            }
            oprc++;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            switch (opr)
            {
                case 1:
                    oprc++;
                    break;
                case 2:
                    oprc++;
                    break;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            opr = 2;
            oprc = 1;
            opcid = 1;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            oprc = 1;
            opr++;
            opcid = 2;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            opr = 2;
            oprc = 1;
            opcid = 3;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            opr = 2;
            oprc = 1;
            opcid = 4;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            endcode++;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            left = 0;
            
            right = 0;
            
            opr = 1;
            
            oprc = 1;
            
            ans = 0;
            
            opcid = 0;
           
            endcode = 0;
        }

        
    }

    
}
