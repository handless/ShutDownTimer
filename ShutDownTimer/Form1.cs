using System;
using System.Windows.Forms;
using System.Diagnostics;


namespace ShutDownTimer
{
    public partial class ShutDownTimer : Form
    {
        DateTime ShutDownTime;
        public ShutDownTimer()
        {
            InitializeComponent();
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            // Присваеваем атрибуту текущее время + 5 минут
            ShutDownTime = DateTime.Now.AddMinutes(5);

            // Запускаем наш таймер
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (ShutDownTime > DateTime.Now)
            {
                // Высчитываем отрезок времени (Время выключения - Текущее время) 
                TimeSpan ts = ShutDownTime - DateTime.Now;
                // Выводим на наш label который у меня называется labelInfo
                labelInfo.Text = "Осталось времени: " + ts.Minutes + " min " +
                    ts.Seconds + " sec";
            }
            else 
            {
               //Вызываем процесс shutdown который собственно и выключит наш компьютер.
                Process.Start("shutdown", "/s /t 0");
                Close();
            }

        }
    }
}
