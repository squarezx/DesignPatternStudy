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

namespace DesignPatternStudy.AbstractFactory
{
    /// <summary>
    /// 景德镇瓷器厂
    /// </summary>
    public class JingDeZhenChinaFactory : AbstractChinaFactory
    {
        public override AbstractBowl CreateBowl()
        {
            return new JingDeZhenBowl();
        }

        public override AbstractPlate CreatePlate()
        {
            return new JingDeZhenPlate();
        }
    }

    /// <summary>
    /// 景德镇碗
    /// </summary>
    public class JingDeZhenBowl : AbstractBowl
    {
        public override string GetColor()
        {
            return "青花";
        }
    }

    /// <summary>
    /// 景德镇盘子
    /// </summary>
    public class JingDeZhenPlate : AbstractPlate
    {
        public override string GetColor()
        {
            return "青花";
        }
    }
}