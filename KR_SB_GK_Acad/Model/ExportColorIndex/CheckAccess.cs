﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR_SB_GK_Acad.Model.ExportColorIndex
{
   public static class Access
   {
      private static List<string> _accessUsers = new List<string>() { "LukashovaTS", "khisyametdinovvt" };

      public static bool Success()
      {
         return _accessUsers.Contains(Environment.UserName, StringComparer.OrdinalIgnoreCase);
      }
   }
}
