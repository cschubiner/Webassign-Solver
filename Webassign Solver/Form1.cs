using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Webassign_Solver
{
    public partial class Form1 : Form
    {

        practiceproblems[] problems;
        int numofequations;

        public Form1()
        {
            problems = new practiceproblems[2];
            for (int i = 0; i < 2; i++)
            {
                problems[i] = new practiceproblems();
            }
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxHowToSolve.Text = "";
            readValuesAndFindConstants();
            for (int j = 0; j < 2; j++)
            {
                for (int k = 0; k < 3; k++)
                {


                    for (int i = 0; i < numofequations; i++)
                    {
                        //The percentage difference is the difference between two values divided by the average of the two values. Shown as a percentage.
                        double percentdifference = Math.Abs(
                            (problems[0].constants[i] - problems[1].constants[i]) / (.5 * (problems[0].constants[i] + problems[1].constants[i]))
                           );
                        if (percentdifference <= .02)
                        {
                            //textBoxHowToSolve.Text += "On try " + (k + 1)+","+(j+1) + ", used constant " + i.ToString() + "'s value of " + problems[0].constants[i] + " and " + problems[1].constants[i] + " to solve. Score: " + (100 - Math.Round(5000 * percentdifference, 2)) + " (" + Math.Round(percentdifference * 100, 3) + "%)";
                            //textBoxHowToSolve.Text += "\n\r\nA= " + problems[0].A + " B= " + problems[0].B + " C= " + problems[0].C + "  Average constant value: " +
                            //    .5 * (problems[0].constants[i] + problems[1].constants[i]) + "\n\r\n\r\r\n";

                            textBoxHowToSolve.Text += "Constant array: " + i.ToString() + " \t\t\tScore: " + (100 - Math.Round(5000 * percentdifference, 2)) + " (" + Math.Round(percentdifference * 100, 3) + "%)" + "\n\r\nAverage constant value: " +
                                .5 * (problems[0].constants[i] + problems[1].constants[i]) + " \tA= " + problems[0].A + "   B= " + problems[0].B + "   C= " + problems[0].C+"\n\r\n\r\r\n";
                        }
                    }
                    orderSwapABCtoBCA();
                    readValuesAndFindConstants();
                }
                orderSwapABtoBA();
                readValuesAndFindConstants();
            }
         if (textBoxHowToSolve.Text=="")
             textBoxHowToSolve.Text = "No solution within 2% found.";

       //  orderSwap();
        }

        private void readValuesAndFindConstants()
        {
            problems[0].A = Convert.ToDouble(textBoxA.Text) * Math.Pow(10, Convert.ToInt32(ea1.Text));
            problems[0].B = Convert.ToDouble(textBoxB.Text) * Math.Pow(10, Convert.ToInt32(ea2.Text));
            problems[0].C = Convert.ToDouble(textBoxC.Text) * Math.Pow(10, Convert.ToInt32(ea3.Text));
            problems[0].answer = Convert.ToDouble(textBoxAnswer.Text) * Math.Pow(10, Convert.ToInt32(eaA.Text));

            problems[1].A = Convert.ToDouble(textBoxA2.Text) * Math.Pow(10, Convert.ToInt32(eb1.Text));
            problems[1].B = Convert.ToDouble(textBoxB2.Text) * Math.Pow(10, Convert.ToInt32(eb2.Text));
            problems[1].C = Convert.ToDouble(textBoxC2.Text) * Math.Pow(10, Convert.ToInt32(eb3.Text));
            problems[1].answer = Convert.ToDouble(textBoxAnswer2.Text) * Math.Pow(10, Convert.ToInt32(ebA.Text));


            foreach (practiceproblems problem in problems)
            { //edit here! and edit practiceproblem.cs's constants = new double[NUMBER];//NUMBER=numofequations;
                numofequations = 1 + 39;
                problem.constants[0] = problem.answer / (problem.A * problem.B * problem.C);
                problem.constants[1] = problem.answer / (problem.A + problem.B + problem.C);
                problem.constants[2] = problem.answer / ((problem.A * problem.B / problem.C));
                problem.constants[3] = problem.answer / ((problem.A * problem.B / (problem.C * problem.C)));
                problem.constants[4] = problem.answer / ((problem.A * problem.B * (problem.C * problem.C)));
                problem.constants[5] = problem.answer / ((problem.A * problem.B * problem.B * (problem.C * problem.C)));
                problem.constants[6] = problem.answer / (problem.A * problem.B * Math.Sin(problem.C));
                problem.constants[7] = problem.answer / (problem.A * problem.B * Math.Tan(problem.C));
                problem.constants[8] = problem.answer / (problem.A * problem.B * Math.Cos(problem.C));
                problem.constants[9] = problem.answer / (Math.Pow(problem.A*problem.B/problem.C,.5));
                problem.constants[10] = problem.answer / (Math.Pow(problem.A * problem.B * problem.C, .5));
                problem.constants[11] = problem.answer / (Math.Pow(problem.A /( problem.B * problem.C), .5));
                problem.constants[12] = problem.answer / (problem.A * Math.Sin(problem.C));
                problem.constants[13] = problem.answer / (problem.A * Math.Tan(problem.C));
                problem.constants[14] = problem.answer / (problem.A * Math.Cos(problem.C));
                problem.constants[15] = problem.answer / (problem.A  * problem.C);
                problem.constants[16] = problem.answer / (problem.A  + problem.C);
                problem.constants[17] = problem.answer / ((problem.A  / problem.C));
                problem.constants[18] = problem.answer / ((problem.A  / (problem.C * problem.C)));
                problem.constants[19] = problem.answer / ((problem.A  * (problem.C * problem.C)));
                problem.constants[20] = problem.answer / (Math.Pow(problem.A / (problem.B * problem.B), .5));
                problem.constants[21] = problem.answer / (Math.Pow(problem.A *problem.A/ (problem.B * problem.C), .5));
                problem.constants[22] = problem.answer / (Math.Pow(problem.A * problem.A / (problem.B), .5));
                problem.constants[23] = problem.answer / (Math.Pow(problem.A * problem.A / (problem.B * problem.B), .5));
                problem.constants[24] = problem.answer / (Math.Pow(problem.A * problem.A *problem.B/ (problem.C * problem.C), .5));
                problem.constants[25] = problem.answer / (Math.Pow(problem.A * problem.B / (problem.C * problem.C), .5));
                problem.constants[26] = problem.answer / (Math.Pow(problem.A +problem.B, .5));
                problem.constants[27] = problem.answer / (Math.Pow(problem.A + problem.B+problem.C, .5));
                problem.constants[28] = problem.answer / (Math.Pow(problem.A - problem.B, .5));
                problem.constants[29] = problem.answer / (Math.Pow(problem.A*problem.A + problem.B, .5));
                problem.constants[30] = problem.answer / (Math.Pow(problem.A * problem.A - problem.B*problem.B, .5));
                problem.constants[31] = problem.answer / (Math.Pow(problem.A * problem.A + problem.B*problem.C, .5));
                problem.constants[32] = problem.answer / (Math.Pow(problem.A * problem.A + problem.B * problem.B, .5));
                problem.constants[33] = (problem.A * problem.A - problem.answer * problem.answer) / problem.B; // d=+-sqrt(a^2-b*constant)
                problem.constants[34] = problem.answer / (problem.A);
                problem.constants[35] = problem.answer;
                problem.constants[36] = problem.answer / ((problem.A * problem.A / problem.B));
                problem.constants[37] = problem.answer / ((problem.A * problem.A / problem.B));
                problem.constants[38] = problem.answer / ((problem.A * problem.A / (problem.B*problem.C)));
                problem.constants[39] = problem.answer / ((problem.A * problem.A *problem.B/ problem.C));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
          
        }

        private void orderSwapABCtoBCA()
        {
            string oldA = textBoxA.Text;
            string oldEA = ea1.Text;
            string oldB = textBoxB.Text;
            string oldEB = ea2.Text;
            string oldC = textBoxC.Text;
            string oldEC = ea3.Text;
            //string oldAnswer = textBoxAnswer.Text;
            //string oldEAnswer = eaA.Text;

            string oldA2 = textBoxA2.Text;
            string oldEA2 = eb1.Text;
            string oldB2 = textBoxB2.Text;
            string oldEB2 = eb2.Text;
            string oldC2 = textBoxC2.Text;
            string oldEC2 = eb3.Text;
            //string oldAnswer2 = textBoxAnswer2.Text;
            //string oldEAnswer2 = ebA.Text;

            textBoxA.Text = oldB;
            ea1.Text = oldEB;
            textBoxB.Text = oldC;
            ea2.Text = oldEC;
            textBoxC.Text = oldA;
            ea3.Text = oldEA;

            textBoxA2.Text = oldB2;
            eb1.Text = oldEB2;
            textBoxB2.Text = oldC2;
            eb2.Text = oldEC2;
            textBoxC2.Text = oldA2;
            eb3.Text = oldEA2;

            
        }

        private void orderSwapABtoBA()
        {
            string oldA = textBoxA.Text;
            string oldEA = ea1.Text;
            string oldB = textBoxB.Text;
            string oldEB = ea2.Text;


            string oldA2 = textBoxA2.Text;
            string oldEA2 = eb1.Text;
            string oldB2 = textBoxB2.Text;
            string oldEB2 = eb2.Text;
   

            textBoxA.Text = oldB;
            ea1.Text = oldEB;
            textBoxB.Text = oldA;
            ea2.Text = oldEA;
       

            textBoxA2.Text = oldB2;
            eb1.Text = oldEB2;
            textBoxB2.Text = oldA2;
            eb2.Text = oldEA2;
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ebA.Text = eaA.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxA_DragDrop(object sender, DragEventArgs e)
        {
            textBoxA.Text=e.Data.ToString();
        }
    }
}
