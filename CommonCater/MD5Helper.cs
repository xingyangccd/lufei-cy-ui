using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CommonCater
{
    public class MD5Helper
    {

        /// <summary>
        /// 获取MD5数据
        /// </summary>
        /// <param name="str">要加密的字符串</param>
        /// <returns></returns>
        public static string GetMD5(string str)
        {
            //21232f297a57a5a743894a0e4a801fc3
            //1.创建MD5对象
            MD5 md5 = MD5.Create();

            //2.把要加密的字符串 转换成字符数组 针对每个字节进行加密
            byte[] buffer = Encoding.UTF8.GetBytes(str);

            //3.通过hash算法对buffer开始加密
            byte[] newBuffer = md5.ComputeHash(buffer);

            //4.把字节数组中的每个字节 转换成16禁止的字符串 并且每个字节2位
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < newBuffer.Length; i++)
            {
                //x2 十六禁止 每个字节2位 对齐
                sb.Append(newBuffer[i].ToString("x2"));
            }
            return sb.ToString();
        }

    }
}
