﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BussinessLayer
{

    [Serializable]
    public class SYS_PARAM
    {
        QLHOTELSEntities db = new QLHOTELSEntities();

        public tb_Param getParam()
        {
            return db.tb_Param.FirstOrDefault();
        }
        string _macty;
        public string macty
        {
            get { return _macty; }
            set { _macty = value; }
        }
        string _madvi;
        public string madvi
        {
            get { return _madvi; }
            set { _madvi = value; }
        }
        /*public SYS_PARAM(string macty, string madvi)
        {
            this._macty = macty;
            this._madvi = madvi;
        }*/
        public void SaveFile()
        {
            if (File.Exists("sysparam.ini"))
                File.Delete("sysparam.ini");
            FileStream fs = File.Open("sysparam.ini", FileMode.OpenOrCreate, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, this);
            fs.Close();
        }
    }
}
