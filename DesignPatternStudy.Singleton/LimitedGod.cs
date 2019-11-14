////////////////////////////////////////////////////////////////////
//                          _ooOoo_                               //
//                         o8888888o                              //
//                         88" . "88                              //
//                         (| ^_^ |)                              //
//                         O\  =  /O                              //
//                      ____/`---'\____                           //
//                    .'  \\|     |//  `.                         //
//                   /  \\|||  :  |||//  \                        //
//                  /  _||||| -:- |||||-  \                       //
//                  |   | \\\  -  /// |   |                       //
//                  | \_|  ''\---/''  |   |                       //
//                  \  .-\__  `-`  ___/-. /                       //
//                ___`. .'  /--.--\  `. . ___                     //
//              ."" '<  `.___\_<|>_/___.'  >'"".                  //
//            | | :  `- \`.;`\ _ /`;.`/ - ` : | |                 //
//            \  \ `-.   \_ __\ /__ _/   .-` /  /                 //
//      ========`-.____`-.___\_____/___.-`____.-'========         //
//                           `=---='                              //
//      ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^        //
//            佛祖保佑       永不宕机     永无BUG                 //
////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternStudy.Singleton
{
    /// <summary>
    /// 有限制数量的扩展单例
    /// </summary>
    public class LimitedGod
    {
        private static int _maxNumGod = 3;

        private static List<LimitedGod> _limitedGods = new List<LimitedGod>();

        private LimitedGod()
        {
        }

        /// <summary>
        /// 静态构造函数用于初始化任何静态数据，或执行仅需执行一次的特定操作。
        /// 将在创建第一个实例或引用任何静态成员之前自动调用静态构造函数。
        /// </summary>
        static LimitedGod()
        {
            for (int i = 0; i < _maxNumGod; i++)
            {
                _limitedGods.Add(new LimitedGod());
            }
        }

        public static LimitedGod Instance()
        {
            Random random = new Random();
            return _limitedGods[random.Next(3)];
        }

        public void Say()
        {
            Console.WriteLine($"I'm God,No:{GetHashCode()}");
        }
    }
}