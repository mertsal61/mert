using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tckontrol
{
    public class employee
    {

        private string tmptckn;



        public string tckn
        {
            get
            {
                Console.WriteLine("asdasd");
                return tmptckn.Substring(0, 5);
            }



            set
            {
                bool atamaokey = true;
                bool burak = false;
                if (value.Length == 11)
                {
                    for (int i = 0; i < 11; i++)
                    {
                        if (!char.IsNumber(value, i))
                        {
                            burak = true;
                            break;
                        }

                    }
                    //if (atamaokey)
                    //    tmptckn = value;
                    if (!burak)
                    {
                        tmptckn = value;
                    }

                }

            }


        }
    }
}
