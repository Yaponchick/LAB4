namespace LAB4
{
    public partial class Form1 : Form
    {
        List<Animal> animalsList = new List<Animal>();

        public Form1()
        {
            InitializeComponent();
            ShowInfo();
        }
        // Кнопка для перезаписи значений
        private void btnRefill_Click(object sender, EventArgs e)
        {
            this.animalsList.Clear();
            var rnd = new Random();
            for (var i = 0; i < 10; ++i)
            {
                switch (rnd.Next() % 3) //Next() возвращает неотрицательное случайное целое число.
                {
                    case 0:
                        this.animalsList.Add(Cows.Generate());
                        break;
                    case 1:
                        this.animalsList.Add(Dogs.Generate());
                        break;
                    case 2:
                        this.animalsList.Add(Cats.Generate());
                        break;
                }
            }
            ShowInfo();
        }

        // Функция выводит информацию о количестве животных в на форму
        private void ShowInfo()
        {
            int cowsCount = 0;
            int dogsCount = 0;
            int catsCount = 0;

            foreach (var animal in this.animalsList)
            {
                if (animal is Cows)
                {
                    cowsCount += 1;
                }
                else if (animal is Dogs)
                {
                    dogsCount += 1;
                }
                else if (animal is Cats)
                {
                    catsCount += 1;
                }
            }

            txtInfo.Text = "\tКоров\tСобак\tКотов";
            txtInfo.Text += "\n";
            txtInfo.Text += String.Format("\t{0}\t{1}\t{2}", cowsCount, dogsCount, catsCount);

        }
        // Кнопка "Взять"
        private void btnGet_Click(object sender, EventArgs e)
        {
            if(this.animalsList.Count == 0)
            {
                txtOut.Text = "Пусто ^_^";
                return;
            }

             var animal = this.animalsList[0];
             this.animalsList.RemoveAt(0);

             txtOut.Text = animal.GetInfo();

            ShowInfo();
        }
    }
}
