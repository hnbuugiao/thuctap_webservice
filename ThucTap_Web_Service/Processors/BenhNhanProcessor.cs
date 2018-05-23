using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ThucTap_Web_Service.Models;
using ThucTap_Web_Service.Repositories;

namespace ThucTap_Web_Service.Processors
{
    public class BenhNhanProcessor
    {
        public static string AddBenhNhan(BenhNhan benhnhan)
        {
            return BenhNhanRepository.AddBenhNhanToDB(benhnhan);
        }

        public static List<BenhNhan> ShowAllBenhNhan()
        {
            return BenhNhanRepository.ShowAllBenhNhanFromDB();
        }

        public static List<BenhNhan> ShowBenhNhan(string mabn)
        {
            return BenhNhanRepository.ShowBenhNhanFromDB(mabn);
        }

        public static bool SuaThongTinBenhNhan(BenhNhan benhnhan)
        {
            return BenhNhanRepository.SuaThongTinBenhNhan(benhnhan);
        }

        public static bool XoaBenhNhan(string mabn)
        {
            return BenhNhanRepository.XoaBenhNhan(mabn);
        }
    }
}