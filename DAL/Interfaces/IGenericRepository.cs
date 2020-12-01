﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dapper;
using System.Data.SqlClient;

namespace Code2Night.DAL.Interfaces
{
    public interface IGenericMaster<T>
    {
        List<T> GetAll(string spname, string Activity);
        T GetRecordsById(string spname, string Activity, int id);
        DataTable GetTableById(string spname, string Activity, int? id);

        List<T> GetAllById(string spname, string Activity, int? id);
        DataSet GetDataSetById(string spname, string Activity, int? id = 0);

        IEnumerable<T> GetList(string spname, DynamicParameters param);
        List<T> GetListOptimized(string spname, string Activity, int? Id = 0);
        string Insert(string spname, DynamicParameters param);

        int ExecuteScalar(string spname, DynamicParameters param);
        DataTable GetTableByCustomParameters(string spname, List<SqlParameter> Parameters = null);
        string SaveData(string spname, List<SqlParameter> Parameters = null);
        DataSet GetDataSetByCustomParameters(string spname, List<SqlParameter> Parameters = null);

    }
}
