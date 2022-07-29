using System;
using System.IO;
using System.Text;

namespace application.Mensagens
{
    public class MensagemLog
    {
        public string Erro(string msg)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(msg + "\n\n");
            string _path = "logErro" + DateTime.Now.Millisecond + ".txt";
            File.WriteAllBytes(AppDomain.CurrentDomain.BaseDirectory + "Erro\\" + _path, bytes);

            return _path;
        }
    }
}
