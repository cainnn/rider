using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace 观察者模式传值
{
    public partial class ControlForm : Form,ISubject
    {
        public string Message { get; set; }
        private List<IObserver> _observers = new List<IObserver>();
        public ControlForm()
        {
            InitializeComponent();
        }


        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

     

        public void NotifyObserver(bool isShown)
        {
            foreach (IObserver observer in _observers)
            {
                observer.Update(Message,isShown);
            }
        }

        private void txtCtrl_TextChanged(object sender, EventArgs e)
        {
            this.Message = txtCtrl.Text;
            NotifyObserver(true);
        }

        private void ControlForm_Load(object sender, EventArgs e)
        {
            NotifyObserver(false); 
        }
    }
}