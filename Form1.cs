using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{


    public partial class Form1 : Form
    {
        int player = 0;
        int index = 0;
        int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        Random rnd = new Random();
        int number = 0;
        string array2;
        int index2 = 0;
        int numbers;
        int h = 0;

        public Form1()
        {
            InitializeComponent();
            
        }
        public void winO(string array2)
        {
            string docPath =
           Directory.GetCurrentDirectory();

            // Write the string array to a new file named "WriteLines.txt".
            using (StreamWriter outputFile = File.AppendText(Path.Combine(docPath, "WriteLine.txt")))
                if (array2.Length <= 8)
                {
                    outputFile.WriteLine(array2);
                }
        }

        public void win(string array2)
        {
            string docPath =
           Directory.GetCurrentDirectory();

            // Write the string array to a new file named "WriteLines.txt".
           
            using (StreamWriter outputFile = File.AppendText(Path.Combine(docPath, "WriteLines.txt")))
            {
                if (array2.Length<=6)
                {
                    outputFile.WriteLine(array2);
                }



            }
        }
        public int ai(string array2,int h)
        {
            string docPath =
           Directory.GetCurrentDirectory();
            var lines = File.ReadAllLines("WriteLines.txt");
            foreach (var line in lines)
            {
               
                if (line.Contains(array2))
                {
                    
                    var a = line[array2.Length];
                    if (array2.Contains(a)) { goto fuck; }
                   
                    
                    if (a == '1')
                    { button1.Text="o"; h = 1;number = 1; break; }
                    else if (a == '2')
                    { button2.Text= "o"; h = 1;number = 2; break; }
                    else if (a == '3')
                    {  button3.Text= "o"; h = 1; number = 3; break; }
                    else if (a == '4')
                    {  button4.Text = "o"; h = 1; number = 4; break; }
                    else if (a == '5')
                    {  button5.Text = "o"; h = 1; number = 5; break; }
                    else if (a == '6')
                    { button6.Text = "o"; h = 1; number = 6; break; }
                    else if (a == '7')
                    {  button7.Text = "o"; h = 1;number = 7; break; }
                    else if (a == '8')
                    {  button8.Text = "o"; h = 1; number = 8; break; }
                    else if (a == '9')
                    {   button9.Text = "o"; h = 1; number = 9; break; }
                    
                    
                    

                }

            }
            
            fuck:
            return h;
        }
        public int aiO(string array2, int h)
        {
            string docPath =
           Directory.GetCurrentDirectory();
            var lines = File.ReadAllLines("WriteLine.txt");
            foreach (var line in lines)
            {
             
                if (line.Contains(array2))
                {
                     
                    var a = line[array2.Length];
                    if (array2.Contains(a)) { goto fuck1; }
                     
                   
                    if (a == '1')
                    {  button1.Text = "x"; h = 1; number = 1; break; }
                    else if (a == '2')
                    {  button2.Text = "x"; h = 1; number = 2; break; }
                    else if (a == '3')
                    {  button3.Text = "x"; h = 1; number = 3; break; }
                    else if (a == '4')
                    {  button4.Text = "x"; h = 1; number = 4; break; }
                    else if (a == '5')
                    {  button5.Text = "x"; h = 1; number = 5; break; }
                    else if (a == '6')
                    {  button6.Text = "x"; h = 1; number = 6; break; }
                    else if (a == '7')
                    {  button7.Text = "x"; h = 1; number = 7; break; }
                    else if (a == '8')
                    {  button8.Text = "x"; h = 1; number = 8; break; }
                    else if (a == '9')
                    { button9.Text = "x"; h = 1; number = 9; break; }




                }

            }
            fuck1:
            return h;
        }


        public void Button1_Click(object sender, EventArgs e)
        {

            while (array[index] == 1 && button1.Text != ".")
            { new Random().Shuffle(array); }

            if (player == 1 )
            { button1.Text = "x";
                array2 += "1";
                //
                if (button1.Text == "x" && button2.Text == "x" && (button3.Text ==".")) { number = 3; button3.Text = "o"; goto jump1; }
                else if (button1.Text == "x" && button3.Text == "x" && (button2.Text ==".")) { number = 2; button2.Text = "o"; goto jump1; }
                else if (button3.Text == "x" && button2.Text == "x" && (button1.Text ==".")) { number = 1; button1.Text = "o"; goto jump1; }

                if (button4.Text == "x" && button5.Text == "x" && button6.Text ==".") { number = 6; button6.Text = "o"; goto jump1; }
                else if (button5.Text == "x" && button6.Text == "x" && (button4.Text ==".")) { number = 4; button4.Text = "o"; goto jump1; }
                else if (button6.Text == "x" && button4.Text == "x" && (button5.Text ==".")) { number = 5; button5.Text = "o"; goto jump1; }

                if (button8.Text == "x" && button9.Text == "x" && (button7.Text ==".")) { number = 7; button7.Text = "o"; goto jump1; }
                else if (button7.Text == "x" && button9.Text == "x" && (button8.Text ==".")) { number = 8; button8.Text = "o"; goto jump1; }
                else if (button7.Text == "x" && button8.Text == "x" && (button9.Text ==".")) { number = 9; button9.Text = "o"; goto jump1; }

                if (button4.Text == "x" && button7.Text == "x" && (button1.Text ==".")) { number = 1; button1.Text = "o"; goto jump1; }
                else if (button1.Text == "x" && button7.Text == "x" && (button4.Text ==".")) { number = 4; button4.Text = "o"; goto jump1; }
                else if (button4.Text == "x" && button1.Text == "x" && (button7.Text ==".")) { number = 7; button7.Text = "o"; goto jump1; }

                if (button5.Text == "x" && button8.Text == "x" && (button2.Text ==".")) { number = 2; button2.Text = "o"; goto jump1; }
                else if (button2.Text == "x" && button8.Text == "x" && (button5.Text ==".")) { number = 5; button5.Text = "o"; goto jump1; }
                else if (button2.Text == "x" && button5.Text == "x" && (button8.Text ==".")) { number = 8; button8.Text = "o"; goto jump1; }

                if (button6.Text == "x" && button9.Text == "x" && (button3.Text ==".")) { number = 3; button3.Text = "o"; goto jump1; }
                else if (button3.Text == "x" && button9.Text == "x" && (button6.Text ==".")) { number = 6; button6.Text = "o"; goto jump1; }
                else if (button3.Text == "x" && button6.Text == "x" && (button9.Text ==".")) { number = 9; button9.Text = "o"; goto jump1; }

                if (button5.Text == "x" && button9.Text == "x" && (button1.Text ==".")) { number = 1; button1.Text = "o"; goto jump1; }
                else if (button1.Text == "x" && button9.Text == "x" && (button5.Text ==".")) { number = 5; button5.Text = "o"; goto jump1; }
                else if (button1.Text == "x" && button5.Text == "x" && (button9.Text ==".")) { number = 9; button9.Text = "o"; goto jump1; }

                if (button5.Text == "x" && button7.Text == "x" && (button3.Text ==".")) { number = 3; button3.Text = "o"; goto jump1; }
                else if (button3.Text == "x" && button7.Text == "x" && (button5.Text ==".")) { number = 5; button5.Text = "o"; goto jump1; }
                else if (button3.Text == "x" && button5.Text == "x" && (button7.Text ==".")) { number = 7; button7.Text = "o"; goto jump1; }








                //
                ai(array2, 0);
                 
                 
                h = ai(array2, h);
                if (h==1) {   goto jump1;  }
                for (int i = 0; i <= 1000; i++)
                {
                    number = rnd.Next(1, 10);
                    if (number == 1 && button1.Text == ".")
                    { }
                    if (number == 2 && button2.Text==".")
                    { button2.Text = "o"; break; }
                    if (number == 3 && button3.Text == ".")
                    { button3.Text = "o"; break; }
                    if (number == 4 && button4.Text == ".")
                    { button4.Text = "o"; break; }
                    if (number == 5 && button5.Text == ".")
                    { button5.Text = "o"; break; }
                    if (number == 6 && button6.Text == ".")
                    { button6.Text = "o"; break; }
                    if (number == 7 && button7.Text == ".")
                    { button7.Text = "o"; break; }
                    if (number == 8 && button8.Text == ".")
                    { button8.Text = "o"; break; }
                    if (number == 9 && button9.Text == ".")
                    { button9.Text = "o"; break; }


                }
                jump1:
                
                h = 0;
                 
                array2 += Convert.ToString(number);
                index++;
                
                label13.Text = array2;
                index2++;
                
               
            }
            else if (player == 2)
            {
                button1.Text = "o";
                array2 += "1";
                if (button1.Text == "o" && button2.Text == "o" && (button3.Text == ".")) { number = 3; button3.Text = "x"; goto jumpo1; }
                else if (button1.Text == "o" && button3.Text == "o" && (button2.Text == ".")) { number = 2; button2.Text = "x"; goto jumpo1; }
                else if (button3.Text == "o" && button2.Text == "o" && (button1.Text == ".")) { number = 1; button1.Text = "x"; goto jumpo1; }

                if (button4.Text == "o" && button5.Text == "o" && button6.Text == ".") { number = 6; button6.Text = "o"; goto jumpo1; }
                else if (button5.Text == "o" && button6.Text == "o" && (button4.Text == ".")) { number = 4; button4.Text = "x"; goto jumpo1; }
                else if (button6.Text == "o" && button4.Text == "o" && (button5.Text == ".")) { number = 5; button5.Text = "x"; goto jumpo1; }

                if (button8.Text == "o" && button9.Text == "o" && (button7.Text == ".")) { number = 7; button7.Text = "x"; goto jumpo1; }
                else if (button7.Text == "o" && button9.Text == "o" && (button8.Text == ".")) { number = 8; button8.Text = "x"; goto jumpo1; }
                else if (button7.Text == "o" && button8.Text == "o" && (button9.Text == ".")) { number = 9; button9.Text = "x"; goto jumpo1; }

                if (button4.Text == "o" && button7.Text == "o" && (button1.Text == ".")) { number = 1; button1.Text = "x"; goto jumpo1; }
                else if (button1.Text == "o" && button7.Text == "o" && (button4.Text == ".")) { number = 4; button4.Text = "x"; goto jumpo1; }
                else if (button4.Text == "o" && button1.Text == "o" && (button7.Text == ".")) { number = 7; button7.Text = "x"; goto jumpo1; }

                if (button5.Text == "o" && button8.Text == "o" && (button2.Text == ".")) { number = 2; button2.Text = "x"; goto jumpo1; }
                else if (button2.Text == "o" && button8.Text == "o" && (button5.Text == ".")) { number = 5; button5.Text = "x"; goto jumpo1; }
                else if (button2.Text == "o" && button5.Text == "o" && (button8.Text == ".")) { number = 8; button8.Text = "x"; goto jumpo1; }

                if (button6.Text == "o" && button9.Text == "o" && (button3.Text == ".")) { number = 3; button3.Text = "x"; goto jumpo1; }
                else if (button3.Text == "o" && button9.Text == "o" && (button6.Text == ".")) { number = 6; button6.Text = "x"; goto jumpo1; }
                else if (button3.Text == "o" && button6.Text == "o" && (button9.Text == ".")) { number = 9; button9.Text = "x"; goto jumpo1; }

                if (button5.Text == "o" && button9.Text == "o" && (button1.Text == ".")) { number = 1; button1.Text = "x"; goto jumpo1; }
                else if (button1.Text == "o" && button9.Text == "o" && (button5.Text == ".")) { number = 5; button5.Text = "x"; goto jumpo1; }
                else if (button1.Text == "o" && button5.Text == "o" && (button9.Text == ".")) { number = 9; button9.Text = "x"; goto jumpo1; }

                if (button5.Text == "o" && button7.Text == "o" && (button3.Text == ".")) { number = 3; button3.Text = "x"; goto jumpo1; }
                else if (button3.Text == "o" && button7.Text == "o" && (button5.Text == ".")) { number = 5; button5.Text = "x"; goto jumpo1; }
                else if (button3.Text == "o" && button5.Text == "o" && (button7.Text == ".")) { number = 7; button7.Text = "x"; goto jumpo1; }
                aiO(array2, 0);
                 
                 
                h = aiO(array2, h);
                if (h == 1) {   goto jumpo1; }
                for (int i = 0; i <= 1000; i++)
                {
                    number = rnd.Next(1, 10);
                    if (number == 1 && button1.Text == ".")
                    { }
                    if (number == 2 && button2.Text == ".")
                    { button2.Text = "x"; break; }
                    if (number == 3 && button3.Text == ".")
                    { button3.Text = "x"; break; }
                    if (number == 4 && button4.Text == ".")
                    { button4.Text = "x"; break; }
                    if (number == 5 && button5.Text == ".")
                    { button5.Text = "x"; break; }
                    if (number == 6 && button6.Text == ".")
                    { button6.Text = "x"; break; }
                    if (number == 7 && button7.Text == ".")
                    { button7.Text = "x"; break; }
                    if (number == 8 && button8.Text == ".")
                    { button8.Text = "x"; break; }
                    if (number == 9 && button9.Text == ".")
                    { button9.Text = "x"; break; }


                }
                    jumpo1:
                    h = 0;
                    array2 += Convert.ToString(number);
                    index++;

                    label13.Text = array2;
                    index2++;













            }
            //Draw
            if (button1.Text != "." && button2.Text != "." && button3.Text != "." && button4.Text != "." && button5.Text != "." && button6.Text != "." && button7.Text != "." && button8.Text != "." && button9.Text != "." && label1.Text != "The winner is O" && label1.Text != "The winner is X")
            { label1.Text = "It is a draw";
                
            }
            //
            if (button1.Text == "o" && button2.Text == "o" && button3.Text == "o")
            { label1.Text = "The winner is O"; }
            else if (button3.Text == "o" && button6.Text == "o" && button9.Text == "o")
            { label1.Text = "The winner is O"; }
            else if (button9.Text == "o" && button8.Text == "o" && button7.Text == "o")
            { label1.Text = "The winner is O"; }
            else if (button7.Text == "o" && button4.Text == "o" && button1.Text == "o")
            { label1.Text = "The winner is O"; }
            else if (button1.Text == "o" && button5.Text == "o" && button9.Text == "o")
            { label1.Text = "The winner is O"; }
            else if (button3.Text == "o" && button5.Text == "o" && button7.Text == "o")
            { label1.Text = "The winner is O"; }
            else if (button4.Text == "o" && button5.Text == "o" && button6.Text == "o")
            { label1.Text = "The winner is O"; }
            else if (button4.Text == "o" && button5.Text == "o" && button6.Text == "o")
            { label1.Text = "The winner is O"; }
            else if (button2.Text == "o" && button5.Text == "o" && button8.Text == "o")
            { label1.Text = "The winner is O"; }

            if (button1.Text == "x" && button2.Text == "x" && button3.Text == "x")
            { label1.Text = "The winner is X"; }
            else if (button3.Text == "x" && button6.Text == "x" && button9.Text == "x")
            { label1.Text = "The winner is X"; }
            else if (button9.Text == "x" && button8.Text == "x" && button7.Text == "x")
            { label1.Text = "The winner is X"; }
            else if (button7.Text == "x" && button4.Text == "x" && button1.Text == "x")
            { label1.Text = "The winner is X"; }
            else if (button1.Text == "x" && button5.Text == "x" && button9.Text == "x")
            { label1.Text = "The winner is X"; }
            else if (button3.Text == "x" && button5.Text == "x" && button7.Text == "x")
            { label1.Text = "The winner is X"; }
            else if (button4.Text == "x" && button5.Text == "x" && button6.Text == "x")
            { label1.Text = "The winner is X"; }
            else if (button4.Text == "x" && button5.Text == "x" && button6.Text == "x")
            { label1.Text = "The winner is X"; }
            else if (button2.Text == "x" && button5.Text == "x" && button8.Text == "x")
            { label1.Text = "The winner is X"; }
            if (label1.Text=="The winner is O")
            {
                win(array2);
            }
            if (label1.Text == "The winner is X")
            {
                winO(array2);
            }

            if (label1.Text != "Winner is:")
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;

            }
        }

        public void Button2_Click(object sender, EventArgs e)
        {

            while (array[index] == 2 && button2.Text != ".")
            { new Random().Shuffle(array); }
            if (player == 1)
            { button2.Text = "x";
                array2 += "2";
                if (button1.Text == "x" && button2.Text == "x" && (button3.Text ==".")) { number = 3; button3.Text = "o"; goto jump2; }
                else if (button1.Text == "x" && button3.Text == "x" && (button2.Text ==".")) { number = 2; button2.Text = "o"; goto jump2; }
                else if (button3.Text == "x" && button2.Text == "x" && button1.Text ==".") { number = 1; button1.Text = "o"; goto jump2; }

                if (button4.Text == "x" && button5.Text == "x" && (button6.Text ==".")) { number = 6; button6.Text = "o"; goto jump2; }
                else if (button5.Text == "x" && button6.Text == "x" && (button4.Text ==".")) { number = 4; button4.Text = "o"; goto jump2; }
                else if (button6.Text == "x" && button4.Text == "x" && (button5.Text ==".")) { number = 5; button5.Text = "o"; goto jump2; }

                if (button8.Text == "x" && button9.Text == "x" && (button7.Text ==".")) { number = 7; button7.Text = "o"; goto jump2; }
                else if (button7.Text == "x" && button9.Text == "x" && (button8.Text ==".")) { number = 8; button8.Text = "o"; goto jump2; }
                else if (button7.Text == "x" && button8.Text == "x" && (button9.Text ==".")) { number = 9; button9.Text = "o"; goto jump2; }

                if (button4.Text == "x" && button7.Text == "x" && (button1.Text ==".")) { number = 1; button1.Text = "o"; goto jump2; }
                else if (button1.Text == "x" && button7.Text == "x" && (button4.Text ==".")) { number = 4; button4.Text = "o"; goto jump2; }
                else if (button4.Text == "x" && button1.Text == "x" && (button7.Text ==".")) { number = 7; button7.Text = "o"; goto jump2; }

                if (button5.Text == "x" && button8.Text == "x" && (button2.Text ==".")) { number = 2; button2.Text = "o"; goto jump2; }
                else if (button2.Text == "x" && button8.Text == "x" && (button5.Text ==".")) { number = 5; button5.Text = "o"; goto jump2; }
                else if (button2.Text == "x" && button5.Text == "x" && (button8.Text ==".")) { number = 8; button8.Text = "o"; goto jump2; }

                if (button6.Text == "x" && button9.Text == "x" && (button3.Text ==".")) { number = 3; button3.Text = "o"; goto jump2; }
                else if (button3.Text == "x" && button9.Text == "x" && (button6.Text ==".")) { number = 6; button6.Text = "o"; goto jump2; }
                else if (button3.Text == "x" && button6.Text == "x" && (button9.Text ==".")) { number = 9; button9.Text = "o"; goto jump2; }

                if (button5.Text == "x" && button9.Text == "x" && (button1.Text ==".")) { number = 1; button1.Text = "o"; goto jump2; }
                else if (button1.Text == "x" && button9.Text == "x" && (button5.Text ==".")) { number = 5; button5.Text = "o"; goto jump2; }
                else if (button1.Text == "x" && button5.Text == "x" && (button9.Text ==".")) { number = 9; button9.Text = "o"; goto jump2; }

                if (button5.Text == "x" && button7.Text == "x" && (button3.Text ==".")) { number = 3; button3.Text = "o"; goto jump2; }
                else if (button3.Text == "x" && button7.Text == "x" && (button5.Text ==".")) { number = 5; button5.Text = "o"; goto jump2; }
                else if (button3.Text == "x" && button5.Text == "x" && (button7.Text ==".")) { number = 7; button7.Text = "o"; goto jump2; }

                ai(array2, 0);
                h = ai(array2, h);
                if (h == 1) { goto jump2; }
                for (int i = 0; i <= 1000; i++)
                {
                    number = rnd.Next(1, 10);
                    if (number == 1 && button1.Text == ".")
                    { button1.Text = "o"; break; }
                    if (number == 2 && button2.Text == ".")
                    { }
                    if (number == 3 && button3.Text == ".")
                    { button3.Text = "o"; break; }
                    if (number == 4 && button4.Text == ".")
                    { button4.Text = "o"; break; }
                    if (number == 5 && button5.Text == ".")
                    { button5.Text = "o"; break; }
                    if (number == 6 && button6.Text == ".")
                    { button6.Text = "o"; break; }
                    if (number == 7 && button7.Text == ".")
                    { button7.Text = "o"; break; }
                    if (number == 8 && button8.Text == ".")
                    { button8.Text = "o"; break; }
                    if (number == 9 && button9.Text == ".")
                    { button9.Text = "o"; break; }

                    

                }
                jump2:

                h = 0;
                 
                index++;
                
                array2 += Convert.ToString(number);
                
                label13.Text = array2;


            }
            else if (player == 2)
            {  
                
                    button2.Text = "o";
                    array2 += "2";
                if (button1.Text == "o" && button2.Text == "x" && (button3.Text == ".")) { number = 3; button3.Text = "x"; goto jumpo2; }
                else if (button1.Text == "o" && button3.Text == "o" && (button2.Text == ".")) { number = 2; button2.Text = "x"; goto jumpo2; }
                else if (button3.Text == "o" && button2.Text == "o" && button1.Text == ".") { number = 1; button1.Text = "x"; goto jumpo2; }

                if (button4.Text == "o" && button5.Text == "o" && (button6.Text == ".")) { number = 6; button6.Text = "x"; goto jumpo2; }
                else if (button5.Text == "o" && button6.Text == "o" && (button4.Text == ".")) { number = 4; button4.Text = "x"; goto jumpo2; }
                else if (button6.Text == "o" && button4.Text == "o" && (button5.Text == ".")) { number = 5; button5.Text = "x"; goto jumpo2; }

                if (button8.Text == "o" && button9.Text == "o" && (button7.Text == ".")) { number = 7; button7.Text = "x"; goto jumpo2; }
                else if (button7.Text == "o" && button9.Text == "o" && (button8.Text == ".")) { number = 8; button8.Text = "x"; goto jumpo2; }
                else if (button7.Text == "o" && button8.Text == "o" && (button9.Text == ".")) { number = 9; button9.Text = "x"; goto jumpo2; }

                if (button4.Text == "o" && button7.Text == "o" && (button1.Text == ".")) { number = 1; button1.Text = "x"; goto jumpo2; }
                else if (button1.Text == "o" && button7.Text == "o" && (button4.Text == ".")) { number = 4; button4.Text = "x"; goto jumpo2; }
                else if (button4.Text == "o" && button1.Text == "o" && (button7.Text == ".")) { number = 7; button7.Text = "x"; goto jumpo2; }

                if (button5.Text == "o" && button8.Text == "o" && (button2.Text == ".")) { number = 2; button2.Text = "x"; goto jumpo2; }
                else if (button2.Text == "o" && button8.Text == "o" && (button5.Text == ".")) { number = 5; button5.Text = "x"; goto jumpo2; }
                else if (button2.Text == "o" && button5.Text == "o" && (button8.Text == ".")) { number = 8; button8.Text = "x"; goto jumpo2; }

                if (button6.Text == "o" && button9.Text == "o" && (button3.Text == ".")) { number = 3; button3.Text = "x"; goto jumpo2; }
                else if (button3.Text == "o" && button9.Text == "o" && (button6.Text == ".")) { number = 6; button6.Text = "x"; goto jumpo2; }
                else if (button3.Text == "o" && button6.Text == "o" && (button9.Text == ".")) { number = 9; button9.Text = "x"; goto jumpo2; }

                if (button5.Text == "o" && button9.Text == "o" && (button1.Text == ".")) { number = 1; button1.Text = "x"; goto jumpo2; }
                else if (button1.Text == "o" && button9.Text == "o" && (button5.Text == ".")) { number = 5; button5.Text = "x"; goto jumpo2; }
                else if (button1.Text == "o" && button5.Text == "o" && (button9.Text == ".")) { number = 9; button9.Text = "x"; goto jumpo2; }

                if (button5.Text == "o" && button7.Text == "o" && (button3.Text == ".")) { number = 3; button3.Text = "x"; goto jumpo2; }
                else if (button3.Text == "o" && button7.Text == "o" && (button5.Text == ".")) { number = 5; button5.Text = "x"; goto jumpo2; }
                else if (button3.Text == "o" && button5.Text == "o" && (button7.Text == ".")) { number = 7; button7.Text = "x"; goto jumpo2; }
                aiO(array2, 0);
                     
                    
                    h = aiO(array2, h);
                    if (h == 1) {   goto jumpo2; }
                    for (int i = 0; i <= 1000; i++)
                    {
                        number = rnd.Next(1, 10);
                        if (number == 1 && button1.Text == ".")
                        { button1.Text = "x"; break; }
                        if (number == 2 && button2.Text == ".")
                        { }
                        if (number == 3 && button3.Text == ".")
                        { button3.Text = "x"; break; }
                        if (number == 4 && button4.Text == ".")
                        { button4.Text = "x"; break; }
                        if (number == 5 && button5.Text == ".")
                        { button5.Text = "x"; break; }
                        if (number == 6 && button6.Text == ".")
                        { button6.Text = "x"; break; }
                        if (number == 7 && button7.Text == ".")
                        { button7.Text = "x"; break; }
                        if (number == 8 && button8.Text == ".")
                        { button8.Text = "x"; break; }
                        if (number == 9 && button9.Text == ".")
                        { button9.Text = "x"; break; }


                    }
                jumpo2:
                    h = 0;
                    array2 += Convert.ToString(number);
                    index++;

                    label13.Text = array2;
                    index2++;
                }
            //Draw
            if (button1.Text != "." && button2.Text != "." && button3.Text != "." && button4.Text != "." && button5.Text != "." && button6.Text != "." && button7.Text != "." && button8.Text != "." && button9.Text != "." && label1.Text != "The winner is O" && label1.Text != "The winner is X")
            { label1.Text = "It is a draw"; }
            //
            
                if (button1.Text == "o" && button2.Text == "o" && button3.Text == "o")
                { label1.Text = "The winner is O"; }
                else if (button3.Text == "o" && button6.Text == "o" && button9.Text == "o")
                { label1.Text = "The winner is O"; }
                else if (button9.Text == "o" && button8.Text == "o" && button7.Text == "o")
                { label1.Text = "The winner is O"; }
                else if (button7.Text == "o" && button4.Text == "o" && button1.Text == "o")
                { label1.Text = "The winner is O"; }
                else if (button1.Text == "o" && button5.Text == "o" && button9.Text == "o")
                { label1.Text = "The winner is O"; }
                else if (button3.Text == "o" && button5.Text == "o" && button7.Text == "o")
                { label1.Text = "The winner is O"; }
                else if (button4.Text == "o" && button5.Text == "o" && button6.Text == "o")
                { label1.Text = "The winner is O"; }
                else if (button4.Text == "o" && button5.Text == "o" && button6.Text == "o")
                { label1.Text = "The winner is O"; }
                else if (button2.Text == "o" && button5.Text == "o" && button8.Text == "o")
                { label1.Text = "The winner is O"; }
            
                if (button1.Text == "x" && button2.Text == "x" && button3.Text == "x")
                { label1.Text = "The winner is X"; }
                else if (button3.Text == "x" && button6.Text == "x" && button9.Text == "x")
                { label1.Text = "The winner is X"; }
                else if (button9.Text == "x" && button8.Text == "x" && button7.Text == "x")
                { label1.Text = "The winner is X"; }
                else if (button7.Text == "x" && button4.Text == "x" && button1.Text == "x")
                { label1.Text = "The winner is X"; }
                else if (button1.Text == "x" && button5.Text == "x" && button9.Text == "x")
                { label1.Text = "The winner is X"; }
                else if (button3.Text == "x" && button5.Text == "x" && button7.Text == "x")
                { label1.Text = "The winner is X"; }
                else if (button4.Text == "x" && button5.Text == "x" && button6.Text == "x")
                { label1.Text = "The winner is X"; }
                else if (button4.Text == "x" && button5.Text == "x" && button6.Text == "x")
                { label1.Text = "The winner is X"; }
                else if (button2.Text == "x" && button5.Text == "x" && button8.Text == "x")
                { label1.Text = "The winner is X"; }

            if (label1.Text == "The winner is O")
            {
                win(array2);
            }
            if (label1.Text == "The winner is X")
            {
                winO(array2);
            }
            if (label1.Text != "Winner is:")
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;

            }
        }

        public void Button3_Click(object sender, EventArgs e)
        {

            while (array[index] == 3 && button3.Text != ".")
            { new Random().Shuffle(array); }
            if (player == 1)
            { button3.Text = "x";
                array2 += "3";
                if (button1.Text == "x" && button2.Text == "x" && (button3.Text ==".")) { number = 3; button3.Text = "o"; goto jump3; }
                else if (button1.Text == "x" && button3.Text == "x" && (button2.Text ==".")) { number = 2; button2.Text = "o"; goto jump3; }
                else if (button3.Text == "x" && button2.Text == "x" && (button1.Text ==".")) { number = 1; button1.Text = "o"; goto jump3; }

                if (button4.Text == "x" && button5.Text == "x" && (button6.Text ==".")) { number = 6; button6.Text = "o"; goto jump3; }
                else if (button5.Text == "x" && button6.Text == "x" && (button4.Text ==".")) { number = 4; button4.Text = "o"; goto jump3; }
                else if (button6.Text == "x" && button4.Text == "x" && (button5.Text ==".")) { number = 5; button5.Text = "o"; goto jump3; }

                if (button8.Text == "x" && button9.Text == "x" && (button7.Text ==".")) { number = 7; button7.Text = "o"; goto jump3; }
                else if (button7.Text == "x" && button9.Text == "x" && (button8.Text ==".")) { number = 8; button8.Text = "o"; goto jump3; }
                else if (button7.Text == "x" && button8.Text == "x" && (button9.Text ==".")) { number = 9; button9.Text = "o"; goto jump3; }

                if (button4.Text == "x" && button7.Text == "x" && (button1.Text ==".")) { number = 1; button1.Text = "o"; goto jump3; }
                else if (button1.Text == "x" && button7.Text == "x" && (button4.Text ==".")) { number = 4; button4.Text = "o"; goto jump3; }
                else if (button4.Text == "x" && button1.Text == "x" && (button7.Text ==".")) { number = 7; button7.Text = "o"; goto jump3; }

                if (button5.Text == "x" && button8.Text == "x" && (button2.Text ==".")) { number = 2; button2.Text = "o"; goto jump3; }
                else if (button2.Text == "x" && button8.Text == "x" && (button5.Text ==".")) { number = 5; button5.Text = "o"; goto jump3; }
                else if (button2.Text == "x" && button5.Text == "x" && (button8.Text ==".")) { number = 8; button8.Text = "o"; goto jump3; }

                if (button6.Text == "x" && button9.Text == "x" && (button3.Text ==".")) { number = 3; button3.Text = "o"; goto jump3; }
                else if (button3.Text == "x" && button9.Text == "x" && (button6.Text ==".")) { number = 6; button6.Text = "o"; goto jump3; }
                else if (button3.Text == "x" && button6.Text == "x" && (button9.Text ==".")) { number = 9; button9.Text = "o"; goto jump3; }

                if (button5.Text == "x" && button9.Text == "x" && (button1.Text ==".")) { number = 1; button1.Text = "o"; goto jump3; }
                else if (button1.Text == "x" && button9.Text == "x" && (button5.Text ==".")) { number = 5; button5.Text = "o"; goto jump3; }
                else if (button1.Text == "x" && button5.Text == "x" && (button9.Text ==".")) { number = 9; button9.Text = "o"; goto jump3; }

                if (button5.Text == "x" && button7.Text == "x" && (button3.Text ==".")) { number = 3; button3.Text = "o"; goto jump3; }
                else if (button3.Text == "x" && button7.Text == "x" && (button5.Text ==".")) { number = 5; button5.Text = "o"; goto jump3; }
                else if (button3.Text == "x" && button5.Text == "x" && (button7.Text ==".")) { number = 7; button7.Text = "o"; goto jump3; }

                ai(array2, 0);
                h = ai(array2, h);
                if (h == 1) { goto jump3; }
                for (int i = 0; i <= 1000; i++)
                {
                    number = rnd.Next(1, 10);
                    if (number == 1 && button1.Text == ".")
                    { button1.Text = "o"; break; }
                    if (number == 2 && button2.Text == ".")
                    { button2.Text = "o"; break; }
                    if (number == 3 && button3.Text == ".")
                    {  }
                    if (number == 4 && button4.Text == ".")
                    { button4.Text = "o"; break; }
                    if (number == 5 && button5.Text == ".")
                    { button5.Text = "o"; break; }
                    if (number == 6 && button6.Text == ".")
                    { button6.Text = "o"; break; }
                    if (number == 7 && button7.Text == ".")
                    { button7.Text = "o"; break; }
                    if (number == 8 && button8.Text == ".")
                    { button8.Text = "o"; break; }
                    if (number == 9 && button9.Text == ".")
                    { button9.Text = "o"; break; }

                }
                jump3:

                h = 0;
             
                index++;
                
                array2 += Convert.ToString(number);
                index2++;
                label13.Text = array2;
            }
            else if (player == 2)
            
                    {
                        button3.Text = "o";
                        array2 += "3";
                if (button1.Text == "o" && button2.Text == "x" && (button3.Text == ".")) { number = 3; button3.Text = "x"; goto jumpo3; }
                else if (button1.Text == "o" && button3.Text == "o" && (button2.Text == ".")) { number = 2; button2.Text = "x"; goto jumpo3; }
                else if (button3.Text == "o" && button2.Text == "o" && button1.Text == ".") { number = 1; button1.Text = "x"; goto jumpo3; }

                if (button4.Text == "o" && button5.Text == "o" && (button6.Text == ".")) { number = 6; button6.Text = "x"; goto jumpo3; }
                else if (button5.Text == "o" && button6.Text == "o" && (button4.Text == ".")) { number = 4; button4.Text = "x"; goto jumpo3; }
                else if (button6.Text == "o" && button4.Text == "o" && (button5.Text == ".")) { number = 5; button5.Text = "x"; goto jumpo3; }

                if (button8.Text == "o" && button9.Text == "o" && (button7.Text == ".")) { number = 7; button7.Text = "x"; goto jumpo3; }
                else if (button7.Text == "o" && button9.Text == "o" && (button8.Text == ".")) { number = 8; button8.Text = "x"; goto jumpo3; }
                else if (button7.Text == "o" && button8.Text == "o" && (button9.Text == ".")) { number = 9; button9.Text = "x"; goto jumpo3; }

                if (button4.Text == "o" && button7.Text == "o" && (button1.Text == ".")) { number = 1; button1.Text = "x"; goto jumpo3; }
                else if (button1.Text == "o" && button7.Text == "o" && (button4.Text == ".")) { number = 4; button4.Text = "x"; goto jumpo3; }
                else if (button4.Text == "o" && button1.Text == "o" && (button7.Text == ".")) { number = 7; button7.Text = "x"; goto jumpo3; }

                if (button5.Text == "o" && button8.Text == "o" && (button2.Text == ".")) { number = 2; button2.Text = "x"; goto jumpo3; }
                else if (button2.Text == "o" && button8.Text == "o" && (button5.Text == ".")) { number = 5; button5.Text = "x"; goto jumpo3; }
                else if (button2.Text == "o" && button5.Text == "o" && (button8.Text == ".")) { number = 8; button8.Text = "x"; goto jumpo3; }

                if (button6.Text == "o" && button9.Text == "o" && (button3.Text == ".")) { number = 3; button3.Text = "x"; goto jumpo3; }
                else if (button3.Text == "o" && button9.Text == "o" && (button6.Text == ".")) { number = 6; button6.Text = "x"; goto jumpo3; }
                else if (button3.Text == "o" && button6.Text == "o" && (button9.Text == ".")) { number = 9; button9.Text = "x"; goto jumpo3; }

                if (button5.Text == "o" && button9.Text == "o" && (button1.Text == ".")) { number = 1; button1.Text = "x"; goto jumpo3; }
                else if (button1.Text == "o" && button9.Text == "o" && (button5.Text == ".")) { number = 5; button5.Text = "x"; goto jumpo3; }
                else if (button1.Text == "o" && button5.Text == "o" && (button9.Text == ".")) { number = 9; button9.Text = "x"; goto jumpo3; }

                if (button5.Text == "o" && button7.Text == "o" && (button3.Text == ".")) { number = 3; button3.Text = "x"; goto jumpo3; }
                else if (button3.Text == "o" && button7.Text == "o" && (button5.Text == ".")) { number = 5; button5.Text = "x"; goto jumpo3; }
                else if (button3.Text == "o" && button5.Text == "o" && (button7.Text == ".")) { number = 7; button7.Text = "x"; goto jumpo3; }
                aiO(array2, 0);
                         
                        
                        h = aiO(array2, h);
                        if (h == 1) {   goto jumpo3; }
                        for (int i = 0; i <= 1000; i++)
                        {
                            number = rnd.Next(1, 10);
                            if (number == 1 && button1.Text == ".")
                            { button1.Text = "x"; break; }
                            if (number == 2 && button2.Text == ".")
                            { button2.Text = "x"; break; }
                            if (number == 3 && button3.Text == ".")
                            { }
                            if (number == 4 && button4.Text == ".")
                            { button4.Text = "x"; break; }
                            if (number == 5 && button5.Text == ".")
                            { button5.Text = "x"; break; }
                            if (number == 6 && button6.Text == ".")
                            { button6.Text = "x"; break; }
                            if (number == 7 && button7.Text == ".")
                            { button7.Text = "x"; break; }
                            if (number == 8 && button8.Text == ".")
                            { button8.Text = "x"; break; }
                            if (number == 9 && button9.Text == ".")
                            { button9.Text = "x"; break; }


                        }
                    jumpo3:
                        h = 0;
                        array2 += Convert.ToString(number);
                        index++;

                        label13.Text = array2;
                        index2++;
                    }
            //Draw
            if (button1.Text != "." && button2.Text != "." && button3.Text != "." && button4.Text != "." && button5.Text != "." && button6.Text != "." && button7.Text != "." && button8.Text != "." && button9.Text != "." && label1.Text != "The winner is O" && label1.Text != "The winner is X")
            { label1.Text = "It is a draw"; }
            //
            if (button1.Text == "o" && button2.Text == "o" && button3.Text == "o")
            { label1.Text = "The winner is O"; }
            else if (button3.Text == "o" && button6.Text == "o" && button9.Text == "o")
            { label1.Text = "The winner is O"; }
            else if (button9.Text == "o" && button8.Text == "o" && button7.Text == "o")
            { label1.Text = "The winner is O"; }
            else if (button7.Text == "o" && button4.Text == "o" && button1.Text == "o")
            { label1.Text = "The winner is O"; }
            else if (button1.Text == "o" && button5.Text == "o" && button9.Text == "o")
            { label1.Text = "The winner is O"; }
            else if (button3.Text == "o" && button5.Text == "o" && button7.Text == "o")
            { label1.Text = "The winner is O"; }
            else if (button4.Text == "o" && button5.Text == "o" && button6.Text == "o")
            { label1.Text = "The winner is O"; }
            else if (button4.Text == "o" && button5.Text == "o" && button6.Text == "o")
            { label1.Text = "The winner is O"; }
            else if (button2.Text == "o" && button5.Text == "o" && button8.Text == "o")
            { label1.Text = "The winner is O"; }

            if (button1.Text == "x" && button2.Text == "x" && button3.Text == "x")
            { label1.Text = "The winner is X"; }
            else if (button3.Text == "x" && button6.Text == "x" && button9.Text == "x")
            { label1.Text = "The winner is X"; }
            else if (button9.Text == "x" && button8.Text == "x" && button7.Text == "x")
            { label1.Text = "The winner is X"; }
            else if (button7.Text == "x" && button4.Text == "x" && button1.Text == "x")
            { label1.Text = "The winner is X"; }
            else if (button1.Text == "x" && button5.Text == "x" && button9.Text == "x")
            { label1.Text = "The winner is X"; }
            else if (button3.Text == "x" && button5.Text == "x" && button7.Text == "x")
            { label1.Text = "The winner is X"; }
            else if (button4.Text == "x" && button5.Text == "x" && button6.Text == "x")
            { label1.Text = "The winner is X"; }
            else if (button4.Text == "x" && button5.Text == "x" && button6.Text == "x")
            { label1.Text = "The winner is X"; }
            else if (button2.Text == "x" && button5.Text == "x" && button8.Text == "x")
            { label1.Text = "The winner is X"; }

            if (label1.Text == "The winner is O")
            {
                win(array2);
            }
            if (label1.Text == "The winner is X")
            {
                winO(array2);
            }
            if (label1.Text != "Winner is:")
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;

            }
        }

        public void Button4_Click(object sender, EventArgs e)
        {
            while (array[index] == 4 && button4.Text != ".")
            { new Random().Shuffle(array); }

            if (player == 1)
            { button4.Text = "x";
                array2 += "4";
                if (button1.Text == "x" && button2.Text == "x" && ( button3.Text ==".")) { number = 3; button3.Text = "o"; goto jump4; }
                else if (button1.Text == "x" && button3.Text == "x" && ( button2.Text ==".")) { number = 2; button2.Text = "o"; goto jump4; }
                else if (button3.Text == "x" && button2.Text == "x" && ( button1.Text ==".")) { number = 1; button1.Text = "o"; goto jump4; }

                if (button4.Text == "x" && button5.Text == "x" && ( button6.Text ==".")) { number = 6; button6.Text = "o"; goto jump4; }
                else if (button5.Text == "x" && button6.Text == "x" && ( button4.Text ==".")) { number = 4; button4.Text = "o"; goto jump4; }
                else if (button6.Text == "x" && button4.Text == "x" && ( button5.Text ==".")) { number = 5; button5.Text = "o"; goto jump4; }

                if (button8.Text == "x" && button9.Text == "x" && ( button7.Text ==".")) { number = 7; button7.Text = "o"; goto jump4; }
                else if (button7.Text == "x" && button9.Text == "x" && ( button8.Text ==".")) { number = 8; button8.Text = "o"; goto jump4; }
                else if (button7.Text == "x" && button8.Text == "x" && ( button9.Text ==".")) { number = 9; button9.Text = "o"; goto jump4; }

                if (button4.Text == "x" && button7.Text == "x" && ( button1.Text ==".")) { number = 1; button1.Text = "o"; goto jump4; }
                else if (button1.Text == "x" && button7.Text == "x" && ( button4.Text ==".")) { number = 4; button4.Text = "o"; goto jump4; }
                else if (button4.Text == "x" && button1.Text == "x" && ( button7.Text ==".")) { number = 7; button7.Text = "o"; goto jump4; }

                if (button5.Text == "x" && button8.Text == "x" && ( button2.Text ==".")) { number = 2; button2.Text = "o"; goto jump4; }
                else if (button2.Text == "x" && button8.Text == "x" && ( button5.Text ==".")) { number = 5; button5.Text = "o"; goto jump4; }
                else if (button2.Text == "x" && button5.Text == "x" && ( button8.Text ==".")) { number = 8; button8.Text = "o"; goto jump4; }

                if (button6.Text == "x" && button9.Text == "x" && ( button3.Text ==".")) { number = 3; button3.Text = "o"; goto jump4; }
                else if (button3.Text == "x" && button9.Text == "x" && ( button6.Text ==".")) { number = 6; button6.Text = "o"; goto jump4; }
                else if (button3.Text == "x" && button6.Text == "x" && ( button9.Text ==".")) { number = 9; button9.Text = "o"; goto jump4; }

                if (button5.Text == "x" && button9.Text == "x" && ( button1.Text ==".")) { number = 1; button1.Text = "o"; goto jump4; }
                else if (button1.Text == "x" && button9.Text == "x" && ( button5.Text ==".")) { number = 5; button5.Text = "o"; goto jump4; }
                else if (button1.Text == "x" && button5.Text == "x" && ( button9.Text ==".")) { number = 9; button9.Text = "o"; goto jump4; }

                if (button5.Text == "x" && button7.Text == "x" && ( button3.Text ==".")) { number = 3; button3.Text = "o"; goto jump4; }
                else if (button3.Text == "x" && button7.Text == "x" && ( button5.Text ==".")) { number = 5; button5.Text = "o"; goto jump4; }
                else if (button3.Text == "x" && button5.Text == "x" && ( button7.Text ==".")) { number = 7; button7.Text = "o"; goto jump4; }

                ai(array2, 0);
                h = ai(array2, h);
                if (h == 1) { goto jump4; }
                for (int i = 0; i <= 1000; i++)
                {
                    number = rnd.Next(1, 10);
                    if (number == 1 && button1.Text == ".")
                    { button1.Text = "o"; break; }
                    if (number == 2 && button2.Text == ".")
                    { button2.Text = "o"; break; }
                    if (number == 3 && button3.Text == ".")
                    { button3.Text = "o"; break; }
                    if (number == 4 && button4.Text == ".")
                    {  }
                    if (number == 5 && button5.Text == ".")
                    { button5.Text = "o"; break; }
                    if (number == 6 && button6.Text == ".")
                    { button6.Text = "o"; break; }
                    if (number == 7 && button7.Text == ".")
                    { button7.Text = "o"; break; }
                    if (number == 8 && button8.Text == ".")
                    { button8.Text = "o"; break; }
                    if (number == 9 && button9.Text == ".")
                    { button9.Text = "o"; break; }

                }
                jump4:

                h = 0;
                 
                index++;
                
                array2 += Convert.ToString(number);
                index2++;
                label13.Text = array2;

            }
            else if (player == 2)
            { button4.Text = "o"; 
                
                    button4.Text = "o";
                    array2 += "4";
                if (button1.Text == "o" && button2.Text == "x" && (button3.Text == ".")) { number = 3; button3.Text = "x"; goto jumpo4; }
                else if (button1.Text == "o" && button3.Text == "o" && (button2.Text == ".")) { number = 2; button2.Text = "x"; goto jumpo4; }
                else if (button3.Text == "o" && button2.Text == "o" && button1.Text == ".") { number = 1; button1.Text = "x"; goto jumpo4; }

                if (button4.Text == "o" && button5.Text == "o" && (button6.Text == ".")) { number = 6; button6.Text = "x"; goto jumpo4; }
                else if (button5.Text == "o" && button6.Text == "o" && (button4.Text == ".")) { number = 4; button4.Text = "x"; goto jumpo4; }
                else if (button6.Text == "o" && button4.Text == "o" && (button5.Text == ".")) { number = 5; button5.Text = "x"; goto jumpo4; }

                if (button8.Text == "o" && button9.Text == "o" && (button7.Text == ".")) { number = 7; button7.Text = "x"; goto jumpo4; }
                else if (button7.Text == "o" && button9.Text == "o" && (button8.Text == ".")) { number = 8; button8.Text = "x"; goto jumpo4; }
                else if (button7.Text == "o" && button8.Text == "o" && (button9.Text == ".")) { number = 9; button9.Text = "x"; goto jumpo4; }

                if (button4.Text == "o" && button7.Text == "o" && (button1.Text == ".")) { number = 1; button1.Text = "x"; goto jumpo4; }
                else if (button1.Text == "o" && button7.Text == "o" && (button4.Text == ".")) { number = 4; button4.Text = "x"; goto jumpo4; }
                else if (button4.Text == "o" && button1.Text == "o" && (button7.Text == ".")) { number = 7; button7.Text = "x"; goto jumpo4; }

                if (button5.Text == "o" && button8.Text == "o" && (button2.Text == ".")) { number = 2; button2.Text = "x"; goto jumpo4; }
                else if (button2.Text == "o" && button8.Text == "o" && (button5.Text == ".")) { number = 5; button5.Text = "x"; goto jumpo4; }
                else if (button2.Text == "o" && button5.Text == "o" && (button8.Text == ".")) { number = 8; button8.Text = "x"; goto jumpo4; }

                if (button6.Text == "o" && button9.Text == "o" && (button3.Text == ".")) { number = 3; button3.Text = "x"; goto jumpo4; }
                else if (button3.Text == "o" && button9.Text == "o" && (button6.Text == ".")) { number = 6; button6.Text = "x"; goto jumpo4; }
                else if (button3.Text == "o" && button6.Text == "o" && (button9.Text == ".")) { number = 9; button9.Text = "x"; goto jumpo4; }

                if (button5.Text == "o" && button9.Text == "o" && (button1.Text == ".")) { number = 1; button1.Text = "x"; goto jumpo4; }
                else if (button1.Text == "o" && button9.Text == "o" && (button5.Text == ".")) { number = 5; button5.Text = "x"; goto jumpo4; }
                else if (button1.Text == "o" && button5.Text == "o" && (button9.Text == ".")) { number = 9; button9.Text = "x"; goto jumpo4; }

                if (button5.Text == "o" && button7.Text == "o" && (button3.Text == ".")) { number = 3; button3.Text = "x"; goto jumpo4; }
                else if (button3.Text == "o" && button7.Text == "o" && (button5.Text == ".")) { number = 5; button5.Text = "x"; goto jumpo4; }
                else if (button3.Text == "o" && button5.Text == "o" && (button7.Text == ".")) { number = 7; button7.Text = "x"; goto jumpo4; }
                aiO(array2, 0);
                     
                   
                    h = aiO(array2, h);
                    if (h == 1) {   goto jumpo4; }
                    for (int i = 0; i <= 1000; i++)
                    {
                        number = rnd.Next(1, 10);
                        if (number == 1 && button1.Text == ".")
                        { button1.Text = "x"; break; }
                        if (number == 2 && button2.Text == ".")
                        { button2.Text = "x"; break; }
                        if (number == 3 && button3.Text == ".")
                        { button3.Text = "x"; break; }
                        if (number == 4 && button4.Text == ".")
                        { }
                        if (number == 5 && button5.Text == ".")
                        { button5.Text = "x"; break; }
                        if (number == 6 && button6.Text == ".")
                        { button6.Text = "x"; break; }
                        if (number == 7 && button7.Text == ".")
                        { button7.Text = "x"; break; }
                        if (number == 8 && button8.Text == ".")
                        { button8.Text = "x"; break; }
                        if (number == 9 && button9.Text == ".")
                        { button9.Text = "x"; break; }


                    }
                jumpo4:
                    h = 0;
                    array2 += Convert.ToString(number);
                    index++;

                    label13.Text = array2;
                    index2++;
                }
            //Draw
            if (button1.Text != "." && button2.Text != "." && button3.Text != "." && button4.Text != "." && button5.Text != "." && button6.Text != "." && button7.Text != "." && button8.Text != "." && button9.Text != "." && label1.Text != "The winner is O" && label1.Text != "The winner is X")
            { label1.Text = "It is a draw"; }
            //
            if (button1.Text == "o" && button2.Text == "o" && button3.Text == "o")
            { label1.Text = "The winner is O"; }
            else if (button3.Text == "o" && button6.Text == "o" && button9.Text == "o")
            { label1.Text = "The winner is O"; }
            else if (button9.Text == "o" && button8.Text == "o" && button7.Text == "o")
            { label1.Text = "The winner is O"; }
            else if (button7.Text == "o" && button4.Text == "o" && button1.Text == "o")
            { label1.Text = "The winner is O"; }
            else if (button1.Text == "o" && button5.Text == "o" && button9.Text == "o")
            { label1.Text = "The winner is O"; }
            else if (button3.Text == "o" && button5.Text == "o" && button7.Text == "o")
            { label1.Text = "The winner is O"; }
            else if (button4.Text == "o" && button5.Text == "o" && button6.Text == "o")
            { label1.Text = "The winner is O"; }
            else if (button4.Text == "o" && button5.Text == "o" && button6.Text == "o")
            { label1.Text = "The winner is O"; }
            else if (button2.Text == "o" && button5.Text == "o" && button8.Text == "o")
            { label1.Text = "The winner is O"; }

            if (button1.Text == "x" && button2.Text == "x" && button3.Text == "x")
            { label1.Text = "The winner is X"; }
            else if (button3.Text == "x" && button6.Text == "x" && button9.Text == "x")
            { label1.Text = "The winner is X"; }
            else if (button9.Text == "x" && button8.Text == "x" && button7.Text == "x")
            { label1.Text = "The winner is X"; }
            else if (button7.Text == "x" && button4.Text == "x" && button1.Text == "x")
            { label1.Text = "The winner is X"; }
            else if (button1.Text == "x" && button5.Text == "x" && button9.Text == "x")
            { label1.Text = "The winner is X"; }
            else if (button3.Text == "x" && button5.Text == "x" && button7.Text == "x")
            { label1.Text = "The winner is X"; }
            else if (button4.Text == "x" && button5.Text == "x" && button6.Text == "x")
            { label1.Text = "The winner is X"; }
            else if (button4.Text == "x" && button5.Text == "x" && button6.Text == "x")
            { label1.Text = "The winner is X"; }
            else if (button2.Text == "x" && button5.Text == "x" && button8.Text == "x")
            { label1.Text = "The winner is X"; }

            if (label1.Text == "The winner is O")
            {
                win(array2);
            }
            if (label1.Text == "The winner is X")
            {
                winO(array2);
            }
            if (label1.Text != "Winner is:")
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;

            }
        }

        public void Button5_Click(object sender, EventArgs e)
        {

            while (array[index] == 5 && button5.Text != ".")
            { new Random().Shuffle(array); }
            if (player == 1)
            { button5.Text = "x";
                array2 += "5";
                if      (button1.Text == "x" && button2.Text == "x" && ( button3.Text ==".")) { number = 3; button3.Text = "o"; goto jump5; }
                else if (button1.Text == "x" && button3.Text == "x" && ( button2.Text ==".")) { number = 2; button2.Text = "o"; goto jump5; }
                else if (button3.Text == "x" && button2.Text == "x" && ( button1.Text ==".")) { number = 1; button1.Text = "o"; goto jump5; }

                if      (button4.Text == "x" && button5.Text == "x" && ( button6.Text ==".")) { number = 6; button6.Text = "o"; goto jump5; }
                else if (button5.Text == "x" && button6.Text == "x" && ( button4.Text ==".")) { number = 4; button4.Text = "o"; goto jump5; }
                else if (button6.Text == "x" && button4.Text == "x" && ( button5.Text ==".")) { number = 5; button5.Text = "o"; goto jump5; }
                 
                if      (button8.Text == "x" && button9.Text == "x" && ( button7.Text ==".")) { number = 7; button7.Text = "o"; goto jump5; }
                else if (button7.Text == "x" && button9.Text == "x" && ( button8.Text ==".")) { number = 8; button8.Text = "o"; goto jump5; }
                else if (button7.Text == "x" && button8.Text == "x" && ( button9.Text ==".")) { number = 9; button9.Text = "o"; goto jump5; }

                if      (button4.Text == "x" && button7.Text == "x" && ( button1.Text ==".")) { number = 1; button1.Text = "o"; goto jump5; }
                else if (button1.Text == "x" && button7.Text == "x" && ( button4.Text ==".")) { number = 4; button4.Text = "o"; goto jump5; }
                else if (button4.Text == "x" && button1.Text == "x" && ( button7.Text ==".")) { number = 7; button7.Text = "o"; goto jump5; }

                if      (button5.Text == "x" && button8.Text == "x" && ( button2.Text ==".")) { number = 2; button2.Text = "o"; goto jump5; }
                else if (button2.Text == "x" && button8.Text == "x" && ( button5.Text ==".")) { number = 5; button5.Text = "o"; goto jump5; }
                else if (button2.Text == "x" && button5.Text == "x" && ( button8.Text ==".")) { number = 8; button8.Text = "o"; goto jump5; }

                if      (button6.Text == "x" && button9.Text == "x" && ( button3.Text ==".")) { number = 3; button3.Text = "o"; goto jump5; }
                else if (button3.Text == "x" && button9.Text == "x" && ( button6.Text ==".")) { number = 6; button6.Text = "o"; goto jump5; }
                else if (button3.Text == "x" && button6.Text == "x" && ( button9.Text ==".")) { number = 9; button9.Text = "o"; goto jump5; }

                if      (button5.Text == "x" && button9.Text == "x" && ( button1.Text ==".")) { number = 1; button1.Text = "o"; goto jump5; }
                else if (button1.Text == "x" && button9.Text == "x" && ( button5.Text ==".")) { number = 5; button5.Text = "o"; goto jump5; }
                else if (button1.Text == "x" && button5.Text == "x" && ( button9.Text ==".")) { number = 9; button9.Text = "o"; goto jump5; }

                if      (button5.Text == "x" && button7.Text == "x" && ( button3.Text ==".")) { number = 3; button3.Text = "o"; goto jump5; }
                else if (button3.Text == "x" && button7.Text == "x" && ( button5.Text ==".")) { number = 5; button5.Text = "o"; goto jump5; }
                else if (button3.Text == "x" && button5.Text == "x" && ( button7.Text ==".")) { number = 7; button7.Text = "o"; goto jump5; }
                ai(array2, 0);
                h = ai(array2, h);
                if (h == 1) { goto jump5; }
                for (int i = 0; i <= 1000; i++)
                {
                    number = rnd.Next(1, 10);
                    if (number == 1 && button1.Text == ".")
                    { button1.Text = "o"; break; }
                    if (number == 2 && button2.Text == ".")
                    { button2.Text = "o"; break; }
                    if (number == 3 && button3.Text == ".")
                    { button3.Text = "o"; break; }
                    if (number == 4 && button4.Text == ".")
                    { button4.Text = "o"; break; }
                    if (number == 5 && button5.Text == ".")
                    {  }
                    if (number == 6 && button6.Text == ".")
                    { button6.Text = "o"; break; }
                    if (number == 7 && button7.Text == ".")
                    { button7.Text = "o"; break; }
                    if (number == 8 && button8.Text == ".")
                    { button8.Text = "o"; break; }
                    if (number == 9 && button9.Text == ".")
                    { button9.Text = "o"; break; }

                }
                jump5:

                h = 0;
                 
                index++;
              
                array2 += Convert.ToString(number);
                index2++;
                label13.Text = array2;

            }
            else if (player == 2)
            {
                button5.Text = "o";
                array2 += "5";
                if (button1.Text == "o" && button2.Text == "x" && (button3.Text == ".")) { number = 3; button3.Text = "x"; goto jumpo5; }
                else if (button1.Text == "o" && button3.Text == "o" && (button2.Text == ".")) { number = 2; button2.Text = "x"; goto jumpo5; }
                else if (button3.Text == "o" && button2.Text == "o" && button1.Text == ".") { number = 1; button1.Text = "x"; goto jumpo5; }

                if (button4.Text == "o" && button5.Text == "o" && (button6.Text == ".")) { number = 6; button6.Text = "x"; goto jumpo5; }
                else if (button5.Text == "o" && button6.Text == "o" && (button4.Text == ".")) { number = 4; button4.Text = "x"; goto jumpo5; }
                else if (button6.Text == "o" && button4.Text == "o" && (button5.Text == ".")) { number = 5; button5.Text = "x"; goto jumpo5; }

                if (button8.Text == "o" && button9.Text == "o" && (button7.Text == ".")) { number = 7; button7.Text = "x"; goto jumpo5; }
                else if (button7.Text == "o" && button9.Text == "o" && (button8.Text == ".")) { number = 8; button8.Text = "x"; goto jumpo5; }
                else if (button7.Text == "o" && button8.Text == "o" && (button9.Text == ".")) { number = 9; button9.Text = "x"; goto jumpo5; }

                if (button4.Text == "o" && button7.Text == "o" && (button1.Text == ".")) { number = 1; button1.Text = "x"; goto jumpo5; }
                else if (button1.Text == "o" && button7.Text == "o" && (button4.Text == ".")) { number = 4; button4.Text = "x"; goto jumpo5; }
                else if (button4.Text == "o" && button1.Text == "o" && (button7.Text == ".")) { number = 7; button7.Text = "x"; goto jumpo5; }

                if (button5.Text == "o" && button8.Text == "o" && (button2.Text == ".")) { number = 2; button2.Text = "x"; goto jumpo5; }
                else if (button2.Text == "o" && button8.Text == "o" && (button5.Text == ".")) { number = 5; button5.Text = "x"; goto jumpo5; }
                else if (button2.Text == "o" && button5.Text == "o" && (button8.Text == ".")) { number = 8; button8.Text = "x"; goto jumpo5; }

                if (button6.Text == "o" && button9.Text == "o" && (button3.Text == ".")) { number = 3; button3.Text = "x"; goto jumpo5; }
                else if (button3.Text == "o" && button9.Text == "o" && (button6.Text == ".")) { number = 6; button6.Text = "x"; goto jumpo5; }
                else if (button3.Text == "o" && button6.Text == "o" && (button9.Text == ".")) { number = 9; button9.Text = "x"; goto jumpo5; }

                if (button5.Text == "o" && button9.Text == "o" && (button1.Text == ".")) { number = 1; button1.Text = "x"; goto jumpo5; }
                else if (button1.Text == "o" && button9.Text == "o" && (button5.Text == ".")) { number = 5; button5.Text = "x"; goto jumpo5; }
                else if (button1.Text == "o" && button5.Text == "o" && (button9.Text == ".")) { number = 9; button9.Text = "x"; goto jumpo5; }

                if (button5.Text == "o" && button7.Text == "o" && (button3.Text == ".")) { number = 3; button3.Text = "x"; goto jumpo5; }
                else if (button3.Text == "o" && button7.Text == "o" && (button5.Text == ".")) { number = 5; button5.Text = "x"; goto jumpo5; }
                else if (button3.Text == "o" && button5.Text == "o" && (button7.Text == ".")) { number = 7; button7.Text = "x"; goto jumpo5; }
                aiO(array2, 0);
                 
                 
                h = aiO(array2, h);
                if (h == 1) {   goto jumpo5; }
                for (int i = 0; i <= 1000; i++)
                {
                    number = rnd.Next(1, 10);
                    if (number == 1 && button1.Text == ".")
                    { button1.Text = "x"; break; }
                    if (number == 2 && button2.Text == ".")
                    { button2.Text = "x"; break; }
                    if (number == 3 && button3.Text == ".")
                    { button3.Text = "x"; break; }
                    if (number == 4 && button4.Text == ".")
                    { button4.Text = "x"; break; }
                    if (number == 5 && button5.Text == ".")
                    {  }
                    if (number == 6 && button6.Text == ".")
                    { button6.Text = "x"; break; }
                    if (number == 7 && button7.Text == ".")
                    { button7.Text = "x"; break; }
                    if (number == 8 && button8.Text == ".")
                    { button8.Text = "x"; break; }
                    if (number == 9 && button9.Text == ".")
                    { button9.Text = "x"; break; }


                }
            jumpo5:
                h = 0;
                array2 += Convert.ToString(number);
                index++;

                label13.Text = array2;
                index2++;
            }
            //Draw
            if (button1.Text != "." && button2.Text != "." && button3.Text != "." && button4.Text != "." && button5.Text != "." && button6.Text != "." && button7.Text != "." && button8.Text != "." && button9.Text != "." && label1.Text != "The winner is O" && label1.Text != "The winner is X")
            { label1.Text = "It is a draw"; }
            //
            if (button1.Text == "o" && button2.Text == "o" && button3.Text == "o")
            { label1.Text = "The winner is O"; }
            else if (button3.Text == "o" && button6.Text == "o" && button9.Text == "o")
            { label1.Text = "The winner is O"; }
            else if (button9.Text == "o" && button8.Text == "o" && button7.Text == "o")
            { label1.Text = "The winner is O"; }
            else if (button7.Text == "o" && button4.Text == "o" && button1.Text == "o")
            { label1.Text = "The winner is O"; }
            else if (button1.Text == "o" && button5.Text == "o" && button9.Text == "o")
            { label1.Text = "The winner is O"; }
            else if (button3.Text == "o" && button5.Text == "o" && button7.Text == "o")
            { label1.Text = "The winner is O"; }
            else if (button4.Text == "o" && button5.Text == "o" && button6.Text == "o")
            { label1.Text = "The winner is O"; }
            else if (button4.Text == "o" && button5.Text == "o" && button6.Text == "o")
            { label1.Text = "The winner is O"; }
            else if (button2.Text == "o" && button5.Text == "o" && button8.Text == "o")
            { label1.Text = "The winner is O"; }

            if (button1.Text == "x" && button2.Text == "x" && button3.Text == "x")
            { label1.Text = "The winner is X"; }
            else if (button3.Text == "x" && button6.Text == "x" && button9.Text == "x")
            { label1.Text = "The winner is X"; }
            else if (button9.Text == "x" && button8.Text == "x" && button7.Text == "x")
            { label1.Text = "The winner is X"; }
            else if (button7.Text == "x" && button4.Text == "x" && button1.Text == "x")
            { label1.Text = "The winner is X"; }
            else if (button1.Text == "x" && button5.Text == "x" && button9.Text == "x")
            { label1.Text = "The winner is X"; }
            else if (button3.Text == "x" && button5.Text == "x" && button7.Text == "x")
            { label1.Text = "The winner is X"; }
            else if (button4.Text == "x" && button5.Text == "x" && button6.Text == "x")
            { label1.Text = "The winner is X"; }
            else if (button4.Text == "x" && button5.Text == "x" && button6.Text == "x")
            { label1.Text = "The winner is X"; }
            else if (button2.Text == "x" && button5.Text == "x" && button8.Text == "x")
            { label1.Text = "The winner is X"; }

            if (label1.Text == "The winner is O")
            {
                win(array2);
            }
            if (label1.Text == "The winner is X")
            {
                winO(array2);
            }
            if (label1.Text != "Winner is:")
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;

            }
        }

        public void Button6_Click(object sender, EventArgs e)
        {
            while (array[index] == 6 && button6.Text != ".")
            { new Random().Shuffle(array); }

            if (player == 1)
            { button6.Text = "x";
                array2 += "6";
                if (button1.Text == "x" && button2.Text == "x" && (button3.Text != "o" || button3.Text ==".")) { number = 3; button3.Text = "o"; goto jump6; }
                else if (button1.Text == "x" && button3.Text == "x" && (button2.Text != "o" || button2.Text ==".")) { number = 2; button2.Text = "o"; goto jump6; }
                else if (button3.Text == "x" && button2.Text == "x" && ( button1.Text ==".")) { number = 1; button1.Text = "o"; goto jump6; }

                if (button4.Text == "x" && button5.Text == "x" && (button6.Text != "o" || button6.Text ==".")) { number = 6; button6.Text = "o"; goto jump6; }
                else if (button5.Text == "x" && button6.Text == "x" && (button4.Text != "o" || button4.Text ==".")) { number = 4; button4.Text = "o"; goto jump6; }
                else if (button6.Text == "x" && button4.Text == "x" && (button5.Text != "o" || button5.Text ==".")) { number = 5; button5.Text = "o"; goto jump6; }

                if (button8.Text == "x" && button9.Text == "x" && (button7.Text != "o" || button7.Text ==".")) { number = 7; button7.Text = "o"; goto jump6; }
                else if (button7.Text == "x" && button9.Text == "x" && (button8.Text != "o" || button8.Text ==".")) { number = 8; button8.Text = "o"; goto jump6; }
                else if (button7.Text == "x" && button8.Text == "x" && (button9.Text != "o" || button9.Text ==".")) { number = 9; button9.Text = "o"; goto jump6; }

                if (button4.Text == "x" && button7.Text == "x" && ( button1.Text ==".")) { number = 1; button1.Text = "o"; goto jump6; }
                else if (button1.Text == "x" && button7.Text == "x" && (button4.Text != "o" || button4.Text ==".")) { number = 4; button4.Text = "o"; goto jump6; }
                else if (button4.Text == "x" && button1.Text == "x" && (button7.Text != "o" || button7.Text ==".")) { number = 7; button7.Text = "o"; goto jump6; }

                if (button5.Text == "x" && button8.Text == "x" && (button2.Text != "o" || button2.Text ==".")) { number = 2; button2.Text = "o"; goto jump6; }
                else if (button2.Text == "x" && button8.Text == "x" && (button5.Text != "o" || button5.Text ==".")) { number = 5; button5.Text = "o"; goto jump6; }
                else if (button2.Text == "x" && button5.Text == "x" && (button8.Text != "o" || button8.Text ==".")) { number = 8; button8.Text = "o"; goto jump6; }

                if (button6.Text == "x" && button9.Text == "x" && (button3.Text != "o" || button3.Text ==".")) { number = 3; button3.Text = "o"; goto jump6; }
                else if (button3.Text == "x" && button9.Text == "x" && (button6.Text != "o" || button6.Text ==".")) { number = 6; button6.Text = "o"; goto jump6; }
                else if (button3.Text == "x" && button6.Text == "x" && (button9.Text != "o" || button9.Text ==".")) { number = 9; button9.Text = "o"; goto jump6; }

                if (button5.Text == "x" && button9.Text == "x" && ( button1.Text ==".")) { number = 1; button1.Text = "o"; goto jump6; }
                else if (button1.Text == "x" && button9.Text == "x" && (button5.Text != "o" || button5.Text ==".")) { number = 5; button5.Text = "o"; goto jump6; }
                else if (button1.Text == "x" && button5.Text == "x" && (button9.Text != "o" || button9.Text ==".")) { number = 9; button9.Text = "o"; goto jump6; }

                if (button5.Text == "x" && button7.Text == "x" && (button3.Text != "o" || button3.Text ==".")) { number = 3; button3.Text = "o"; goto jump6; }
                else if (button3.Text == "x" && button7.Text == "x" && (button5.Text != "o" || button5.Text ==".")) { number = 5; button5.Text = "o"; goto jump6; }
                else if (button3.Text == "x" && button5.Text == "x" && (button7.Text != "o" || button7.Text ==".")) { number = 7; button7.Text = "o"; goto jump6; }
                ai(array2, 0);
                h = ai(array2, h);
                if (h == 1) { goto jump6; }
                for (int i = 0; i <= 1000; i++)
                {
                    number = rnd.Next(1, 10);
                    if (number == 1 && button1.Text == ".")
                    { button1.Text = "o"; break; }
                    if (number == 2 && button2.Text == ".")
                    { button2.Text = "o"; break; }
                    if (number == 3 && button3.Text == ".")
                    { button3.Text = "o"; break; }
                    if (number == 4 && button4.Text == ".")
                    { button4.Text = "o"; break; }
                    if (number == 5 && button5.Text == ".")
                    { button5.Text = "o"; break; }
                    if (number == 6 && button6.Text == ".")
                    {  }
                    if (number == 7 && button7.Text == ".")
                    { button7.Text = "o"; break; }
                    if (number == 8 && button8.Text == ".")
                    { button8.Text = "o"; break; }
                    if (number == 9 && button9.Text == ".")
                    { button9.Text = "o"; break; }

                }
                jump6:

                h = 0;
                 

                index++;
                
                array2 += Convert.ToString(number);
                index2++;
                label13.Text = array2;
            }
            else if (player == 2)
            {
                button6.Text = "o";
                array2 += "6";
                if (button1.Text == "o" && button2.Text == "x" && (button3.Text == ".")) { number = 3; button3.Text = "x"; goto jumpo6; }
                else if (button1.Text == "o" && button3.Text == "o" && (button2.Text == ".")) { number = 2; button2.Text = "x"; goto jumpo6; }
                else if (button3.Text == "o" && button2.Text == "o" && button1.Text == ".") { number = 1; button1.Text = "x"; goto jumpo6; }

                if (button4.Text == "o" && button5.Text == "o" && (button6.Text == ".")) { number = 6; button6.Text = "x"; goto jumpo6; }
                else if (button5.Text == "o" && button6.Text == "o" && (button4.Text == ".")) { number = 4; button4.Text = "x"; goto jumpo6; }
                else if (button6.Text == "o" && button4.Text == "o" && (button5.Text == ".")) { number = 5; button5.Text = "x"; goto jumpo6; }

                if (button8.Text == "o" && button9.Text == "o" && (button7.Text == ".")) { number = 7; button7.Text = "x"; goto jumpo6; }
                else if (button7.Text == "o" && button9.Text == "o" && (button8.Text == ".")) { number = 8; button8.Text = "x"; goto jumpo6; }
                else if (button7.Text == "o" && button8.Text == "o" && (button9.Text == ".")) { number = 9; button9.Text = "x"; goto jumpo6; }

                if (button4.Text == "o" && button7.Text == "o" && (button1.Text == ".")) { number = 1; button1.Text = "x"; goto jumpo6; }
                else if (button1.Text == "o" && button7.Text == "o" && (button4.Text == ".")) { number = 4; button4.Text = "x"; goto jumpo6; }
                else if (button4.Text == "o" && button1.Text == "o" && (button7.Text == ".")) { number = 7; button7.Text = "x"; goto jumpo6; }

                if (button5.Text == "o" && button8.Text == "o" && (button2.Text == ".")) { number = 2; button2.Text = "x"; goto jumpo6; }
                else if (button2.Text == "o" && button8.Text == "o" && (button5.Text == ".")) { number = 5; button5.Text = "x"; goto jumpo6; }
                else if (button2.Text == "o" && button5.Text == "o" && (button8.Text == ".")) { number = 8; button8.Text = "x"; goto jumpo6; }

                if (button6.Text == "o" && button9.Text == "o" && (button3.Text == ".")) { number = 3; button3.Text = "x"; goto jumpo6; }
                else if (button3.Text == "o" && button9.Text == "o" && (button6.Text == ".")) { number = 6; button6.Text = "x"; goto jumpo6; }
                else if (button3.Text == "o" && button6.Text == "o" && (button9.Text == ".")) { number = 9; button9.Text = "x"; goto jumpo6; }

                if (button5.Text == "o" && button9.Text == "o" && (button1.Text == ".")) { number = 1; button1.Text = "x"; goto jumpo6; }
                else if (button1.Text == "o" && button9.Text == "o" && (button5.Text == ".")) { number = 5; button5.Text = "x"; goto jumpo6; }
                else if (button1.Text == "o" && button5.Text == "o" && (button9.Text == ".")) { number = 9; button9.Text = "x"; goto jumpo6; }

                if (button5.Text == "o" && button7.Text == "o" && (button3.Text == ".")) { number = 3; button3.Text = "x"; goto jumpo6; }
                else if (button3.Text == "o" && button7.Text == "o" && (button5.Text == ".")) { number = 5; button5.Text = "x"; goto jumpo6; }
                else if (button3.Text == "o" && button5.Text == "o" && (button7.Text == ".")) { number = 7; button7.Text = "x"; goto jumpo6; }
                aiO(array2, 0);
                 
                 
                h = aiO(array2, h);
                if (h == 1) {   goto jumpo6; }
                for (int i = 0; i <= 1000; i++)
                {
                    number = rnd.Next(1, 10);
                    if (number == 1 && button1.Text == ".")
                    { button1.Text = "x"; break; }
                    if (number == 2 && button2.Text == ".")
                    { button2.Text = "x"; break; }
                    if (number == 3 && button3.Text == ".")
                    { button3.Text = "x"; break; }
                    if (number == 4 && button4.Text == ".")
                    { button4.Text = "x"; break; }
                    if (number == 5 && button5.Text == ".")
                    { button5.Text = "x"; break; }
                    if (number == 6 && button6.Text == ".")
                    {  }
                    if (number == 7 && button7.Text == ".")
                    { button7.Text = "x"; break; }
                    if (number == 8 && button8.Text == ".")
                    { button8.Text = "x"; break; }
                    if (number == 9 && button9.Text == ".")
                    { button9.Text = "x"; break; }


                }
            jumpo6:
                h = 0;
                array2 += Convert.ToString(number);
                index++;

                label13.Text = array2;
                index2++;
            }
            //Draw
            if (button1.Text != "." && button2.Text != "." && button3.Text != "." && button4.Text != "." && button5.Text != "." && button6.Text != "." && button7.Text != "." && button8.Text != "." && button9.Text != "." && label1.Text != "The winner is O" && label1.Text != "The winner is X")
            { label1.Text = "It is a draw"; }
            //
            if (button1.Text == "o" && button2.Text == "o" && button3.Text == "o")
            { label1.Text = "The winner is O"; }
            else if (button3.Text == "o" && button6.Text == "o" && button9.Text == "o")
            { label1.Text = "The winner is O"; }
            else if (button9.Text == "o" && button8.Text == "o" && button7.Text == "o")
            { label1.Text = "The winner is O"; }
            else if (button7.Text == "o" && button4.Text == "o" && button1.Text == "o")
            { label1.Text = "The winner is O"; }
            else if (button1.Text == "o" && button5.Text == "o" && button9.Text == "o")
            { label1.Text = "The winner is O"; }
            else if (button3.Text == "o" && button5.Text == "o" && button7.Text == "o")
            { label1.Text = "The winner is O"; }
            else if (button4.Text == "o" && button5.Text == "o" && button6.Text == "o")
            { label1.Text = "The winner is O"; }
            else if (button4.Text == "o" && button5.Text == "o" && button6.Text == "o")
            { label1.Text = "The winner is O"; }
            else if (button2.Text == "o" && button5.Text == "o" && button8.Text == "o")
            { label1.Text = "The winner is O"; }

            if (button1.Text == "x" && button2.Text == "x" && button3.Text == "x")
            { label1.Text = "The winner is X"; }
            else if (button3.Text == "x" && button6.Text == "x" && button9.Text == "x")
            { label1.Text = "The winner is X"; }
            else if (button9.Text == "x" && button8.Text == "x" && button7.Text == "x")
            { label1.Text = "The winner is X"; }
            else if (button7.Text == "x" && button4.Text == "x" && button1.Text == "x")
            { label1.Text = "The winner is X"; }
            else if (button1.Text == "x" && button5.Text == "x" && button9.Text == "x")
            { label1.Text = "The winner is X"; }
            else if (button3.Text == "x" && button5.Text == "x" && button7.Text == "x")
            { label1.Text = "The winner is X"; }
            else if (button4.Text == "x" && button5.Text == "x" && button6.Text == "x")
            { label1.Text = "The winner is X"; }
            else if (button4.Text == "x" && button5.Text == "x" && button6.Text == "x")
            { label1.Text = "The winner is X"; }
            else if (button2.Text == "x" && button5.Text == "x" && button8.Text == "x")
            { label1.Text = "The winner is X"; }
            if (label1.Text == "The winner is O")
            {
                win(array2);
            }
            if (label1.Text == "The winner is X")
            {
                winO(array2);
            }
            if (label1.Text != "Winner is:")
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;

            }
        }

        public void Button7_Click(object sender, EventArgs e)
        {
            while (array[index] == 7 && button7.Text != ".")
            { new Random().Shuffle(array); }


            if (player == 1)
            { button7.Text = "x";
                array2 += "7";
                if (button1.Text == "x" && button2.Text == "x" && ( button3.Text ==".")) { number = 3; button3.Text = "o"; goto jump7; }
                else if (button1.Text == "x" && button3.Text == "x" && ( button2.Text ==".")) { number = 2; button2.Text = "o"; goto jump7; }
                else if (button3.Text == "x" && button2.Text == "x" && (button1.Text != "o" || button1.Text ==".")) { number = 1; button1.Text = "o"; goto jump7; }

                if (button4.Text == "x" && button5.Text == "x" && ( button6.Text ==".")) { number = 6; button6.Text = "o"; goto jump7; }
                else if (button5.Text == "x" && button6.Text == "x" && ( button4.Text ==".")) { number = 4; button4.Text = "o"; goto jump7; }
                else if (button6.Text == "x" && button4.Text == "x" && ( button5.Text ==".")) { number = 5; button5.Text = "o"; goto jump7; }

                if (button8.Text == "x" && button9.Text == "x" && ( button7.Text ==".")) { number = 7; button7.Text = "o"; goto jump7; }
                else if (button7.Text == "x" && button9.Text == "x" && ( button8.Text ==".")) { number = 8; button8.Text = "o"; goto jump7; }
                else if (button7.Text == "x" && button8.Text == "x" && ( button9.Text ==".")) { number = 9; button9.Text = "o"; goto jump7; }

                if (button4.Text == "x" && button7.Text == "x" && ( button1.Text ==".")) { number = 1; button1.Text = "o"; goto jump7; }
                else if (button1.Text == "x" && button7.Text == "x" && ( button4.Text ==".")) { number = 4; button4.Text = "o"; goto jump7; }
                else if (button4.Text == "x" && button1.Text == "x" && ( button7.Text ==".")) { number = 7; button7.Text = "o"; goto jump7; }

                if (button5.Text == "x" && button8.Text == "x" && ( button2.Text ==".")) { number = 2; button2.Text = "o"; goto jump7; }
                else if (button2.Text == "x" && button8.Text == "x" && ( button5.Text ==".")) { number = 5; button5.Text = "o"; goto jump7; }
                else if (button2.Text == "x" && button5.Text == "x" && ( button8.Text ==".")) { number = 8; button8.Text = "o"; goto jump7; }

                if (button6.Text == "x" && button9.Text == "x" && ( button3.Text ==".")) { number = 3; button3.Text = "o"; goto jump7; }
                else if (button3.Text == "x" && button9.Text == "x" && ( button6.Text ==".")) { number = 6; button6.Text = "o"; goto jump7; }
                else if (button3.Text == "x" && button6.Text == "x" && ( button9.Text ==".")) { number = 9; button9.Text = "o"; goto jump7; }

                if (button5.Text == "x" && button9.Text == "x" && ( button1.Text ==".")) { number = 1; button1.Text = "o"; goto jump7; }
                else if (button1.Text == "x" && button9.Text == "x" && ( button5.Text ==".")) { number = 5; button5.Text = "o"; goto jump7; }
                else if (button1.Text == "x" && button5.Text == "x" && (button9.Text ==".")) { number = 9; button9.Text = "o"; goto jump7; }

                if (button5.Text == "x" && button7.Text == "x" && (button3.Text ==".")) { number = 3; button3.Text = "o"; goto jump7; }
                else if (button3.Text == "x" && button7.Text == "x" && ( button5.Text ==".")) { number = 5; button5.Text = "o"; goto jump7; }
                else if (button3.Text == "x" && button5.Text == "x" && ( button7.Text ==".")) { number = 7; button7.Text = "o"; goto jump7; }
                ai(array2, 0);
                h = ai(array2, h);
                if (h == 1) { goto jump7; }
                for (int i = 0; i <= 1000; i++)
                {
                    number = rnd.Next(1, 10);
                    if (number == 1 && button1.Text == ".")
                    { button1.Text = "o"; break; }
                    if (number == 2 && button2.Text == ".")
                    { button2.Text = "o"; break; }
                    if (number == 3 && button3.Text == ".")
                    { button3.Text = "o"; break; }
                    if (number == 4 && button4.Text == ".")
                    { button4.Text = "o"; break; }
                    if (number == 5 && button5.Text == ".")
                    { button5.Text = "o"; break; }
                    if (number == 6 && button6.Text == ".")
                    { button6.Text = "o"; break; }
                    if (number == 7 && button7.Text == ".")
                    { }
                    if (number == 8 && button8.Text == ".")
                    { button8.Text = "o"; break; }
                    if (number == 9 && button9.Text == ".")
                    { button9.Text = "o"; break; }

                }
                jump7:

                h = 0;
                 
                index++;
                
                array2 += Convert.ToString(number);
                index2++;
                label13.Text = array2;

            }
            else if (player == 2)
            {
                button7.Text = "o";
                array2 += "7";
                if (button1.Text == "o" && button2.Text == "x" && (button3.Text == ".")) { number = 3; button3.Text = "x"; goto jumpo7; }
                else if (button1.Text == "o" && button3.Text == "o" && (button2.Text == ".")) { number = 2; button2.Text = "x"; goto jumpo7; }
                else if (button3.Text == "o" && button2.Text == "o" && button1.Text == ".") { number = 1; button1.Text = "x"; goto jumpo7; }

                if (button4.Text == "o" && button5.Text == "o" && (button6.Text == ".")) { number = 6; button6.Text = "x"; goto jumpo7; }
                else if (button5.Text == "o" && button6.Text == "o" && (button4.Text == ".")) { number = 4; button4.Text = "x"; goto jumpo7; }
                else if (button6.Text == "o" && button4.Text == "o" && (button5.Text == ".")) { number = 5; button5.Text = "x"; goto jumpo7; }

                if (button8.Text == "o" && button9.Text == "o" && (button7.Text == ".")) { number = 7; button7.Text = "x"; goto jumpo7; }
                else if (button7.Text == "o" && button9.Text == "o" && (button8.Text == ".")) { number = 8; button8.Text = "x"; goto jumpo7; }
                else if (button7.Text == "o" && button8.Text == "o" && (button9.Text == ".")) { number = 9; button9.Text = "x"; goto jumpo7; }

                if (button4.Text == "o" && button7.Text == "o" && (button1.Text == ".")) { number = 1; button1.Text = "x"; goto jumpo7; }
                else if (button1.Text == "o" && button7.Text == "o" && (button4.Text == ".")) { number = 4; button4.Text = "x"; goto jumpo7; }
                else if (button4.Text == "o" && button1.Text == "o" && (button7.Text == ".")) { number = 7; button7.Text = "x"; goto jumpo7; }

                if (button5.Text == "o" && button8.Text == "o" && (button2.Text == ".")) { number = 2; button2.Text = "x"; goto jumpo7; }
                else if (button2.Text == "o" && button8.Text == "o" && (button5.Text == ".")) { number = 5; button5.Text = "x"; goto jumpo7; }
                else if (button2.Text == "o" && button5.Text == "o" && (button8.Text == ".")) { number = 8; button8.Text = "x"; goto jumpo7; }

                if (button6.Text == "o" && button9.Text == "o" && (button3.Text == ".")) { number = 3; button3.Text = "x"; goto jumpo7; }
                else if (button3.Text == "o" && button9.Text == "o" && (button6.Text == ".")) { number = 6; button6.Text = "x"; goto jumpo7; }
                else if (button3.Text == "o" && button6.Text == "o" && (button9.Text == ".")) { number = 9; button9.Text = "x"; goto jumpo7; }

                if (button5.Text == "o" && button9.Text == "o" && (button1.Text == ".")) { number = 1; button1.Text = "x"; goto jumpo7; }
                else if (button1.Text == "o" && button9.Text == "o" && (button5.Text == ".")) { number = 5; button5.Text = "x"; goto jumpo7; }
                else if (button1.Text == "o" && button5.Text == "o" && (button9.Text == ".")) { number = 9; button9.Text = "x"; goto jumpo7; }

                if (button5.Text == "o" && button7.Text == "o" && (button3.Text == ".")) { number = 3; button3.Text = "x"; goto jumpo7; }
                else if (button3.Text == "o" && button7.Text == "o" && (button5.Text == ".")) { number = 5; button5.Text = "x"; goto jumpo7; }
                else if (button3.Text == "o" && button5.Text == "o" && (button7.Text == ".")) { number = 7; button7.Text = "x"; goto jumpo7; }
                aiO(array2, 0);
                 
                 
                h = aiO(array2, h);
                if (h == 1) {   goto jumpo7; }
                for (int i = 0; i <= 1000; i++)
                {
                    number = rnd.Next(1, 10);
                    if (number == 1 && button1.Text == ".")
                    { button1.Text = "x"; break; }
                    if (number == 2 && button2.Text == ".")
                    { button2.Text = "x"; break; }
                    if (number == 3 && button3.Text == ".")
                    { button3.Text = "x"; break; }
                    if (number == 4 && button4.Text == ".")
                    { button4.Text = "x"; break; }
                    if (number == 5 && button5.Text == ".")
                    { button5.Text = "x"; break; }
                    if (number == 6 && button6.Text == ".")
                    { button6.Text = "x"; break; }
                    if (number == 7 && button7.Text == ".")
                    {  }
                    if (number == 8 && button8.Text == ".")
                    { button8.Text = "x"; break; }
                    if (number == 9 && button9.Text == ".")
                    { button9.Text = "x"; break; }


                }
            jumpo7:
                h = 0;
                array2 += Convert.ToString(number);
                index++;

                label13.Text = array2;
                index2++;
            }
            //Draw
            if (button1.Text != "." && button2.Text != "." && button3.Text != "." && button4.Text != "." && button5.Text != "." && button6.Text != "." && button7.Text != "." && button8.Text != "." && button9.Text != "." && label1.Text != "The winner is O" && label1.Text != "The winner is X")
            { label1.Text = "It is a draw"; }
            //
            if (button1.Text == "o" && button2.Text == "o" && button3.Text == "o")
            { label1.Text = "The winner is O"; }
            else if (button3.Text == "o" && button6.Text == "o" && button9.Text == "o")
            { label1.Text = "The winner is O"; }
            else if (button9.Text == "o" && button8.Text == "o" && button7.Text == "o")
            { label1.Text = "The winner is O"; }
            else if (button7.Text == "o" && button4.Text == "o" && button1.Text == "o")
            { label1.Text = "The winner is O"; }
            else if (button1.Text == "o" && button5.Text == "o" && button9.Text == "o")
            { label1.Text = "The winner is O"; }
            else if (button3.Text == "o" && button5.Text == "o" && button7.Text == "o")
            { label1.Text = "The winner is O"; }
            else if (button4.Text == "o" && button5.Text == "o" && button6.Text == "o")
            { label1.Text = "The winner is O"; }
            else if (button4.Text == "o" && button5.Text == "o" && button6.Text == "o")
            { label1.Text = "The winner is O"; }
            else if (button2.Text == "o" && button5.Text == "o" && button8.Text == "o")
            { label1.Text = "The winner is O"; }

            if (button1.Text == "x" && button2.Text == "x" && button3.Text == "x")
            { label1.Text = "The winner is X"; }
            else if (button3.Text == "x" && button6.Text == "x" && button9.Text == "x")
            { label1.Text = "The winner is X"; }
            else if (button9.Text == "x" && button8.Text == "x" && button7.Text == "x")
            { label1.Text = "The winner is X"; }
            else if (button7.Text == "x" && button4.Text == "x" && button1.Text == "x")
            { label1.Text = "The winner is X"; }
            else if (button1.Text == "x" && button5.Text == "x" && button9.Text == "x")
            { label1.Text = "The winner is X"; }
            else if (button3.Text == "x" && button5.Text == "x" && button7.Text == "x")
            { label1.Text = "The winner is X"; }
            else if (button4.Text == "x" && button5.Text == "x" && button6.Text == "x")
            { label1.Text = "The winner is X"; }
            else if (button4.Text == "x" && button5.Text == "x" && button6.Text == "x")
            { label1.Text = "The winner is X"; }
            else if (button2.Text == "x" && button5.Text == "x" && button8.Text == "x")
            { label1.Text = "The winner is X"; }

            if (label1.Text == "The winner is O")
            {
                win(array2);
            }
            if (label1.Text == "The winner is X")
            {
                winO(array2);
            }
            if (label1.Text != "Winner is:")
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;

            }
        }

        public void Button8_Click(object sender, EventArgs e)
        {
            while (array[index] == 8 && button8.Text != ".")
            { new Random().Shuffle(array); }

            if (player == 1)
            { button8.Text = "x";
                array2 += "8";
                if (button1.Text == "x" && button2.Text == "x" && ( button3.Text ==".")) { number = 3; button3.Text = "o"; goto jump8; }
                else if (button1.Text == "x" && button3.Text == "x" && (button2.Text ==".")) { number = 2; button2.Text = "o"; goto jump8; }
                else if (button3.Text == "x" && button2.Text == "x" && ( button1.Text ==".")) { number = 1; button1.Text = "o"; goto jump8; }

                if (button4.Text == "x" && button5.Text == "x" && ( button6.Text ==".")) { number = 6; button6.Text = "o"; goto jump8; }
                else if (button5.Text == "x" && button6.Text == "x" && ( button4.Text ==".")) { number = 4; button4.Text = "o"; goto jump8; }
                else if (button6.Text == "x" && button4.Text == "x" && ( button5.Text ==".")) { number = 5; button5.Text = "o"; goto jump8; }

                if (button8.Text == "x" && button9.Text == "x" && ( button7.Text ==".")) { number = 7; button7.Text = "o"; goto jump8; }
                else if (button7.Text == "x" && button9.Text == "x" && ( button8.Text ==".")) { number = 8; button8.Text = "o"; goto jump8; }
                else if (button7.Text == "x" && button8.Text == "x" && ( button9.Text ==".")) { number = 9; button9.Text = "o"; goto jump8; }

                if (button4.Text == "x" && button7.Text == "x" && (button1.Text ==".")) { number = 1; button1.Text = "o"; goto jump8; }
                else if (button1.Text == "x" && button7.Text == "x" && ( button4.Text ==".")) { number = 4; button4.Text = "o"; goto jump8; }
                else if (button4.Text == "x" && button1.Text == "x" && ( button7.Text ==".")) { number = 7; button7.Text = "o"; goto jump8; }

                if (button5.Text == "x" && button8.Text == "x" && ( button2.Text ==".")) { number = 2; button2.Text = "o"; goto jump8; }
                else if (button2.Text == "x" && button8.Text == "x" && ( button5.Text ==".")) { number = 5; button5.Text = "o"; goto jump8; }
                else if (button2.Text == "x" && button5.Text == "x" && (button8.Text ==".")) { number = 8; button8.Text = "o"; goto jump8; }

                if (button6.Text == "x" && button9.Text == "x" && ( button3.Text ==".")) { number = 3; button3.Text = "o"; goto jump8; }
                else if (button3.Text == "x" && button9.Text == "x" && ( button6.Text ==".")) { number = 6; button6.Text = "o"; goto jump8; }
                else if (button3.Text == "x" && button6.Text == "x" && ( button9.Text ==".")) { number = 9; button9.Text = "o"; goto jump8; }

                if (button5.Text == "x" && button9.Text == "x" && ( button1.Text ==".")) { number = 1; button1.Text = "o"; goto jump8; }
                else if (button1.Text == "x" && button9.Text == "x" && ( button5.Text ==".")) { number = 5; button5.Text = "o"; goto jump8; }
                else if (button1.Text == "x" && button5.Text == "x" && ( button9.Text ==".")) { number = 9; button9.Text = "o"; goto jump8; }

                if (button5.Text == "x" && button7.Text == "x" && ( button3.Text ==".")) { number = 3; button3.Text = "o"; goto jump8; }
                else if (button3.Text == "x" && button7.Text == "x" && ( button5.Text ==".")) { number = 5; button5.Text = "o"; goto jump8; }
                else if (button3.Text == "x" && button5.Text == "x" && ( button7.Text ==".")) { number = 7; button7.Text = "o"; goto jump8; }
                ai(array2, 0);
                h = ai(array2, h);
                if (h == 1) { goto jump8; }
                for (int i = 0; i <= 1000; i++)
                {
                    number = rnd.Next(1, 10);
                    if (number == 1 && button1.Text == ".")
                    { button1.Text = "o"; break; }
                    if (number == 2 && button2.Text == ".")
                    { button2.Text = "o"; break; }
                    if (number == 3 && button3.Text == ".")
                    { button3.Text = "o"; break; }
                    if (number == 4 && button4.Text == ".")
                    { button4.Text = "o"; break; }
                    if (number == 5 && button5.Text == ".")
                    { button5.Text = "o"; break; }
                    if (number == 6 && button6.Text == ".")
                    { button6.Text = "o"; break; }
                    if (number == 7 && button7.Text == ".")
                    { button7.Text = "o"; break; }
                    if (number == 8 && button8.Text == ".")
                    {  }
                    if (number == 9 && button9.Text == ".")
                    { button9.Text = "o"; break; }

                }
                jump8:

                h = 0;
                 
                index++;
                
                array2 += Convert.ToString(number);
                index2++;
                label13.Text = array2;

            }
            else if (player == 2)
            {
                button8.Text = "o";
                array2 += "8";
                if (button1.Text == "o" && button2.Text == "x" && (button3.Text == ".")) { number = 3; button3.Text = "x"; goto jumpo8; }
                else if (button1.Text == "o" && button3.Text == "o" && (button2.Text == ".")) { number = 2; button2.Text = "x"; goto jumpo8; }
                else if (button3.Text == "o" && button2.Text == "o" && button1.Text == ".") { number = 1; button1.Text = "x"; goto jumpo8; }

                if (button4.Text == "o" && button5.Text == "o" && (button6.Text == ".")) { number = 6; button6.Text = "x"; goto jumpo8; }
                else if (button5.Text == "o" && button6.Text == "o" && (button4.Text == ".")) { number = 4; button4.Text = "x"; goto jumpo8; }
                else if (button6.Text == "o" && button4.Text == "o" && (button5.Text == ".")) { number = 5; button5.Text = "x"; goto jumpo8; }

                if (button8.Text == "o" && button9.Text == "o" && (button7.Text == ".")) { number = 7; button7.Text = "x"; goto jumpo8; }
                else if (button7.Text == "o" && button9.Text == "o" && (button8.Text == ".")) { number = 8; button8.Text = "x"; goto jumpo8; }
                else if (button7.Text == "o" && button8.Text == "o" && (button9.Text == ".")) { number = 9; button9.Text = "x"; goto jumpo8; }

                if (button4.Text == "o" && button7.Text == "o" && (button1.Text == ".")) { number = 1; button1.Text = "x"; goto jumpo8; }
                else if (button1.Text == "o" && button7.Text == "o" && (button4.Text == ".")) { number = 4; button4.Text = "x"; goto jumpo8; }
                else if (button4.Text == "o" && button1.Text == "o" && (button7.Text == ".")) { number = 7; button7.Text = "x"; goto jumpo8; }

                if (button5.Text == "o" && button8.Text == "o" && (button2.Text == ".")) { number = 2; button2.Text = "x"; goto jumpo8; }
                else if (button2.Text == "o" && button8.Text == "o" && (button5.Text == ".")) { number = 5; button5.Text = "x"; goto jumpo8; }
                else if (button2.Text == "o" && button5.Text == "o" && (button8.Text == ".")) { number = 8; button8.Text = "x"; goto jumpo8; }

                if (button6.Text == "o" && button9.Text == "o" && (button3.Text == ".")) { number = 3; button3.Text = "x"; goto jumpo8; }
                else if (button3.Text == "o" && button9.Text == "o" && (button6.Text == ".")) { number = 6; button6.Text = "x"; goto jumpo8; }
                else if (button3.Text == "o" && button6.Text == "o" && (button9.Text == ".")) { number = 9; button9.Text = "x"; goto jumpo8; }

                if (button5.Text == "o" && button9.Text == "o" && (button1.Text == ".")) { number = 1; button1.Text = "x"; goto jumpo8; }
                else if (button1.Text == "o" && button9.Text == "o" && (button5.Text == ".")) { number = 5; button5.Text = "x"; goto jumpo8; }
                else if (button1.Text == "o" && button5.Text == "o" && (button9.Text == ".")) { number = 9; button9.Text = "x"; goto jumpo8; }

                if (button5.Text == "o" && button7.Text == "o" && (button3.Text == ".")) { number = 3; button3.Text = "x"; goto jumpo8; }
                else if (button3.Text == "o" && button7.Text == "o" && (button5.Text == ".")) { number = 5; button5.Text = "x"; goto jumpo8; }
                else if (button3.Text == "o" && button5.Text == "o" && (button7.Text == ".")) { number = 7; button7.Text = "x"; goto jumpo8; }
                aiO(array2, 0);
                 
                 
                h = aiO(array2, h);
                if (h == 1) {   goto jumpo8; }
                for (int i = 0; i <= 1000; i++)
                {
                    number = rnd.Next(1, 10);
                    if (number == 1 && button1.Text == ".")
                    { button1.Text = "x"; break; }
                    if (number == 2 && button2.Text == ".")
                    { button2.Text = "x"; break; }
                    if (number == 3 && button3.Text == ".")
                    { button3.Text = "x"; break; }
                    if (number == 4 && button4.Text == ".")
                    { button4.Text = "x"; break; }
                    if (number == 5 && button5.Text == ".")
                    { button5.Text = "x"; break; }
                    if (number == 6 && button6.Text == ".")
                    { button6.Text = "x"; break; }
                    if (number == 7 && button7.Text == ".")
                    { button7.Text = "x"; break; }
                    if (number == 8 && button8.Text == ".")
                    { }
                    if (number == 9 && button9.Text == ".")
                    { button9.Text = "x"; break; }


                }
            jumpo8:
                h = 0;
                array2 += Convert.ToString(number);
                index++;

                label13.Text = array2;
                index2++;
            }
            //Draw
            if (button1.Text != "." && button2.Text != "." && button3.Text != "." && button4.Text != "." && button5.Text != "." && button6.Text != "." && button7.Text != "." && button8.Text != "." && button9.Text != "." && label1.Text != "The winner is O" && label1.Text != "The winner is X")
            { label1.Text = "It is a draw"; }
            //
            if (button1.Text == "o" && button2.Text == "o" && button3.Text == "o")
            { label1.Text = "The winner is O"; }
            else if (button3.Text == "o" && button6.Text == "o" && button9.Text == "o")
            { label1.Text = "The winner is O"; }
            else if (button9.Text == "o" && button8.Text == "o" && button7.Text == "o")
            { label1.Text = "The winner is O"; }
            else if (button7.Text == "o" && button4.Text == "o" && button1.Text == "o")
            { label1.Text = "The winner is O"; }
            else if (button1.Text == "o" && button5.Text == "o" && button9.Text == "o")
            { label1.Text = "The winner is O"; }
            else if (button3.Text == "o" && button5.Text == "o" && button7.Text == "o")
            { label1.Text = "The winner is O"; }
            else if (button4.Text == "o" && button5.Text == "o" && button6.Text == "o")
            { label1.Text = "The winner is O"; }
            else if (button4.Text == "o" && button5.Text == "o" && button6.Text == "o")
            { label1.Text = "The winner is O"; }
            else if (button2.Text == "o" && button5.Text == "o" && button8.Text == "o")
            { label1.Text = "The winner is O"; }

            if (button1.Text == "x" && button2.Text == "x" && button3.Text == "x")
            { label1.Text = "The winner is X"; }
            else if (button3.Text == "x" && button6.Text == "x" && button9.Text == "x")
            { label1.Text = "The winner is X"; }
            else if (button9.Text == "x" && button8.Text == "x" && button7.Text == "x")
            { label1.Text = "The winner is X"; }
            else if (button7.Text == "x" && button4.Text == "x" && button1.Text == "x")
            { label1.Text = "The winner is X"; }
            else if (button1.Text == "x" && button5.Text == "x" && button9.Text == "x")
            { label1.Text = "The winner is X"; }
            else if (button3.Text == "x" && button5.Text == "x" && button7.Text == "x")
            { label1.Text = "The winner is X"; }
            else if (button4.Text == "x" && button5.Text == "x" && button6.Text == "x")
            { label1.Text = "The winner is X"; }
            else if (button4.Text == "x" && button5.Text == "x" && button6.Text == "x")
            { label1.Text = "The winner is X"; }
            else if (button2.Text == "x" && button5.Text == "x" && button8.Text == "x")
            { label1.Text = "The winner is X"; }

            if (label1.Text == "The winner is O")
            {
                win(array2);
            }
            if (label1.Text == "The winner is X")
            {
                winO(array2);
            }
            if (label1.Text != "Winner is:")
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;

            }
        }

        public void Button9_Click(object sender, EventArgs e)
        {
            while (array[index] == 9 && button9.Text != ".")
            { new Random().Shuffle(array); }
            if (player == 1)
            { button9.Text = "x";
                array2 += "9";
                if (button1.Text == "x" && button2.Text == "x" && ( button3.Text ==".")) { number = 3; button3.Text = "o"; goto jump9; }
                else if (button1.Text == "x" && button3.Text == "x" && ( button2.Text ==".")) { number = 2; button2.Text = "o"; goto jump9; }
                else if (button3.Text == "x" && button2.Text == "x" && ( button1.Text ==".")) { number = 1; button1.Text = "o"; goto jump9; }

                if (button4.Text == "x" && button5.Text == "x" && ( button6.Text ==".")) { number = 6; button6.Text = "o"; goto jump9; }
                else if (button5.Text == "x" && button6.Text == "x" && ( button4.Text ==".")) { number = 4; button4.Text = "o"; goto jump9; }
                else if (button6.Text == "x" && button4.Text == "x" && (button5.Text ==".")) { number = 5; button5.Text = "o"; goto jump9; }

                if (button8.Text == "x" && button9.Text == "x" && ( button7.Text ==".")) { number = 7; button7.Text = "o"; goto jump9; }
                else if (button7.Text == "x" && button9.Text == "x" && ( button8.Text ==".")) { number = 8; button8.Text = "o"; goto jump9; }
                else if (button7.Text == "x" && button8.Text == "x" && ( button9.Text ==".")) { number = 9; button9.Text = "o"; goto jump9; }

                if (button4.Text == "x" && button7.Text == "x" && ( button1.Text ==".")) { number = 1; button1.Text = "o"; goto jump9; }
                else if (button1.Text == "x" && button7.Text == "x" && ( button4.Text ==".")) { number = 4; button4.Text = "o"; goto jump9; }
                else if (button4.Text == "x" && button1.Text == "x" && ( button7.Text ==".")) { number = 7; button7.Text = "o"; goto jump9; }

                if (button5.Text == "x" && button8.Text == "x" && ( button2.Text ==".")) { number = 2; button2.Text = "o"; goto jump9; }
                else if (button2.Text == "x" && button8.Text == "x" && ( button5.Text ==".")) { number = 5; button5.Text = "o"; goto jump9; }
                else if (button2.Text == "x" && button5.Text == "x" && ( button8.Text ==".")) { number = 8; button8.Text = "o"; goto jump9; }

                if (button6.Text == "x" && button9.Text == "x" && (button3.Text ==".")) { number = 3; button3.Text = "o"; goto jump9; }
                else if (button3.Text == "x" && button9.Text == "x" && (button6.Text ==".")) { number = 6; button6.Text = "o"; goto jump9; }
                else if (button3.Text == "x" && button6.Text == "x" && ( button9.Text ==".")) { number = 9; button9.Text = "o"; goto jump9; }

                if (button5.Text == "x" && button9.Text == "x" && ( button1.Text ==".")) { number = 1; button1.Text = "o"; goto jump9; }
                else if (button1.Text == "x" && button9.Text == "x" && ( button5.Text ==".")) { number = 5; button5.Text = "o"; goto jump9; }
                else if (button1.Text == "x" && button5.Text == "x" && ( button9.Text ==".")) { number = 9; button9.Text = "o"; goto jump9; }

                if (button5.Text == "x" && button7.Text == "x" && (button3.Text ==".")) { number = 3; button3.Text = "o"; goto jump9; }
                else if (button3.Text == "x" && button7.Text == "x" && ( button5.Text ==".")) { number = 5; button5.Text = "o"; goto jump9; }
                else if (button3.Text == "x" && button5.Text == "x" && ( button7.Text ==".")) { number = 7; button7.Text = "o"; goto jump9; }
                ai(array2, 0);
                h = ai(array2, h);
                if (h == 1) { goto jump9; }
                for (int i = 0; i <= 1000; i++)
                {
                    number = rnd.Next(1, 10);
                    if (number == 1 && button1.Text == ".")
                    { button1.Text = "o"; break; }
                    if (number == 2 && button2.Text == ".")
                    { button2.Text = "o"; break; }
                    if (number == 3 && button3.Text == ".")
                    { button3.Text = "o"; break; }
                    if (number == 4 && button4.Text == ".")
                    { button4.Text = "o"; break; }
                    if (number == 5 && button5.Text == ".")
                    { button5.Text = "o"; break; }
                    if (number == 6 && button6.Text == ".")
                    { button6.Text = "o"; break; }
                    if (number == 7 && button7.Text == ".")
                    { button7.Text = "o"; break; }
                    if (number == 8 && button8.Text == ".")
                    { button8.Text = "o"; break; }
                    if (number == 9 && button9.Text == ".")
                    {  }


                }
                jump9:

                h = 0;
                 
                index++;
                
                array2 += Convert.ToString(number);
                index2++;
                label13.Text = array2;

            }
            else if (player == 2)
            {
                button9.Text = "o";
                array2 += "9";
                if (button1.Text == "o" && button2.Text == "x" && (button3.Text == ".")) { number = 3; button3.Text = "x"; goto jumpo9; }
                else if (button1.Text == "o" && button3.Text == "o" && (button2.Text == ".")) { number = 2; button2.Text = "x"; goto jumpo9; }
                else if (button3.Text == "o" && button2.Text == "o" && button1.Text == ".") { number = 1; button1.Text = "x"; goto jumpo9; }

                if (button4.Text == "o" && button5.Text == "o" && (button6.Text == ".")) { number = 6; button6.Text = "x"; goto jumpo9; }
                else if (button5.Text == "o" && button6.Text == "o" && (button4.Text == ".")) { number = 4; button4.Text = "x"; goto jumpo9; }
                else if (button6.Text == "o" && button4.Text == "o" && (button5.Text == ".")) { number = 5; button5.Text = "x"; goto jumpo9; }

                if (button8.Text == "o" && button9.Text == "o" && (button7.Text == ".")) { number = 7; button7.Text = "x"; goto jumpo9; }
                else if (button7.Text == "o" && button9.Text == "o" && (button8.Text == ".")) { number = 8; button8.Text = "x"; goto jumpo9; }
                else if (button7.Text == "o" && button8.Text == "o" && (button9.Text == ".")) { number = 9; button9.Text = "x"; goto jumpo9; }

                if (button4.Text == "o" && button7.Text == "o" && (button1.Text == ".")) { number = 1; button1.Text = "x"; goto jumpo9; }
                else if (button1.Text == "o" && button7.Text == "o" && (button4.Text == ".")) { number = 4; button4.Text = "x"; goto jumpo9; }
                else if (button4.Text == "o" && button1.Text == "o" && (button7.Text == ".")) { number = 7; button7.Text = "x"; goto jumpo9; }

                if (button5.Text == "o" && button8.Text == "o" && (button2.Text == ".")) { number = 2; button2.Text = "x"; goto jumpo9; }
                else if (button2.Text == "o" && button8.Text == "o" && (button5.Text == ".")) { number = 5; button5.Text = "x"; goto jumpo9; }
                else if (button2.Text == "o" && button5.Text == "o" && (button8.Text == ".")) { number = 8; button8.Text = "x"; goto jumpo9; }

                if (button6.Text == "o" && button9.Text == "o" && (button3.Text == ".")) { number = 3; button3.Text = "x"; goto jumpo9; }
                else if (button3.Text == "o" && button9.Text == "o" && (button6.Text == ".")) { number = 6; button6.Text = "x"; goto jumpo9; }
                else if (button3.Text == "o" && button6.Text == "o" && (button9.Text == ".")) { number = 9; button9.Text = "x"; goto jumpo9; }

                if (button5.Text == "o" && button9.Text == "o" && (button1.Text == ".")) { number = 1; button1.Text = "x"; goto jumpo9; }
                else if (button1.Text == "o" && button9.Text == "o" && (button5.Text == ".")) { number = 5; button5.Text = "x"; goto jumpo9; }
                else if (button1.Text == "o" && button5.Text == "o" && (button9.Text == ".")) { number = 9; button9.Text = "x"; goto jumpo9; }

                if (button5.Text == "o" && button7.Text == "o" && (button3.Text == ".")) { number = 3; button3.Text = "x"; goto jumpo9; }
                else if (button3.Text == "o" && button7.Text == "o" && (button5.Text == ".")) { number = 5; button5.Text = "x"; goto jumpo9; }
                else if (button3.Text == "o" && button5.Text == "o" && (button7.Text == ".")) { number = 7; button7.Text = "x"; goto jumpo9; }
                aiO(array2, 0);
                 
                 
                h = aiO(array2, h);
                if (h == 1) {   goto jumpo9; }
                for (int i = 0; i <= 1000; i++)
                {
                    number = rnd.Next(1, 10);
                    if (number == 1 && button1.Text == ".")
                    { button1.Text = "x"; break; }
                    if (number == 2 && button2.Text == ".")
                    { button2.Text = "x"; break; }
                    if (number == 3 && button3.Text == ".")
                    { button3.Text = "x"; break; }
                    if (number == 4 && button4.Text == ".")
                    { button4.Text = "x"; break; }
                    if (number == 5 && button5.Text == ".")
                    { button5.Text = "x"; break; }
                    if (number == 6 && button6.Text == ".")
                    { button6.Text = "x"; break; }
                    if (number == 7 && button7.Text == ".")
                    { button7.Text = "x"; break; }
                    if (number == 8 && button8.Text == ".")
                    { button8.Text = "x"; break; }
                    if (number == 9 && button9.Text == ".")
                    { }


                }
            jumpo9:
                h = 0;
                array2 += Convert.ToString(number);
                index++;

                label13.Text = array2;
                index2++;
            }
            //Draw
            if (button1.Text != "." && button2.Text != "." && button3.Text != "." && button4.Text != "." && button5.Text != "." && button6.Text != "." && button7.Text != "." && button8.Text != "." && button9.Text != "." && label1.Text != "The winner is O" && label1.Text != "The winner is X")
            { label1.Text = "It is a draw"; }
            //
            if (button1.Text == "o" && button2.Text == "o" && button3.Text == "o")
            { label1.Text = "The winner is O"; }
            else if (button3.Text == "o" && button6.Text == "o" && button9.Text == "o")
            { label1.Text = "The winner is O"; }
            else if (button9.Text == "o" && button8.Text == "o" && button7.Text == "o")
            { label1.Text = "The winner is O"; }
            else if (button7.Text == "o" && button4.Text == "o" && button1.Text == "o")
            { label1.Text = "The winner is O"; }
            else if (button1.Text == "o" && button5.Text == "o" && button9.Text == "o")
            { label1.Text = "The winner is O"; }
            else if (button3.Text == "o" && button5.Text == "o" && button7.Text == "o")
            { label1.Text = "The winner is O"; }
            else if (button4.Text == "o" && button5.Text == "o" && button6.Text == "o")
            { label1.Text = "The winner is O"; }
            else if (button4.Text == "o" && button5.Text == "o" && button6.Text == "o")
            { label1.Text = "The winner is O"; }
            else if (button2.Text == "o" && button5.Text == "o" && button8.Text == "o")
            { label1.Text = "The winner is O"; }
            
            if (button1.Text == "x" && button2.Text == "x" && button3.Text == "x")
            { label1.Text = "The winner is X"; }
            else if (button3.Text == "x" && button6.Text == "x" && button9.Text == "x")
            { label1.Text = "The winner is X"; }
            else if (button9.Text == "x" && button8.Text == "x" && button7.Text == "x")
            { label1.Text = "The winner is X"; }
            else if (button7.Text == "x" && button4.Text == "x" && button1.Text == "x")
            { label1.Text = "The winner is X"; }
            else if (button1.Text == "x" && button5.Text == "x" && button9.Text == "x")
            { label1.Text = "The winner is X"; }
            else if (button3.Text == "x" && button5.Text == "x" && button7.Text == "x")
            { label1.Text = "The winner is X"; }
            else if (button4.Text == "x" && button5.Text == "x" && button6.Text == "x")
            { label1.Text = "The winner is X"; }
            else if (button4.Text == "x" && button5.Text == "x" && button6.Text == "x")
            { label1.Text = "The winner is X"; }
            else if (button2.Text == "x" && button5.Text == "x" && button8.Text == "x")
            { label1.Text = "The winner is X"; }

            if (label1.Text == "The winner is O")
            {
                win(array2);
            }
            if (label1.Text == "The winner is X")
            {
                winO(array2);
            }
            if (label1.Text != "Winner is:")
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;

            }

        }

        public void Button10_Click(object sender, EventArgs e)
        {
            if (label2.Text=="Playing as: X") { player = 1; }
            else if (label2.Text == "Playing as: O") { player = 2; }
            index = 0;
            button1.Text = ".";
            button2.Text = ".";
            button3.Text = ".";
            button4.Text = ".";
            button5.Text = ".";
            button6.Text = ".";
            button7.Text = ".";
            button8.Text = ".";
            button9.Text = ".";
            new Random().Shuffle(array);
            label1.Text = "Winner is:";
            array2 = null;
            label13.Text = "";
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
        }

        public void Button11_Click(object sender, EventArgs e)
        {
            label2.Text = "Playing as: O";
            player = 2;
            index = 0;
            label1.Text = "Winner is:";
            
            //
            new Random().Shuffle(array);
            number = rnd.Next(1, 10);
            if (number == 1 && button1.Text == ".")
            { button1.Text = "x";  }
            if (number == 2 && button2.Text == ".")
            { button2.Text = "x";  }
            if (number == 3 && button3.Text == ".")
            { button3.Text = "x";  }
            if (number == 4 && button4.Text == ".")
            { button4.Text = "x"; }
            if (number == 5 && button5.Text == ".")
            { button5.Text = "x";  }
            if (number == 6 && button6.Text == ".")
            { button6.Text = "x";  }
            if (number == 7 && button7.Text == ".")
            { button7.Text = "x";  }
            if (number == 8 && button8.Text == ".")
            { button8.Text = "x";  }
            if (number == 9 && button9.Text == ".")
            { button9.Text = "x"; }
            array2 += Convert.ToString(number);
        }

        public void Form1_Load(object sender, EventArgs e)
        {

        }

        public void Button12_Click(object sender, EventArgs e)
        {
            label2.Text = "Playing as: X";
            player = 1;
            
            new Random().Shuffle(array);
            
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            button12.PerformClick();
            for (int i = 0; i <= 5000; i++)
            {
                while (label1.Text == "Winner is:")

                {

                   

                    numbers = rnd.Next(1, 10);
                    if (numbers == 1 && button1.Text == ".")
                    { button1.PerformClick(); }
                    if (numbers == 2 && button2.Text == ".")
                    { button2.PerformClick(); }
                    if (numbers == 3 && button3.Text == ".")
                    { button3.PerformClick(); }
                    if (numbers == 4 && button4.Text == ".")
                    { button4.PerformClick(); }
                    if (numbers == 5 && button5.Text == ".")
                    { button5.PerformClick(); }
                    if (numbers == 6 && button6.Text == ".")
                    { button6.PerformClick(); }
                    if (numbers == 7 && button7.Text == ".")
                    { button7.PerformClick(); }
                    if (numbers == 8 && button8.Text == ".")
                    { button8.PerformClick(); }
                    if (numbers == 9 && button9.Text == ".")
                    { button9.PerformClick(); }


                }
                button10.PerformClick();
            }
               
            
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button14_Click(object sender, EventArgs e)
        {
            File.WriteAllText("WriteLine.txt", String.Empty);
            File.WriteAllText("WriteLines.txt", String.Empty);
        }
    }
}

static class RandomExtensions
{
    public static void Shuffle<T>(this Random rng, T[] array)
    {
        int n = array.Length;
        while (n > 1)
        {
            int k = rng.Next(n--);
            T temp = array[n];
            array[n] = array[k];
            array[k] = temp;
        }
    }
}
