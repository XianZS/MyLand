using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLand
{
    public class Stu
    {
        // 单例模式
        private static Stu _Instance;
        public static Stu Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new Stu();
                return _Instance;
            }
        }
        public string PicturePath = @"D:\\program\\C_cs\\Code\\MyLand\\MyLand\\MyLand\\Resources\\头像.jpg";
        public string info = "";
    }
}