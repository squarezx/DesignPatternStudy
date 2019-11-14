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
    /// 禹州瓷器厂，生产钧窑
    /// </summary>
    public class YuZhouChinaFactory : AbstractChinaFactory
    {
        public override AbstractBowl CreateBowl()
        {
            return new YuZhouBowl();
        }

        public override AbstractPlate CreatePlate()
        {
            return new YuZhouPlate();
        }
    }

    /// <summary>
    /// 禹州钧窑碗
    /// </summary>
    public class YuZhouBowl : AbstractBowl
    {
        public override string GetColor()
        {
            return "蓝色渐变";
        }
    }

    /// <summary>
    /// 禹州钧窑盘子
    /// </summary>
    public class YuZhouPlate : AbstractPlate
    {
        public override string GetColor()
        {
            return "蓝色渐变";
        }
    }
}