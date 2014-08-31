using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace WinFormEx
{
    public class DataGridViewEx
    {
        class ExItemInfo
        {
            public DataGridViewCell NameCell{ get; set; }

            public DataGridViewCell ValueCell{ get; set; }

            public Object Tag{ get; set; }
        }

        #region internal properties

        // grid view col
        internal static int IconCol { get { return 0; } }

        internal static int NameCol { get { return 1; } }

        internal static int ValueCol { get { return 2; } }

        internal static int TypeCol { get { return 3; } }

        // icon index
        static int BlankIconIdx { get { return 0; } }

        static int CloseIconIdx { get { return 1; } }

        static int OpenIconIdx { get { return 2; } }

        #endregion

        List<ExItemInfo> _exItemInfos;

        List<ExItemInfo> ExItemInfos
        {
            get
            {
                if (null == _exItemInfos)
                {
                    _exItemInfos = new List<ExItemInfo>();
                }
                return _exItemInfos;
            }
            set
            {
                _exItemInfos = value;
            }
        }

        DataGridView _dgv = null;

        public DataGridViewEx(DataGridView dgv)
        {
            _dgv = dgv;

            // set column title
            _dgv.Columns.Clear();
            _dgv.Columns.Add("Icon", "");
            _dgv.Columns.Add("Property", "Property");
            _dgv.Columns.Add("Value", "Value");
            _dgv.Columns.Add("Type", "Type");
            _dgv.Columns[0].ReadOnly = true;
            _dgv.Columns[1].ReadOnly = true;
            _dgv.Columns[2].ReadOnly = false; // value could be edited.
            _dgv.Columns[3].ReadOnly = true;


            // set event handler
            _dgv.CellEndEdit += CellEndEdit;
        }

        public bool SetObj(Object obj)
        {
            _dgv.Rows.Clear();
            _dgv.Tag = obj;

            Type type = obj.GetType();
            if (IsSimpleType(type))
            {
                DataGridViewRow row = 
                    type.Name;
            }
            /*
            PropertyInfo[] propertyInfos;
            Type t = obj.GetType();
            propertyInfos = t.GetProperties();
            foreach (PropertyInfo propertyInfo in propertyInfos)
            {
                String val;
                Object o = propertyInfo.GetValue(obj, null);
                if (null == o)
                {
                    val = "";
                }
                else
                {
                    val = o.ToString();
                }
                ExItemInfo eii = new ExItemInfo();

                _dgv.Rows.Add(propertyInfo.Name, val);
                DataGridViewRow row = _dgv.Rows[_dgv.Rows.Count - 1];
                row.Cells[0].Tag = eii;
                row.Cells[1].Tag = eii;
                eii.nameCell = row.Cells[0];
                eii.valCell = row.Cells[1];


                //eii.tag = 

            }
            */
            return false;
        }

        private void CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }


        public bool IsSimpleType(Type t)
        {
            if (t.IsValueType || t == typeof(string) || t == typeof(object))
            {
                return true;
            }
            return false;
        }
    }
}
