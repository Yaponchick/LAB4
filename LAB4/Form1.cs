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

        private void btnRefill_Click(object sender, EventArgs e)
        {
            this.animalsList.Clear();
            var rnd = new Random();
            for (var i = 0; i < 10; ++i)
            {
                switch (rnd.Next() % 3) //Next() возвращает неотрицательное случайное целое число.
                {
                    case 0:
                        this.animalsList.Add(new Cows());
                        break;
                    case 1:
                        this.animalsList.Add(new Dogs());
                        break;
                    case 2:
                        this.animalsList.Add(new Cats());
                        break;
                }
            }
            ShowInfo();
        }

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

            txtInfo.Text = "Крв\tСбк\tКт";
            txtInfo.Text += "\n";
            txtInfo.Text += String.Format("{0}\t{1}\t{2}", cowsCount, dogsCount, catsCount);

        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            if(this.animalsList.Count == 0)
            {
                txtOut.Text = "Пусто ^_^";
                return;
            }

             var animal = this.animalsList[0];
             this.animalsList.RemoveAt(0);

            if(animal is Cows)
            {
                txtOut.Text = "Корова";
            }
            else if(animal is Dogs)
            {
                txtOut.Text = "Собака";
            }
            else if(animal is Cats)
            {
                txtOut.Text = "Кот";
            }

            ShowInfo();
        }
    }
}
