using UnityEngine;
using System.Collections;

// 建立单例的过程
// 1 构造函数 必须私有, 以使外部不能实例化 (外部只能有一个调用就接口, 以控制实例化的数量.)
// 2 在内部建立实例 字段
// 3 给外界一个公有的静态访问接口 

public class Singleton
{
    private Singleton() { }
    private static Singleton instance;

    // M1 通过属性来获取单例 封装字段, 只能通过属性来访问实例,
    public static Singleton Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }
    }

    // M2 通过方法来获取单例.这两个方法都可以
    public static Singleton GetInstance()
    {
        if (instance == null)
        {
            instance = new Singleton();
        }
        return instance;
    }
}
