using System.Windows.Forms;

namespace 观察者模式传值
{
    public partial class ChildForm3 : Form,IObserver
    {
        public ChildForm3(ISubject subject)
        {
            InitializeComponent();
            subject.RegisterObserver(this);
        }

        public void Update(string msg, bool isShown)
        {
            if (isShown)
            {
                txtChild3.Text = msg;
            }
            else
            {
                this.Show();
            }
        }
    }
}