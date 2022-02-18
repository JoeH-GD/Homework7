using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doubler
{// Халдон. Игра "Угадай число". Минималистичная версия.
    public partial class Form2 : Form
    {
        private int userNumber;
        private int computerNumber;
        Random rand = new Random();

        public Form2()
        {
            InitializeComponent();
            GameStateUpdate(rand.Next(100));
        }

        public void GameStateUpdate(int computerNumber)
        {
            this.computerNumber = computerNumber;
            lbComputerMessage.Text = "I'm thinking of a number from 0 to a 100\n" +
                                                    "What is it?";
        }

       //забыл переименовать кнопку заранее а переименование постфактум привело к конфликтам
       //так и жевет теперь как "кнопка 1" а должно быть RESET
        private void button1_Click(object sender, EventArgs e)
        {
            userNumber = 0;
            GameStateUpdate(rand.Next(100));

        }

        private void CheckWin()
        {
            if (userNumber == computerNumber)
            {
                lbComputerMessage.Text = "Congrats! That's my number!";
            }

            if (userNumber < computerNumber)
            {
                lbComputerMessage.Text = "My number is bigger than that!";
            }

            if (userNumber > computerNumber)
            {
                lbComputerMessage.Text = "My number is less than that!";
            }
        }

        //Я не нашел ивент типа "ввод данных" поэтому сделал кнопку "enter"
        private void btnEnter_Click(object sender, EventArgs e)
        {
            userNumber = int.Parse(textBox1.Text);
            textBox1.Clear();
            CheckWin();
        }


    }
}
