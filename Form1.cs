namespace C__OOP_Interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            Myclass mc = new Myclass();
            MessageBox.Show(mc.PrintOut("11"));

            IIfc1 ifc1 = (IIfc1)mc;
            MessageBox.Show(ifc1.PrintOut("22"));

        }

        private void btnAnimal_Click(object sender, EventArgs e)
        {
            Animal[] animalsAray = new Animal[3];
            animalsAray[0] = new Cat();
            animalsAray[1] = new Dog();
            animalsAray[2] = new Bird();

            foreach (Animal a in animalsAray)
            {
                IliveBirth b = a as IliveBirth;

                if (b != null)
                    MessageBox.Show(b.BabyCall());
            }
        }
    }
}
