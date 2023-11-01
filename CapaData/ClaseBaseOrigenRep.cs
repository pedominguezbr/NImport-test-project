using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using System.Reflection;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
//using Hoc.Gemm.Inf.Trans;
using System.Xml;

namespace NImport.Inf.Rep
{
    public class ClaseBaseOrigenRep
    {
        private SqlDatabase _DataBase;
        private DbTransaction _dbTransaction;

        public SqlDatabase DataBase
        {
            get { return _DataBase; }
            set { _DataBase = value; }
        }

        public DbTransaction Transaction
        {
            get { return _dbTransaction; }
            set { _dbTransaction = value; }
        }

        #region Metodos

        public int? TestConnection()
        {
            int? Result = null;
            if (_DataBase != null)
            {
                try
                {
                    using (DbConnection con = _DataBase.CreateConnection())
                    {
                        con.Open();
                        Result = 1;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return Result;
        }

        public virtual void HandleSqlException(SqlException sqlex)
        {
            if (sqlex != null)
            {
                string Message = sqlex.Number.ToString() + ", ";
                switch (sqlex.Number)
                {
                    case 245:   // Division entre cero
                    case 2627:  // Unique constraint error
                    case 547:   // Constraint check violation
                    case 2601:  // Duplicated key row error
                                // Constraint violation exception
                                // A custom exception of yours for concurrency issues
                    case 53:
                        Message += "No está conectado a la red corporativa.";
                        break;

                    default:
                        // A custom exception of yours for other DB issues
                        Message += sqlex.Message.ToString();
                        break;
                }
                //if ((sqlex.Procedure.ToString() == "uspOtraMuestraInsert" || sqlex.Procedure.ToString() == "uspMuestraASDInsert") && sqlex.Number == 50000 && sqlex.Message.Substring(0, 1) == "0") Message = (sqlex.Message.Replace("0","").Replace("(null).", ""));
                //else
                //    Message += sqlex.Procedure != null ? ", " + sqlex.Procedure.ToString() : "" + sqlex.LineNumber != null ? ", " + sqlex.LineNumber.ToString() : "";
                throw new Exception(Message);
            }
        }
        public static string GetConnectionStringFromKey(string conStringKey)
        {
            ConnectionStringsSection configurationSection = ConfigurationManager.GetSection("connectionStrings") as ConnectionStringsSection;
            return configurationSection.ConnectionStrings[conStringKey].ConnectionString;
        }

        public DataSet ExecuteDataSet(string sp_name, params object[] @params)
        {
            DataSet Result = new DataSet();
            Result = null;

            if ((_DataBase != null) && (!string.IsNullOrEmpty(sp_name)))
            {
                try
                {
                    Result = (_DataBase.ExecuteDataSet(sp_name, @params));
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return Result;
        }

        public DataSet ExecuteDataSet(DbCommand command)
        {
            DataSet Result = null;

            if ((_DataBase != null))
            {
                try
                {
                    Result = (_DataBase.ExecuteDataSet(command));
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return Result;
        }

        public DataSet ExecuteDataSet(DbTransaction trans, string sp_name, params object[] @params)
        {
            DataSet Result = new DataSet();
            Result = null;
            if ((_DataBase != null) && (trans != null))
            {
                try
                {
                    Result = (_DataBase.ExecuteDataSet(trans, sp_name, @params));
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return Result;
        }

        public int? ExecuteNonQuery(string sp_name, params object[] @params)
        {
            int? Result = null;
            if ((_DataBase != null) && (!string.IsNullOrEmpty(sp_name)))
            {
                try
                {
                    Result = _DataBase.ExecuteNonQuery(sp_name, @params);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return Result;
        }

        public int? ExecuteNonQueryIdentity(string sp_name, params object[] @params)
        {
            int? Result = null;
            if ((_DataBase != null) && (!string.IsNullOrEmpty(sp_name)))
            {
                try
                {
                    Result = _DataBase.ExecuteNonQueryIdentity(sp_name, @params);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return Result;
        }

        public long? ExecuteNonQueryIdentityLong(string sp_name, params object[] @params)
        {
            long? Result = null;
            if ((_DataBase != null) && (!string.IsNullOrEmpty(sp_name)))
            {
                try
                {
                    Result = _DataBase.ExecuteNonQueryIdentityLong(sp_name, @params);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return Result;
        }


        public long? ExecuteNonQueryIdentityLong(DbTransaction trans, string sp_name, params object[] @params)
        {
            long? Result = null;
            if ((_DataBase != null) && (!string.IsNullOrEmpty(sp_name)))
            {
                try
                {
                    Result = _DataBase.ExecuteNonQueryIdentityLong(trans, sp_name, @params);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return Result;
        }

        public int? ExecuteNonQueryIdentity(DbTransaction trans, string sp_name, params object[] @params)
        {
            int? Result = null;
            if ((_DataBase != null) && (trans != null))
            {
                try
                {
                    Result = _DataBase.ExecuteNonQueryIdentity(trans, sp_name, @params);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return Result;
        }

        public string ExecuteNonQueryString(string sp_name, params object[] @params)
        {
            string Result = "";
            if ((_DataBase != null) && (!string.IsNullOrEmpty(sp_name)))
            {
                try
                {
                    Result = _DataBase.ExecuteNonQueryString(sp_name, @params);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return Result;
        }

        public int? ExecuteNonQueryTemp(string sp_name, params object[] @params)
        {
            int? Result = null;
            if ((_DataBase != null) && (!string.IsNullOrEmpty(sp_name)))
            {
                try
                {
                    Result = _DataBase.ExecuteNonQuery(sp_name, @params);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return Result;
        }

        public int? ExecuteNonQuery(DbTransaction trans, string sp_name, params object[] @params)
        {
            int? Result = null;
            if ((_DataBase != null) && (trans != null))
            {
                try
                {
                    Result = (_DataBase.ExecuteNonQuery(trans, sp_name, @params));
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return Result;
        }

        public object ExecuteScalar(DbCommand command)
        {
            object Result = null;
            if ((_DataBase != null) && (command != null))
            {
                try
                {
                    Result = (_DataBase.ExecuteScalar(command));
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return Result;
        }

        public object ExecuteScalar(string sp_name, params object[] @params)
        {
            object Result = null;
            if ((_DataBase != null) && (!string.IsNullOrEmpty(sp_name)))
            {
                try
                {
                    Result = (_DataBase.ExecuteScalar(sp_name, @params));
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return Result;
        }

        public XmlReader ExecuteXmlReader(string sp_name, params object[] @params)
        {
            XmlReader Result = null;
            if ((_DataBase != null) && (!string.IsNullOrEmpty(sp_name)))
            {
                try
                {
                    Result = _DataBase.ExecuteXmlReader(sp_name, @params);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return Result;
        }

        public object ExecuteScalar(DbTransaction trans, string sp_name, params object[] @params)
        {
            object Result = null;
            if ((_DataBase != null) && (!string.IsNullOrEmpty(sp_name)))
            {
                try
                {
                    Result = (_DataBase.ExecuteScalar(trans, sp_name, @params));
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return Result;
        }

        public DbDataAdapter GetDataAdapter()
        {
            DbDataAdapter Result = null;
            if (_DataBase != null)
            {
                try
                {
                    Result = _DataBase.GetDataAdapter();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return Result;
        }

        public IDataReader GetDataReader(string storedProcedureName)
        {
            IDataReader Result = null;
            using (SqlConnection conn = new SqlConnection(GetConnectionStringFromKey("ConnectionString")))
            {
                conn.Open();
                try
                {
                    if (_DataBase != null)
                    {
                        Result = _DataBase.ExecuteReader(CommandType.StoredProcedure, storedProcedureName);
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                    { conn.Close(); }
                }
            }
            return Result;
        }

        public IDataReader ExecuteReader(string storedProcedureName, params object[] @params)
        {
            IDataReader Result = null;
            if (_DataBase != null)
            {
                try
                {
                    Result = _DataBase.ExecuteReader(storedProcedureName, @params);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return Result;
        }

        public IDataReader GetDataReaderTrans(string storedProcedureName, params object[] @params)
        {
            IDataReader Result = null;
            using (SqlConnection conn = new SqlConnection(GetConnectionStringFromKey("ConnectionString")))
            {
                conn.Open();
                SqlTransaction transaccion2 = conn.BeginTransaction("transaccion");
                if (_DataBase != null)
                {
                    try
                    {
                        Result = _DataBase.ExecuteReader(transaccion2, storedProcedureName, @params);
                    }
                    catch (Exception ex)
                    {
                        transaccion2.Rollback();
                        throw ex;
                    }
                    finally
                    {
                        if (conn.State == ConnectionState.Open)
                        { conn.Close(); }
                    }
                }
            }
            return Result;
        }

        public DbCommand GetStoredProcCommand(string storedProcedureName, params object[] @params)
        {
            DbCommand Result = null;
            if (_DataBase != null)
            {
                try
                {
                    Result = (_DataBase.GetStoredProcCommand(storedProcedureName, @params));
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return Result;
        }

        public void LoadDataSet(string storeProcedureName, DataSet dataSet, string[] tables, params object[] @params)
        {
            if (_DataBase != null)
            {
                try
                {
                    _DataBase.LoadDataSet(storeProcedureName, dataSet, tables, @params);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
        #endregion

        #region "getobject filled object with property reconized"

        public List<T> ConvertToList<T>(DataTable dt)
        {
            var columnNames = dt.Columns.Cast<DataColumn>()
                    .Select(c => c.ColumnName.ToUpper())
                    .ToList();
            var properties = typeof(T).GetProperties();
            return dt.AsEnumerable().Select(row =>
            {
                var objT = Activator.CreateInstance<T>();
                foreach (var pro in properties)
                {
                    if (columnNames.Contains(pro.Name.ToUpper()))
                    {
                        PropertyInfo pI = objT.GetType().GetProperty(pro.Name);
                        pro.SetValue(objT, row[pro.Name] == DBNull.Value ? null : Convert.ChangeType(row[pro.Name], pI.PropertyType));
                    }
                }
                return objT;
            }).ToList();
        }

        public List<T> ConvertTo<T>(DataTable datatable) where T : new()
        {
            List<T> Temp = new List<T>();
            try
            {
                List<string> columnsNames = new List<string>();
                foreach (DataColumn DataColumn in datatable.Columns)
                    columnsNames.Add(DataColumn.ColumnName);
                Temp = datatable.AsEnumerable().ToList().ConvertAll<T>(row => getObject<T>(row, columnsNames));
                return Temp;
            }
            catch
            {
                return Temp;
            }

        }

        public T getObject<T>(DataRow row, List<string> columnsName) where T : new()
        {
            T obj = new T();
            try
            {
                string columnname = "";
                string value = "";
                PropertyInfo[] Properties;
                Properties = typeof(T).GetProperties();
                foreach (PropertyInfo objProperty in Properties)
                {
                    columnname = columnsName.Find(name => name.ToLower() == objProperty.Name.ToLower());
                    if (!string.IsNullOrEmpty(columnname))
                    {
                        value = row[columnname].ToString();
                        if (!string.IsNullOrEmpty(value))
                        {
                            if (Nullable.GetUnderlyingType(objProperty.PropertyType) != null)
                            {
                                value = row[columnname].ToString().Replace("$", "").Replace(",", "");
                                objProperty.SetValue(obj, Convert.ChangeType(value, Type.GetType(Nullable.GetUnderlyingType(objProperty.PropertyType).ToString())), null);
                            }
                            else
                            {
                                value = row[columnname].ToString().Replace("%", "");
                                objProperty.SetValue(obj, Convert.ChangeType(value, Type.GetType(objProperty.PropertyType.ToString())), null);
                            }
                        }
                    }
                }
                return obj;
            }
            catch
            {
                return obj;
            }
        }

        #endregion

        #region "New DataTable"
        public DataTable ToDataTable<T>(IEnumerable<T> collection)
        {
            DataTable newDataTable = new DataTable();
            Type impliedType = typeof(T);
            PropertyInfo[] _propInfo = impliedType.GetProperties();
            foreach (PropertyInfo pi in _propInfo)
                newDataTable.Columns.Add(pi.Name, pi.PropertyType);

            foreach (T item in collection)
            {
                DataRow newDataRow = newDataTable.NewRow();
                newDataRow.BeginEdit();
                foreach (PropertyInfo pi in _propInfo)
                    newDataRow[pi.Name] = pi.GetValue(item, null);
                newDataRow.EndEdit();
                newDataTable.Rows.Add(newDataRow);
            }
            return newDataTable;
        }
        #endregion
    }
}
