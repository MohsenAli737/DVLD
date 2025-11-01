using DataAcsses;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataBussnsLayer
{
    public class ClsTestType
    {
        enum enmode { Uptata, Add }
        enmode _mode = enmode.Add;
        public int id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Fees { get; set; }
        public static DataTable GetListTestType()
        {
            return TestTypeDataAcess.GetlistTestType();
        }
        private bool _Uptata()
        {
            return TestTypeDataAcess.Uptate(id, Title, Description, Fees);
        }
       public ClsTestType()

        {

        }

        public static ClsTestType Find(int id)
        {


            string Title = "";
            string Description = "";
            int Fees = 0;

            if (TestTypeDataAcess.GetRecordTestTypeById(id, ref Title, ref Description, ref Fees))
            {
                return new ClsTestType(id, Title, Description, Fees);
            }
            return null;


        }
        private ClsTestType(int id, string title, string description, int fees)
        {
            this.id = id;
            this.Title = title;
            this.Description = description;
            this.Fees = fees;

            _mode = enmode.Uptata;


        }


        public bool Save()
        {
            switch (_mode)
            {

                case enmode.Uptata:
                    {

                        if (_Uptata())
                        {
                            return true;
                        }
                        break;
                    }

            }

            return false;
        }
    }
}
