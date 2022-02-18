using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Халдон. В игре есть меню и возможность откатиться на три хода назад
//после выполнения любой новой операции снова можно откатиться на три хода
//Мне попадались какие-то более элегантные решения, но без Stack

namespace Doubler
{
    public partial class Doubler : Form
    {
        private Random random = new Random();
        private int computerNumber;
        private int userNumber;
        private int numberOfMoves;
        int index = 1;
        bool movedBack;
        Stack<int> moves = new Stack<int>();

        public Doubler()
        {
            InitializeComponent();
            MenuMode();
            userNumber = 0;
            UpdateGameState(userNumber, random.Next(50));
        }

        //Меню собирал на скорую руку - пошел по простому пути
        private void MenuMode()
        {
            btnBack.Hide();
            btnPlus.Hide();
            btnMultiply.Hide();
            btnReset.Hide();
            lbComputerNumber.Hide();
            lbUserNumber.Hide();
            lbWelcome.Text = "Welcome to Doubler. The computer will give you a number you need to ger.\n" +
                "You start with 0 and can increment or double your number.\n" +
                "Try to use as few moves as possible!";
        }
        private void UpdateGameState(int userNumber)
        {
            lbUserNumber.Text = $"Your current number: {userNumber}, you've made {numberOfMoves} moves";
            
        }

        private void UpdateGameState(int userNumber, int computerNumber)
        {
            UpdateGameState(userNumber);
            this.computerNumber = computerNumber;
            lbComputerNumber.Text = $"Get this number: {computerNumber}";
        }

        private void btnPlus_Click_1(object sender, EventArgs e)
        {
            //проверяем не выполнялись ли ходы назад,
            //потому что если выполнялись, то зачистить стак нужно прежде чем подавать новое значение
            if (movedBack)
            {
            //достаем из стака все значения старой ветки операций, чтобы они не мешались при новом откате
                for (int i = 0; i <index-1; i++)
                {
                    moves.Pop();
                }

                index = 1;
                movedBack = false;
            }
            //userNumber = userNumber + 1;
            UpdateGameState(++userNumber);
            CheckWin();
            //считаем ходы
            ++numberOfMoves;
            //подаем значение в стак
            moves.Push(userNumber);

        }

        private void btnMultiply_Click_1(object sender, EventArgs e)
        {
          //аналогично кнопке "плюс"
            if (movedBack)
            {
                for (int i =0; i<index-1;i++)
                {
                    moves.Pop();
                }
                index = 1;
                movedBack = false;
            }
            // userNumber = userNumber * 2;
            UpdateGameState(userNumber *= 2);
            CheckWin();
            ++numberOfMoves;
            moves.Push(userNumber);

        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            //зачищаем все переменные, которые используются в игре
            userNumber = 0;
            numberOfMoves = 0;
            index = 1;
            UpdateGameState(userNumber, random.Next(50));
            //зачищаем стак
            moves.Clear();
            movedBack = false;
        }
   

        private void CheckWin()
        {
            if (computerNumber == userNumber)
            {
                MessageBox.Show("You have beat the game", "Doubler",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                numberOfMoves = 0;

                if (MessageBox.Show("Would you like to play again?", "Doubler",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    userNumber = 0;
                    UpdateGameState(userNumber, random.Next(50));
                }
                else
                {
                    Close();
                }
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
    //Достаем нужное значение из стака по индексу
         UpdateGameState(userNumber = moves.ElementAt(index));
    //функция позволяет сделать до 3 отмен хода (классический откат для многих игр)     
          if (index<4)
            {
                --numberOfMoves;
                ++index;
            }
         
         movedBack = true;
          
        }

        //Просто даем пользователю все нужные кнопки по нажатию кнопки Play
        private void btnPlay_Click(object sender, EventArgs e)
        {
            btnPlay.Hide();
            lbWelcome.Hide();
            btnBack.Show();
            btnPlus.Show();
            btnMultiply.Show();
            btnReset.Show();
            lbComputerNumber.Show();
            lbUserNumber.Show();
        }
    }
}
