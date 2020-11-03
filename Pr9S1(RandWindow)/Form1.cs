using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr9S1_RandWindow_
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    private void Form1_MouseMove(object sender, MouseEventArgs e)
    {
      //переводим координаты в строку и записываем
      textBox1.Text = e.X.ToString();
      textBox2.Text = e.Y.ToString();

      Random rnd = new Random();
      Point tmp_Location; //в будущем хранить текущее положение окна
      int _w = System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Width;
      int _h = System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Height;

      if(e.X > 10 && e.X < 225 && e.Y > 120 && e.Y < 270)
      {
        tmp_Location = this.Location; //запоминаем текущее

        tmp_Location.X += rnd.Next(-100, 100);
        tmp_Location.Y += rnd.Next(-100, 100); //генерируем перемещения и прибавляем, соответсвенно перемещая окно

        if (tmp_Location.X < 0 || tmp_Location.X > (_w - this.Width / 2) || tmp_Location.Y < 0 || tmp_Location.Y > (_h - this.Height / 2)) //не вышли ли за границы
        {
          tmp_Location.X = _w / 2;
          tmp_Location.Y = _h / 2;
        }

        this.Location = tmp_Location; //обновляем положение
      } 
    }

    private void button1_Click(object sender, EventArgs e)
    {
      MessageBox.Show("Вы усердный!!");
      Application.Exit();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      MessageBox.Show("Мы не сомневались в вашем безразличии", "Ну ещё бы", MessageBoxButtons.OK, MessageBoxIcon.Information);
      //выводится текст "мы не сомневались...", заголовок окна сообщения "ну еще бы", размещаемая кнопка на форме сообщения, тип сообщения (иконка, звук)
    }
  }
}
