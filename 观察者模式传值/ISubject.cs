using System;

namespace 观察者模式传值
{
    public interface ISubject
    {
        /// <summary>
        /// 注册订阅者
        /// </summary>
        /// <param name="observer"></param>
        void RegisterObserver(IObserver observer);

        /// <summary>
        /// 删除订阅者
        /// </summary>
        /// <param name="observer"></param>
        void RemoveObserver(IObserver observer);

        void NotifyObserver(bool isShown);
    }

    public interface IObserver
    {
        /// <summary>
        /// 观察者对发布者的响应方法
        /// </summary>
        /// <param name="msg"></param>
        void Update(string msg,bool isShown);
    }
}