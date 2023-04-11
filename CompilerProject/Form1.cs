using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompilerProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kapatButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void asagiAlmaButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //FORM TAŞIMA
        bool move;
        int mouse_x;
        int mouse_y;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }
        private void Form1_MouseUp_1(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void Form1_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (move)
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
        }


        //REGEX TANIMLAMALARI
        Regex sembollerRegex = new Regex(@"\+|-|\*|/|=|==|!=|!|>=|<=|<|>|&&|\(|\)|\)|{|}|;|\.|\|\||%|//|");
        Regex genelRegex = new Regex(@"\d|\w|\d+|\w+|\+|-|\*|/|=|==|!=|!|>=|<=|<|>|&&|\(|\)|\)|{|}|;|\.|\|\||%|//|");


        //TOKEN TANIMLAMARI
        List<string> degiskenTurleri = new List<string>(new string[] { "int", "float", "string", "bool", "char" });
        List<string> fonksiyonlar = new List<string>(new string[] { "Console.WriteLine", "Console.ReadLine" , "for","while","if","else" , "do", "return", "break", "continue" });

        //SEMBOL TANIMLAMALARI
        List<string> semboller = new List<string>(new string[] {
                "+", "-", "/", "*", "(", ")", "{", "}", ";", "&&",
                "||", "<", ">", "=", "!", "++", "==", ">=", "<=", "!="
            });
        List<string> comp_operators = new List<string>(new string[]
                {
                        "==","!=","<=","<",">",">="
                });
        List<string> bool_operators = new List<string>(new string[]
        {
                        "&&","||"
        });

        string metin;

        private void derleButton_Click(object sender, EventArgs e)
        {
            konsolText.Text = null;
            metin = derleyiciText.Text;
            List<string> satirlar = new List<string>();

            string[] parcalar = metin.Split(";");
            foreach(string satir in parcalar)
            {
                satirlar.Add(satir);
            }

            for(int i =0; i< satirlar.Count; i++)
            {
                satirlar[i] = InnerTrim(satirlar[i]);
            }

            Yazdir(satirlar);
        }



        public void Yazdir(List<string> list)
        {
            foreach (var item in list)
            {
                konsolText.Text += item + "\n";
            }
        }


        //KELİME ARASI BOŞLUKLARI SİLME
        public static string InnerTrim(string input)
        {
            return input.Trim().Replace(" ", string.Empty);
        }
    }
}
