using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4_fruitStore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string[][] arr = new string[3][];
            arr[0] = new string[4] { "홍길동", "포도", "복숭아", "바나나" };
            arr[1] = new string[4] { "아무개", "사과", "수박", "오렌지" };
            arr[2] = new string[4] { "손오공", "바나나", "사과", "오렌지" };

            //바나나->바나나(유기농)
            //수박->씨없는 수박
            //4글자 넘는 상품->상품명(인기)
            //사람 별 전체 상품 출력
            //상품이름 첫글자 뽑아서 포/씨/복

            ForUsed(arr);

            //for, if 없이 삼항연산자로 풀기
            //arr[0][1] = arr[0][1] == "바나나" ? "바나나 (유기농)" :
            //arr[0][1] == "수박" ? "씨없는 수박" : arr[0][1];
            //arr[0][1] = arr[0][1].Length > 2 ? arr[0][1] + " (인기)" : arr[0][1];
            

            textBox1.Text = "과일가게 주문정보 \r\n\r\n";

            for (int i = 0; i < arr.Length; i++)
            {
                textBox1.Text += (i+1) + ". " + arr[i][0] + ": ";
                for (int k = 1; k < arr[i].Length - 1; k++)
                {
                    textBox1.Text += arr[i][k] + " / ";
                }
                textBox1.Text += arr[i][arr[i].Length - 1] + "\r\n";


                textBox1.Text += "상품 첫글자 요약: ";
                for (int k = 1; k < arr[i].Length - 1; k++)
                {
                    textBox1.Text += arr[i][k].Substring(0, 1) + " / ";
                }
                textBox1.Text += arr[i][arr[i].Length - 1].Substring(0, 1) + "\r\n\r\n";
            }

            ////홍길동
            //textBox1.Text += "1. " + arr[0][0] + ": " + arr[0][1] + " / " + arr[0][2] + " / " + arr[0][3] + "\r\n";
            //textBox1.Text += "상품 첫글자 요약: " + arr[0][1].Substring(0, 1) + " / " + arr[0][2].Substring(0, 1) + " / " + arr[0][3].Substring(0, 1) + "\r\n\r\n";

            ////아무개
            //textBox1.Text += "2. " + arr[1][0] + ": " + arr[1][1] + " / " + arr[1][2] + " / " + arr[1][3] + "\r\n";
            //textBox1.Text += "상품 첫글자 요약: " + arr[1][1].Substring(0, 1) + " / " + arr[1][2].Substring(0, 1) + " / " + arr[1][3].Substring(0, 1) + "\r\n\r\n";

            ////손오공
            //textBox1.Text += "3. " + arr[2][0] + ": " + arr[2][1] + " / " + arr[2][2] + " / " + arr[2][3] + "\r\n";
            //textBox1.Text += "상품 첫글자 요약: " + arr[2][1].Substring(0, 1) + " / " + arr[2][2].Substring(0, 1) + " / " + arr[2][3].Substring(0, 1) + "\r\n\r\n";

        }

        void ForUsed(string[][] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int k = 1; k < arr[i].Length; k++)
                {
                    if (arr[i][k].Equals("바나나"))
                    {
                        arr[i][k] = "바나나 (유기농)";
                    }
                    if (arr[i][k].Equals("수박"))
                    {
                        arr[i][k] = "씨없는 수박";
                    }

                    if (arr[i][k].Length > 2)
                    {
                        arr[i][k] += " (인기)";
                    }
                }
            }
        }

    }
}
