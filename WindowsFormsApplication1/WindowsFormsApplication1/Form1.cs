using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textLe_Click(object sender, EventArgs e)
        {
            String A = textBox1.Text;
            string[,] MultiLetters = new string[5, 5]{
                {A, "", "", "", "",},
                {A, A, "", "", "",},
                {A, A, A, "", "",},
                {A, A, A, A, "",},
                {A, A, A, A, A,},
            };

            string[] Letters = new string[5];
            Letters[0] = MultiLetters[0, 0];
            Letters[1] = MultiLetters[1, 0] + MultiLetters[1, 1];
            Letters[2] = MultiLetters[2, 0] + MultiLetters[2, 1] + MultiLetters[2, 2];
            Letters[3] = MultiLetters[3, 0] + MultiLetters[3, 1] + MultiLetters[3, 2] + MultiLetters[3, 3];
            Letters[4] = MultiLetters[4, 0] + MultiLetters[4, 1] + MultiLetters[4, 2] + MultiLetters[4, 3] + MultiLetters[4, 4];


            MessageBox.Show(Letters[0] + "\n" + Letters[1] + "\n" + Letters[2] + "\n" + Letters[3] + "\n" + Letters[4]);
 
        }

    }
}
