using System.Windows.Forms;

namespace 观察者模式传值
{
    public partial class ChildForm2 : Form,IObserver
    {
        public ChildForm2(ISubject subject)
        {
            InitializeComponent();
            subject.RegisterObserver(this);
        }

        public void Update(string msg, bool isShown)
        {
            if (isShown)
            {
                txtChild2.Text = msg;
            }
            else
            {
                this.Show();
            }
        }
    }
}