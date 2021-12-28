using System.Windows.Forms;

namespace 观察者模式传值
{
    public partial class ChildForm1 : Form,IObserver
    {
        public ChildForm1(ISubject subject)
        {
            InitializeComponent();
            subject.RegisterObserver(this);
        }

        public void Update(string msg,bool isShown)
        {
            if (isShown)
            {
                txtChild1.Text = msg;
            }
            else
            {
                this.Show();
            }
        }
    }
}