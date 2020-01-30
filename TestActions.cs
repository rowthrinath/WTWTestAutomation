using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace WTWTestAutomation
{
    public static class TestActions
    {
       public static DataTable GetSterlingCurrencyData(int SCurrency1, int SCurrency2, int SCurrency3,
                                                        int SCurrency4, int STotal)
       {
            DataTable sterlingTable = new DataTable();
            sterlingTable.Columns.Add("SCurrency1", typeof(int));
            sterlingTable.Columns.Add("SCurrency2", typeof(int));
            sterlingTable.Columns.Add("SCurrency3", typeof(int));
            sterlingTable.Columns.Add("SCurrency4", typeof(int));
            sterlingTable.Columns.Add("STotal", typeof(int));

            sterlingTable.Rows.Add(SCurrency1, SCurrency2, SCurrency3, SCurrency4);
            sterlingTable.Rows.Add(STotal);
            return sterlingTable;
        }

        public  static DataTable GetEuroCurrencyData(int ECurrency1, int ECurrency2, int ECurrency3,
                                                        int ECurrency4, int ETotal)
        {
            DataTable euroTable = new DataTable();
            euroTable.Columns.Add("ECurrency1", typeof(int));
            euroTable.Columns.Add("ECurrency2", typeof(int));
            euroTable.Columns.Add("ECurrency3", typeof(int));
            euroTable.Columns.Add("ECurrency4", typeof(int));
            euroTable.Columns.Add("ETotal", typeof(int));

            euroTable.Rows.Add(ECurrency1, ECurrency2, ECurrency3, ECurrency4);
            euroTable.Rows.Add(ETotal);
            return euroTable;
        }
    }
}
