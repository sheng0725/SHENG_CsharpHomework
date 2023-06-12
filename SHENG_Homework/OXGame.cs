using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace SHENG_Homework
{
    
    public partial class OXGame : Form
    {
        Button[] PlayButton = new Button[9]; //將按鍵結果放入陣列
        bool isGameOver = false; //有連線成功就結束
        bool isO = true;  //點選是 O 還是 X

        public OXGame()
        {
            InitializeComponent();
            KeyDown += new KeyEventHandler(OXGame_KeyDown);
            //井字遊戲的 9 個按鍵
            PlayButton = new Button[9] {a1, a2, a3, b1, b2, b3, c1, c2, c3};
            GameStart();

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            GameStart();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //設定按鍵內的文字(重設的時候)
        private void GameStart()
        {
            isGameOver = false;
            isO = true;
            for (int i = 0; i < PlayButton.Length; i++)
            {
                PlayButton[i].Text = "";
                PlayButton[i].Enabled = true;
            }
            //a1.Enabled = true;
            //a2.Enabled = true;
            //a3.Enabled = true;
            //b1.Enabled = true;
            //b2.Enabled = true;
            //b3.Enabled = true;
            //c1.Enabled = true;
            //c2.Enabled = true;
            //c3.Enabled = true;
        }

        private void btnOX_Click(object sender, EventArgs e)
        {
            Button tmpButton = (Button)sender;
            tmpButton.Enabled = false;
            if (isO)
                tmpButton.Text = "O";
            else
                tmpButton.Text = "X";
            isO = !isO;

            bool[] GameStatus = CheckWinGroup(PlayButton);
            isGameOver = GameStatus[1];

            //有人獲勝
            if (GameStatus[0])
            {
                DialogResult ok = MessageBox.Show(tmpButton.Text + " 手獲勝!", "遊戲結束", MessageBoxButtons.OK);
                if (ok == DialogResult.OK)
                    GameStart();
                return;
            }
            //和局
            if (GameStatus[1])
            {
                DialogResult ok = MessageBox.Show("平手!按下確定重新開始", "遊戲結束", MessageBoxButtons.OK);
                if (ok == DialogResult.OK)
                    GameStart();
            }
        }

        //檢查是否OX連線成功
        private bool[] CheckWinGroup(Button[] myControls)
        {
            //gameWinOver {是否有人獲勝, 是否遊戲結束(或是平局)}
            bool[] gameWinOver = new bool[2] { false, false };
            int btnIsUse = 1;
            for (int i = 0; i < 8; i++)
            {
                //連線成功，遊戲結束
                if (a1.Text == a2.Text && a2.Text == a3.Text && a1.Text == "X") { gameWinOver = new bool[2] { true, true }; break; }
                if (a1.Text == a2.Text && a2.Text == a3.Text && a1.Text == "O") { gameWinOver = new bool[2] { true, true }; break; }
                if (b1.Text == b2.Text && b2.Text == b3.Text && b1.Text == "X") { gameWinOver = new bool[2] { true, true }; break; }
                if (b1.Text == b2.Text && b2.Text == b3.Text && b1.Text == "O") { gameWinOver = new bool[2] { true, true }; break; }
                if (c1.Text == c2.Text && c2.Text == c3.Text && c1.Text == "X") { gameWinOver = new bool[2] { true, true }; break; }
                if (c1.Text == c2.Text && c2.Text == c3.Text && c1.Text == "O") { gameWinOver = new bool[2] { true, true }; break; }
                if (a1.Text == b1.Text && b1.Text == c1.Text && a1.Text == "X") { gameWinOver = new bool[2] { true, true }; break; }
                if (a1.Text == b1.Text && b1.Text == c1.Text && a1.Text == "O") { gameWinOver = new bool[2] { true, true }; break; }
                if (a2.Text == b2.Text && b2.Text == c2.Text && a2.Text == "X") { gameWinOver = new bool[2] { true, true }; break; }
                if (a2.Text == b2.Text && b2.Text == c2.Text && a2.Text == "O") { gameWinOver = new bool[2] { true, true }; break; }
                if (a3.Text == b3.Text && b3.Text == c3.Text && a3.Text == "X") { gameWinOver = new bool[2] { true, true }; break; }
                if (a3.Text == b3.Text && b3.Text == c3.Text && a3.Text == "O") { gameWinOver = new bool[2] { true, true }; break; }
                if (a1.Text == b2.Text && b2.Text == c3.Text && a1.Text == "X") { gameWinOver = new bool[2] { true, true }; break; }
                if (a1.Text == b2.Text && b2.Text == c3.Text && a1.Text == "O") { gameWinOver = new bool[2] { true, true }; break; }
                if (a3.Text == b2.Text && b2.Text == c1.Text && a3.Text == "X") { gameWinOver = new bool[2] { true, true }; break; }
                if (a3.Text == b2.Text && b2.Text == c1.Text && a3.Text == "O") { gameWinOver = new bool[2] { true, true }; break; }

                //九格填完，顯示結束
                if (myControls[i].Text != "")
                {
                    btnIsUse++;
                    if (btnIsUse == 9)
                        gameWinOver[1] = true;
                }
            }
            return gameWinOver;
        }

        private void OXGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.R)
                GameStart();
            if (e.KeyCode == Keys.Escape)
                Close();
        }
    }
}

