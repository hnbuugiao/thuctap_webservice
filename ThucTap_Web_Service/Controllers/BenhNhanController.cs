using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ThucTap_Web_Service.Models;
using ThucTap_Web_Service.Processors;
using Newtonsoft.Json;
using System.Globalization;
using Newtonsoft.Json.Converters;

namespace ThucTap_Web_Service.Controllers
{
    public class BenhNhanController : ApiController
    {
        [HttpPost]
        public string ThemBenhNhan([FromBody]BenhNhan benhnhan)
        {
            if (benhnhan == null)
            {
                return "NULL";
            }
            return BenhNhanProcessor.AddBenhNhan(benhnhan);
        }

        [HttpGet]
        public string HienThiBenhNhan()
        {
            List<BenhNhan> list = new List<BenhNhan>();
            list = BenhNhanProcessor.ShowAllBenhNhan();
            var converter = new IsoDateTimeConverter();
            var convertedJson = JsonConvert.SerializeObject(list,converter);
            return convertedJson;
        }

        [HttpGet]
        public string HienThiBenhNhan(string id)
        {
            List<BenhNhan> list = new List<BenhNhan>();
            list = BenhNhanProcessor.ShowBenhNhan(id);

            var convertedJson = JsonConvert.SerializeObject(list);
            return convertedJson;
        }

        [HttpPut]
        public bool SuaThongTin(BenhNhan benhnhan)
        {
            if (benhnhan == null)
            {
                return false;
            }
            return BenhNhanProcessor.SuaThongTinBenhNhan(benhnhan);
        }

        [HttpPut]
        public bool SuaThongTinX(string id, BenhNhan benhnhan)
        {
            if (benhnhan == null)
            {
                return false;
            }
            return BenhNhanProcessor.SuaThongTinBenhNhan(benhnhan);
        }


        [HttpDelete]
        public bool XoaBenhNhan(string id)
        {
            if (id == null)
            {
                return false;
            }
            return BenhNhanProcessor.XoaBenhNhan(id);
        }
    }
}
