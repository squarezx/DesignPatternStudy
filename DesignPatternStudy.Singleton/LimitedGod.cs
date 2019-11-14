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
            return _limitedGods[random.Next(2)];
        }

        public void Say()
        {
            Console.WriteLine($"I'm God,No:{GetHashCode()}");
        }
    }
}