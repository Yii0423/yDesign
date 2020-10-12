﻿using System;

namespace yDesign.单例模式
{
    public class Singleton
    {
        // 定义一个静态私有变量来保存类的实例
        private static Singleton _uniqueInstance;

        // 定义一个标识确保线程同步
        private static readonly object Locker = new object();

        private static string _newTime;

        // 定义私有构造函数，使外界不能创建该类实例
        private Singleton() { }

        public string Say()
        {
            return $"Singleton创建实例的时间：{_newTime}";
        }

        /// <summary>
        /// 定义公有静态方法提供一个全局访问点,同时你也可以定义公有属性来提供全局访问点
        /// </summary>
        /// <returns></returns>
        public static Singleton GetInstance()
        {
            // 当第一个线程运行到这里时，此时会对locker对象 "加锁"，
            // 当第二个线程运行该方法时，首先检测到locker对象为"加锁"状态，该线程就会挂起等待第一个线程解锁
            // lock语句运行完之后（即线程运行完之后）会对该对象"解锁"
            // 双重锁定只需要一句判断就可以了
            if (_uniqueInstance == null)
            {
                lock (Locker)
                {
                    // 如果类的实例不存在则创建，否则直接返回
                    if (_uniqueInstance == null)
                    {
                        _uniqueInstance = new Singleton();
                        _newTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
                    }
                }
            }
            return _uniqueInstance;
        }
    }
}
