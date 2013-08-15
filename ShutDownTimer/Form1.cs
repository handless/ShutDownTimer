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
            try
            {
                string varTimes = cBTimerHours.SelectedItem.ToString();
                ShutDownTime = DateTime.Now.AddHours(Int32.Parse(varTimes));
                varTimes = cbTimerMinutes.SelectedItem.ToString();
                ShutDownTime = ShutDownTime.AddMinutes(Int32.Parse(varTimes));

            }
            catch (Exception q)
            {
                MessageBox.Show("Ошибка ввода времени: " + q.Message);
                Application.Exit();
            }

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
                labelInfo.Text = "Осталось времени: "+ ts.Hours + " hours " + ts.Minutes + " min " +
                    ts.Seconds + " sec";
            }
            else 
            {
                MessageBox.Show("Выключение");
                timer.Stop();
               //Вызываем процесс shutdown который собственно и выключит наш компьютер.
               // Process.Start("shutdown", "/s /t 0");
                
                Close();
            }

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }
    }
}
